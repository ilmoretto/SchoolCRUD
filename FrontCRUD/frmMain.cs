using BackCRUD.DAO;
using BackCRUD.Mapeamento;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FrontCRUD;

public partial class frmMain : Form
{
    private AlunoDAO _alunoDAO;

    public frmMain() {
        InitializeComponent();
        _alunoDAO = new AlunoDAO();
        dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dgvAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAlunos.MultiSelect = false;
        dgvAlunos.ReadOnly = true;
        dgvAlunos.AllowUserToAddRows = false;

        CarregarDGV();
    }

    private void CarregarDGV(string nomeFiltro = "") {
        try {
            dgvAlunos.DataSource = null;
            List<Aluno> alunos;

            if (string.IsNullOrWhiteSpace(nomeFiltro)) {
                alunos = _alunoDAO.BuscarTodos();
            } else {
                alunos = _alunoDAO.BuscarNome(nomeFiltro);
            }
            dgvAlunos.DataSource = alunos;
            NomearColunas();

        } catch (Exception ex) {
            MessageBox.Show($"Erro ao carregar alunos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void NomearColunas() {
        dgvAlunos.Columns["IdAluno"].HeaderText = "ID";
        dgvAlunos.Columns["NomeAlu"].HeaderText = "Nome";
        dgvAlunos.Columns["CpfAluno"].HeaderText = "CPF";
        dgvAlunos.Columns["DataNascAlu"].HeaderText = "Data Nascimento";
        dgvAlunos.Columns["TelefoneAlu"].HeaderText = "Contato";
        dgvAlunos.Columns["RgAlu"].HeaderText = "RG";
        dgvAlunos.Columns["EmailAlu"].HeaderText = "Email";
        dgvAlunos.Columns["Fk_id_responsavel"].HeaderText = "ID Responsável";
        dgvAlunos.Columns["FkResponsavelAluno"].Visible = false;

    }

    private void frmMain_Load(object sender, EventArgs e) {
        txtBuscarNom.Text = "Insira o nome do Aluno...";
        txtBuscarNom.ForeColor = System.Drawing.Color.Gray;
    }

    private void btnCadastrar_Click_1(object sender, EventArgs e) {
        using (frmCadastro formCadastro = new frmCadastro()) {
            if (formCadastro.ShowDialog() == DialogResult.OK) {
                CarregarDGV();
            }
        }

    }

    private void btnAlterar_Click_1(object sender, EventArgs e) {
        if (dgvAlunos.SelectedRows.Count > 0) {
            int idAlunoSelecionado = Convert.ToInt32(dgvAlunos.SelectedRows[0].Cells["IdAluno"].Value);

            try {
                Aluno alunoParaEditar = _alunoDAO.BuscarPorId(idAlunoSelecionado);
                //MessageBox.Show($"ID selecionado: {idAlunoSelecionado}");

                if (alunoParaEditar != null) {
                    using (frmCadastro formEditar = new frmCadastro(alunoParaEditar)) {
                        if (formEditar.ShowDialog() == DialogResult.OK) {
                            CarregarDGV();
                        }
                    }
                } else {

                    MessageBox.Show("Não foi possível carregar os dados do aluno selecionado para edição.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao preparar edição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } else {
            MessageBox.Show("Selecione um aluno na lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnBuscar_Click_1(object sender, EventArgs e) {
        string termoBusca = txtBuscarNom.Text;
        string placeHolder = "Insira o nome do Aluno...";
        if (termoBusca == placeHolder) {
            termoBusca = "";
        }

        if (string.IsNullOrWhiteSpace(termoBusca)) {
            CarregarDGV();
        } else {
            CarregarDGV(termoBusca);
            if (dgvAlunos.Rows.Count == 0) {
                MessageBox.Show($"Nenhum aluno encontrado com o nome '{termoBusca}'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private void btnDeletar_Click_1(object sender, EventArgs e) {
        if (dgvAlunos.SelectedRows.Count > 0) {
            int idParaExcluir = Convert.ToInt32(dgvAlunos.SelectedRows[0].Cells["IdAluno"].Value);
            string nomeAluno = dgvAlunos.SelectedRows[0].Cells["NomeAlu"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Tem certeza que deseja excluir o aluno '{nomeAluno}' (ID: {idParaExcluir})?",
                                                   "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes) {
                try {
                    _alunoDAO.Deletar(idParaExcluir);
                    CarregarDGV();
                    MessageBox.Show("Aluno excluído com sucesso!", "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex) {
                    MessageBox.Show($"Erro ao excluir aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } else {
            MessageBox.Show("Selecione um aluno na lista para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void txtBuscarNom_Leave_1(object sender, EventArgs e) {
        if (string.IsNullOrWhiteSpace(txtBuscarNom.Text)) {
            txtBuscarNom.Text = "Insira o nome do Aluno...";
            txtBuscarNom.ForeColor = System.Drawing.Color.Gray;
        }

    }

    private void txtBuscarNom_Enter_1(object sender, EventArgs e) {
        if (txtBuscarNom.Text == "Insira o nome do Aluno...") {
            txtBuscarNom.Text = "";
            txtBuscarNom.ForeColor = System.Drawing.Color.Black;
        }
    }

    private void frmMain_Load_1(object sender, EventArgs e) {
        txtBuscarNom.Text = "Insira o nome do Aluno...";
        txtBuscarNom.ForeColor = System.Drawing.Color.Gray;

    }
}
