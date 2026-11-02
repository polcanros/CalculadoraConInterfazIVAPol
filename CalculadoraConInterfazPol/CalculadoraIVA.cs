public class CalculadoraIVA
{
    public double baseImponible;
    public double porcentajeIVA;

    public double CalcularCuota()
    {
        return baseImponible * (porcentajeIVA / 100);
    }

    public double CalcularTotal()
    {
        return baseImponible + CalcularCuota();
    }
}