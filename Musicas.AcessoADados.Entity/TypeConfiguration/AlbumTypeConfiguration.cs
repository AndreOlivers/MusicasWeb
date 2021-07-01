using Comum.Entity;
using Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.AcessoADados.Entity.TypeConfiguration
{
    class AlbumTypeConfiguration : MusicasWebEntityAbstractConfig<Album>
    {
        protected override void configurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ALB_ID");

            Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("ALB_Nome")
                .HasMaxLength(100);

            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("ALB_ANO");

            Property(p => p.Observacoes)
                .IsOptional()
                .HasColumnName("ALB_OBSERVACOES")
                .HasMaxLength(1000);

        }
            
        protected override void configurarChaveEstrangeira()
        {
            HasKey(pk => pk.Id);
        }

        protected override void configurarChavePrimaria()
        {
           
        }

        protected override void configurarNomeTabela()
        {
            ToTable("ALB_ALBUNS");
        }
    }
}
