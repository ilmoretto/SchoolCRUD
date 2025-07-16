using BackCRUD.Visualizacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCRUD.Interface
{
    internal interface ICRUD<T>
    {
        public void Cadastrar(T t) { }
        public void Alterar(T t) { }
        public void Deletar(T t) { }
      
    }
}
