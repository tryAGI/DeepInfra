#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class AuthenticationApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"authentication", @"Authentication endpoint commands.");
                         command.Subcommands.Add(AuthenticationCreateApiTokenCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationCreateScopedJwtCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationCreateSshKeyCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationDeleteApiTokenCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationDeleteSshKeyCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationExportApiTokenToVercelCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationGetApiTokenCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationGetApiTokensCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationGetSshKeysCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationGithubCliLoginCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationGithubLoginCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationGoogleLoginCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationInspectScopedJwtCommandApiCommand.Create());
                         command.Subcommands.Add(AuthenticationOktaLoginCommandApiCommand.Create());
        return command;
    }
}