export function addGiscus(repo,repoId,category,categoryId,mapping,reactionsEnabled,emitMetadata,inputPosition,theme,lang) {
	const giscus = document.createElement("script");
	giscus.setAttribute("src", "https://giscus.app/client.js");
	giscus.setAttribute("data-repo", repo);
	giscus.setAttribute("data-repo-id", repoId);
	giscus.setAttribute("data-category", category);
	giscus.setAttribute("data-category-id", categoryId);
	giscus.setAttribute("data-mapping", mapping);
	giscus.setAttribute("data-reactions-enabled", reactionsEnabled);
	giscus.setAttribute("data-emit-metadata", emitMetadata);
	giscus.setAttribute("data-input-position", inputPosition);
	giscus.setAttribute("data-theme", theme);
	giscus.setAttribute("data-lang", lang);
	giscus.setAttribute("crossorigin", "anonymous");
	giscus.setAttribute("async", "");
	document.getElementById("giscus-block").appendChild(giscus);
}
export function addGiscusWithTerm(repo, repoId, category, categoryId, mapping,term, reactionsEnabled, emitMetadata, inputPosition, theme, lang) {
	const giscus = document.createElement("script");
	giscus.setAttribute("src", "https://giscus.app/client.js");
	giscus.setAttribute("data-repo", repo);
	giscus.setAttribute("data-repo-id", repoId);
	giscus.setAttribute("data-category", category);
	giscus.setAttribute("data-category-id", categoryId);
	giscus.setAttribute("data-mapping", mapping);
	giscus.setAttribute("data-term",term);
	giscus.setAttribute("data-reactions-enabled", reactionsEnabled);
	giscus.setAttribute("data-emit-metadata", emitMetadata);
	giscus.setAttribute("data-input-position", inputPosition);
	giscus.setAttribute("data-theme", theme);
	giscus.setAttribute("data-lang", lang);
	giscus.setAttribute("crossorigin", "anonymous");
	giscus.setAttribute("async", "");
	document.getElementById("giscus-block").appendChild(giscus);
}

