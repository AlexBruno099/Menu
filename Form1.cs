using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESSTE
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
            
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.ShowDialog();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Receber receber = new Receber();
            receber.ShowDialog();
        }
    }
}
