namespace sistema_escola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtTelefone = new MaskedTextBox();
            txtNascimento = new MaskedTextBox();
            dgvAlunos = new DataGridView();
            btnLimpar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnListar = new Button();
            btnCadastrar = new Button();
            label4 = new Label();
            txtCurso = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtNascimento);
            groupBox1.Controls.Add(dgvAlunos);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnListar);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCurso);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 3);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(547, 478);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(200, 60);
            txtTelefone.Margin = new Padding(2);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 23);
            txtTelefone.TabIndex = 15;
            // 
            // txtNascimento
            // 
            txtNascimento.Location = new Point(200, 137);
            txtNascimento.Margin = new Padding(2);
            txtNascimento.Mask = "00/00/0000";
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(64, 23);
            txtNascimento.TabIndex = 14;
            // 
            // dgvAlunos
            // 
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(6, 216);
            dgvAlunos.Margin = new Padding(2);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.RowHeadersWidth = 62;
            dgvAlunos.Size = new Size(537, 252);
            dgvAlunos.TabIndex = 13;
            dgvAlunos.CellContentClick += dgvAlunos_CellContentClick;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(415, 169);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(71, 31);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(332, 169);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(71, 31);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(239, 169);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(71, 31);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(150, 169);
            btnListar.Margin = new Padding(2);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(71, 31);
            btnListar.TabIndex = 9;
            btnListar.Text = "listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(66, 169);
            btnCadastrar.Margin = new Padding(2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(71, 31);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 137);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "Nascimento:";
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(200, 97);
            txtCurso.Margin = new Padding(2);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(194, 23);
            txtCurso.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(200, 27);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(194, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 482);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtCurso;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnCadastrar;
        private DataGridView dgvAlunos;
        private Button btnLimpar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnListar;
        private MaskedTextBox txtNascimento;
        private MaskedTextBox txtTelefone;
    }
}
