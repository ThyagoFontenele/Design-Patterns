namespace DesignPatterns.BehavioralPatterns.Strategy.Routes;

internal class BusRoute : IRouteStrategy
{
    public void BuildRoute(string origin, string destiny)
    {
        Console.WriteLine($"From {origin} to {destiny} by bus");
        Console.WriteLine($"Time estimated {2 * 1.2} hours");
    }
}
