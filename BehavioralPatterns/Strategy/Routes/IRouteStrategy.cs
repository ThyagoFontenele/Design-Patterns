namespace DesignPatterns.BehavioralPatterns.Strategy.Routes;

public interface IRouteStrategy
{
    void BuildRoute(string origin, string destiny);
}
