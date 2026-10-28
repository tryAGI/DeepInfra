#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class BillingDeepstartApplyCommandApiCommand
{
    private static Option<object?> Session { get; } = new(
        name: @"--session")
    {
        Description = @"",
    };

    private static Option<string> Company { get; } = new(
        name: @"--company")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Ceo { get; } = new(
        name: @"--ceo")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Funding { get; } = new(
        name: @"--funding")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> FoundedOn { get; } = new(
        name: @"--founded-on")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Website { get; } = new(
        name: @"--website")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> CountryCode { get; } = new(
        name: @"--country-code")
    {
        Description = @"",
    };

    private static Option<bool?> NvidiaConsent { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--nvidia-consent",
        description: @"");

    private static Option<string?> Deal { get; } = new(
        name: @"--deal")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.DeepStartApplicationOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.DeepStartApplicationOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"deepstart-apply", @"Deepstart Apply");
                        command.Options.Add(Session);
                        command.Options.Add(Company);
                        command.Options.Add(Ceo);
                        command.Options.Add(Funding);
                        command.Options.Add(FoundedOn);
                        command.Options.Add(Website);
                        command.Options.Add(CountryCode);
                        command.Options.Add(NvidiaConsent);
                        command.Options.Add(Deal);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.DeepStartApplicationIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var session = parseResult.GetValue(Session);
                        var company = parseResult.GetRequiredValue(Company);
                        var ceo = parseResult.GetRequiredValue(Ceo);
                        var funding = parseResult.GetRequiredValue(Funding);
                        var foundedOn = parseResult.GetRequiredValue(FoundedOn);
                        var website = parseResult.GetRequiredValue(Website);
                        var countryCode = CliRuntime.WasSpecified(parseResult, CountryCode) ? parseResult.GetValue(CountryCode) : (__requestBase is { } __CountryCodeBaseValue ? __CountryCodeBaseValue.CountryCode : default);
                        var nvidiaConsent = CliRuntime.WasSpecified(parseResult, NvidiaConsent) ? parseResult.GetValue(NvidiaConsent) : (__requestBase is { } __NvidiaConsentBaseValue ? __NvidiaConsentBaseValue.NvidiaConsent : default);
                        var deal = CliRuntime.WasSpecified(parseResult, Deal) ? parseResult.GetValue(Deal) : (__requestBase is { } __DealBaseValue ? __DealBaseValue.Deal : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Billing.DeepstartApplyAsync(
                                    session: session,
                                    company: company,
                                    ceo: ceo,
                                    funding: funding,
                                    foundedOn: foundedOn,
                                    website: website,
                                    countryCode: countryCode,
                                    nvidiaConsent: nvidiaConsent,
                                    deal: deal,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::DeepInfra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}