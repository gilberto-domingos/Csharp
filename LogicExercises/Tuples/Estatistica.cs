namespace Tuples;

internal class Estatistica
{
    public (double media, int quantidade) CalcularEstatisticaVendas(List<double> vendas)
    {
        double soma = 0;
        foreach (double venda in vendas)
        {
            soma += venda;
        }

        double media = soma / vendas.Count;
        int quantidade = vendas.Count;
        
        return (media, quantidade);
    }
}