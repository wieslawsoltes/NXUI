using Avalonia;
using Avalonia.Controls;
using NXUI.HotReload;
using NXUI.HotReload.State;
using NXUI.HotReload.Nodes;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class StateAdapterTests
{
    [Fact]
    public void Coordinator_Transfers_TextBox_State()
    {
        var source = new TextBox
        {
            Text = "User input",
            SelectionStart = 1,
            SelectionEnd = 4,
            CaretIndex = 2,
        };

        var target = new TextBox
        {
            Text = "Builder value",
        };

        HotReloadStateCoordinator.TransferState(source, target);

        Assert.Equal("User input", target.Text);
        Assert.Equal(2, target.CaretIndex);
    }

    [Fact]
    public void ComponentHandle_Transfers_State_On_Root_Replacement()
    {
        var iteration = 0;

        ElementNode Build()
            => TextBox()
                .Key($"textbox-{iteration}")
                .WithAction(tb => tb.Text = "Builder")
                .Node;

        var host = new TestComponentHost();
        var handle = new ComponentHandle("stateful-textbox", () => Build(), host, _ => { });
        handle.Attach();

        var textBox = Assert.IsType<TextBox>(host.Root);
        textBox.Text = "User input";
        textBox.SelectionStart = 0;
        textBox.SelectionEnd = 0;
        textBox.CaretIndex = textBox.Text.Length;

        iteration++;
        handle.TryRefresh("test");

        var newTextBox = Assert.IsType<TextBox>(host.Root);
        Assert.NotSame(textBox, newTextBox);
        Assert.Equal("User input", newTextBox.Text);
        Assert.Equal(textBox.Text.Length, newTextBox.CaretIndex);
    }

    private sealed class TestComponentHost : IComponentHost
    {
        public AvaloniaObject? Root { get; private set; }

        public void AttachRoot(AvaloniaObject instance)
        {
            Root = instance;
        }

        public void OnRootReplaced(AvaloniaObject oldRoot, AvaloniaObject newRoot)
        {
            Root = newRoot;
        }

        public void OnComponentUpdated(ReconcileResult result)
        {
        }

        public void OnComponentDisposed(AvaloniaObject? instance)
        {
            Root = null;
        }
    }
}
