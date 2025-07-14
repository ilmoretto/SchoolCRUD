using BackCRUD.Mapeamento;
using BackCRUD.Utilitarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCRUD.DAO
{
    public class ResponsavelAlunoDAO
    {
        public List<ResponsavelAluno> BuscarTodos() {
            List<ResponsavelAluno> respCadastrados = new List<ResponsavelAluno>();
            try {
                string sql = "SELECT * FROM Responsavel_aluno ORDER BY nome_resp";
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBD.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader()) {
                    while (dr.Read()) {
                        ResponsavelAluno r = new ResponsavelAluno();
                        if (!dr.IsDBNull(dr.GetOrdinal("id_responsavel")))
                            r.IdResp = dr.GetInt32("id_responsavel");
                        if (!dr.IsDBNull(dr.GetOrdinal("nome_resp")))
                            r.NomeResp = dr.GetString("nome_resp");
                        if (!dr.IsDBNull(dr.GetOrdinal("cpf_resp")))
                            r.CpfResp = dr.GetString("cpf_resp");
                        if (!dr.IsDBNull(dr.GetOrdinal("rg_resp")))
                            r.RgResp = dr.GetString("rg_resp");
                        if (!dr.IsDBNull(dr.GetOrdinal("dataNasc_resp")))
                            r.DataNascResp = DateOnly.FromDateTime(dr.GetDateTime("dataNasc_resp"));
                        if (!dr.IsDBNull(dr.GetOrdinal("email_resp")))
                            r.EmailResp = dr.GetString("email_resp");
                        if (!dr.IsDBNull(dr.GetOrdinal("telefone_resp")))
                            r.TelefoneResp = dr.GetString("telefone_resp");
                        if (!dr.IsDBNull(dr.GetOrdinal("parentesco_resp")))
                            r.ParentescoResp = dr.GetString("parentesco_resp");

                        respCadastrados.Add(r);
                    }
                }
                return respCadastrados;
            } catch (Exception ex) {
                throw new Exception("Erro ao buscar todos os responsáveis: " + ex.Message);
            } finally {
                ConexaoBD.Desconectar();
            }
        }
    }
}
