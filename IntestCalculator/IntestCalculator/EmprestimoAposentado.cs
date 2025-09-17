namespace IntestCalculator;
internal class EmprestimoAposentado : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * 0.015m * meses);
    }
}
