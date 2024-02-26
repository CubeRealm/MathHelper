using Microsoft.Extensions.Logging;
using PluginAPI;

namespace NoiseGenerator;

public class MathHelper(ILogger<MathHelper> logger) : IPlugin
{
    
    private ILogger<MathHelper> Logger { get; } = logger;
    
    
    public void Load()
    {
        Logger.LogDebug("Loading MathHelper plugin");
    }

    public void Enable()
    {
        Logger.LogDebug("Enabling MathHelper plugin");
    }

    ~MathHelper()
    {
        Logger.LogDebug("Disabling MathHelper plugin");
    }

    public string Name { get; set; } = "MathHelper";
    public string Version { get; set; } = "0.1-SNAPSHOT";
    public string[] Authors { get; set; } = new[] { "CubeRealm" };
}