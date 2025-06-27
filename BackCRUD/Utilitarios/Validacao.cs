using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCRUD.Utilitarios
{
    public static class Validacao
    {
        public static string ValidarCPF(string cpf) {
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11) {
                throw new Exception("Cpf inválido!");
            }

            int mult = 0;
            for (int i = 0; i <= cpf.Length - 3; i++) {
                mult += Convert.ToInt32(cpf[i].ToString()) * (10 - i);
            }

            int resto = mult % 11;
            if (resto < 2 && Convert.ToInt32(cpf[9].ToString()) != 0) {
                throw new Exception("CPF inválido!");
            } else if (resto >= 2 && 11 - resto != Convert.ToInt32(cpf[9].ToString())) {
                throw new Exception("CPF inválido!");
            }

            mult = 0;
            for (int i = 0; i <= cpf.Length - 2; i++) {
                mult += Convert.ToInt32(cpf[i].ToString()) * (11 - i);
            }

            resto = mult % 11;
            if (resto < 2 && Convert.ToInt32(cpf[10].ToString()) != 0) {
                throw new Exception("CPF inválido!");
            } else if (resto >= 2 && 11 - resto != Convert.ToInt32(cpf[10].ToString())) {
                throw new Exception("CPF inválido!");
            }
            return cpf;
        }
    }
}
