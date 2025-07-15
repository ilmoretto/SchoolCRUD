using BackCRUD.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCRUD.Mapeamento
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string NomeAlu { get; set; }
        private string? _cpfAlu;
        public string CpfAluno {
            get { return _cpfAlu; }
            set { _cpfAlu = Validacao.ValidarCPF(value); }
        }
        public DateOnly DataNascAlu { get; set; }
        public string? EmailAlu { get; set; }
        public string? TelefoneAlu { get; set; }
        public string? RgAlu { get; set; }
        public int? Fk_id_responsavel { get; set; }

        public ResponsavelAluno? FkResponsavelAluno { get; set; }



    }
}
