using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Vagas.Modelos;
using Xamarin.Forms;

namespace Vagas.Banco
{
    class Database
    {
        private SQLiteConnection _conexao;

        public Database()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");
            _conexao = new SQLiteConnection(caminho);
        }

        public List<Vaga> Consultar()
        {
            return null;
        }

        public void Cadastro(Vaga vaga)
        {
            
        }

        public Vaga ObterVagaPorId(int id)
        {
            return null;
        }

        public void Atualizacao(Vaga vaga)
        {
            
        }
    }
}
