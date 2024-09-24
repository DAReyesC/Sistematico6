public static class MetodosExtension
{
    public static decimal CalcularImpuesto(this decimal precio, decimal tasa = 0.15m)
    {
        return precio * tasa;
    }

}