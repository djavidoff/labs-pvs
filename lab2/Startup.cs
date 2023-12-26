public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
      
       services.AddScoped<IMyService, MyService>();
    }   
}
