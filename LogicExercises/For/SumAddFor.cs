    namespace For;

    public class SumAddFor
    {
        public int SumTenNumbers()
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i}° numero :");

                bool validate = int.TryParse(Console.ReadLine(), out int number);

                if (validate)
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, digite um numero inteiro!");
                }
            }
            return sum;
        }
    }