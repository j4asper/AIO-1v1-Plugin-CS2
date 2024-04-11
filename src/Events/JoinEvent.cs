using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;

namespace AIO1v1Plugin;

public partial class AIO1v1Plugin
{
    [GameEventHandler]
    public HookResult OnPlayerConnect(EventPlayerConnect @event, GameEventInfo info)
    {
        // Userid will give you a reference to a CCSPlayerController class.
        // Before accessing any of its fields, you must first check if the Userid
        // handle is actually valid, otherwise you may run into runtime exceptions.
        // See the documentation section on Referencing Players for details.
        if (@event.Userid.IsValid) {
            Server.PrintToChatAll($"Player {@event.Userid.PlayerName} has connected to the server!");
        }
        //@event.Userid.
        //Server.PrintToChatAll($"Player {@event.Userid.PlayerName} has connected to the server!");

        return HookResult.Continue;
    }
}