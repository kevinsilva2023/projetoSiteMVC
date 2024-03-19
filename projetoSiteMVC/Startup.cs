using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using projetoSiteMVC.Context;
using projetoSiteMVC.Models;
using projetoSiteMVC.Repository;
using projetoSiteMVC.Repository.Interfaces;
using projetoSiteMVC.Services;

namespace projetoSiteMVC;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

        //// sobrescrevendo padrao do identity
        //services.Configure<IdentityOptions>(options =>
        //{
        //    options.Password.RequireDigit = false;
        //    options.Password.RequireLowercase = false; // um minusculo
        //    options.Password.RequireUppercase = false; // um maiusculo
        //    options.Password.RequireNonAlphanumeric = false; // numero
        //    options.Password.RequiredLength = 3; // 
        //});

        services.AddTransient<ICategoriaRepository, CategoriaRepository>();
        services.AddTransient<IProdutoRepository, ProdutoRepository>();
        services.AddTransient<IPedidoRepository, PedidoRepository>();
        services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>(); 

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

        services.AddAuthorization(options =>
        {
            options.AddPolicy("Admin",
                politica =>
                {
                    politica.RequireRole("Admin");
                });
        });

        services.AddControllersWithViews();

        services.AddMemoryCache();
        //service.AddDistributedMemoryCache();

        services.AddSession();
        //{
        //    options.IdleTimeout = TimeSpan.FromSeconds(10);
        //    options.Cookie.HttpOnly = true;
        //    options.Cookie.IsEssential = true;
        //}

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app,
        IWebHostEnvironment env, ISeedUserRoleInitial seedUserRoleInitial)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseRouting();

        // cria perfil
        seedUserRoleInitial.SeedRoles();
        // cria user
        seedUserRoleInitial.SeedUsers();

        app.UseSession();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {

            endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
                );

            endpoints.MapControllerRoute(
                name: "categoriaFiltro",
                pattern: "Produto/{action}/{categoria?}",
                defaults: new { controller = "Produto", Action = "List" }
                );

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
