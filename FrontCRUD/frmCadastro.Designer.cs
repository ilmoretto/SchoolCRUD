namespace FrontCRUD
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            txtRgAluno = new TextBox();
            txtEmailAluno = new TextBox();
            txtTelefoneAluno = new TextBox();
            txtCpfAluno = new TextBox();
            txtNomeAluno = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpDataNascAluno = new DateTimePicker();
            label8 = new Label();
            cmbResponsavel = new ComboBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleRight;
            btnSalvar.Location = new Point(379, 349);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 34);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(97, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 34);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(16, 87);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(205, 23);
            txtId.TabIndex = 4;
            // 
            // txtRgAluno
            // 
            txtRgAluno.Location = new Point(183, 213);
            txtRgAluno.Name = "txtRgAluno";
            txtRgAluno.Size = new Size(84, 23);
            txtRgAluno.TabIndex = 5;
            // 
            // txtEmailAluno
            // 
            txtEmailAluno.Location = new Point(293, 213);
            txtEmailAluno.Name = "txtEmailAluno";
            txtEmailAluno.Size = new Size(174, 23);
            txtEmailAluno.TabIndex = 6;
            // 
            // txtTelefoneAluno
            // 
            txtTelefoneAluno.Location = new Point(482, 213);
            txtTelefoneAluno.Name = "txtTelefoneAluno";
            txtTelefoneAluno.Size = new Size(92, 23);
            txtTelefoneAluno.TabIndex = 7;
            // 
            // txtCpfAluno
            // 
            txtCpfAluno.Location = new Point(16, 213);
            txtCpfAluno.Name = "txtCpfAluno";
            txtCpfAluno.Size = new Size(140, 23);
            txtCpfAluno.TabIndex = 8;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(16, 137);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(292, 23);
            txtNomeAluno.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 63);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 13;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 113);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 13;
            label2.Text = "Nome completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(332, 113);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 13;
            label3.Text = "Data de nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(293, 189);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 13;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 189);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 13;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(183, 189);
            label6.Name = "label6";
            label6.Size = new Size(35, 21);
            label6.TabIndex = 13;
            label6.Text = "RG:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(482, 189);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 13;
            label7.Text = "Telefone:";
            // 
            // dtpDataNascAluno
            // 
            dtpDataNascAluno.Location = new Point(332, 137);
            dtpDataNascAluno.Name = "dtpDataNascAluno";
            dtpDataNascAluno.Size = new Size(172, 23);
            dtpDataNascAluno.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(338, 63);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 16;
            label8.Text = "Responsável:";
            // 
            // cmbResponsavel
            // 
            cmbResponsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResponsavel.FormattingEnabled = true;
            cmbResponsavel.Location = new Point(332, 87);
            cmbResponsavel.Name = "cmbResponsavel";
            cmbResponsavel.Size = new Size(196, 23);
            cmbResponsavel.TabIndex = 17;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 471);
            Controls.Add(cmbResponsavel);
            Controls.Add(label8);
            Controls.Add(dtpDataNascAluno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtId);
            Controls.Add(txtRgAluno);
            Controls.Add(txtEmailAluno);
            Controls.Add(txtTelefoneAluno);
            Controls.Add(txtCpfAluno);
            Controls.Add(txtNomeAluno);
            Name = "frmCadastro";
            Text = "frmCad";
            Load += frmCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtId;
        private TextBox txtRgAluno;
        private TextBox txtEmailAluno;
        private TextBox txtTelefoneAluno;
        private TextBox txtCpfAluno;
        private TextBox txtNomeAluno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpDataNascAluno;
        private Label label8;
        private ComboBox cmbResponsavel;
    }
}