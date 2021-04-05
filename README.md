CodeBaseHq2GitLab is a .Net program to export tickets/issues from a CodeBase project to a GitLab one.

I share this code to be a base for your own thing. The code you will find here was rapidly produced, and thus can be greatly improved (refactoring, parallelization, errors handling, etc.). It might need some tweaking before it does exactly what you want, but it will save you several hours of coding, I hope.

Since CodeBase and GitLab have different philosophies/concepts regarding their tickets/issues, CodeBaseHq2GitLab converts those concepts as it sees fit, like how to transform a CodeBase's Priority into a GitLab's Weight. So please take a look at the conversion code before running it, and tweak it if needed.

Of course, before running CodeBaseHq2GitLab on your precious GitLab project, use it first on some test project.
