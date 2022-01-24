namespace DevStacks.WebApi.Core.Core;

public abstract class BootstrapBase
{
    public readonly DevStacksServer Server;
    
    protected BootstrapBase(DevStacksServer server)
    {
        this.Server = server;
    }
}