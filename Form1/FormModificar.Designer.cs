namespace Form1
{
    partial class FormModificar
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
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAcepar = new System.Windows.Forms.Button();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelModificarArt = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DisplayMember = "Descripcion";
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(104, 215);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(214, 21);
            this.comboBoxCategoria.TabIndex = 33;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancelar.Location = new System.Drawing.Point(204, 333);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(131, 38);
            this.buttonCancelar.TabIndex = 32;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAcepar
            // 
            this.buttonAcepar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAcepar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAcepar.Location = new System.Drawing.Point(10, 333);
            this.buttonAcepar.Name = "buttonAcepar";
            this.buttonAcepar.Size = new System.Drawing.Size(131, 38);
            this.buttonAcepar.TabIndex = 31;
            this.buttonAcepar.Text = "Aceptar";
            this.buttonAcepar.UseVisualStyleBackColor = false;
            this.buttonAcepar.Click += new System.EventHandler(this.buttonAcepar_Click);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DisplayMember = "Descripcion";
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(104, 177);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(214, 21);
            this.comboBoxMarca.TabIndex = 30;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(104, 252);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(214, 20);
            this.textBoxURL.TabIndex = 28;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(104, 144);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(214, 20);
            this.textBoxDescripcion.TabIndex = 27;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(104, 108);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(214, 20);
            this.textBoxNombre.TabIndex = 26;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(104, 70);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(214, 20);
            this.textBoxCod.TabIndex = 25;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelURL.Location = new System.Drawing.Point(4, 251);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(94, 18);
            this.labelURL.TabIndex = 24;
            this.labelURL.Text = "URL Imagen:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrecio.Location = new System.Drawing.Point(43, 290);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(55, 18);
            this.labelPrecio.TabIndex = 23;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCategoria.Location = new System.Drawing.Point(22, 218);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(76, 18);
            this.labelCategoria.TabIndex = 22;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMarca.Location = new System.Drawing.Point(43, 180);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(58, 18);
            this.labelMarca.TabIndex = 21;
            this.labelMarca.Text = "Marca: ";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelDescripcion.Location = new System.Drawing.Point(7, 145);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(91, 18);
            this.LabelDescripcion.TabIndex = 20;
            this.LabelDescripcion.Text = "Descripción:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombre.Location = new System.Drawing.Point(28, 108);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(70, 18);
            this.labelNombre.TabIndex = 19;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCodigo.Location = new System.Drawing.Point(34, 70);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(64, 18);
            this.labelCodigo.TabIndex = 18;
            this.labelCodigo.Text = "Codigo: ";
            // 
            // labelModificarArt
            // 
            this.labelModificarArt.AutoSize = true;
            this.labelModificarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelModificarArt.Location = new System.Drawing.Point(40, 9);
            this.labelModificarArt.Name = "labelModificarArt";
            this.labelModificarArt.Size = new System.Drawing.Size(282, 37);
            this.labelModificarArt.TabIndex = 17;
            this.labelModificarArt.Text = "Modificar Artículo";
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(105, 288);
            this.numPrecio.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(213, 20);
            this.numPrecio.TabIndex = 34;
            this.numPrecio.ThousandsSeparator = true;
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(349, 381);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.labelModificarArt);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAcepar);
            this.Controls.Add(this.comboBoxMarca);
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
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "FormModificar";
            this.Text = "FormModificar";
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAcepar;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelModificarArt;
        private System.Windows.Forms.NumericUpDown numPrecio;
    }
}