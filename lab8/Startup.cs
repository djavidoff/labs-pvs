public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>();

    services.AddControllersWithViews();
}
