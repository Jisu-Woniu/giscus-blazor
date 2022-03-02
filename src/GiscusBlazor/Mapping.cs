using System;

namespace GiscusBlazor
{
    public enum Mapping
    {
        PathName,
        Url,
        Title,
        OgTitle,
        Specific,
        Number
    }

    internal static class MappingExtensions
    {
        internal static string ToMappingString(this Mapping mapping)
        {
            return mapping switch
            {
                Mapping.PathName => "pathname",
                Mapping.Url => "url",
                Mapping.Title => "title",
                Mapping.OgTitle => "og:title",
                Mapping.Specific => "specific",
                Mapping.Number => "number",
                _ => throw new ArgumentOutOfRangeException(nameof(mapping))
            };
        }
    }
}
