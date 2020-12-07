using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos
{
    public partial class lst_contato : Form
    {
        public lst_contato()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de Contatos 1.0 \n Desenvolvido por : Pedro ", "About");
        }

        private void contatosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contatosDBDataSet);

        }

        private void contatosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.contatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contatosDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contatosDBDataSet.Contatos' table. You can move, or remove it, as needed.
            this.contatosTableAdapter.Fill(this.contatosDBDataSet.Contatos);

        }

        private void contatosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clientCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
