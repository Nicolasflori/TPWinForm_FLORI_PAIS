namespace Form1
{
    partial class FormAgregarArt
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
            this.labelAgregarArt = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.buttonAcepar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelAgregarArt
            // 
            this.labelAgregarArt.AutoSize = true;
            this.labelAgregarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAgregarArt.Location = new System.Drawing.Point(44, 9);
            this.labelAgregarArt.Name = "labelAgregarArt";
            this.labelAgregarArt.Size = new System.Drawing.Size(265, 37);
            this.labelAgregarArt.TabIndex = 0;
            this.labelAgregarArt.Text = "Agregar Artículo";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCodigo.Location = new System.Drawing.Point(38, 70);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(64, 18);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Codigo: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombre.Location = new System.Drawing.Point(32, 108);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(70, 18);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre: ";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelDescripcion.Location = new System.Drawing.Point(11, 145);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(91, 18);
            this.LabelDescripcion.TabIndex = 3;
            this.LabelDescripcion.Text = "Descripción:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMarca.Location = new System.Drawing.Point(47, 180);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(58, 18);
            this.labelMarca.TabIndex = 4;
            this.labelMarca.Text = "Marca: ";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCategoria.Location = new System.Drawing.Point(26, 218);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(76, 18);
            this.labelCategoria.TabIndex = 5;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrecio.Location = new System.Drawing.Point(47, 290);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(55, 18);
            this.labelPrecio.TabIndex = 6;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelURL.Location = new System.Drawing.Point(8, 251);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(94, 18);
            this.labelURL.TabIndex = 7;
            this.labelURL.Text = "URL Imagen:";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(108, 70);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(214, 20);
            this.textBoxCod.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(108, 108);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(214, 20);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(108, 144);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(214, 20);
            this.textBoxDescripcion.TabIndex = 10;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(108, 252);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(214, 20);
            this.textBoxURL.TabIndex = 11;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(108, 291);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(214, 20);
            this.textBoxPrecio.TabIndex = 12;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DisplayMember = "Descripcion";
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(108, 177);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(214, 21);
            this.comboBoxMarca.TabIndex = 13;
            // 
            // buttonAcepar
            // 
            this.buttonAcepar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAcepar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAcepar.Location = new System.Drawing.Point(14, 333);
            this.buttonAcepar.Name = "buttonAcepar";
            this.buttonAcepar.Size = new System.Drawing.Size(131, 38);
            this.buttonAcepar.TabIndex = 14;
            this.buttonAcepar.Text = "Aceptar";
            this.buttonAcepar.UseVisualStyleBackColor = false;
            this.buttonAcepar.Click += new System.EventHandler(this.buttonAcepar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancelar.Location = new System.Drawing.Point(208, 333);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(131, 38);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(108, 215);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(214, 21);
            this.comboBoxCategoria.TabIndex = 16;
            // 
            // FormAgregarArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(351, 383);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAcepar);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelAgregarArt);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "FormAgregarArt";
            this.Text = "FormAgregarArt";
            this.Load += new System.EventHandler(this.FormAgregarArt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgregarArt;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Button buttonAcepar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
    }
}