using System;
using NXUI.HotReload;

namespace NXUI.Extensions;

public static partial class AppBuilderExtensions
{
    /// <summary>
    /// Initializes NXUI hot reload services when the build flag is enabled.
    /// </summary>
    public static AppBuilder UseNXUIHotReload(this AppBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        if (!HotReloadManager.IsHotReloadBuild)
        {
            return builder;
        }

        return builder.AfterSetup(_ => HotReloadManager.Initialize(builder));
    }
}
