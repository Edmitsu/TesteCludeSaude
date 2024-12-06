using Microsoft.EntityFrameworkCore;
namespace TesteCludeSaude.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ProfissionalModel> Profissionais { get; set; } = null!;

        public DbSet<Especialidade> Especialidades { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Inserir a massa de dados inicial
            modelBuilder.Entity<Especialidade>().HasData(
                new Especialidade { Id = 1, Nome = "Cardiologia", TipoDocumento = "CRM" },
                new Especialidade { Id = 2, Nome = "Ortopedia", TipoDocumento = "CRM" },
                new Especialidade { Id = 3, Nome = "Pediatria", TipoDocumento = "CRM" },
                new Especialidade { Id = 4, Nome = "Dermatologia", TipoDocumento = "CRM" },
                new Especialidade { Id = 5, Nome = "Ginecologia", TipoDocumento = "CRM" },
                new Especialidade { Id = 6, Nome = "Neurologia", TipoDocumento = "CRM" },
                new Especialidade { Id = 7, Nome = "Psiquiatria", TipoDocumento = "CRM" },
                new Especialidade { Id = 8, Nome = "Anestesiologia", TipoDocumento = "CRM" },
                new Especialidade { Id = 9, Nome = "Radiologia", TipoDocumento = "CRM" },
                new Especialidade { Id = 10, Nome = "Endocrinologia", TipoDocumento = "CRM" },
                new Especialidade { Id = 11, Nome = "Nutricionista Clínico", TipoDocumento = "CRN" },
                new Especialidade { Id = 12, Nome = "Nutrição Esportiva", TipoDocumento = "CRN" },
                new Especialidade { Id = 13, Nome = "Nutrição Oncológica", TipoDocumento = "CRN" },
                new Especialidade { Id = 14, Nome = "Fisioterapia Ortopédica", TipoDocumento = "CREFITO" },
                new Especialidade { Id = 15, Nome = "Fisioterapia Neurológica", TipoDocumento = "CREFITO" },
                new Especialidade { Id = 16, Nome = "Fisioterapia Respiratória", TipoDocumento = "CREFITO" },
                new Especialidade { Id = 17, Nome = "Ortodontia", TipoDocumento = "CRO" },
                new Especialidade { Id = 18, Nome = "Implantodontia", TipoDocumento = "CRO" },
                new Especialidade { Id = 19, Nome = "Endodontia", TipoDocumento = "CRO" },
                new Especialidade { Id = 20, Nome = "Enfermagem Geral", TipoDocumento = "COREN" },
                new Especialidade { Id = 21, Nome = "Enfermagem Obstétrica", TipoDocumento = "COREN" },
                new Especialidade { Id = 22, Nome = "Psicologia Clínica", TipoDocumento = "CRP" },
                new Especialidade { Id = 23, Nome = "Psicologia Organizacional", TipoDocumento = "CRP" },
                new Especialidade { Id = 24, Nome = "Neuropsicologia", TipoDocumento = "CRP" },
                new Especialidade { Id = 25, Nome = "Farmácia Clínica", TipoDocumento = "CRF" },
                new Especialidade { Id = 26, Nome = "Farmácia Hospitalar", TipoDocumento = "CRF" },
                new Especialidade { Id = 27, Nome = "Análises Clínicas", TipoDocumento = "CRF" },
                new Especialidade { Id = 28, Nome = "Personal Trainer", TipoDocumento = "CREF" },
                new Especialidade { Id = 29, Nome = "Preparação Física", TipoDocumento = "CREF" }
            );
        }
    }
}
