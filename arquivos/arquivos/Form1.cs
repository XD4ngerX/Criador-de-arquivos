using System.Text;

namespace arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            var FolderDialog = new FolderBrowserDialog();
            DialogResult result = FolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                String folderPath = FolderDialog.SelectedPath;
                if (folderPath != null || folderPath != "")
                {
                    txtCaminho.Text = folderPath;
                    txtCaminho.Focus();
                }
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja continuar?", "Confirmação", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK&&txtNomePasta.Text != null&&txtNomeArquivos.Text!=null&&txtQuantidade.Text!=null)
            {
                String nome = txtNomeArquivos.Text;
                String nomePasta = txtNomePasta.Text;
                String novoCaminho = Path.Combine(txtCaminho.Text, nomePasta);
                int count = int.Parse(txtQuantidade.Text);
                Directory.CreateDirectory(novoCaminho);

                for(int i = 0; i < count; i++)
                {
                    String nomenovo = $"{nome} ({i.ToString()}).txt";
                    using (FileStream fs = File.Create(Path.Combine(novoCaminho,nomenovo)))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("");
                    }
                }
            }
        }
    }
}
