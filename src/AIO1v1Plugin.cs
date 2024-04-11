using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;

namespace AIO1v1Plugin;

public partial class AIO1v1Plugin : BasePlugin
{
    public override string ModuleName => "AIO1v1Plugin";
    public override string ModuleVersion => "1.0";
    public override string ModuleDescription => "All-in-One 1v1 Plugin for Counter-Strike 2";
    public override string ModuleAuthor => "j4asper";

    public override void Load(bool hotReload)
    {
        string prefix = $"[{ModuleName}] ";

        string[] messages = [
            $"{ModuleName} by {ModuleAuthor}",
            $"Plugin Version: {ModuleVersion}",
            "Source: https://github.com/j4asper/AIO-1v1-Plugin-CS2"
        ];

        foreach (string message in messages)
        {
            Console.WriteLine(prefix + message);
        }
    }
}