namespace ExamenU3
{
    partial class ProductoUnico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoUnico));
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtCategoria = new TextBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label7 = new Label();
            txtNombre = new TextBox();
            label8 = new Label();
            dtpFechaRegistro = new DateTimePicker();
            btnImprimir = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(42, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 238);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "FechaRegistro";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(189, 176);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(132, 27);
            txtCantidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 153);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(14, 284);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(132, 27);
            txtPrecio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 261);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "Precio";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(14, 221);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(132, 27);
            txtCategoria.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 198);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 10;
            label6.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 158);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(132, 27);
            txtDescripcion.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 135);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 12;
            label7.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 27);
            txtNombre.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 73);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 14;
            label8.Text = "Nombre";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(184, 261);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(215, 27);
            dtpFechaRegistro.TabIndex = 16;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(305, 337);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 17;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(197, 303);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(305, 302);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ProductoUnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 378);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnImprimir);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(txtDescripcion);
            Controls.Add(label7);
            Controls.Add(txtCategoria);
            Controls.Add(label6);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductoUnico";
            Text = "ProductoUnico";
            Load += ProductoUnico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtCantidad;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtCategoria;
        private Label label6;
        private TextBox txtDescripcion;
        private Label label7;
        private TextBox txtNombre;
        private Label label8;
        private DateTimePicker dtpFechaRegistro;
        private Button btnImprimir;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}