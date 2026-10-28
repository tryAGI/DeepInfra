#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class BillingApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"billing", @"Billing endpoint commands.");
                         command.Subcommands.Add(BillingGetChecklistCommandApiCommand.Create());
                         command.Subcommands.Add(BillingGetConfigCommandApiCommand.Create());
                         command.Subcommands.Add(BillingGetKeyLimitsCommandApiCommand.Create());
                         command.Subcommands.Add(BillingListInvoicesCommandApiCommand.Create());
                         command.Subcommands.Add(BillingUsageCommandApiCommand.Create());
                         command.Subcommands.Add(BillingUsageApiTokenByIdCommandApiCommand.Create());
                         command.Subcommands.Add(BillingUsageRentCommandApiCommand.Create());
                         command.Subcommands.Add(BillingUsageTokensCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}