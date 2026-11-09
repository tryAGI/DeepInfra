# DeepInfra.CLI

Command-line interface for the DeepInfra SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global DeepInfra.CLI --prerelease
```

## Usage

```bash
deep-infra --help
deep-infra api --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
deep-infra completion bash > /usr/local/etc/bash_completion.d/deep-infra
deep-infra completion zsh  > _deep-infra   # then put it on your zsh fpath
deep-infra completion fish > ~/.config/fish/completions/deep-infra.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.