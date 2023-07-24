namespace DesignPatterns.BehavioralPatterns.Strategy.Routes;

internal class CycleRoute : IRouteStrategy
{
    public void BuildRoute(string origin, string destiny)
    {
        Console.WriteLine($"From {origin} to {destiny} by bike");
        Console.WriteLine($"Time estimated {2 * 1.5} hours");
    }
}
