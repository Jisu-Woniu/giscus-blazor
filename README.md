# giscus-blazor

A Blazor component to embed [giscus](https://giscus.app), a comments system powered by GitHub Discussions.

Supports both Blazor WebAssembly and Blazor Server.

## Getting started

To start, install it from NuGet:

[![Nuget GiscusBlazor](https://img.shields.io/nuget/v/GiscusBlazor.svg)](https://www.nuget.org/packages/GiscusBlazor/)

```sh
dotnet add package GiscusBlazor
```

Then add **either one** of the following tag to your `wwwroot/index.html` (Blazor WebAssembly) or  `Pages/_Layout.cshtml` (Blazor Server) as the last child of `<head>` element.

```html
<!-- Use esm.sh, using bundled module, recommended -->
<script type="module" src="https://cdn.esm.sh/giscus?bundle"></script>

<!-- or jsDelivr -->
<script type="module" src="https://cdn.jsdelivr.net/npm/giscus/+esm"></script>

<!-- or Skypack -->
<script type="module" src="https://cdn.skypack.dev/giscus"></script>

<!-- or unpkg -->
<script type="module" src="https://unpkg.com/giscus?module"></script>
```

You might need to fix the version when publish your website. For example:

```html
<!-- Use esm.sh, using bundled module -->
<script type="module" src="https://cdn.esm.sh/giscus@1.0.5?bundle"></script>

<!-- or jsDelivr -->
<script type="module" src="https://cdn.jsdelivr.net/npm/giscus@1.0.5/+esm"></script>

<!-- or Skypack, and get the pinned URL as in https://docs.skypack.dev/skypack-cdn/api-reference/pinned-urls-optimized -->
<script type="module" src="https://cdn.skypack.dev/pin/giscus@v1.0.5-fJEzgjC6Tv2TgAOCxRiI/mode=imports,min/optimized/giscus.js"></script>

<!-- or unpkg -->
<script type="module" src="https://unpkg.com/giscus@1.0.5?module"></script>
```

You can also install giscus in your `wwwroot` folder with npm or other Node.js package manager, and include it like above.

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
        Lang="en"
        LazyLoading="true" />
```

Or you can just add `@using GiscusBlazor` to `_Imports.razor`.

Most values of the `string` parameters can be found from the [giscus official site](https://giscus.app/).

## Samples

You can get some sample apps from the [samples](samples) directory, in both Blazor WebAssembly and Blazor Server.

## Changelog

### v2.2.1

- Add support for lazy-loading (see [giscus official site](https://giscus.app/)).
- Removed TFM for .NET 5.0, which is now [out of support](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core#lifecycle).
