using BL.ERP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.ERP
{
    public partial class FormProductosServicios : Form
    {
        ProductosServiciosBL _ProductosServicios;

        public FormProductosServicios()
        {
            InitializeComponent();

            _ProductosServicios = new ProductosServiciosBL();
            productosServiciosBL_ProductosServiciosBindingSource.DataSource = _ProductosServicios.ObtenerProductosServicios();
        }

        private void FormProductosServicios_Load(object sender, EventArgs e)
        {

        }

        private void productosServiciosBL_ProductosServiciosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
