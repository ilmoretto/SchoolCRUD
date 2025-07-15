using BackCRUD.Interface;
using BackCRUD.Mapeamento;
using BackCRUD.Utilitarios;
using BackCRUD.Visualizacao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BackCRUD.DAO
{
    public class AlunoDAO : ICRUD<Aluno>
    {
        public void Cadastrar(Aluno aluno) { // cadastro de novos alunos 
            try {
                string dataNasc = aluno.DataNascAlu.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO alunos(nome_alu, cpf_alu, dataNasc_alu, email_alu, rg_alu, telefone_alu, fk_id_responsavel) " +
                    "VALUES(@nome_alu, @cpf_alu, @dataNasc_alu, @email_alu, @rg_alu, @telefone_alu, @fk_id_responsavel)";
                MySqlCommand cmd = new MySqlCommand(sql, ConexaoBD.Conectar());

                cmd.Parameters.AddWithValue("@nome_alu", aluno.NomeAlu);
                cmd.Parameters.AddWithValue("@cpf_alu", aluno.CpfAluno);
                cmd.Parameters.AddWithValue("@dataNasc_alu", dataNasc);
                cmd.Parameters.AddWithValue("@email_alu", aluno.EmailAlu);
                cmd.Parameters.AddWithValue("@rg_alu", aluno.RgAlu);
                cmd.Parameters.AddWithValue("@telefone_alu", aluno.TelefoneAlu);
                cmd.Parameters.AddWithValue("@fk_id_responsavel", aluno.Fk_id_responsavel);

                cmd.ExecuteNonQuery();

            } catch (Exception ex) {

                throw new Exception("Erro ao cadastrar aluno: " + ex.Message);
            } finally {
                ConexaoBD.Desconectar();
            }
        }// fim de cadastrar
        public void Alterar(Aluno aluno) { // alterando um aluno existente
            try {
                string dataNasc = aluno.DataNascAlu.ToString("yyyy-MM-dd");
                string sql = "UPDATE alunos SET nome_alu = @nome_alu, cpf_alu = @cpf_alu, dataNasc_alu = @dataNasc_alu," +
                    "email_alu = @email_alu, rg_alu = @rg_alu, telefone_alu = @telefone_alu, fk_id_responsavel = @fk_id_responsavel" +
                    " WHERE id_aluno = @id_aluno";

                MySqlCommand cmd = new MySqlCommand(sql, ConexaoBD.Conectar());

                cmd.Parameters.AddWithValue("@nome_alu", aluno.NomeAlu);
                cmd.Parameters.AddWithValue("@cpf_alu", aluno.CpfAluno);
                cmd.Parameters.AddWithValue("@dataNasc_alu", dataNasc);
                cmd.Parameters.AddWithValue("@email_alu", aluno.EmailAlu);
                cmd.Parameters.AddWithValue("@rg_alu", aluno.RgAlu);
                cmd.Parameters.AddWithValue("@telefone_alu", aluno.TelefoneAlu);
                cmd.Parameters.AddWithValue("@fk_id_responsavel", aluno.Fk_id_responsavel);
                cmd.Parameters.AddWithValue("@id_aluno", aluno.IdAluno);

                cmd.ExecuteNonQuery();
            } catch (Exception ex) {

                throw new Exception("Erro ao alterar aluno: " + ex.Message);
            } finally {

                ConexaoBD.Desconectar();
            }
        }// fim de alterar
        public List<AlunoDTO> BuscarTodos() {
            List<AlunoDTO> lista = new List<AlunoDTO>();
            try {


                string sql = @"SELECT a.id_aluno, a.nome_alu, a.cpf_alu, a.dataNasc_alu,
                          a.email_alu, a.rg_alu, a.telefone_alu,
                          r.nome_resp AS nome_responsavel
                   FROM alunos AS a
                   LEFT JOIN responsavel_aluno AS r ON r.id_responsavel = a.fk_id_responsavel ORDER BY nome_alu";

                using var cmd = new MySqlCommand(sql, ConexaoBD.Conectar());
                using var dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    var dto = new AlunoDTO {
                        IdAluno = dr.GetInt32("id_aluno"),
                        NomeAlu = dr.GetString("nome_alu"),
                        CpfAluno = dr.IsDBNull(dr.GetOrdinal("cpf_alu")) ? "" : dr.GetString("cpf_alu"),
                        TelefoneAlu = dr.IsDBNull(dr.GetOrdinal("telefone_alu")) ? "" : dr.GetString("telefone_alu"),
                        EmailAlu = dr.IsDBNull(dr.GetOrdinal("email_alu")) ? "" : dr.GetString("email_alu"),
                        RgAlu = dr.IsDBNull(dr.GetOrdinal("rg_alu")) ? "" : dr.GetString("rg_alu"),
                        NomeResponsavel = dr.IsDBNull(dr.GetOrdinal("nome_responsavel")) ? "" : dr.GetString("nome_responsavel")
                    };

                    if (!dr.IsDBNull(dr.GetOrdinal("dataNasc_alu")))
                        dto.DataNascAlu = DateOnly.FromDateTime(dr.GetDateTime("dataNasc_alu"));

                    lista.Add(dto);
                }
                return lista;

            } catch (Exception ex) {
                throw new Exception("Erro ao buscar todos dos alunos: " + ex.Message);
            } finally {
                ConexaoBD.Desconectar();
            }
        }// fim de buscar todos



        public Aluno BuscarPorId(int id) {
            Aluno aluno = null;
            try {
                string sql = "SELECT id_aluno, nome_alu, cpf_alu, dataNasc_alu, email_alu, rg_alu, telefone_alu, fk_id_responsavel FROM alunos WHERE id_aluno = @id_aluno";
                using (MySqlCommand comando = new MySqlCommand(sql, ConexaoBD.Conectar())) {
                    comando.Parameters.AddWithValue("@id_aluno", id);

                    using (MySqlDataReader dr = comando.ExecuteReader()) {
                        if (dr.Read()) {
                            aluno = new Aluno();
                            aluno.IdAluno = dr.GetInt32("id_aluno");
                            aluno.NomeAlu = dr.GetString("nome_alu");
                            aluno.TelefoneAlu = dr.GetString("telefone_alu");
                            aluno.RgAlu = dr.GetString("rg_alu");
                            aluno.EmailAlu = dr.GetString("email_alu");


                            if (!dr.IsDBNull(dr.GetOrdinal("dataNasc_alu"))) {
                                aluno.DataNascAlu = DateOnly.FromDateTime(dr.GetDateTime("dataNasc_alu"));
                            }
                            if (!dr.IsDBNull(dr.GetOrdinal("fk_id_responsavel"))) {
                                aluno.Fk_id_responsavel = dr.GetInt32("fk_id_responsavel");
                            }
                            if (!dr.IsDBNull(dr.GetOrdinal("cpf_alu"))) {
                                aluno.CpfAluno = dr.GetString("cpf_alu");
                            }
                        }
                    }
                }
                return aluno;
            } catch (Exception ex) {
                throw new Exception($"Erro ao buscar aluno por ID: {ex.Message}", ex);
            } finally {
                ConexaoBD.Desconectar();
            }
        }
        public List<AlunoDTO> BuscarNome(string nomeBusca) {
            List<AlunoDTO> lista = new List<AlunoDTO>();
            try {
                string sql = @"SELECT a.id_aluno, a.nome_alu, a.cpf_alu, a.dataNasc_alu, a.email_alu, a.rg_alu,
                              a.telefone_alu, r.nome_resp AS nome_responsavel
                       FROM alunos AS a
                       LEFT JOIN responsavel_aluno AS r ON r.id_responsavel = a.fk_id_responsavel
                       WHERE a.nome_alu LIKE @nomeBusca
                       ORDER BY a.nome_alu";

                using var cmd = new MySqlCommand(sql, ConexaoBD.Conectar());
                cmd.Parameters.AddWithValue("@nomeBusca", $"%{nomeBusca}%");

                using var dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    var dto = new AlunoDTO {
                        IdAluno = dr.GetInt32("id_aluno"),
                        NomeAlu = dr.GetString("nome_alu"),
                        CpfAluno = dr.IsDBNull(dr.GetOrdinal("cpf_alu")) ? "" : dr.GetString("cpf_alu"),
                        TelefoneAlu = dr.IsDBNull(dr.GetOrdinal("telefone_alu")) ? "" : dr.GetString("telefone_alu"),
                        EmailAlu = dr.IsDBNull(dr.GetOrdinal("email_alu")) ? "" : dr.GetString("email_alu"),
                        RgAlu = dr.IsDBNull(dr.GetOrdinal("rg_alu")) ? "" : dr.GetString("rg_alu"),
                        NomeResponsavel = dr.IsDBNull(dr.GetOrdinal("nome_responsavel")) ? "" : dr.GetString("nome_responsavel")
                    };

                    if (!dr.IsDBNull(dr.GetOrdinal("dataNasc_alu")))
                        dto.DataNascAlu = DateOnly.FromDateTime(dr.GetDateTime("dataNasc_alu"));

                    lista.Add(dto);
                }

                return lista;

            } catch (Exception ex) {
                throw new Exception("Erro ao buscar alunos pelo nome com responsável: " + ex.Message, ex);
            } finally {
                ConexaoBD.Desconectar();
            }
        }


        // deletar
        public void Deletar(int id_aluno) {
            try {
                string sql = "DELETE FROM alunos WHERE id_aluno = @id_aluno";
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBD.Conectar());
                comando.Parameters.AddWithValue("@id_aluno", id_aluno);
                comando.ExecuteNonQuery();
            } catch (Exception ex) {
                throw new Exception("Erro ao deletar aluno: " + ex.Message, ex);
            } finally {
                ConexaoBD.Desconectar();
            }
        }
    }
}
