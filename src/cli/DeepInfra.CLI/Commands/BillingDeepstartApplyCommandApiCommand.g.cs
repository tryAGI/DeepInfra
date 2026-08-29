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

    private static Option<string?> Id { get; } = new(
        name: @"--id")
    {
        Description = @"",
    };

    private static Option<string?> Uid { get; } = new(
        name: @"--uid")
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

    private static Option<int?> CreatedAt { get; } = new(
        name: @"--created-at")
    {
        Description = @"",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"",
    };

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


    public static Command Create()
    {
        var command = new Command(@"deepstart-apply", @"Deepstart Apply");
                        command.Options.Add(Session);
                        command.Options.Add(Id);
                        command.Options.Add(Uid);
                        command.Options.Add(Company);
                        command.Options.Add(Ceo);
                        command.Options.Add(Funding);
                        command.Options.Add(FoundedOn);
                        command.Options.Add(Website);
                        command.Options.Add(CreatedAt);
                        command.Options.Add(Status);
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
                        var id = CliRuntime.WasSpecified(parseResult, Id) ? parseResult.GetValue(Id) : (__requestBase is { } __IdBaseValue ? __IdBaseValue.Id : default);
                        var uid = CliRuntime.WasSpecified(parseResult, Uid) ? parseResult.GetValue(Uid) : (__requestBase is { } __UidBaseValue ? __UidBaseValue.Uid : default);
                        var company = parseResult.GetRequiredValue(Company);
                        var ceo = parseResult.GetRequiredValue(Ceo);
                        var funding = parseResult.GetRequiredValue(Funding);
                        var foundedOn = parseResult.GetRequiredValue(FoundedOn);
                        var website = parseResult.GetRequiredValue(Website);
                        var createdAt = CliRuntime.WasSpecified(parseResult, CreatedAt) ? parseResult.GetValue(CreatedAt) : (__requestBase is { } __CreatedAtBaseValue ? __CreatedAtBaseValue.CreatedAt : default);
                        var status = CliRuntime.WasSpecified(parseResult, Status) ? parseResult.GetValue(Status) : (__requestBase is { } __StatusBaseValue ? __StatusBaseValue.Status : default);
                        var deal = CliRuntime.WasSpecified(parseResult, Deal) ? parseResult.GetValue(Deal) : (__requestBase is { } __DealBaseValue ? __DealBaseValue.Deal : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Billing.DeepstartApplyAsync(
                                    session: session,
                                    id: id,
                                    uid: uid,
                                    company: company,
                                    ceo: ceo,
                                    funding: funding,
                                    foundedOn: foundedOn,
                                    website: website,
                                    createdAt: createdAt,
                                    status: status,
                                    deal: deal,
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