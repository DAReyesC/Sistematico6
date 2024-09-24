namespace SistematicoIV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            comboBoxCategoria = new ComboBox();
            btnAgregarProducto = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            listBoxProductos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 29);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ScrollBar;
            txtNombre.Location = new Point(129, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 27);
            txtNombre.TabIndex = 2;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.BackColor = SystemColors.InactiveCaption;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(129, 258);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(184, 28);
            comboBoxCategoria.TabIndex = 4;
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregarProducto.Location = new Point(129, 337);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(94, 29);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar...";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(45, 89);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(45, 146);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 7;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(45, 202);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(45, 261);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 9;
            label5.Text = "Categoria:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.ScrollBar;
            txtPrecio.Location = new Point(129, 146);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(184, 27);
            txtPrecio.TabIndex = 10;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.ScrollBar;
            txtCantidad.Location = new Point(129, 202);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(184, 27);
            txtCantidad.TabIndex = 11;
            // 
            // listBoxProductos
            // 
            listBoxProductos.BackColor = SystemColors.GradientInactiveCaption;
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.Location = new Point(45, 404);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(298, 204);
            listBoxProductos.TabIndex = 12;
            listBoxProductos.SelectedIndexChanged += listBoxProductos_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 645);
            Controls.Add(listBoxProductos);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAgregarProducto);
            Controls.Add(comboBoxCategoria);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private ComboBox comboBoxCategoria;
        private Button btnAgregarProducto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private ListBox listBoxProductos;
    }
}
