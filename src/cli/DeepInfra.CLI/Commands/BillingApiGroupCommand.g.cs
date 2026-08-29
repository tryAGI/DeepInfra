#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class BillingApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"billing", @"Billing endpoint commands.");
                         command.Subcommands.Add(BillingAddFundsCommandApiCommand.Create());
                         command.Subcommands.Add(BillingBillingPortalCommandApiCommand.Create());
                         command.Subcommands.Add(BillingDeepstartApplyCommandApiCommand.Create());
                         command.Subcommands.Add(BillingGetChecklistCommandApiCommand.Create());
                         command.Subcommands.Add(BillingGetConfigCommandApiCommand.Create());
                         command.Subcommands.Add(BillingListInvoicesCommandApiCommand.Create());
                         command.Subcommands.Add(BillingSetConfigCommandApiCommand.Create());
                         command.Subcommands.Add(BillingSetupTopupCommandApiCommand.Create());
                         command.Subcommands.Add(BillingUsageCommandApiCommand.Create());
                         command.Subcommands.Add(BillingUsageApiTokenCommandApiCommand.Create());
                         command.Subcommands.Add(BillingUsageRentCommandApiCommand.Create());
                         command.Subcommands.Add(BillingUsageTokensCommandApiCommand.Create());
        return command;
    }
}