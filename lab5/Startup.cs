public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "custom",
            pattern: "custom/{action}/{id?}",
            defaults: new { controller = "Home", action = "Index" });
        
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    });

}
