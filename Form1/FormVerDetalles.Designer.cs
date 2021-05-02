
namespace Form1
{
    partial class FormVerDetalles
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
            this.Detalles = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCódigo = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.PictureBoxDetalles = new System.Windows.Forms.PictureBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCódigo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // Detalles
            // 
            this.Detalles.AutoSize = true;
            this.Detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Detalles.Location = new System.Drawing.Point(12, 21);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(368, 42);
            this.Detalles.TabIndex = 0;
            this.Detalles.Text = "Detalles del Artículo";
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAtras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAtras.Location = new System.Drawing.Point(19, 391);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(131, 38);
            this.buttonAtras.TabIndex = 15;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombre.Location = new System.Drawing.Point(37, 89);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(70, 18);
            this.labelNombre.TabIndex = 16;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelCódigo
            // 
            this.labelCódigo.AutoSize = true;
            this.labelCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCódigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCódigo.Location = new System.Drawing.Point(45, 140);
            this.labelCódigo.Name = "labelCódigo";
            this.labelCódigo.Size = new System.Drawing.Size(60, 18);
            this.labelCódigo.TabIndex = 17;
            this.labelCódigo.Text = "Código:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDescripcion.Location = new System.Drawing.Point(14, 190);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(91, 18);
            this.labelDescripcion.TabIndex = 18;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMarca.Location = new System.Drawing.Point(51, 240);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(54, 18);
            this.labelMarca.TabIndex = 19;
            this.labelMarca.Text = "Marca:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCategoria.Location = new System.Drawing.Point(31, 290);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(76, 18);
            this.labelCategoria.TabIndex = 20;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrecio.Location = new System.Drawing.Point(50, 340);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(55, 18);
            this.labelPrecio.TabIndex = 21;
            this.labelPrecio.Text = "Precio:";
            // 
            // PictureBoxDetalles
            // 
            this.PictureBoxDetalles.Location = new System.Drawing.Point(479, 92);
            this.PictureBoxDetalles.Name = "PictureBoxDetalles";
            this.PictureBoxDetalles.Size = new System.Drawing.Size(295, 264);
            this.PictureBoxDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxDetalles.TabIndex = 22;
            this.PictureBoxDetalles.TabStop = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(113, 90);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(347, 20);
            this.textBoxNombre.TabIndex = 23;
            // 
            // textBoxCódigo
            // 
            this.textBoxCódigo.Location = new System.Drawing.Point(113, 140);
            this.textBoxCódigo.Name = "textBoxCódigo";
            this.textBoxCódigo.ReadOnly = true;
            this.textBoxCódigo.Size = new System.Drawing.Size(347, 20);
            this.textBoxCódigo.TabIndex = 24;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(113, 190);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ReadOnly = true;
            this.textBoxDescripcion.Size = new System.Drawing.Size(347, 20);
            this.textBoxDescripcion.TabIndex = 25;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(113, 240);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.ReadOnly = true;
            this.textBoxMarca.Size = new System.Drawing.Size(347, 20);
            this.textBoxMarca.TabIndex = 26;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(113, 290);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.ReadOnly = true;
            this.textBoxCategoria.Size = new System.Drawing.Size(347, 20);
            this.textBoxCategoria.TabIndex = 27;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(113, 340);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(347, 20);
            this.textBoxPrecio.TabIndex = 28;
            // 
            // FormVerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxCódigo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.PictureBoxDetalles);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelCódigo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.Detalles);
            this.Name = "FormVerDetalles";
            this.Text = "FormVerDetalles";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Detalles;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCódigo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.PictureBox PictureBoxDetalles;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCódigo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}