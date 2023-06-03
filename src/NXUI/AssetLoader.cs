using System.Reflection;

namespace NXUI;

/// <summary>
/// 
/// </summary>
public static class AssetLoader
{
    /// <summary>
    /// We need a way to override the default assembly selected by the host platform
    /// because right now it is selecting the wrong one for PCL based Apps. The 
    /// AssetLoader needs a refactor cause right now it lives in 3+ platforms which 
    /// can all be loaded on Windows. 
    /// </summary>
    /// <param name="assembly"></param>
    public static void SetDefaultAssembly(Assembly assembly)
    {
        Avalonia.Platform.AssetLoader.SetDefaultAssembly(assembly);
    }

    /// <summary>
    /// Checks if an asset with the specified URI exists.
    /// </summary>
    /// <param name="uri">The URI.</param>
    /// <param name="baseUri">
    /// A base URI to use if <paramref name="uri"/> is relative.
    /// </param>
    /// <returns>True if the asset could be found; otherwise false.</returns>
    public static bool Exists(Uri uri, Uri? baseUri = null)
    {
        return Avalonia.Platform.AssetLoader.Exists(uri, baseUri);
    }

    /// <summary>
    /// Checks if an asset with the specified URI exists.
    /// </summary>
    /// <param name="uriString">The URI string.</param>
    /// <returns>True if the asset could be found; otherwise false.</returns>
    public static bool Exists(string uriString)
    {
        return Avalonia.Platform.AssetLoader.Exists(new Uri(uriString));
    }

    /// <summary>
    /// Opens the asset with the requested URI.
    /// </summary>
    /// <param name="uri">The URI.</param>
    /// <param name="baseUri">
    /// A base URI to use if <paramref name="uri"/> is relative.
    /// </param>
    /// <returns>A stream containing the asset contents.</returns>
    /// <exception cref="FileNotFoundException">
    /// The asset could not be found.
    /// </exception>
    public static Stream Open(Uri uri, Uri? baseUri = null)
    {
        return Avalonia.Platform.AssetLoader.Open(uri, baseUri);
    }

    /// <summary>
    /// Opens the asset with the requested URI.
    /// </summary>
    /// <param name="uriString">The URI string.</param>
    /// <returns>A stream containing the asset contents.</returns>
    /// <exception cref="FileNotFoundException">
    /// The asset could not be found.
    /// </exception>
    public static Stream Open(string uriString)
    {
        return Avalonia.Platform.AssetLoader.Open(new Uri(uriString));
    }

    /// <summary>
    /// Opens the asset with the requested URI and returns the asset stream and the
    /// assembly containing the asset.
    /// </summary>
    /// <param name="uri">The URI.</param>
    /// <param name="baseUri">
    /// A base URI to use if <paramref name="uri"/> is relative.
    /// </param>
    /// <returns>
    /// The stream containing the asset contents together with the assembly.
    /// </returns>
    /// <exception cref="FileNotFoundException">
    /// The asset could not be found.
    /// </exception>
    public static (Stream stream, Assembly assembly) OpenAndGetAssembly(Uri uri, Uri? baseUri = null)
    {
        return Avalonia.Platform.AssetLoader.OpenAndGetAssembly(uri, baseUri);
    }

    /// <summary>
    /// Opens the asset with the requested URI and returns the asset stream and the
    /// assembly containing the asset.
    /// </summary>
    /// <param name="uriString">The URI string.</param>
    /// <returns>
    /// The stream containing the asset contents together with the assembly.
    /// </returns>
    /// <exception cref="FileNotFoundException">
    /// The asset could not be found.
    /// </exception>
    public static (Stream stream, Assembly assembly) OpenAndGetAssembly(string uriString)
    {
        return Avalonia.Platform.AssetLoader.OpenAndGetAssembly(new Uri(uriString));
    }

    /// <summary>
    /// Extracts assembly information from URI
    /// </summary>
    /// <param name="uri">The URI.</param>
    /// <param name="baseUri">
    /// A base URI to use if <paramref name="uri"/> is relative.
    /// </param>
    /// <returns>Assembly associated with the Uri</returns>
    public static Assembly? GetAssembly(Uri uri, Uri? baseUri = null)
    {
        return Avalonia.Platform.AssetLoader.GetAssembly(uri, baseUri);
    }

    /// <summary>
    /// Extracts assembly information from URI
    /// </summary>
    /// <param name="uriString">The URI string.</param>
    /// <returns>Assembly associated with the Uri</returns>
    public static Assembly? GetAssembly(string uriString)
    {
        return Avalonia.Platform.AssetLoader.GetAssembly(new Uri(uriString));
    }

    /// <summary>
    /// Gets all assets of a folder and subfolders that match specified uri.
    /// </summary>
    /// <param name="uri">The URI.</param>
    /// <param name="baseUri">The base URI.</param>
    /// <returns>All matching assets as a tuple of the absolute path to the asset and the assembly containing the asset</returns>
    public static IEnumerable<Uri> GetAssets(Uri uri, Uri? baseUri = null)
    {
        return Avalonia.Platform.AssetLoader.GetAssets(uri, baseUri);
    }

    /// <summary>
    /// Gets all assets of a folder and subfolders that match specified uri.
    /// </summary>
    /// <param name="uriString">The URI string.</param>
    /// <returns>All matching assets as a tuple of the absolute path to the asset and the assembly containing the asset</returns>
    public static IEnumerable<Uri> GetAssets(string uriString)
    {
        return Avalonia.Platform.AssetLoader.GetAssets(new Uri(uriString), null);
    }
}
