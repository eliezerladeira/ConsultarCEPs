using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarCEPs
{
    public partial class frmConsultarCeps : Form
    {
        public frmConsultarCeps()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCep.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}