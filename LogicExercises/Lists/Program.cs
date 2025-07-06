using Lists.Service;

namespace Lists;

class Program
{
   public static void Main(string[] args)
   {
    // --------- Exercício 3 ------------
    
       TaskManager manager = new TaskManager();
       int option = 0;

       do
       {
           Console.WriteLine("\n--- MENU DE TAREFAS ---");
           Console.WriteLine("1 - Adicionar tarefa");
           Console.WriteLine("2 - Remover tarefa");
           Console.WriteLine("3 - Listar tarefas");
           Console.WriteLine("0 - Sair");
           Console.Write("Escolha uma opção: ");

           string? input = Console.ReadLine();
           
           if (!int.TryParse(input, out option))
               throw new FormatException("Entrada inválida. Digite um número inteiro!");
           
           bool validate = int.TryParse(input, out option);

           switch (option)
           {
               case 1 :
                   Console.WriteLine("Digite a descrição da tarefa!");
                   string description = Console.ReadLine();
                   manager.AddTask(description);
                   break;
               case 2 :
                   try
                   {
                     Console.WriteLine("Digite o número da tarefa a remover :");
                     string? indexInput = Console.ReadLine();
                     if (!int.TryParse(indexInput, out int index))
                         throw new FormatException("Número inválido.");
                     manager.RemoveTask(index);
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine($"Erro: {ex.Message}");
                   }
                   break;
               
               case 3:
                   try
                   {
                       manager.ListTasks();
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine($"Erro: {ex.Message}");
                   }
                   break;

               case 0:
                   Console.WriteLine("Saindo...");
                   break;

               default:
                   Console.WriteLine("Opção inválida.");
                   break;
           }
       } while (option != 0);

       // Exercício 1 -------------------------------- x ------------------
       List1 list1 = new List1();
       
       Console.WriteLine("Digite 5 números");
       
       for(int i = 0; i < 5; i++)
       {
           Console.WriteLine($"Número {i + 1}");
           string input = Console.ReadLine();
       
           if (!int.TryParse(input, out int number))
               throw new ArgumentException("Entrada inválida adicione um 'número'!");
           list1.Numbers.Add(number);
       }
       
       int result = list1.SumNumbers();
       Console.WriteLine($"A soma dos números é : {result}");

      // Exercício 2 --------------------------- x ------------------------------

       List2 list2 = new List2();
       
       Console.WriteLine("Digite nomes adicionar na lista, parar digite 'fim'");
       
       while (true)
       {
           Console.WriteLine("Digite nome :");
           string input2 = Console.ReadLine();
       
           if (string.IsNullOrWhiteSpace(input2) || int.TryParse(input2, out _))
               throw new ArgumentException("Entrada invalida digite um 'nome'");
           list2.Names.Add(input2);
           list2.checkName();
           break;
       }
   }
}


















