Func<int, string> checkAge = a => a >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine(checkAge(20));
Console.WriteLine(checkAge(15));

Func<int, string> checkEvenOdd = n => n % 2 == 0 ? "Par" : "Impar";
Console.WriteLine(checkEvenOdd(4));
Console.WriteLine(checkEvenOdd(7));

Func<double, string> checkFever = t => t >= 37.5 ? "Com febre" : "Sem febre";
Console.WriteLine(checkFever(41.5));
Console.WriteLine(checkFever(23.4));

Func<int, string> classifyAge = a =>
    a < 12 ? "Criança" :
    a < 18 ? "Adolescente" :
    a > 60 ? "Idoso" : "Adulto";

Console.WriteLine(classifyAge(11));
Console.WriteLine(classifyAge(17));
Console.WriteLine(classifyAge(40));
Console.WriteLine(classifyAge(80));

Func<string, string> validateName = n => n.Length >= 3 ? "Nome válido" : "Nome inválido";
Console.WriteLine(validateName("Ana"));
Console.WriteLine(validateName("Li"));

Func<decimal, string> checkTax = salary => salary > 2500 ? "Deve pagar imposto" : "Não deve pagar imposto";
Console.WriteLine(checkTax(3000));
Console.WriteLine(checkTax(1500));

Func<string, string> validatePassword = pwd => pwd.Length >= 8 ? "Senha forte" : "senha fraca";
Console.WriteLine(validatePassword("Sennha_234$%#**"));
Console.WriteLine(validatePassword("senha"));

Func<double, string> getGradeStatus = grade => grade >= 7.0 ? "Aprovado" :
    grade >= 5.0 ? "Recuperação" : "Reprovado";

Console.WriteLine(getGradeStatus(8.0));
Console.WriteLine(getGradeStatus(5.0));
Console.WriteLine(getGradeStatus(4.0));

Func<string, string> validateEmail = email => email.Contains("@") ? "Email válido" : "Email invalido";
Console.WriteLine(validateEmail("jrdomingosjr@gmail.com"));
Console.WriteLine(validateEmail("jrdomingosjr.gmail.com"));

Func<int, string> describeNumber = n => n > 0 ? "Positivo" :
    n < 0 ? "negativo" : "Zero";

Console.WriteLine(describeNumber(2));
Console.WriteLine(describeNumber(-3));
Console.WriteLine(describeNumber(0));