using BackCRUD.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BackCRUD.Mapeamento
{
    public class ResponsavelAluno
    {
        public int IdResp {  get; set; }
        public string NomeResp { get; set; }
        private string _cpfResp { get; set; }
        public string? RgResp { get; set; }
        public DateOnly? DataNascResp {  get; set; }
        public string EmailResp { get; set; }
        public string? TelefoneResp { get; set; }
        public string? ParentescoResp { get; set; }

        public string CpfResp {
            get {  return _cpfResp; }
            set { _cpfResp = Validacao.ValidarCPF(value); }
        }

    }
}
