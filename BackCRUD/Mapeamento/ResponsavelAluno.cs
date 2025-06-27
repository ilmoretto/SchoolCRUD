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
        public int _idResp {  get; set; }
        public string _nomeResp { get; set; }
        private string _cpfResp { get; set; }
        public string? _rgResp { get; set; }
        public DateOnly? _dataNascResp {  get; set; }
        public string _emailResp { get; set; }
        public string? _telefoneResp { get; set; }
        public string? _parentescoResp { get; set; }

        public string CpfResp {
            get {  return _cpfResp; }
            set { _cpfResp = Validacao.ValidarCPF(value); }
        }

    }
}
