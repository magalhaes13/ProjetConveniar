using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebMySQL
{
    public class StartUp { 
        public StartUp(IConfiguration configuration)
        {
            configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string stringConexao = "Server=localhost;Database=formulario;Uid=arthur;Pwd=123456";
            services.AddDbContext<Contexto>(option =>
            options.UseMySql(stringConexao));
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) ;
        }


    }

}
