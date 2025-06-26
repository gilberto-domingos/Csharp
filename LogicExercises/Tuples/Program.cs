using Tuples;

//chamada do método e uso da Tupla:
List<double>vendas = new List<double>{10.5,20.75,15.20,25.80};

Estatistica estatisicaVendas = new Estatistica();
var resultado = estatisicaVendas.CalcularEstatisticaVendas(vendas);

Console.WriteLine($"Média : {resultado.media}, Quantidade: {resultado.quantidade}");

// outra prática 

var pt = (X: 1, Y: 2);
var slope = (double)pt.Y / (double)pt.X;

Console.WriteLine($"Uma reta de origem ao ponto {pt}, tem um inclinação de {slope}");
pt.X = pt.X + 5;
Console.WriteLine($"O ponto agora está em {pt}");
var pt2 = pt with {Y = 10};
Console.WriteLine($"O ponto 'pt2' é {pt2}");

var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);