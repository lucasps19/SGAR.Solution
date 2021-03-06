using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SGAR.Bll.CadastroUsuarios;
using SGAR.Bll.EditarApreciacao;
using SGAR.Bll.EditarRisco;
using SGAR.Bll.ListarApreciacoes;
using SGAR.Bll.Login;
using SGAR.Bll.NovaApreciacao;
using SGAR.Bll.NovoRisco;
using SGAR.Dal.CadastroUsuarios;
using SGAR.Dal.EditarApreciacao;
using SGAR.Dal.EditarRisco;
using SGAR.Dal.ListarApreciacoes;
using SGAR.Dal.Login;
using SGAR.Dal.NovaApreciacao;
using SGAR.Dal.NovoRisco;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.Dto.Empresa;
using SGAR.Dto.Equipamento;
using SGAR.Dto.HRN;
using SGAR.Dto.NR12100;
using SGAR.Dto.Pessoa;
using SGAR.Model.Contexto;
using System;

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

            services.AddScoped<EditarApreciacaoBll>();
            services.AddScoped<EditarApreciacaoDal>();
            services.AddScoped<LoginBll>();
            services.AddScoped<CadastroUsuarioBll>();
            services.AddScoped<ListarApreciacoesBll>();
            services.AddScoped<NovaApreciacaoBll>();
            services.AddScoped<NovoRiscoBll>();
            services.AddScoped<EditarRiscoBll>();
            services.AddScoped<LoginDal>();
            services.AddScoped<CadastroUsuarioDal>();
            services.AddScoped<ListarApreciacoesDal>();
            services.AddScoped<NovaApreciacaoDal>();
            services.AddScoped<NovoRiscoDal>();
            services.AddScoped<EditarRiscoDal>();
            services.AddScoped<PessoaDTO>();
            services.AddScoped<EmpresaDto>();
            services.AddScoped<TipoEquipamentoDto>();
            services.AddScoped<EquipamentoDto>();
            services.AddScoped<FaixaHRNDto>();
            services.AddScoped<CicloVidaDto>();
            services.AddScoped<TarefaDto>();
            services.AddScoped<TipoGrupoPerigoDto>();
            services.AddScoped<DanoDto>();
            services.AddScoped<RiscoABNT12100Dto>();
            services.AddScoped<PossibilidadeOcorrenciaDto>();
            services.AddScoped<FrequenciaExposicaoDto>();
            services.AddScoped<NumeroPessoasDto>();
            services.AddScoped<GrauPossivelLesaoDto>();
            services.AddScoped<HRNAntesDto>();
            services.AddScoped<HRNDepoisDto>();
            services.AddScoped<DescricaoCategoriaDto>();
            services.AddScoped<PossibilidadeEvitarPerigoDto>();
            services.AddScoped<FrequenciaExposicaoPerigoDto>();
            services.AddScoped<SeveridadeFerimentoDto>();
            services.AddScoped<CategoriaRiscoDto>();
            services.AddScoped<DescricaoPerformanceLevelDto>();
            services.AddScoped<PerformanceLevelRequeridoDto>();
            services.AddScoped<CategoriaPerformanceLevelRequeridoDto>();
            services.AddScoped<RiscoDto>();
            services.AddScoped<ApreciacaoRiscoDto>();
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
