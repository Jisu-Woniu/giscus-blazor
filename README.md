# giscus-blazor

A Blazor component to embed [giscus](https://giscus.app), a comments system powered by GitHub Discussions.

Supports both Blazor WebAssembly and Blazor Server.

## Getting started

To start, install it from NuGet.

[![Nuget GiscusBlazor](https://img.shields.io/nuget/v/GiscusBlazor.svg)](https://www.nuget.org/packages/GiscusBlazor/)

Then add this component to your `.razor` files where you want the comments to appear like this:

```razor
@using GiscusBlazor

<Giscus Repo="[ENTER REPO HERE]"
        RepoId="[ENTER REPO ID HERE]"
        Category="[ENTER CATEGORY NAME HERE]"
        CategoryId="[ENTER CATEGORY ID HERE]"
        Mapping="Mapping.Specific"
        Term="[ENTER TERM HERE]"
        ReactionsEnabled="true"
        EmitMetadata="false"
        InputPosition="InputPosition.Bottom"
        Theme="light"
        Lang="en" />
```

Most of the parameters can be found from the [giscus official site](https://giscus.app/).
