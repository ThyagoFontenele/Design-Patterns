using DesignPatterns.BehavioralPatterns.Strategy.Routes;

namespace DesignPatterns.BehavioralPatterns.Strategy;

public class Navigator
{
    private IRouteStrategy routeStrategy;

	public Navigator(IRouteStrategy routeStrategy) =>
		this.routeStrategy = routeStrategy;

	public void SetRouteStrategy(IRouteStrategy routeStrategy) =>
		this.routeStrategy = routeStrategy;
	public void BuildRoute(string origin, string destiny) =>
		routeStrategy.BuildRoute(origin, destiny);
}
