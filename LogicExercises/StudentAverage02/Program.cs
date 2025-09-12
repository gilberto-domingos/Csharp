/*4- Um professor necessita de ajuda para realizar a média e situação final de
seus alunos. Para isso, crie um programa para ler uma quantidade de
    notas, que deve ser informada pelo usuário, de forma que, após lidas, seu
    programa deve exibir a média delas e a situação final do aluno em
    questão, sabendo que:
a. Situação Final
i. Reprovado – Quando a média do aluno for inferior à 4.50
ii. Recuperação – Quando a média do aluno for entre 4.50 e
7.0
iii. Aprovado – Quando a média do aluno for superior à 7.0
b. Não será admitido digitação de notas inferiores à 0 e superiores à
10
c. Seu programa, após ler as notas e mostrar o resultado de um
    aluno, deve permitir a digitação e processamento de um novo
    aluno, até que seja informado o valor -1
d. O professor poderá escolher calcular a média de pelo menos 3 e
    no máximo 5 notas
e. Caso o professor informe uma entrada inválida, deve ser permitido
uma nova digitação da mesma.*/

class AverageStudent
{
    public double Nota;
    public List<double> Notas = new List<double>();
    public void CalculateAverage()
    {
        while (true)
        {
            Console.WriteLine("Digite as notas ou -1 para encerrar o envio de notas");
           
            if (!double.TryParse(Console.ReadLine(), out Nota))
            {
                Console.WriteLine("Entrada inválida. Digite uma nota.");
                continue; 
            }
            
            if (Nota == -1)
            {
                if (Notas.Count < 3 || Notas.Count > 5)
                {
                    Console.WriteLine($"Número inválido de notas. Você digitou {Notas.Count}. É necessário digitar entre 3 e 5 notas.");
                    continue; 
                }
                
                Console.WriteLine("Encerrando a recepção de notas");
                Console.WriteLine($"Notas digitadas :");
                foreach (var n in Notas)
                {
                    Console.WriteLine($"{n}");
                }
                Console.WriteLine($"Numero de notas digitadas : {Notas.Count}");
                
                Console.WriteLine($"Soma das notas: {Notas.Sum():F1}");
                
               double finalAverage = Notas.Sum() / Notas.Count;
               
               Console.WriteLine($"A média final do aluno é {finalAverage:F1}");
               
               if (finalAverage < 4.5)
               {
                   Console.WriteLine("Situação final: Reprovado");
               }
               else if (finalAverage >= 4.5 && finalAverage <= 7.0)
               {
                   Console.WriteLine("Situação final: Recuperação");
               }
               else
               {
                   Console.WriteLine("Situação final: Aprovado");
               }
               
                break;
            }
            
            if (Nota < 0 || Nota > 10)
            {
                Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
                continue;
            }
            Notas.Add(Nota);
           
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
       var average = new AverageStudent();
       average.CalculateAverage();
    }
}