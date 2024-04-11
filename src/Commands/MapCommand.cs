using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;

namespace AIO1v1Plugin;

public partial class AIO1v1Plugin
{
    [ConsoleCommand("css_map", "Change the current map using this command.")]
    public void OnMapCommand(CCSPlayerController? player, CommandInfo commandInfo)
    {
        // The first argument is the command name, in this case "css_hello".
        commandInfo.GetArg(0); // css_hello

        // The second argument is the first argument passed to the command, in this case "name".
        // The `minArgs` helper parameter is used to ensure that the second argument is present.
        //var name = commandInfo.GetArg(1);

        string[] maps = Server.GetMapList();

        commandInfo.ReplyToCommand(string.Join("\n", maps));
    }


    // Commands can also be registered using the `Command` attribute.
    [ConsoleCommand("css_hello", "Responds to the caller with \"pong\"")]
    // The `CommandHelper` attribute can be used to provide additional information about the command.
    public void OnHelloCommand(CCSPlayerController? player, CommandInfo commandInfo)
    {
        // The first argument is the command name, in this case "css_hello".
        //commandInfo.GetArg(0); // css_hello

        // The second argument is the first argument passed to the command, in this case "name".
        // The `minArgs` helper parameter is used to ensure that the second argument is present.
        //var name = commandInfo.GetArg(1);

        commandInfo.ReplyToCommand("Hello");
    }
}