using System;

namespace FlashyDJ.Slotmaps;

// Inspired by dotnet/runtime's ThrowHelper
[StackTraceHidden]
internal static class ThrowHelper
{
    [DoesNotReturn]
    internal static void ThrowKeyNotFoundException<T>(T key) =>
    // Generic key to move the boxing to the right hand side of throw
        throw GetKeyNotFoundException(key);

    [DoesNotReturn]
    internal static void ThrowKeyNotFoundException_MaybeNull<T>(T key)
        where T : struct, ISlotKey<T> =>
        // Generic key to move the boxing to the right hand side of throw
        throw GetKeyNotFoundException_MaybeNull(key);


    [DoesNotReturn]
    internal static void ThrowKeyNotFoundException_Null<T>(T key) =>
    // Generic key to move the boxing to the right hand side of throw
        throw GetKeyNotFoundException_Null(key);

    [DoesNotReturn]
    internal static void ThrowKeyNotFoundException_OlderVersion<T>(T key) =>
    // Generic key to move the boxing to the right hand side of throw
        throw GetKeyNotFoundException_OlderVersion(key);

    internal static KeyNotFoundException GetKeyNotFoundException<T>(T key) =>
    // Generic key to move the boxing to the right hand side of throw
        GetKeyNotFoundException((object?)key);

    internal static KeyNotFoundException GetKeyNotFoundException_MaybeNull<T>(T key)
        where T : struct, ISlotKey<T> => 
        key.IsNull ? GetKeyNotFoundException_Null((object?)key) 
                   : GetKeyNotFoundException((object?)key);

    internal static KeyNotFoundException GetKeyNotFoundException_OlderVersion<T>(T key) =>
    // Generic key to move the boxing to the right hand side of throw
        GetKeyNotFoundException_OlderVersion((object?)key);

    private static KeyNotFoundException GetKeyNotFoundException(object? key) =>
        new($"The given slot key {key} was not found.");

    private static KeyNotFoundException GetKeyNotFoundException_Null(object? key) =>
        new($"The given slot key {key} is null.");

    private static KeyNotFoundException GetKeyNotFoundException_OlderVersion(object? key) =>
        new($"The given slot key {key} is an older version.");
}
