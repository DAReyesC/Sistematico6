public enum Categoria
{
    Electronica,
    Ropa,
    Alimentos,
    Hogar,
    Otros
}

public partial class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public Categoria CategoriaProducto { get; set; }

    public bool EstaDisponible()
    {
        return Cantidad > 0;
    }

    public string EstadoStock()
    {
        return EstaDisponible() ? "Disponible" : "Agotado";
    }
}