using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avaleu.Model;

namespace Avaleu.Dao
{
    public class DataContext : DbContext
    {
		//Crio um construtor para o DataContext que passa a ConnectionString para a classe mãe(DbContext)
		public DataContext() : base(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString)
		{
		//	Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}

        // Definir os DbSet's para cada uma das Models
        // Serão criadas Tabelas no Banco para os DbSets/Models

        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
