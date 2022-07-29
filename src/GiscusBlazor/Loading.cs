using System;

namespace GiscusBlazor
{
    public enum Loading
    {
        Lazy,
        Eager
    }

    internal static class LoadingExtensions
    {
        internal static string ToLoadingString(this Loading loading) =>
            loading switch
            {
                Loading.Eager => "eager",
                Loading.Lazy => "lazy",
                _ => throw new ArgumentOutOfRangeException(nameof(loading))
            };
    }
}
