#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class AccountAccountUpdateDetailsCommandApiCommand
{
    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<string?> XApiKey { get; } = new(
        name: @"--x-api-key")
    {
        Description = @"",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Personal name",
    };

    private static Option<string?> FirstName { get; } = new(
        name: @"--first-name")
    {
        Description = @"First name of the user",
    };

    private static Option<string?> LastName { get; } = new(
        name: @"--last-name")
    {
        Description = @"Last name of the user",
    };

    private static Option<string?> Country { get; } = new(
        name: @"--country")
    {
        Description = @"Country of the user",
    };

    private static Option<string?> Email { get; } = new(
        name: @"--email")
    {
        Description = @"",
    };

    private static Option<bool?> IsBusinessAccount { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-business-account",
        description: @"");

    private static Option<string?> Company { get; } = new(
        name: @"--company")
    {
        Description = @"Company name",
    };

    private static Option<string?> Website { get; } = new(
        name: @"--website")
    {
        Description = @"Company website address",
    };

    private static Option<string?> Title { get; } = new(
        name: @"--title")
    {
        Description = @"Job title of the user, e.g. 'Software Engineer'",
    };

    private static Option<string?> DisplayName { get; } = new(
        name: @"--display-name")
    {
        Description = @"String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.",
    };

    private static Option<string?> UseCase { get; } = new(
        name: @"--use-case")
    {
        Description = @"Short description of the use case for the account",
    };

    private static Option<string?> Attribution { get; } = new(
        name: @"--attribution")
    {
        Description = @"Short description of how the user found out about DeepInfra",
    };

    private static Option<bool?> MarketingEmails { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--marketing-emails",
        description: @"Set to false to opt out of marketing emails");

    private static Option<string?> CountryCode { get; } = new(
        name: @"--country-code")
    {
        Description = @"ISO 3166-1 alpha-2 country code of the user selected country",
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
        var command = new Command(@"update-details", @"Account Update Details");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(NameOption);
                        command.Options.Add(FirstName);
                        command.Options.Add(LastName);
                        command.Options.Add(Country);
                        command.Options.Add(Email);
                        command.Options.Add(IsBusinessAccount);
                        command.Options.Add(Company);
                        command.Options.Add(Website);
                        command.Options.Add(Title);
                        command.Options.Add(DisplayName);
                        command.Options.Add(UseCase);
                        command.Options.Add(Attribution);
                        command.Options.Add(MarketingEmails);
                        command.Options.Add(CountryCode);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.MeIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var firstName = CliRuntime.WasSpecified(parseResult, FirstName) ? parseResult.GetValue(FirstName) : (__requestBase is { } __FirstNameBaseValue ? __FirstNameBaseValue.FirstName : default);
                        var lastName = CliRuntime.WasSpecified(parseResult, LastName) ? parseResult.GetValue(LastName) : (__requestBase is { } __LastNameBaseValue ? __LastNameBaseValue.LastName : default);
                        var country = CliRuntime.WasSpecified(parseResult, Country) ? parseResult.GetValue(Country) : (__requestBase is { } __CountryBaseValue ? __CountryBaseValue.Country : default);
                        var email = CliRuntime.WasSpecified(parseResult, Email) ? parseResult.GetValue(Email) : (__requestBase is { } __EmailBaseValue ? __EmailBaseValue.Email : default);
                        var isBusinessAccount = CliRuntime.WasSpecified(parseResult, IsBusinessAccount) ? parseResult.GetValue(IsBusinessAccount) : (__requestBase is { } __IsBusinessAccountBaseValue ? __IsBusinessAccountBaseValue.IsBusinessAccount : default);
                        var company = CliRuntime.WasSpecified(parseResult, Company) ? parseResult.GetValue(Company) : (__requestBase is { } __CompanyBaseValue ? __CompanyBaseValue.Company : default);
                        var website = CliRuntime.WasSpecified(parseResult, Website) ? parseResult.GetValue(Website) : (__requestBase is { } __WebsiteBaseValue ? __WebsiteBaseValue.Website : default);
                        var title = CliRuntime.WasSpecified(parseResult, Title) ? parseResult.GetValue(Title) : (__requestBase is { } __TitleBaseValue ? __TitleBaseValue.Title : default);
                        var displayName = CliRuntime.WasSpecified(parseResult, DisplayName) ? parseResult.GetValue(DisplayName) : (__requestBase is { } __DisplayNameBaseValue ? __DisplayNameBaseValue.DisplayName : default);
                        var useCase = CliRuntime.WasSpecified(parseResult, UseCase) ? parseResult.GetValue(UseCase) : (__requestBase is { } __UseCaseBaseValue ? __UseCaseBaseValue.UseCase : default);
                        var attribution = CliRuntime.WasSpecified(parseResult, Attribution) ? parseResult.GetValue(Attribution) : (__requestBase is { } __AttributionBaseValue ? __AttributionBaseValue.Attribution : default);
                        var marketingEmails = CliRuntime.WasSpecified(parseResult, MarketingEmails) ? parseResult.GetValue(MarketingEmails) : (__requestBase is { } __MarketingEmailsBaseValue ? __MarketingEmailsBaseValue.MarketingEmails : default);
                        var countryCode = CliRuntime.WasSpecified(parseResult, CountryCode) ? parseResult.GetValue(CountryCode) : (__requestBase is { } __CountryCodeBaseValue ? __CountryCodeBaseValue.CountryCode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Account.AccountUpdateDetailsAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    name: name,
                                    firstName: firstName,
                                    lastName: lastName,
                                    country: country,
                                    email: email,
                                    isBusinessAccount: isBusinessAccount,
                                    company: company,
                                    website: website,
                                    title: title,
                                    displayName: displayName,
                                    useCase: useCase,
                                    attribution: attribution,
                                    marketingEmails: marketingEmails,
                                    countryCode: countryCode,
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