using DesignPatterns.BehavioralPatterns.Strategy.Routes;

namespace DesignPatterns.BehavioralPatterns.Strategy;

internal class Strategy : IDesignPattern
{
    public void Main()
    {
        var walkRoute = new WalkRoute();
        var carRoute = new CarRoute();

        var navigator = new Navigator(carRoute);
        navigator.BuildRoute("niterói", "são paulo");
        navigator.SetRouteStrategy(walkRoute);
        navigator.BuildRoute("niterói", "são paulo");
    }
}
