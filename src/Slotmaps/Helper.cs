namespace FlashyDJ.Slotmaps;

/// <summary>
///   A helper class that contains utility methods.
/// </summary>
internal static class Helper
{
    /// <summary>
    ///   Returns if the left version is older than the right version, taking into account wrapping of versions.
    /// </summary>
    /// <param name="left">The left version number as an unsigned integer.</param>
    /// <param name="right">The right version number as an unsigned integer.</param>
    /// <returns>
    ///   <see langword="true"/> if the left version is older than the right version, <see langword="false"/> otherwise.</returns>
    internal static bool IsOlderVersion(uint left, uint right) =>
        (left - right) >= (1u << 31);
}
