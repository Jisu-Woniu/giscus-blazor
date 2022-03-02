using Microsoft.AspNetCore.Components;

namespace GiscusBlazor
{
    public partial class Giscus
    {
        [Parameter]
#if NET6_0
        [EditorRequired]
#endif
        public string Repo { get; set; } = null!;

        [Parameter]
#if NET6_0
        [EditorRequired]
#endif
        public string RepoId { get; set; } = null!;

        [Parameter]
        public string? Category { get; set; }

        [Parameter]
        public string? CategoryId { get; set; }

        [Parameter]
#if NET6_0
        [EditorRequired]
#endif
        public Mapping Mapping { get; set; } = Mapping.PathName;

        [Parameter]
        public string? Term { get; set; }

        [Parameter]
        public bool ReactionsEnabled { get; set; } = true;

        [Parameter]
        public bool EmitMetadata { get; set; }

        [Parameter]
        public InputPosition? InputPosition { get; set; }

        [Parameter]
        public string? Theme { get; set; }

        [Parameter]
        public string? Lang { get; set; }
    }
}
