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


class Program
{
    static void Main(string[] args)
    {
        double media = 0 , somaNotas = 0 , notaRecebida = -1;
        int quantidadeNotas = 0;


        while (quantidadeNotas != -1)
        {
            
            Console.WriteLine("Quantas notas você deseja digitar ? ou digite -1 para encerrar o programa");
              

            quantidadeNotas = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeNotas; i++)
            {
                while (notaRecebida < 0 || notaRecebida > 10)
                {
                    Console.WriteLine("Digite a nota");
                
                    try
                    {
                        notaRecebida = double.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException("Entrada inválida", e);
                        notaRecebida = -1;
                    }
                }
                somaNotas += notaRecebida;
                notaRecebida = -1;
            }

            media = somaNotas / quantidadeNotas;

            if (media < 4.5)
            {
                Console.WriteLine("Aluno está reprovado");
            }
            else if(media <= 7.0 )
            {
                Console.WriteLine("O aluno está em recuperação.");  
            }
            else
            {
                Console.WriteLine("O aluno foi aprovado.");
            }
               Console.WriteLine("Você deseja calcular a nota de um novo aluno ?");
               quantidadeNotas = int.Parse(Console.ReadLine());
        }
     }
}