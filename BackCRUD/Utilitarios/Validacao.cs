using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCRUD.Utilitarios
{
    public static class Validacao
    {
        public static string ValidarCPF(string? cpf) {
            if (string.IsNullOrWhiteSpace(cpf)) {
                return "";
            }
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();
            if (cpf.Length != 11) {
                throw new Exception("CPF inválido!");
            }
            return cpf;
        }
    }
}
