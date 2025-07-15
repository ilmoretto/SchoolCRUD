using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackCRUD.DAO;
using BackCRUD.Mapeamento;
using System.Globalization;

namespace FrontCRUD
{
    public partial class frmCadastro : Form
    {
        private AlunoDAO _alunoDAO;
        private Aluno _alunoAtual;
        private ResponsavelAlunoDAO _responsavelDAO;
        public frmCadastro() {
            InitializeComponent();
            txtNomeAluno.Select();
            dtpDataNascAluno.Format = DateTimePickerFormat.Custom;
            dtpDataNascAluno.CustomFormat = "dd/MM/yyyy";

            _alunoDAO = new AlunoDAO();
            _responsavelDAO = new ResponsavelAlunoDAO();

            this.Text = "Cadastrar Novo Aluno";
            if (txtId != null) {
                txtId.Enabled = false;
                txtId.Text = "Gerado Automaticamente";
            }
            CarregarCB();
        }
        public frmCadastro(Aluno alunoParaEditar) : this() {
            _alunoAtual = alunoParaEditar;
            this.Text = "Editar Aluno";
            EditCampos();
        }
        private void CarregarCB() {
            try {
                List<ResponsavelAluno> responsaveis = _responsavelDAO.BuscarTodos();

                
                responsaveis.Insert(0, new ResponsavelAluno { IdResp = 0, NomeResp = "Selecione um Responsável" }); // IdResp 0 para indicar "nenhum"

                cmbResponsavel.DataSource = responsaveis; // Define a lista como fonte de dados
                cmbResponsavel.DisplayMember = "NomeResp"; 
                cmbResponsavel.ValueMember = "IdResp";     

                cmbResponsavel.SelectedIndex = 0; 
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao carregar responsáveis: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbResponsavel.DataSource = null; 
            }
        }

        private void EditCampos() {
            if (_alunoAtual != null) {
                txtId.Text = _alunoAtual.IdAluno.ToString();
                
                txtNomeAluno.Select(); // seleciona o campo ao iniciar o form
                txtNomeAluno.Text = _alunoAtual.NomeAlu;
                txtCpfAluno.Text = _alunoAtual.CpfAluno;
                dtpDataNascAluno.Value = _alunoAtual.DataNascAlu.ToDateTime(TimeOnly.MinValue);
                txtTelefoneAluno.Text = _alunoAtual.TelefoneAlu;
                txtRgAluno.Text = _alunoAtual.RgAlu;
                txtEmailAluno.Text = _alunoAtual.EmailAlu;

                if (_alunoAtual.Fk_id_responsavel.HasValue && _alunoAtual.Fk_id_responsavel.Value > 0) {
                    cmbResponsavel.SelectedValue = _alunoAtual.Fk_id_responsavel.Value;
                } else {
                    cmbResponsavel.SelectedIndex = 0;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrWhiteSpace(txtNomeAluno.Text) || string.IsNullOrWhiteSpace(txtCpfAluno.Text)) {
                    MessageBox.Show("Nome e CPF são campos obrigatórios.", "Validação", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateOnly dataNascAluno = DateOnly.FromDateTime(dtpDataNascAluno.Value);

                int? idResponsavel = null;
                if (cmbResponsavel.SelectedValue != null) {
                    int selectedId = (int)cmbResponsavel.SelectedValue;
                    if (selectedId > 0) // Se o ID é maior que 0 (não é o item "Selecione...")
                    {
                        idResponsavel = selectedId;
                    }
                }

                if (_alunoAtual != null) {
                    _alunoAtual.NomeAlu = txtNomeAluno.Text;
                    _alunoAtual.CpfAluno = txtCpfAluno.Text;
                    _alunoAtual.DataNascAlu = dataNascAluno;
                    _alunoAtual.TelefoneAlu = txtTelefoneAluno.Text;
                    _alunoAtual.RgAlu = txtRgAluno.Text;
                    _alunoAtual.EmailAlu = txtEmailAluno.Text;
                    _alunoAtual.Fk_id_responsavel = idResponsavel;

                    _alunoDAO.Alterar(_alunoAtual);
                    MessageBox.Show("Aluno atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                } else {
                    Aluno novoAluno = new Aluno {
                        NomeAlu = txtNomeAluno.Text,
                        CpfAluno = txtCpfAluno.Text,
                        DataNascAlu = dataNascAluno,
                        TelefoneAlu = txtTelefoneAluno.Text,
                        RgAlu = txtRgAluno.Text,
                        EmailAlu = txtEmailAluno.Text,
                        Fk_id_responsavel = idResponsavel
                    };
                    _alunoDAO.Cadastrar(novoAluno);
                    MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show($"Ocorreu um erro ao salvar/atualizar o aluno: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmCadastro_Load(object sender, EventArgs e) {

        }
    }
}