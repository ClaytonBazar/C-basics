using System.Collections;

namespace GestaoEstudantes
  
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList estudantes = new ArrayList();
        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void imprimirEst()
        {
            
            foreach (Estudante estudante in estudantes)
            {
                string[] dados = new string[]
                {
                    estudante.getCodigo() + "", estudante.getNome() +"",estudante.getNota1() +"",estudante.getNota2()+"", estudante.getMedia()+""
                };
                ListViewItem lstv = new ListViewItem(dados);
                lstvEstudante.Items.Add(lstv);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();

            long codigo = Int32.Parse(txtCodigo.Text);
            String nome = txtNome.Text;
            double nota1 = Double.Parse(txtNota1.Text);
            double nota2 = Double.Parse(txtNota2.Text);
            long numEstudante = Int32.Parse(txtNumEstudante.Text);

            Estudante estudante1 = new Estudante(codigo, nome, numEstudante, nota1, nota2);
            
            estudantes.Add(estudante1);

            txtCodigo.Text = " ";
            txtNome.Text = " ";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNumEstudante.Text = "";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
         
          
            
                imprimirEst();

              

            
        }
    }
}
