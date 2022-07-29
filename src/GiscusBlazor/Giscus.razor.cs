using Microsoft.AspNetCore.Components;

namespace GiscusBlazor
{
    public partial class Giscus
    {
#if NET6_0_OR_GREATER
        [EditorRequired]
#endif
        [Parameter]
        public string Repo { get; set; } = null!;

#if NET6_0_OR_GREATER
        [EditorRequired]
#endif
        [Parameter]
        public string RepoId { get; set; } = null!;

        [Parameter]
        public string? Category { get; set; }

        [Parameter]
        public string? CategoryId { get; set; }

#if NET6_0_OR_GREATER
        [EditorRequired]
#endif
        [Parameter]
        public Mapping Mapping { get; set; } = Mapping.PathName;

        [Parameter]
        public string? Term { get; set; }

        [Parameter]
        public bool Strict { get; set; } = false;

        [Parameter]
        public bool ReactionsEnabled { get; set; } = true;

        [Parameter]
        public bool EmitMetadata { get; set; }

        [Parameter]
        public InputPosition InputPosition { get; set; }

        [Parameter]
        public string? Theme { get; set; }

        [Parameter]
        public string? Lang { get; set; }

        [Parameter]
        public Loading Loading { get; set; } = Loading.Eager;

        [Parameter]
        public string? Host { get; set; } = "https://giscus.app";
    }
}
