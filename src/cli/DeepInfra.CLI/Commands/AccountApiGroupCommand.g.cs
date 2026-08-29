#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class AccountApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"account", @"Account endpoint commands.");
                         command.Subcommands.Add(AccountAccountEmailValuesCommandApiCommand.Create());
                         command.Subcommands.Add(AccountAccountGpuPoolCommandApiCommand.Create());
                         command.Subcommands.Add(AccountAccountRateLimitCommandApiCommand.Create());
                         command.Subcommands.Add(AccountAccountUpdateDetailsCommandApiCommand.Create());
                         command.Subcommands.Add(AccountDeleteAccountCommandApiCommand.Create());
                         command.Subcommands.Add(AccountGpuPoolGpuTypesCommandApiCommand.Create());
                         command.Subcommands.Add(AccountMeCommandApiCommand.Create());
                         command.Subcommands.Add(AccountRequestGpuPoolChangeCommandApiCommand.Create());
                         command.Subcommands.Add(AccountRequestRateLimitIncreaseCommandApiCommand.Create());
                         command.Subcommands.Add(AccountTeamSetDisplayNameCommandApiCommand.Create());
        return command;
    }
}