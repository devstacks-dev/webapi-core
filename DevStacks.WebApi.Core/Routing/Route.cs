using System;

namespace DevStacks.WebApi.Core.Routing;

public class Route
{
    public string Path { get; set; }
    public Func<string> Callback { get; set; }

    public Route(string path, Func<string> callback)
    {
        this.Path = path;
        this.Callback = callback;
    }
}