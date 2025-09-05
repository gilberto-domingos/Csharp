
/*2- Escreva um programa que leia dois valores inteiros e encontre todos os números pares entre eles.
// a. Considerar somente valores positivos
// b. O segundo número lido não pode ser menor ou igual ao primeiro
// c. Caso o usuário digite um valor inválido, deve ser permitido uma
// nova digitação.*/

class SolveProblem
{
    public int num1, num2;

     public void ReceiveValues()
     {

          while (true)
          {
               Console.WriteLine("Digite o primeiro número (positivo)");
               num1 = int.Parse(Console.ReadLine());

               if (num1 > 0) 
                    break;
               
              Console.WriteLine(" O número precisa ser positivo. Tente novamente.\n");
          }

          while (true)
          {
               Console.WriteLine("Digite o segundo número (maior que o primeiro e positivo):");
               num2 = int.Parse(Console.ReadLine());

               if (num2 > 0 && num2 > num1) 
                    break;
               
              Console.WriteLine("O número precisa ser maior que o primeiro e positivo. Tente novamente.\n");   
          }    
          
               
          Console.WriteLine($"Números pares entre {num1} e {num2}:");

          for (int i = num1; i <= num2; i++)
          {
               if(i % 2 == 0)
                    Console.WriteLine(i);
          }
          
          Console.WriteLine();
     }
}

class Program
{
     static void Main(string[] args)
     {
          var solveProblem = new SolveProblem();
          solveProblem.ReceiveValues();
     }
}