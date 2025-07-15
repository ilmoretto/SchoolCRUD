using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCRUD.Visualizacao
{
    public class AlunoDTO
    {

        public int IdAluno { get; set; }
        public string NomeAlu { get; set; }
        public string CpfAluno { get; set; }
        public DateOnly? DataNascAlu { get; set; }
        public string TelefoneAlu { get; set; }
        public string EmailAlu { get; set; }
        public string RgAlu { get; set; }

        public string NomeResponsavel { get; set; }
    }
}
