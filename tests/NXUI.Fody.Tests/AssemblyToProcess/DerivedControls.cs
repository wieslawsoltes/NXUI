using System;
using Avalonia;
using Avalonia.Controls;
using NXUI.HotReload;
using NXUI.HotReload.State;

namespace AssemblyToProcess
{
    public class DerivedTextBox : TextBox
    {
        public static Type MarkerSentinel { get; } = typeof(IHotReloadBoundaryMarker);
    }

    [HotReloadCandidateBoundary]
    public class CandidateBoundaryControl : ContentControl
    {
    }

    public class StateAdapterControl : ContentControl, IHotReloadStateAdapter
    {
        public Type ControlType => typeof(StateAdapterControl);

        public object? CaptureState(AvaloniaObject control) => null;

        public void RestoreState(AvaloniaObject control, object? state)
        {
        }
    }
}
