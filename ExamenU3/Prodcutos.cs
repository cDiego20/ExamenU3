using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data;
using System.Windows.Forms;

namespace ExamenU3
{
    public partial class Prodcutos : Form
    {
        Datos dt = new Datos();

        public Prodcutos()
        {
            InitializeComponent();
        }

        private void Prodcutos_Load(object sender, EventArgs e)
        {
            dgvProductos.ContextMenuStrip = contextMenuStrip1;
            Actualizar();
        }

        private void Actualizar()
        {
            DataSet ds = dt.comandoDS(
                "select IdProducto, Nombre, Descripcion, Categoria, Precio, Cantidad, [FechaRegistro] from Producto"
            );
            if (ds != null && ds.Tables.Count > 0)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ProductoUnico insertar = new ProductoUnico();
            insertar.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvProductos.CurrentRow.Index;
            ProductoUnico productoUnico = new ProductoUnico(
                Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value),
                dgvProductos.Rows[i].Cells[1].Value.ToString(),
                dgvProductos.Rows[i].Cells[2].Value.ToString(),
                dgvProductos.Rows[i].Cells[3].Value.ToString(),
                Convert.ToDecimal(dgvProductos.Rows[i].Cells[4].Value),
                Convert.ToInt32(dgvProductos.Rows[i].Cells[5].Value),
                Convert.ToDateTime(dgvProductos.Rows[i].Cells[6].Value)
            );
            productoUnico.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvProductos.CurrentRow.Index;
            DialogResult f = MessageBox.Show(
                "¿Eliminar Producto: " + dgvProductos.Rows[i].Cells[1].Value + "?",
                "Eliminar", MessageBoxButtons.YesNo
            );

            if (f == DialogResult.Yes)
            {
                if (dt.EjecutarComando("DELETE FROM Producto WHERE IdProducto = " + dgvProductos.Rows[i].Cells[0].Value))
                    MessageBox.Show("Producto Eliminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Actualizar();
            }
        }
        private void Prodcutos_Activated(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = dt.comandoDS("select IdProducto, Nombre, Descripcion, Categoria, Precio, Cantidad, [FechaRegistro] " +
        "from Producto where Nombre LIKE '" + txtBusqueda.Text + "%'"
);
            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoUnico insertar = new ProductoUnico();
            insertar.Show();
        }
    }
}


