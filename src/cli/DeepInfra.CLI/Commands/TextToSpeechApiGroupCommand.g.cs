#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class TextToSpeechApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"text-to-speech", @"Text to Speech endpoint commands.");
                         command.Subcommands.Add(TextToSpeechCreateVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechDeleteVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechGetVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechGetVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechTextToSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechTextToSpeechStreamCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechUpdateVoiceCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}