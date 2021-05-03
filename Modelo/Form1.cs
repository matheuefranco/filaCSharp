using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public partial class Form1 : Form
    {
        Queue<String> fila = new Queue<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {

        }

        void mostra()
        {
            listFila.Items.Clear();
            foreach(String s in fila)
            {
                listFila.Items.Add(s);
            }
        }
        //---------------
        void limpa()
        {
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fila.Enqueue(txtNome.Text);
            mostra();
            limpa();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (fila.Count > 0)
            {
                String s = fila.Dequeue();
                MessageBox.Show(s + " foi atendido");
            }
            mostra();

        }
    }
}
