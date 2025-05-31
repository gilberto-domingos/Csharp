Func<string, string> getDayType = day => day.ToLower() switch
{
    "sábado" or "domingo" => "Final de semana",
    "segunda" or "terça" or "quarta" or "quinta" or "sexta" => "Dia útil",
    _ => "Dia inválido"
};

Console.WriteLine(getDayType("Domingo"));

Func<int, string> getAgeCategory = idade => idade switch
{
    < 0 => "Idade inválida",
    < 12 => "Criança",
    < 18 => "Adolescente",
    < 60 => "Adulto",
    _ => "Idoso"
};


Console.WriteLine(getAgeCategory(30));

Func<double, string> getNotaConceito = nota => nota switch
{
    >= 9.0 => "A",
    >= 7.0 => "B",
    >= 5.0 => "C",
    >= 3.0 => "D",
    _ => "F"
};

Console.WriteLine(getNotaConceito(8.7));


Func<string, int, int, int> calcular = (op, a, b) => op switch
{
    "+" => a + b,
    "-" => a - b,
    "*" => a * b,
    "/" when b != 0 => a / b,
    _ => throw new InvalidOperationException("Operação inválida")
};

Console.WriteLine(calcular("*", 3, 4));


Func<char, string> getCharType = c => c switch
{
    >= 'a' and <= 'z' when "aeiou".Contains(c) => "Vogal",
    >= 'a' and <= 'z' => "Consoante",
    _ => "Não é letra minúscula"
};


Console.WriteLine(getCharType('r'));


Func<string, string> getAnimalBySound = som => som.ToLower() switch
{
    "miau" => "Gato",
    "auau" => "Cachorro",
    "piu" => "Pássaro",
    _ => "Desconhecido"
};

Console.WriteLine(getAnimalBySound("auau"));

Func<int, string> getOrderStatus = status => status switch
{
    0 => "Pendente",
    1 => "Aprovado",
    2 => "Enviado",
    3 => "Entregue",
    _ => "Status desconhecido"
};

Console.WriteLine(getOrderStatus(2));