namespace DesignPatterns.BehavioralPatterns.Strategy.Routes;

internal class WalkRoute : IRouteStrategy
{
    public void BuildRoute(string origin, string destiny)
    {
        Console.WriteLine($"From {origin} to {destiny} by walk");
        Console.WriteLine($"Time estimated {2 * 1.96} hours");
    }
}
