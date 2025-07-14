namespace FrontCRUD
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            btnDeletar = new Button();
            btnBuscar = new Button();
            btnAlterar = new Button();
            btnCadastrar = new Button();
            txtBuscarNom = new TextBox();
            dgvAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 10;
            label1.Text = "Encontrar aluno";
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(503, 403);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(100, 34);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(265, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 26);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(262, 403);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(100, 34);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click_1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(16, 403);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 34);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Novo";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // txtBuscarNom
            // 
            txtBuscarNom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarNom.Location = new Point(16, 36);
            txtBuscarNom.Name = "txtBuscarNom";
            txtBuscarNom.Size = new Size(243, 29);
            txtBuscarNom.TabIndex = 5;
            txtBuscarNom.Enter += txtBuscarNom_Enter_1;
            txtBuscarNom.Leave += txtBuscarNom_Leave_1;
            // 
            // dgvAlunos
            // 
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(16, 71);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.Size = new Size(769, 326);
            dgvAlunos.TabIndex = 4;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDeletar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtBuscarNom);
            Controls.Add(dgvAlunos);
            Name = "frmMain";
            Text = "Form1";
            Load += frmMain_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDeletar;
        private Button btnBuscar;
        private Button btnAlterar;
        private Button btnCadastrar;
        private TextBox txtBuscarNom;
        private DataGridView dgvAlunos;
    }
}
