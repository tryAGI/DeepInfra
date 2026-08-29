#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class BillingAddFundsCommandApiCommand
{
    private static Option<bool?> UseCheckout { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--use-checkout",
        description: @"");

    private static Option<object?> Session { get; } = new(
        name: @"--session")
    {
        Description = @"",
    };

    private static Option<int> Amount { get; } = new(
        name: @"--amount")
    {
        Description = @"Amount to add in cents",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.AddFundsOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.AddFundsOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"add-funds", @"Add Funds");
                        command.Options.Add(UseCheckout);
                        command.Options.Add(Session);
                        command.Options.Add(Amount);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var useCheckout = parseResult.GetValue(UseCheckout);
                        var session = parseResult.GetValue(Session);
                        var amount = parseResult.GetRequiredValue(Amount);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Billing.AddFundsAsync(
                                    useCheckout: useCheckout,
                                    session: session,
                                    amount: amount,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::DeepInfra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}