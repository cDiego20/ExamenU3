namespace ExamenU3
{
    partial class Prueba
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
            btnPrueba = new Button();
            SuspendLayout();
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(116, 30);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(94, 29);
            btnPrueba.TabIndex = 0;
            btnPrueba.Text = "Prueba";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // Prueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 87);
            Controls.Add(btnPrueba);
            Name = "Prueba";
            Text = "Prueba";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrueba;
    }
}