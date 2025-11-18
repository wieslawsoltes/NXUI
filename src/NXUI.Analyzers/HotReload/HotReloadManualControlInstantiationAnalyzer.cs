using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace NXUI.Analyzers.HotReload;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class HotReloadManualControlInstantiationAnalyzer : DiagnosticAnalyzer
{
    public const string DiagnosticId = "NXH001";

    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticId,
        title: "Avoid manual Avalonia control instantiation during NXUI hot reload builds",
        messageFormat: "Instantiate '{0}' via NXUI builders when hot reload is enabled to keep controls reusable",
        category: "NXUI.HotReload",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true,
        description: "Hot reload relies on ElementNode builders. Creating Avalonia controls with 'new' breaks reconciliation.",
        helpLinkUri: "https://github.com/wieslawsoltes/NXUI/blob/main/docs/hot-reload-best-practices.md");

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext context)
    {
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        context.EnableConcurrentExecution();

        context.RegisterCompilationStartAction(static startContext =>
        {
            var controlSymbol = startContext.Compilation.GetTypeByMetadataName("Avalonia.Controls.Control");
            if (controlSymbol is null)
            {
                return;
            }

            startContext.RegisterSyntaxNodeAction(
                nodeContext => AnalyzeObjectCreation(nodeContext, controlSymbol),
                SyntaxKind.ObjectCreationExpression);
        });
    }

    private static void AnalyzeObjectCreation(SyntaxNodeAnalysisContext context, INamedTypeSymbol controlSymbol)
    {
        if (context.Node is not ObjectCreationExpressionSyntax creation)
        {
            return;
        }

        var typeInfo = context.SemanticModel.GetTypeInfo(creation, context.CancellationToken);
        if (typeInfo.Type is not INamedTypeSymbol createdType)
        {
            return;
        }

        if (!IsControl(createdType, controlSymbol))
        {
            return;
        }

        context.ReportDiagnostic(Diagnostic.Create(Rule, creation.Type.GetLocation(), createdType.Name));
    }

    private static bool IsControl(INamedTypeSymbol typeSymbol, INamedTypeSymbol controlSymbol)
    {
        for (var current = typeSymbol; current is not null; current = current.BaseType)
        {
            if (SymbolEqualityComparer.Default.Equals(current, controlSymbol))
            {
                return true;
            }
        }

        return false;
    }
}
