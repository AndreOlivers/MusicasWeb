using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comum.Entity
{
    public abstract class MusicasWebEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public MusicasWebEntityAbstractConfig()
        {
            configurarNomeTabela();
            configurarCamposTabela();
            configurarChavePrimaria();
            configurarChaveEstrangeira();
        }

        protected abstract void configurarChaveEstrangeira();
        protected abstract void configurarChavePrimaria();
        protected abstract void configurarCamposTabela();
        protected abstract void configurarNomeTabela();
    }
}
