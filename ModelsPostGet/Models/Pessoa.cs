using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsPostGet.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public String Nome { get; set; }
        public String Instagram { get; set; }
        public Pessoa()
        {
            PessoaId = 0;
            Nome = null;
            Instagram = null;
        }
        public Pessoa(int PessoaId, String Nome, String Instagram)
        {
            this.PessoaId = PessoaId;
            this.Nome = Nome;
            this.Instagram = Instagram;
        }
    }
}