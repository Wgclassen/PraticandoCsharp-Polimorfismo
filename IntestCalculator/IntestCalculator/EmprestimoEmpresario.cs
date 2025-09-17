namespace IntestCalculator;
internal class EmprestimoEmpresario : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * 0.025m * meses);
    }
}
