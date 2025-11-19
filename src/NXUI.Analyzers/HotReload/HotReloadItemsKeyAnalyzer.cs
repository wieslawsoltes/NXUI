using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace NXUI.Analyzers.HotReload;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class HotReloadItemsKeyAnalyzer : DiagnosticAnalyzer
{
    public const string DiagnosticId = "NXH002";

    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticId,
        title: "Provide stable keys for ItemsSource entries",
        messageFormat: "Add .Key(...) to this item so NXUI can reconcile list entries during hot reload",
        category: "NXUI.HotReload",
        defaultSeverity: DiagnosticSeverity.Info,
        isEnabledByDefault: true,
        description: "Items passed to ItemsControl.ItemsSource should provide explicit Key() values so the hot reload diff can align entries.",
        helpLinkUri: "https://github.com/wieslawsoltes/NXUI/blob/main/docs/hot-reload-best-practices.md");

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext context)
    {
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        context.EnableConcurrentExecution();

        context.RegisterOperationAction(AnalyzeInvocation, OperationKind.Invocation);
    }

    private static void AnalyzeInvocation(OperationAnalysisContext context)
    {
        if (context.Operation is not IInvocationOperation invocation)
        {
            return;
        }

        if (!IsItemsSourceExtension(invocation.TargetMethod))
        {
            return;
        }

        foreach (var argument in invocation.Arguments)
        {
            var value = Unwrap(argument.Value);
            if (value is IInvocationOperation invocationOperation)
            {
                if (IsKeyCall(invocationOperation))
                {
                    continue;
                }

                context.ReportDiagnostic(Diagnostic.Create(Rule, argument.Syntax.GetLocation()));
            }
        }
    }

    private static bool IsItemsSourceExtension(IMethodSymbol method)
    {
        if (!method.IsExtensionMethod)
        {
            return false;
        }

        var reduced = method.ReducedFrom ?? method;
        if (reduced.Name != "ItemsSource")
        {
            return false;
        }

        var type = reduced.ContainingType;
        return type.Name == "ItemsControlExtensions"
            && type.ContainingNamespace.ToDisplayString().StartsWith("NXUI.Extensions", StringComparison.Ordinal);
    }

    private static IOperation Unwrap(IOperation operation)
    {
        while (operation is IConversionOperation conversion)
        {
            operation = conversion.Operand;
        }

        return operation;
    }

    private static bool IsKeyCall(IInvocationOperation invocation)
    {
        return invocation.TargetMethod.Name == "Key"
            && invocation.TargetMethod.Parameters.Length == 1
            && invocation.TargetMethod.Parameters[0].Type.SpecialType == SpecialType.System_String;
    }
}
