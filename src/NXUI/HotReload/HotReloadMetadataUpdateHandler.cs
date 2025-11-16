#if NXUI_HOTRELOAD
using System;
using System.Reflection.Metadata;

[assembly: MetadataUpdateHandler(typeof(NXUI.HotReload.HotReloadMetadataUpdateHandler))]

namespace NXUI.HotReload;

/// <summary>
/// Receives CLR hot reload notifications and forwards them to <see cref="HotReloadManager"/>.
/// </summary>
internal static class HotReloadMetadataUpdateHandler
{
    public static void ClearCache(Type[]? updatedTypes)
    {
        HotReloadManager.NotifyCodeUpdates(updatedTypes, nameof(ClearCache));
    }

    public static void UpdateApplication(Type[]? updatedTypes)
    {
        HotReloadManager.NotifyCodeUpdates(updatedTypes, nameof(UpdateApplication));
    }
}
#endif
