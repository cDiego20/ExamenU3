using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU3
{
    public partial class ProductoUnico : Form
    {
        int id = 0;
        bool bandera = false;

        public ProductoUnico() // Insertar
        {
            InitializeComponent();
            dtpFechaRegistro.Value = DateTime.Now;
            txtID.ReadOnly = true;
        }

        public ProductoUnico(int id, string nombre, string descripcion, string categoria, decimal precio, int cantidad, DateTime fechaRegistro) // Actualizar
        {
            InitializeComponent();
            this.id = id;
            txtID.Text = id.ToString();
            txtID.ReadOnly = true;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtCategoria.Text = categoria;
            txtPrecio.Text = precio.ToString("F2");
            txtCantidad.Text = cantidad.ToString();
            dtpFechaRegistro.Value = fechaRegistro;
            bandera = true;
        }

        private void ProductoUnico_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Datos dt = new Datos();
            string sql;
            if (bandera)
            {
                // Actualizar
                sql = "update Producto set " +
                      "Nombre = '" + txtNombre.Text + "', " +
                      "Descripcion = '" + txtDescripcion.Text + "', " +
                      "Categoria = '" + txtCategoria.Text + "', " +
                      "Precio = " + txtPrecio.Text.Replace(',', '.') + ", " +
                      "Cantidad = " + txtCantidad.Text + ", " +
                      "[FechaRegistro] = '" + dtpFechaRegistro.Value.ToString("yyyy-MM-dd") + "' " +
                      "where IdProducto = " + id;
                dt.EjecutarComando(sql);
                MessageBox.Show("Producto actualizado");
            }
            else
            {
                // Insertar
                sql = "insert into Producto (Nombre, Descripcion, Categoria, Precio, Cantidad, [FechaRegistro]) VALUES (" +
                      "'" + txtNombre.Text + "', " +
                      "'" + txtDescripcion.Text + "', " +
                      "'" + txtCategoria.Text + "', " +
                      txtPrecio.Text.Replace(',', '.') + ", " +
                      txtCantidad.Text + ", " +
                      "'" + dtpFechaRegistro.Value.ToString("yyyy-MM-dd") + "')";
                dt.EjecutarComando(sql);
                MessageBox.Show("Producto agregado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
