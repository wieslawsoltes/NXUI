namespace NXUI.HotReload.State.Internal;

using System;
using Avalonia;
using Avalonia.Controls;

internal sealed class TextBoxStateAdapter : IHotReloadStateAdapter
{
    public Type ControlType => typeof(TextBox);

    public object? CaptureState(AvaloniaObject control)
    {
        if (control is not TextBox textBox)
        {
            return null;
        }

        return new Snapshot(
            textBox.Text,
            textBox.SelectionStart,
            textBox.SelectionEnd,
            textBox.CaretIndex);
    }

    public void RestoreState(AvaloniaObject control, object? state)
    {
        if (control is not TextBox textBox || state is not Snapshot snapshot)
        {
            return;
        }

        textBox.Text = snapshot.Text;
        textBox.SelectionStart = snapshot.SelectionStart;
        textBox.SelectionEnd = snapshot.SelectionEnd;
        textBox.CaretIndex = snapshot.CaretIndex;
    }

    private sealed record Snapshot(string? Text, int SelectionStart, int SelectionEnd, int CaretIndex);
}
