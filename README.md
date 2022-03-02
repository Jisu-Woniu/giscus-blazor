# giscus-blazor

A Blazor component to embed [giscus](https://giscus.app), a comments system powered by GitHub Discussions.

Supports both Blazor WebAssembly and Blazor Server.

## Getting started

To start, install it from NuGet.

[![Nuget GiscusBlazor](https://img.shields.io/nuget/v/GiscusBlazor.svg)](https://www.nuget.org/packages/GiscusBlazor/)

Then add **either one** of the following tag to your `wwwroot/index.html` (Blazor WebAssembly) or  `Pages/_Layout.cshtml` (Blazor Server) as the last child of `<head>` element.

```html
<!-- Use unpkg -->
<script type="module" src="https://unpkg.com/giscus?module"></script>

<!-- or Skypack -->
<script type="module" src="https://cdn.skypack.dev/giscus"></script>
```

You might need to fix the version when publish your website. For example:

```html
<!-- Use unpkg -->
<script type="module" src="https://unpkg.com/giscus@0.0.9?module"></script>

<!-- or Skypack -->
<script type="module" src="https://cdn.skypack.dev/giscus@0.0.9"></script>
```

Then add this component to your `.razor` files where you want the comments to appear like this:

```razor
<!-- At top of page -->
@using GiscusBlazor

<!-- At comment area -->
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

Or you can just add `@using GiscusBlazor` to `_imports`

Most of the parameters can be found from the [giscus official site](https://giscus.app/).
