namespace DesignPatterns.BehavioralPatterns.Strategy.Routes;

internal class CarRoute : IRouteStrategy
{
    public void BuildRoute(string origin, string destiny)
    {
        Console.WriteLine($"From {origin} to {destiny} by car");
        Console.WriteLine($"Time estimated {2 * 1} hours");
    }
}
