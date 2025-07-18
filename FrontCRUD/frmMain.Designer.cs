﻿namespace FrontCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            btnBuscar = new Button();
            btnAlterar = new Button();
            btnCadastrar = new Button();
            txtBuscarNom = new TextBox();
            dgvAlunos = new DataGridView();
            btnDeletar = new Button();
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
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.Location = new Point(265, 36);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 29);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            btnBuscar.MouseLeave += btnBuscar_MouseLeave;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.WhiteSmoke;
            btnAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleRight;
            btnAlterar.Location = new Point(339, 407);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(118, 34);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click_1;
            btnAlterar.MouseEnter += btnAlterar_MouseEnter;
            btnAlterar.MouseLeave += btnAlterar_MouseLeave;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.WhiteSmoke;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleRight;
            btnCadastrar.Location = new Point(75, 407);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 34);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Novo";
            btnCadastrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            btnCadastrar.MouseEnter += btnCadastrar_MouseEnter;
            btnCadastrar.MouseLeave += btnCadastrar_MouseLeave;
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
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.WhiteSmoke;
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Image = (Image)resources.GetObject("btnDeletar.Image");
            btnDeletar.ImageAlign = ContentAlignment.MiddleRight;
            btnDeletar.Location = new Point(562, 407);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(118, 34);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar";
            btnDeletar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click_1;
            btnDeletar.MouseEnter += btnDeletar_MouseEnter;
            btnDeletar.MouseLeave += btnDeletar_MouseLeave;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDeletar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtBuscarNom);
            Controls.Add(dgvAlunos);
            Name = "frmMain";
            Text = "Alunos";
            Load += frmMain_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscar;
        private Button btnAlterar;
        private Button btnCadastrar;
        private TextBox txtBuscarNom;
        private DataGridView dgvAlunos;
        private Button btnDeletar;
    }
}
