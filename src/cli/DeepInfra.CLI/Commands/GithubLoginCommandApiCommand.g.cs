#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class GithubLoginCommandApiCommand
{
    private static Option<string?> LoginId { get; } = new(
        name: @"--login-id")
    {
        Description = @"",
    };

    private static Option<string?> Origin { get; } = new(
        name: @"--origin")
    {
        Description = @"",
    };

    private static Option<string?> Deal { get; } = new(
        name: @"--deal")
    {
        Description = @"",
    };

    private static Option<string?> TiToken { get; } = new(
        name: @"--ti-token")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"github-login", @"Github Login
Initiate github SSO login flow. Callback is /github/callback");
                        command.Options.Add(LoginId);
                        command.Options.Add(Origin);
                        command.Options.Add(Deal);
                        command.Options.Add(TiToken);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var loginId = parseResult.GetValue(LoginId);
                        var origin = parseResult.GetValue(Origin);
                        var deal = parseResult.GetValue(Deal);
                        var tiToken = parseResult.GetValue(TiToken);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GithubLoginAsync(
                                    loginId: loginId,
                                    origin: origin,
                                    deal: deal,
                                    tiToken: tiToken,
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