using Microsoft.AspNetCore.Components;

namespace GiscusBlazor;

public partial class Giscus
{
    [Parameter]
    [EditorRequired]
    public string Repo { get; set; } = null!;

    [Parameter]
    [EditorRequired]
    public string RepoId { get; set; } = null!;

    [Parameter]
    public string? Category { get; set; }

    [Parameter]
    public string? CategoryId { get; set; }

    [Parameter]
    [EditorRequired]
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
