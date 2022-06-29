var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddControllersWithViews();
    if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/home/error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=home}/{action=index}/{id?}");
}
);
app.MapControllerRoute(
name: "default",
pattern: "{Controller=Home}/{action=Index}/{id?}");
app.Run();
