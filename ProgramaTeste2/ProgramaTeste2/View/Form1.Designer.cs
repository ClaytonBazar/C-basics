namespace ProgramaTeste2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            tctNome = new TextBox();
            txtDiaTrabalhadores = new TextBox();
            txtSalarioDiario = new TextBox();
            btnGravar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            btnSair = new Button();
            lstvFuncionario = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 61);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 125);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 185);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Dias Trabalhados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 252);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Salario Diario";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(112, 58);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(168, 27);
            txtCodigo.TabIndex = 4;
            // 
            // tctNome
            // 
            tctNome.Location = new Point(112, 127);
            tctNome.Name = "tctNome";
            tctNome.Size = new Size(168, 27);
            tctNome.TabIndex = 5;
            // 
            // txtDiaTrabalhadores
            // 
            txtDiaTrabalhadores.Location = new Point(155, 187);
            txtDiaTrabalhadores.Name = "txtDiaTrabalhadores";
            txtDiaTrabalhadores.Size = new Size(125, 27);
            txtDiaTrabalhadores.TabIndex = 6;
            // 
            // txtSalarioDiario
            // 
            txtSalarioDiario.Location = new Point(132, 249);
            txtSalarioDiario.Name = "txtSalarioDiario";
            txtSalarioDiario.Size = new Size(148, 27);
            txtSalarioDiario.TabIndex = 7;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(533, 61);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 29);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(533, 125);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(533, 185);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(533, 252);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // lstvFuncionario
            // 
            lstvFuncionario.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstvFuncionario.GridLines = true;
            lstvFuncionario.Location = new Point(12, 306);
            lstvFuncionario.Name = "lstvFuncionario";
            lstvFuncionario.Size = new Size(637, 157);
            lstvFuncionario.TabIndex = 12;
            lstvFuncionario.UseCompatibleStateImageBehavior = false;
            lstvFuncionario.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nome";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dias Trabalhados";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Salario Diario";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Salario Mensal";
            columnHeader5.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 475);
            Controls.Add(lstvFuncionario);
            Controls.Add(btnSair);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            Controls.Add(txtSalarioDiario);
            Controls.Add(txtDiaTrabalhadores);
            Controls.Add(tctNome);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigo;
        private TextBox tctNome;
        private TextBox txtDiaTrabalhadores;
        private TextBox txtSalarioDiario;
        private Button btnGravar;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnSair;
        private ListView lstvFuncionario;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
