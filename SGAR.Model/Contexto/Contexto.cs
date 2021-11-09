using SGAR.Model.Models;
using SGAR.Model.Models.Categoria_e_Performance_Level;
using SGAR.Model.Models.HRN;
using SGAR.Model.Models.NR12100;
using System.Data.Entity;

namespace SGAR.Model.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto() : base(@"Data Source=NOTEBOOK-LUCAS-\MSSQLSERVERDEV;Initial Catalog=SGAR_BD_ALPHA;Integrated Security=True")
        {
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<TipoEquipamento> TiposEquipamento { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<ApreciacaoRisco> ApreciacoesRisco { get; set; }
        public DbSet<PossibilidadeOcorrencia> PossibilidadesOcorrencia { get; set; }
        public DbSet<FrequenciaExposicao> FrequenciasExposicao { get; set; }
        public DbSet<NumeroPessoas> NumerosPessoas { get; set; }
        public DbSet<GrauPossivelLesao> GrauPossiveisLesoes { get; set; }
        public DbSet<FaixaHRN> FaixasHRN { get; set; }
        public DbSet<HRNAntes> HRNsAntes { get; set; }
        public DbSet<HRNDepois> HRNsDepois { get; set; }
        public DbSet<PossibilidadeEvitarPerigo> PossibilidadesEvitarPerigos { get; set; }
        public DbSet<SeveridadeFerimento> SeveridadesFerimentos { get; set; }
        public DbSet<FrequenciaExposicaoPerigo> FrequenciasExposicaoPerigos { get; set; }
        public DbSet<DescricaoCategoria> DescricoesCategorias { get; set; }
        public DbSet<DescricaoPerformanceLevel> DescricoesPerformanceLevel { get; set; }
        public DbSet<CategoriaRisco> CategoriasRiscos { get; set; }
        public DbSet<PerformanceLevelRequerido> PerformanceLevelRequeridos { get; set; }
        public DbSet<CicloVida> CiclosDeVida { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoGrupoPerigo> TiposGruposPerigo { get; set; }
        public DbSet<Dano> Danos { get; set; }
        public DbSet<RiscoABNT12100> RiscosABNT { get; set; }
        public DbSet<Risco> Riscos { get; set; }


        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            base.OnModelCreating(dbModelBuilder);

            dbModelBuilder.Entity<Empresa>().ToTable("EMPRESA");
            dbModelBuilder.Entity<Empresa>().HasKey(o => o.Id);
            dbModelBuilder.Entity<Empresa>().Property(o => o.Id).IsRequired().HasColumnName("ID_EMP");
            dbModelBuilder.Entity<Empresa>().Property(o => o.Nome).IsRequired().HasMaxLength(100).HasColumnName("NOM_EMP");

            dbModelBuilder.Entity<Pessoa>().ToTable("PESSOA");
            dbModelBuilder.Entity<Pessoa>().HasKey(o => o.Id);
            dbModelBuilder.Entity<Pessoa>().Property(o => o.Id).IsRequired().HasColumnName("MAT_PES");
            dbModelBuilder.Entity<Pessoa>().Property(o => o.Nome).IsRequired().HasMaxLength(255).HasColumnName("NOM_PES");
            dbModelBuilder.Entity<Pessoa>().Property(o => o.Email).IsRequired().HasMaxLength(255).HasColumnName("EMAIL_PES");
            dbModelBuilder.Entity<Pessoa>().Property(o => o.CPF).IsRequired().HasMaxLength(11).HasColumnName("CPF_PES");
            dbModelBuilder.Entity<Pessoa>().Property(o => o.Senha).IsRequired().HasMaxLength(50).HasColumnName("SENHA");
            dbModelBuilder.Entity<Pessoa>().Property(o => o.IdEmpresa).IsRequired().HasColumnName("ID_EMP");
            dbModelBuilder.Entity<Pessoa>().HasRequired(o => o.Empresa).WithMany(o => o.Pessoas).HasForeignKey(o => o.IdEmpresa);

            dbModelBuilder.Entity<TipoEquipamento>().ToTable("TIPO_EQUIPAMENTO");
            dbModelBuilder.Entity<TipoEquipamento>().HasKey(o => o.Id);
            dbModelBuilder.Entity<TipoEquipamento>().Property(o => o.Id).IsRequired().HasColumnName("ID_TIPO_EQP");
            dbModelBuilder.Entity<TipoEquipamento>().Property(o => o.Descricao).IsRequired().HasMaxLength(100).HasColumnName("DES_TIPO_EQP");

            dbModelBuilder.Entity<Equipamento>().ToTable("EQUIPAMENTO");
            dbModelBuilder.Entity<Equipamento>().HasKey(o => o.Id);
            dbModelBuilder.Entity<Equipamento>().Property(o => o.Id).IsRequired().HasColumnName("ID_EQP");
            dbModelBuilder.Entity<Equipamento>().Property(o => o.Nome).IsRequired().HasMaxLength(100).HasColumnName("NOM_EQP");
            dbModelBuilder.Entity<Equipamento>().Property(o => o.IdTipoEquipamento).IsRequired().HasColumnName("ID_TIPO_EQP");
            dbModelBuilder.Entity<Equipamento>().Property(o => o.IdEmpresa).IsRequired().HasColumnName("ID_EMP");
            dbModelBuilder.Entity<Equipamento>().HasRequired(o => o.TipoEquipamento).WithMany(o => o.Equipamentos).HasForeignKey(o => o.IdTipoEquipamento);
            dbModelBuilder.Entity<Equipamento>().HasRequired(o => o.Empresa).WithMany(o => o.Equipamentos).HasForeignKey(o => o.IdEmpresa);

            dbModelBuilder.Entity<ApreciacaoRisco>().ToTable("APRECIACAO_RISCO");
            dbModelBuilder.Entity<ApreciacaoRisco>().HasKey(o => o.Id);
            dbModelBuilder.Entity<ApreciacaoRisco>().Property(o => o.Id).IsRequired().HasColumnName("ID_APR");
            dbModelBuilder.Entity<ApreciacaoRisco>().Property(o => o.DataApreciacao).IsRequired().HasColumnName("DATA_APR");
            dbModelBuilder.Entity<ApreciacaoRisco>().Property(o => o.LimiteUso).IsRequired().HasMaxLength(500).HasColumnName("LIM_USO");
            dbModelBuilder.Entity<ApreciacaoRisco>().Property(o => o.LimiteEspaco).IsRequired().HasMaxLength(500).HasColumnName("LIM_ESP");
            dbModelBuilder.Entity<ApreciacaoRisco>().Property(o => o.LimiteTempo).IsRequired().HasMaxLength(500).HasColumnName("LIM_TEMP");
            dbModelBuilder.Entity<ApreciacaoRisco>().Property(o => o.IdEquipamento).IsRequired().HasColumnName("ID_EQP");
            dbModelBuilder.Entity<ApreciacaoRisco>().HasRequired(o => o.Equipamento).WithMany(o => o.ApreciacoesRisco).HasForeignKey(o => o.IdEquipamento);
            dbModelBuilder.Entity<ApreciacaoRisco>().HasMany(o => o.Pessoas).WithMany(o => o.ApreciacoesRiscos).Map(o => { o.MapLeftKey("ID_APR"); o.MapRightKey("MAT_PES"); o.ToTable("EXECUTA_APR"); });

            dbModelBuilder.Entity<PossibilidadeOcorrencia>().ToTable("PO_HRN");
            dbModelBuilder.Entity<PossibilidadeOcorrencia>().HasKey(o => o.Id);
            dbModelBuilder.Entity<PossibilidadeOcorrencia>().Property(o => o.Id).IsRequired().HasColumnName("ID_PO");
            dbModelBuilder.Entity<PossibilidadeOcorrencia>().Property(o => o.Descricao).IsRequired().HasMaxLength(100).HasColumnName("DES_PO");
            dbModelBuilder.Entity<PossibilidadeOcorrencia>().Property(o => o.Valor).IsRequired().HasColumnName("VALOR_PO");

            dbModelBuilder.Entity<FrequenciaExposicao>().ToTable("FE_HRN");
            dbModelBuilder.Entity<FrequenciaExposicao>().HasKey(o => o.Id);
            dbModelBuilder.Entity<FrequenciaExposicao>().Property(o => o.Id).IsRequired().HasColumnName("ID_FE");
            dbModelBuilder.Entity<FrequenciaExposicao>().Property(o => o.Descricao).IsRequired().HasMaxLength(50).HasColumnName("DES_FE");
            dbModelBuilder.Entity<FrequenciaExposicao>().Property(o => o.Valor).IsRequired().HasColumnName("VALOR_FE");

            dbModelBuilder.Entity<NumeroPessoas>().ToTable("NP_HRN");
            dbModelBuilder.Entity<NumeroPessoas>().HasKey(o => o.Id);
            dbModelBuilder.Entity<NumeroPessoas>().Property(o => o.Id).IsRequired().HasColumnName("ID_NP");
            dbModelBuilder.Entity<NumeroPessoas>().Property(o => o.Descricao).IsRequired().HasMaxLength(50).HasColumnName("DES_NP");
            dbModelBuilder.Entity<NumeroPessoas>().Property(o => o.Valor).IsRequired().HasColumnName("VALOR_NP");

            dbModelBuilder.Entity<GrauPossivelLesao>().ToTable("GLP_HRN");
            dbModelBuilder.Entity<GrauPossivelLesao>().HasKey(o => o.Id);
            dbModelBuilder.Entity<GrauPossivelLesao>().Property(o => o.Id).IsRequired().HasColumnName("ID_GLP");
            dbModelBuilder.Entity<GrauPossivelLesao>().Property(o => o.Descricao).IsRequired().HasMaxLength(100).HasColumnName("DES_GLP");
            dbModelBuilder.Entity<GrauPossivelLesao>().Property(o => o.Valor).IsRequired().HasColumnName("VALOR_GLP");

            dbModelBuilder.Entity<FaixaHRN>().ToTable("FAIXA_HRN");
            dbModelBuilder.Entity<FaixaHRN>().HasKey(o => o.Id);
            dbModelBuilder.Entity<FaixaHRN>().Property(o => o.Id).IsRequired().HasColumnName("ID_FAIXA");
            dbModelBuilder.Entity<FaixaHRN>().Property(o => o.Faixa).IsRequired().HasMaxLength(25).HasColumnName("FAIXA_HRN");
            dbModelBuilder.Entity<FaixaHRN>().Property(o => o.Descricao).IsRequired().HasMaxLength(100).HasColumnName("DES_FAIXA");

            dbModelBuilder.Entity<HRNAntes>().ToTable("HRN_ANTES");
            dbModelBuilder.Entity<HRNAntes>().HasKey(o => o.Id);
            dbModelBuilder.Entity<HRNAntes>().Property(o => o.Id).IsRequired().HasColumnName("ID_HRN_ANTES");
            dbModelBuilder.Entity<HRNAntes>().Property(o => o.ValorCalculado).IsRequired().HasColumnName("VALOR_HRN");
            dbModelBuilder.Entity<HRNAntes>().Property(o => o.IdFaixaHRN).IsRequired().HasColumnName("ID_FAIXA");
            dbModelBuilder.Entity<HRNAntes>().Property(o => o.IdPossibilidadeOcorrencia).IsRequired().HasColumnName("ID_PO");
            dbModelBuilder.Entity<HRNAntes>().Property(o => o.IdFrequenciaExposicao).IsRequired().HasColumnName("ID_FE");
            dbModelBuilder.Entity<HRNAntes>().Property(o => o.IdNumeroPessoas).IsRequired().HasColumnName("ID_NP");
            dbModelBuilder.Entity<HRNAntes>().Property(o => o.IdGrauPossivelLesao).IsRequired().HasColumnName("ID_GLP");
            dbModelBuilder.Entity<HRNAntes>().HasRequired(o => o.FaixaHRN).WithMany(o => o.HRNsAntes).HasForeignKey(o => o.IdFaixaHRN);
            dbModelBuilder.Entity<HRNAntes>().HasRequired(o => o.PossibilidadeOcorrencia).WithMany(o => o.HRNsAntes).HasForeignKey(o => o.IdPossibilidadeOcorrencia);
            dbModelBuilder.Entity<HRNAntes>().HasRequired(o => o.FrequenciaExposicao).WithMany(o => o.HRNsAntes).HasForeignKey(o => o.IdFrequenciaExposicao);
            dbModelBuilder.Entity<HRNAntes>().HasRequired(o => o.NumeroPessoas).WithMany(o => o.HRNsAntes).HasForeignKey(o => o.IdNumeroPessoas);
            dbModelBuilder.Entity<HRNAntes>().HasRequired(o => o.GrauPossivelLesao).WithMany(o => o.HRNsAntes).HasForeignKey(o => o.IdGrauPossivelLesao);

            dbModelBuilder.Entity<HRNDepois>().ToTable("HRN_DEPOIS");
            dbModelBuilder.Entity<HRNDepois>().HasKey(o => o.Id);
            dbModelBuilder.Entity<HRNDepois>().Property(o => o.Id).IsRequired().HasColumnName("ID_HRN_DEPOIS");
            dbModelBuilder.Entity<HRNDepois>().Property(o => o.ValorCalculado).IsRequired().HasColumnName("VALOR_HRN");
            dbModelBuilder.Entity<HRNDepois>().Property(o => o.IdFaixaHRN).IsRequired().HasColumnName("ID_FAIXA");
            dbModelBuilder.Entity<HRNDepois>().Property(o => o.IdPossibilidadeOcorrencia).IsRequired().HasColumnName("ID_PO");
            dbModelBuilder.Entity<HRNDepois>().Property(o => o.IdFrequenciaExposicao).IsRequired().HasColumnName("ID_FE");
            dbModelBuilder.Entity<HRNDepois>().Property(o => o.IdNumeroPessoas).IsRequired().HasColumnName("ID_NP");
            dbModelBuilder.Entity<HRNDepois>().Property(o => o.IdGrauPossivelLesao).IsRequired().HasColumnName("ID_GLP");
            dbModelBuilder.Entity<HRNDepois>().HasRequired(o => o.FaixaHRN).WithMany(o => o.HRNsDepois).HasForeignKey(o => o.IdFaixaHRN);
            dbModelBuilder.Entity<HRNDepois>().HasRequired(o => o.PossibilidadeOcorrencia).WithMany(o => o.HRNsDepois).HasForeignKey(o => o.IdPossibilidadeOcorrencia);
            dbModelBuilder.Entity<HRNDepois>().HasRequired(o => o.FrequenciaExposicao).WithMany(o => o.HRNsDepois).HasForeignKey(o => o.IdFrequenciaExposicao);
            dbModelBuilder.Entity<HRNDepois>().HasRequired(o => o.NumeroPessoas).WithMany(o => o.HRNsDepois).HasForeignKey(o => o.IdNumeroPessoas);
            dbModelBuilder.Entity<HRNDepois>().HasRequired(o => o.GrauPossivelLesao).WithMany(o => o.HRNsDepois).HasForeignKey(o => o.IdGrauPossivelLesao);

            dbModelBuilder.Entity<PossibilidadeEvitarPerigo>().ToTable("POSSIBILIDADE_EVITAR_PERIGO");
            dbModelBuilder.Entity<PossibilidadeEvitarPerigo>().HasKey(o => o.Id);
            dbModelBuilder.Entity<PossibilidadeEvitarPerigo>().Property(o => o.Id).IsRequired().HasColumnName("ID_PEP");
            dbModelBuilder.Entity<PossibilidadeEvitarPerigo>().Property(o => o.Descricao).IsRequired().HasMaxLength(50).HasColumnName("DES_PEP");

            dbModelBuilder.Entity<SeveridadeFerimento>().ToTable("SEVERIDADE_FERIMENTO");
            dbModelBuilder.Entity<SeveridadeFerimento>().HasKey(o => o.Id);
            dbModelBuilder.Entity<SeveridadeFerimento>().Property(o => o.Id).IsRequired().HasColumnName("ID_SEV");
            dbModelBuilder.Entity<SeveridadeFerimento>().Property(o => o.Descricao).IsRequired().HasMaxLength(50).HasColumnName("DES_SEV");

            dbModelBuilder.Entity<FrequenciaExposicaoPerigo>().ToTable("FREQUENCIA_EXPOSICAO");
            dbModelBuilder.Entity<FrequenciaExposicaoPerigo>().HasKey(o => o.Id);
            dbModelBuilder.Entity<FrequenciaExposicaoPerigo>().Property(o => o.Id).IsRequired().HasColumnName("ID_FREQ");
            dbModelBuilder.Entity<FrequenciaExposicaoPerigo>().Property(o => o.Descricao).IsRequired().HasMaxLength(50).HasColumnName("DES_FREQ");

            dbModelBuilder.Entity<DescricaoCategoria>().ToTable("DESC_CATEGORIA");
            dbModelBuilder.Entity<DescricaoCategoria>().HasKey(o => o.Id);
            dbModelBuilder.Entity<DescricaoCategoria>().Property(o => o.Id).IsRequired().HasColumnName("ID_DES_CAT");
            dbModelBuilder.Entity<DescricaoCategoria>().Property(o => o.Descricao).IsRequired().HasMaxLength(50).HasColumnName("DES_CAT");

            dbModelBuilder.Entity<DescricaoPerformanceLevel>().ToTable("DESC_PL");
            dbModelBuilder.Entity<DescricaoPerformanceLevel>().HasKey(o => o.Id);
            dbModelBuilder.Entity<DescricaoPerformanceLevel>().Property(o => o.Id).IsRequired().HasColumnName("ID_DES_PL");
            dbModelBuilder.Entity<DescricaoPerformanceLevel>().Property(o => o.Descricao).IsRequired().HasMaxLength(50).HasColumnName("DES_PL");

            dbModelBuilder.Entity<CategoriaRisco>().ToTable("CATEGORIA_RISCO");
            dbModelBuilder.Entity<CategoriaRisco>().HasKey(o => o.Id);
            dbModelBuilder.Entity<CategoriaRisco>().Property(o => o.Id).IsRequired().HasColumnName("ID_CAT");
            dbModelBuilder.Entity<CategoriaRisco>().Property(o => o.IdSeveridadeFerimento).IsRequired().HasColumnName("ID_SEV");
            dbModelBuilder.Entity<CategoriaRisco>().Property(o => o.IdFrequenciaExposicaoPerigo).IsRequired().HasColumnName("ID_FREQ");
            dbModelBuilder.Entity<CategoriaRisco>().Property(o => o.IdPossibilidadeEvitarPerigo).IsRequired().HasColumnName("ID_PEP");
            dbModelBuilder.Entity<CategoriaRisco>().Property(o => o.IdDescricaoCategoria).IsRequired().HasColumnName("ID_DES_CAT");
            dbModelBuilder.Entity<CategoriaRisco>().HasRequired(o => o.SeveridadeFerimento).WithMany(o => o.CategoriasRisco).HasForeignKey(o => o.IdSeveridadeFerimento);
            dbModelBuilder.Entity<CategoriaRisco>().HasRequired(o => o.FrequenciaExposicaoPerigo).WithMany(o => o.CategoriasRisco).HasForeignKey(o => o.IdFrequenciaExposicaoPerigo);
            dbModelBuilder.Entity<CategoriaRisco>().HasRequired(o => o.PossibilidadeEvitarPerigo).WithMany(o => o.CategoriasRisco).HasForeignKey(o => o.IdPossibilidadeEvitarPerigo);
            dbModelBuilder.Entity<CategoriaRisco>().HasRequired(o => o.DescricaoCategoria).WithMany(o => o.CategoriasRisco).HasForeignKey(o => o.IdDescricaoCategoria);

            dbModelBuilder.Entity<PerformanceLevelRequerido>().ToTable("PERFORMANCE_LEVEL_REQ");
            dbModelBuilder.Entity<PerformanceLevelRequerido>().HasKey(o => o.Id);
            dbModelBuilder.Entity<PerformanceLevelRequerido>().Property(o => o.Id).IsRequired().HasColumnName("ID_PL");
            dbModelBuilder.Entity<PerformanceLevelRequerido>().Property(o => o.IdSeveridadeFerimento).IsRequired().HasColumnName("ID_SEV");
            dbModelBuilder.Entity<PerformanceLevelRequerido>().Property(o => o.IdFrequenciaExposicaoPerigo).IsRequired().HasColumnName("ID_FREQ");
            dbModelBuilder.Entity<PerformanceLevelRequerido>().Property(o => o.IdPossibilidadeEvitarPerigo).IsRequired().HasColumnName("ID_PEP");
            dbModelBuilder.Entity<PerformanceLevelRequerido>().Property(o => o.IdDescricaoPerformanceLevel).IsRequired().HasColumnName("ID_DES_PL");
            dbModelBuilder.Entity<PerformanceLevelRequerido>().HasRequired(o => o.SeveridadeFerimento).WithMany(o => o.PerformancesLevelRequeridos).HasForeignKey(o => o.IdSeveridadeFerimento);
            dbModelBuilder.Entity<PerformanceLevelRequerido>().HasRequired(o => o.FrequenciaExposicaoPerigo).WithMany(o => o.PerformancesLevelRequeridos).HasForeignKey(o => o.IdFrequenciaExposicaoPerigo);
            dbModelBuilder.Entity<PerformanceLevelRequerido>().HasRequired(o => o.PossibilidadeEvitarPerigo).WithMany(o => o.PerformancesLevelRequeridos).HasForeignKey(o => o.IdPossibilidadeEvitarPerigo);
            dbModelBuilder.Entity<PerformanceLevelRequerido>().HasRequired(o => o.DescricaoPerformanceLevel).WithMany(o => o.PerformancesLevelRequeridos).HasForeignKey(o => o.IdDescricaoPerformanceLevel);

            dbModelBuilder.Entity<CicloVida>().ToTable("CICLO_DE_VIDA");
            dbModelBuilder.Entity<CicloVida>().HasKey(o => o.Id);
            dbModelBuilder.Entity<CicloVida>().Property(o => o.Id).IsRequired().HasColumnName("ID_CICVID");
            dbModelBuilder.Entity<CicloVida>().Property(o => o.Descricao).IsRequired().HasMaxLength(250).HasColumnName("DES_CICVID");

            dbModelBuilder.Entity<Tarefa>().ToTable("TAREFA");
            dbModelBuilder.Entity<Tarefa>().HasKey(o => o.Id);
            dbModelBuilder.Entity<Tarefa>().Property(o => o.Id).IsRequired().HasColumnName("ID_TAR");
            dbModelBuilder.Entity<Tarefa>().Property(o => o.Descricao).IsRequired().HasMaxLength(250).HasColumnName("DES_TAR");
            dbModelBuilder.Entity<Tarefa>().Property(o => o.IdCicloVida).IsRequired().HasColumnName("ID_CICVID");
            dbModelBuilder.Entity<Tarefa>().HasRequired(o => o.CicloVida).WithMany(o => o.Tarefas).HasForeignKey(o => o.IdCicloVida);

            dbModelBuilder.Entity<TipoGrupoPerigo>().ToTable("TIPO_GRUPO_PERIGO");
            dbModelBuilder.Entity<TipoGrupoPerigo>().HasKey(o => o.Id);
            dbModelBuilder.Entity<TipoGrupoPerigo>().Property(o => o.Id).IsRequired().HasColumnName("ID_TIP_PER");
            dbModelBuilder.Entity<TipoGrupoPerigo>().Property(o => o.Descricao).IsRequired().HasMaxLength(250).HasColumnName("DES_TIP_PER");

            dbModelBuilder.Entity<Dano>().ToTable("DANO");
            dbModelBuilder.Entity<Dano>().HasKey(o => o.Id);
            dbModelBuilder.Entity<Dano>().Property(o => o.Id).IsRequired().HasColumnName("ID_DAN");
            dbModelBuilder.Entity<Dano>().Property(o => o.Descricao).IsRequired().HasMaxLength(250).HasColumnName("DES_DAN");
            dbModelBuilder.Entity<Dano>().Property(o => o.IdTipoGrupoPerigo).IsRequired().HasColumnName("ID_TIP_PER");
            dbModelBuilder.Entity<Dano>().HasRequired(o => o.TipoGrupoPerigo).WithMany(o => o.Danos).HasForeignKey(o => o.IdTipoGrupoPerigo);

            dbModelBuilder.Entity<RiscoABNT12100>().ToTable("RISCO_ABNT");
            dbModelBuilder.Entity<RiscoABNT12100>().HasKey(o => o.Id);
            dbModelBuilder.Entity<RiscoABNT12100>().Property(o => o.Id).IsRequired().HasColumnName("ID_RIS");
            dbModelBuilder.Entity<RiscoABNT12100>().Property(o => o.Descricao).IsRequired().HasMaxLength(250).HasColumnName("DES_RIS");

            dbModelBuilder.Entity<Risco>().ToTable("RISCO");
            dbModelBuilder.Entity<Risco>().HasKey(o => o.Id);
            dbModelBuilder.Entity<Risco>().Property(o => o.Id).IsRequired().HasColumnName("ID_RISCO");
            dbModelBuilder.Entity<Risco>().Property(o => o.Atividade).IsRequired().HasMaxLength(250).HasColumnName("ATIVIDADE");
            dbModelBuilder.Entity<Risco>().Property(o => o.Onde).IsRequired().HasMaxLength(250).HasColumnName("ONDE");
            dbModelBuilder.Entity<Risco>().Property(o => o.MedidaProtecaoSugerida).IsRequired().HasMaxLength(500).HasColumnName("MED_PRO_SUG");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdAPreciacaoRisco).IsRequired().HasColumnName("ID_APR");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdCicloVida).IsRequired().HasColumnName("ID_CICVID");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdTarefa).IsRequired().HasColumnName("ID_TAR");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdTipoGrupoPerigo).IsRequired().HasColumnName("ID_TIP_PER");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdDano).IsRequired().HasColumnName("ID_DAN");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdRiscoABNT12100).IsRequired().HasColumnName("ID_RIS_ABNT");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdHRNAntes).IsRequired().HasColumnName("ID_HRN_ANTES");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdCategoriaRisco).IsRequired().HasColumnName("ID_CAT");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdPerformanceLevelRequerido).IsRequired().HasColumnName("ID_PL");
            dbModelBuilder.Entity<Risco>().Property(o => o.IdHRNDepois).IsRequired().HasColumnName("ID_HRN_DEPOIS");
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.ApreciacaoRisco).WithMany(o => o.Riscos).HasForeignKey(o => o.IdAPreciacaoRisco);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.CicloVida).WithMany(o => o.Riscos).HasForeignKey(o => o.IdCicloVida);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.Tarefa).WithMany(o => o.Riscos).HasForeignKey(o => o.IdTarefa);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.TipoGrupoPerigo).WithMany(o => o.Riscos).HasForeignKey(o => o.IdTipoGrupoPerigo);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.Dano).WithMany(o => o.Riscos).HasForeignKey(o => o.IdDano);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.RiscoABNT12100).WithMany(o => o.Riscos).HasForeignKey(o => o.IdRiscoABNT12100);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.HRNAntes).WithMany(o => o.Riscos).HasForeignKey(o => o.IdHRNAntes);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.CategoriaRisco).WithMany(o => o.Riscos).HasForeignKey(o => o.IdCategoriaRisco);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.PerformanceLevelRequerido).WithMany(o => o.Riscos).HasForeignKey(o => o.IdPerformanceLevelRequerido);
            dbModelBuilder.Entity<Risco>().HasRequired(o => o.HRNDepois).WithMany(o => o.Riscos).HasForeignKey(o => o.IdHRNDepois);
        }
    }
}
