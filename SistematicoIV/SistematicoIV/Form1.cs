namespace SistematicoIV
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            comboBoxCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private List<Producto> inventario = new List<Producto>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string precioTexto = txtPrecio.Text;
            string cantidadTexto = txtCantidad.Text;
            Categoria categoria = (Categoria)comboBoxCategoria.SelectedItem;

            if (!Validaciones.ValidarNombre(nombre))
            {
                MessageBox.Show("El nombre del producto es obligatorio.");
                return;
            }

            if (!decimal.TryParse(precioTexto, out decimal precio) || !int.TryParse(cantidadTexto, out int cantidad))
            {
                MessageBox.Show("El precio debe mayor a 0.");
                return;
            }

            if (!Validaciones.ValidarPrecioCantidad(precio, cantidad))
            {
                MessageBox.Show("la cantidad no puede ser negativa.");
                return;
            }

            decimal impuesto = precio.CalcularImpuesto();
            MessageBox.Show($"Impuesto aplicado: {impuesto}");


            // Validación de los campos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    !decimal.TryParse(txtPrecio.Text, out decimal Precio) || precio <= 0 ||
                    !int.TryParse(txtCantidad.Text, out int Cantidad) || cantidad < 0)
            {
                MessageBox.Show("Datos inválidos.");
                return;
            }


            Producto nuevoProducto = new Producto
            {
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad,
                CategoriaProducto = categoria
            };

            inventario.Add(nuevoProducto);
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            listBoxProductos.Items.Clear();
            foreach (var producto in inventario)
            {
                listBoxProductos.Items.Add($"{producto.Nombre} - ${producto.Precio} - {producto.CategoriaProducto} - {producto.EstadoStock()}");
            }



        }


        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Depa = comboBoxCategoria.SelectedItem.ToString();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
