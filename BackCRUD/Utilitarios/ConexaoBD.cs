using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BackCRUD.Utilitarios
{
    internal class ConexaoBD
    {
        static MySqlConnection conexao;
        public static MySqlConnection Conectar() {
			try {
                string strconexao = "server=localhost;uid=root;pwd=241976;port=3306;database=EscolaSonata"; //acessando o bd
                conexao = new MySqlConnection(strconexao); //instancia da conexao
                conexao.Open();
                return conexao;

            } catch (Exception ex) {

                throw new Exception("Erro ao conectar ao banco: " + ex.Message);
			}
        }
        public static void Desconectar() {
            try {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open) {
                    conexao.Close();
                }
                 

            } catch (Exception ex) {

                throw new Exception("Erro ao desconectaro do banco: " + ex.Message);
            }
        }
    }
}
