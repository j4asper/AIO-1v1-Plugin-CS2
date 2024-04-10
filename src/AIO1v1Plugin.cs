using CounterStrikeSharp.API.Core;

namespace AIO1v1Plugin;

public class AIO1v1Plugin : BasePlugin
{
    public override string ModuleName => "AIO1v1Plugin";
    public override string ModuleVersion => "1.0";
    public override string ModuleDescription => "All-in-One 1v1 Plugin for Counter-Strike 2";
	public override string ModuleAuthor => "j4asper";

    public override void Load(bool hotReload)
    {
        Console.WriteLine("AIO 1v1 Plugin by j4asper");
        Console.WriteLine($"Plugin Version: {ModuleVersion}");
        Console.WriteLine("https://github.com/j4asper/AIO-1v1-Plugin-CS2");
    }
}
