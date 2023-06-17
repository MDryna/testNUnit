namespace testNUnit.Map;

public class BaseMap
{
    public AuthorizationMap AuthorizationMap => new AuthorizationMap();
    public HomeMap HomeMap => new HomeMap();
    public ScheduleMap ScheduleMap => new ScheduleMap();
    public HostMap HostMap => new HostMap();
    public FrontendMap FrontendMap => new FrontendMap();
    public QaMap QaMap => new QaMap();
}