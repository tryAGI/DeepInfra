# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [DeepInfra](https://deepinfra.com/) serverless AI inference platform, auto-generated from the official DeepInfra OpenAPI specification using [AutoSDK](https://github.com/tryAGI/AutoSDK). Published as a NuGet package under the `DeepInfra` package name. Covers all DeepInfra-specific endpoints including object detection, token classification, image classification, fill mask, and more. For OpenAI-compatible chat/completion endpoints, use the `tryAGI.OpenAI` package with `CustomProviders.DeepInfra(apiKey)`.

## Build Commands

```bash
# Build the solution
dotnet build DeepInfra.slnx

# Build for release (also produces NuGet package)
dotnet build DeepInfra.slnx -c Release

# Run integration tests (requires DEEPINFRA_API_KEY env var)
dotnet test src/tests/DeepInfra.IntegrationTests/DeepInfra.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/DeepInfra && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `src/libs/DeepInfra/Generated/` is **entirely auto-generated** -- do not manually edit files there.

1. `src/libs/DeepInfra/openapi.yaml` -- the DeepInfra OpenAPI spec (fetched from `https://api.deepinfra.com/openapi.json`)
3. `src/libs/DeepInfra/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI with `--methodNamingConvention Summary`, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/DeepInfra/` | Main SDK library (`DeepInfraClient`) |
| `src/tests/DeepInfra.IntegrationTests/` | Integration tests against real DeepInfra API |

### Hand-Written Extensions

| File | Purpose |
|------|---------|
| `JsonSerializerContextTypes.AdditionalTypes.cs` | Additional types for System.Text.Json source generation |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### Key Conventions

- The client class is named `DeepInfraClient`
- The namespace is `DeepInfra`
- Method names are generated from OpenAPI summaries (`--methodNamingConvention Summary`)

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
