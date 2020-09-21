using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using sCTNSolution.Application.Catalog.Hoadon;
using sCTNSolution.Application.Catalog.TramNuoc;
using sCTNSolution.Data.EF;
using sCTNSolution.Utilities.Constants;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Identity;
using sCTNSolution.Data.Entities;
using sCTNSolution.Application.System.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace sCTNSolution.BackendApi
{
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
            services.AddDbContext<CTNKGContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString(SystempConstants.CTNKGConnectionString)));
            //cofig Authenticate
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<CTNKGContext>()
                .AddDefaultTokenProviders();

            //Declare DI khoi tao dich vu neu khong thi error : Unable to resolve service for type interface
            services.AddTransient<IManagerHoaDonService, ManagerHoaDonService>();
            services.AddTransient<IManageTramNuocService, ManageTramNuocService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<UserManager<AppUser>,UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();


            services.AddControllersWithViews();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CTNKG API test", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,

                        },
                        new List<string>()
                      }
                    });
            });

            //config dich vu chay len doi xac thuc
            string issuer = Configuration.GetValue<string>("Tokens:Issuer");
            string signingKey = Configuration.GetValue<string>("Tokens:Key");
            byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(option =>{
                    option.RequireHttpsMetadata = false;
                    option.SaveToken = true;
                    option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = issuer,
                        ValidateAudience = true,
                        ValidAudience = issuer,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ClockSkew = System.TimeSpan.Zero,
                        IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
                    };
                }); 



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger test CTNKG V1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
