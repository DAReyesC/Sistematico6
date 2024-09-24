public static class Validaciones
{
    public static bool ValidarNombre(string nombre)
    {
        return !string.IsNullOrEmpty(nombre);
    }

    public static bool ValidarPrecioCantidad(decimal precio, int cantidad)
    {
        return precio > 0 && cantidad >= 0;
    }
}