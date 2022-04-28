using BLL.Abstract;
using BLL.Concrete;
using DAL.Abstract;
using DAL.Concrete;
using DAL.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WebIU;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddAuthentication();
 
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddIdentity<AppUser, IdentityRole>(
        opt =>
        {
            opt.Password.RequireDigit = false;
            opt.Password.RequireLowercase = false;
            opt.Password.RequiredLength =1;
            opt.Password.RequireUppercase = false;
            opt.Password.RequireNonAlphanumeric=false;
        }
        ).AddEntityFrameworkStores<MyDbContext>();
IdentityInitializer.CreateAdmin();
builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath=new PathString("/Home/Login");
    opt.Cookie.Name="login_cookie";
    opt.Cookie.HttpOnly = true;
    opt.Cookie.SameSite=SameSiteMode.Strict;
    opt.ExpireTimeSpan=TimeSpan.FromMinutes(30);
});



/*Kategorilerin dependency yöntemiyle eklenmesi sürecince
 * servicren repositoryye kadar yaratýlacak scoplar.*/
builder.Services.AddScoped<ICategoryServices, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryRepository>();

builder.Services.AddScoped<IQuestionServices, QuestionManager>();
builder.Services.AddScoped<IQuestionDal, EfQuestionRepository>();

builder.Services.AddScoped<IExerciseServices, ExerciseManager>();
builder.Services.AddScoped<IExerciseDal, EfExerciseRepository>();

builder.Services.AddScoped<IExerciseQuestionServices, ExerciseQuestionManager>();
builder.Services.AddScoped<IExerciseQuestionDal, EfExerciseQuestionRepository>();


var app = builder.Build();






// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

}
IdentityInitializer.CreateAdmin();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();

IdentityInitializer.CreateAdmin();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area}/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


