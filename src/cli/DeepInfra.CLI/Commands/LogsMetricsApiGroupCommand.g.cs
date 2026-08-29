#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class LogsMetricsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"logs-metrics", @"Logs & Metrics endpoint commands.");
                         command.Subcommands.Add(LogsMetricsDeploymentLogsQueryCommandApiCommand.Create());
                         command.Subcommands.Add(LogsMetricsGetLiveMetricsCommandApiCommand.Create());
                         command.Subcommands.Add(LogsMetricsGetRequestCostsCommandApiCommand.Create());
                         command.Subcommands.Add(LogsMetricsLogsQueryCommandApiCommand.Create());
        return command;
    }
}