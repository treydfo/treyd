using DataLibrary;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using Microsoft.AspNetCore.Components.Authorization;
using treyd.Shared;
using BlazorPro.BlazorSize;
using Microsoft.AspNetCore.Mvc;

namespace treyd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton(Configuration);
            services.AddScoped<IDataAccess, DataAccess>();
            services.AddSyncfusionBlazor();
            services.AddScoped<StateContainer>(); // Used for various states
            services.AddScoped<AuthenticationStateProvider, TreydAuthenticationStateProvider>(); // Used for the User state
            services.AddMediaQueryService();
            /*services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];

                facebookOptions.Events = new Microsoft.AspNetCore.Authentication.OAuth.OAuthEvents()
                {
                    OnRemoteFailure = LoginFailureHandler =>
                    {
                        var auth = facebookOptions.StateDataFormat.Unprotect(LoginFailureHandler.Request.Query["state"]);
                        LoginFailureHandler.Response.Redirect("/rita_inn");
                        return Task.FromResult(0);
                    }
                };
            });*/ // Used for Facebook authentication state
            services.AddHttpClient();

            services.AddMvc(options => options.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDgyMTA4QDMxMzkyZTMyMmUzMGFLOHJqaVpQT2VKQ2E5N2w2N2w1LzBRMDFML1pPR2k4bzNDOWVIV0puTnM9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseMvcWithDefaultRoute();

            // Enabling for user login and register
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
