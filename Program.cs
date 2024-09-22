using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// خدمات را به کانتینر اضافه کنید.  
builder.Services.AddControllersWithViews();

var app = builder.Build();

// پیکربندی خط لوله HTTP درخواست‌ها.  
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // مقدار پیش‌فرض HSTS 30 روز است. شما ممکن است بخواهید این مقدار را برای سناریوهای تولید تغییر دهید.  
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// تنظیم مسیر (Routing)  
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
