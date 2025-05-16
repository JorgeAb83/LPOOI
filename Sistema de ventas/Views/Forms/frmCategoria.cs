using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace Views.Forms
{
    public partial class frmCategoria : Form
    {
        private CategoriaController categoriaController = new CategoriaController();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categoriaController.ListarCategorias("");
        }
    }
}
