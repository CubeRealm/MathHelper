using PluginAPI;

namespace NoiseGenerator;

public class Plugin : IPlugin
{
    public void Load()
    {
        
    }

    public void Enable()
    {
        
    }

    public string Name { get; set; } = "MathHelper";
    public string Version { get; set; } = "0.1-SNAPSHOT";
    public string[] Authors { get; set; } = new[] { "CubeRealm" };
}