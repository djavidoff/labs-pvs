public class AppState
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AppState(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string AppName
    {
        get => _httpContextAccessor.HttpContext.Items["AppName"]?.ToString();
        set => _httpContextAccessor.HttpContext.Items["AppName"] = value;
    }
}
