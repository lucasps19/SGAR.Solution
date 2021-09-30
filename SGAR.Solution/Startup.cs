using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SGAR.Bll.CadastroUsuarios;
using SGAR.Bll.Login;
using SGAR.Dal.CadastroUsuarios;
using SGAR.Dal.Login;
using SGAR.Dto.Empresa;
using SGAR.Dto.Pessoa;
using SGAR.Model.Contexto;
using SGAR.WebApi.ViewModel.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGAR.Solution
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
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<LoginBll>();
            services.AddScoped<CadastroUsuarioBll>();
            services.AddScoped<LoginDal>();
            services.AddScoped<CadastroUsuarioDal>();
            services.AddScoped<PessoaDTO>();
            services.AddScoped<EmpresaDto>();
            services.AddScoped<Contexto>(o => new Contexto(/*Configuration.GetConnectionString(@"Data Source=NOTEBOOK-LUCAS-\MSSQLSERVERDEV;Initial Catalog=SGAR_BD;Integrated Security=True")*/));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SGAR.Solution", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SGAR.Solution v1"));
            }

            app.UseHttpsRedirection();

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
