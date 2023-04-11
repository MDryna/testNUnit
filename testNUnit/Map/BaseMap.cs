namespace testNUnit.Map;

public class BaseMap
{
    public AuthorizationMap AuthorizationMap => new AuthorizationMap();
    public HomeMap HomeMap => new HomeMap();
    public ScheduleMap ScheduleMap => new ScheduleMap();
}