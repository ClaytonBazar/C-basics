namespace GestaoEstudantes
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
            label5 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNumEstudante = new TextBox();
            btnAdicionar = new Button();
            btnLimpar = new Button();
            lstvEstudante = new ListView();
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
            label1.Location = new Point(58, 48);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 116);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 48);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Nota 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 116);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Nota 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(515, 48);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 4;
            label5.Text = "Numero de Estudante";
            label5.Click += label5_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(58, 71);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(58, 139);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 6;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(240, 71);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(125, 27);
            txtNota1.TabIndex = 7;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(240, 139);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(125, 27);
            txtNota2.TabIndex = 8;
            // 
            // txtNumEstudante
            // 
            txtNumEstudante.Location = new Point(515, 71);
            txtNumEstudante.Name = "txtNumEstudante";
            txtNumEstudante.Size = new Size(125, 27);
            txtNumEstudante.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(515, 112);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(125, 29);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(515, 147);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(125, 29);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Listar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lstvEstudante
            // 
            lstvEstudante.BackColor = SystemColors.HighlightText;
            lstvEstudante.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstvEstudante.GridLines = true;
            lstvEstudante.Location = new Point(58, 216);
            lstvEstudante.Name = "lstvEstudante";
            lstvEstudante.Size = new Size(610, 290);
            lstvEstudante.TabIndex = 12;
            lstvEstudante.UseCompatibleStateImageBehavior = false;
            lstvEstudante.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nome";
            columnHeader2.Width = 295;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nota 1";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nota 2";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Media";
            columnHeader5.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(719, 518);
            Controls.Add(lstvEstudante);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNumEstudante);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
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
        private Label label5;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNumEstudante;
        private Button btnAdicionar;
        private Button btnLimpar;
        private ListView lstvEstudante;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
