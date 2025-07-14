using BackCRUD.Mapeamento;
using BackCRUD.Utilitarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BackCRUD.DAO
{
    public class AlunoDAO
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
                    "email_alu = @email_alu, rg_alu = @rg_alu, telefone_alu = @telefone_alu, fk_id_responsavel = @fk_id_responsavel";

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

                throw new Exception("Erro ao alterar aluno: " + ex.Message);
            } finally {

                ConexaoBD.Desconectar();
            }
        }// fim de alterar
        public List<Aluno> BuscarTodos() {
            List<Aluno> alunosCadastrados = new List<Aluno>();
            try {
                string sql = "SELECT * FROM alunos ORDER BY nome_alu";
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBD.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader()) {
                    while (dr.Read()) {
                        Aluno a = new Aluno();
                        a.IdAluno = dr.GetInt32("id_aluno");
                        a.NomeAlu = dr.GetString("nome_alu");
                        a.TelefoneAlu = dr.GetString("telefone_alu");
                        a.RgAlu = dr.GetString("rg_alu");

                        if (!dr.IsDBNull(dr.GetOrdinal("dataNasc_alu"))) {
                            a.DataNascAlu = DateOnly.FromDateTime(dr.GetDateTime("dataNasc_alu"));
                        }
                        if (!dr.IsDBNull(dr.GetOrdinal("fk_id_responsavel"))) {
                            a.Fk_id_responsavel = dr.GetInt32("fk_id_responsavel");
                        }
                        if (!dr.IsDBNull(dr.GetOrdinal("cpf_alu"))) {
                            a.CpfAluno = dr.GetString("cpf_alu");
                        }


                        alunosCadastrados.Add(a);
                    }
                }
                return alunosCadastrados;

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
                            Aluno a = new Aluno();
                            a.IdAluno = dr.GetInt32("id_aluno");
                            a.NomeAlu = dr.GetString("nome_alu");
                            a.TelefoneAlu = dr.GetString("telefone_alu");
                            a.RgAlu = dr.GetString("rg_alu");

                            if (!dr.IsDBNull(dr.GetOrdinal("dataNasc_alu"))) {
                                a.DataNascAlu = DateOnly.FromDateTime(dr.GetDateTime("dataNasc_alu"));
                            }
                            if (!dr.IsDBNull(dr.GetOrdinal("fk_id_responsavel"))) {
                                a.Fk_id_responsavel = dr.GetInt32("fk_id_responsavel");
                            }
                            if (!dr.IsDBNull(dr.GetOrdinal("cpf_alu"))) {
                                a.CpfAluno = dr.GetString("cpf_alu");
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
        public List<Aluno> BuscarPorNome(string nomeBusca) {
            List<Aluno> alunos = new List<Aluno>();
            try {
                string sql = "SELECT id_aluno, nome_alu, cpf_alu, dataNasc_alu, email_alu, rg_alu," +
                    " telefone_alu, fk_id_responsavel FROM alunos WHERE nome_alu LIKE @nomeBusca ORDER BY nome_alu";
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBD.Conectar());
                comando.Parameters.AddWithValue("@nomeBusca", $"%{nomeBusca}%");
                using (MySqlDataReader dr = comando.ExecuteReader()) {
                    while (dr.Read()) {
                        Aluno a = new Aluno();
                        a.IdAluno = dr.GetInt32("id_aluno");
                        a.NomeAlu = dr.GetString("nome_alu");
                        a.TelefoneAlu = dr.GetString("telefone_alu");
                        a.RgAlu = dr.GetString("rg_alu");

                        if (!dr.IsDBNull(dr.GetOrdinal("dataNasc_alu"))) {
                            a.DataNascAlu = DateOnly.FromDateTime(dr.GetDateTime("dataNasc_alu"));
                        }
                        if (!dr.IsDBNull(dr.GetOrdinal("fk_id_responsavel"))) {
                            a.Fk_id_responsavel = dr.GetInt32("fk_id_responsavel");
                        }
                        if (!dr.IsDBNull(dr.GetOrdinal("cpf_alu"))) {
                            a.CpfAluno = dr.GetString("cpf_alu");
                        }
                        alunos.Add(a);
                    }
                }
                return alunos;
            } catch (Exception ex) {
                throw new Exception("Erro ao buscar alunos pelo nome: " + ex.Message, ex);
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
