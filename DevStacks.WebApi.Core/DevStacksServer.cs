using DevStacks.WebApi.Core.Core;
using DevStacks.WebApi.Core.Routing;

namespace DevStacks.WebApi.Core;

public class DevStacksServer
{
    public readonly List<Route> Routes;
    public readonly List<BootstrapBase> Bootstraps;

    public DevStacksServer()
    {
        this.Routes = new List<Route>();
        this.Bootstraps = new List<BootstrapBase>();
    }
}