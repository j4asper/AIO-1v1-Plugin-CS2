using System.Xml.Schema;
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;

namespace AIO1v1Plugin;

public partial class AIO1v1Plugin
{
    [ConsoleCommand("css_map", "Change the current map using this command.")]
    [CommandHelper(minArgs: 1, usage: "[map name]", whoCanExecute: CommandUsage.CLIENT_AND_SERVER)]
    public void OnMapCommand(CCSPlayerController? _player, CommandInfo commandInfo)
    {
        string mapName = commandInfo.GetArg(1);

        if(Server.IsMapValid(mapName))
        {
            commandInfo.ReplyToCommand($"Map: \"{mapName}\" is not a valid map.");
        }
        else
        {
            Server.ExecuteCommand($"map de_{mapName}");
        }
    }
}