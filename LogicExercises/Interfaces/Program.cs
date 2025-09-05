
using System.Transactions;

public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
}


public interface ICredicardPayment
{
    void ProcessPayment(decimal amount);
    bool ValidateCard(string cardNumber);
    string GetPaymentStatus(int transactionId);
}

//----------------------//---------------------------------
public class CredicardPayment : ICredicardPayment
{
    private List<Transaction> _transactions = new List<Transaction>();
    private int transactionCounter = 0;
    
    public void ProcessPayment(decimal amount)
    {
        transactionCounter++;
        string status = amount <= 5000 ? "Aprovado" : "Reprovado";

        var transaction = new Transaction
        {
           Id = transactionCounter,
           Amount = amount,
           Status = status
        };

        _transactions.Add(transaction);
        
        Console.WriteLine($"Transaction #{transaction.Id} processed. Amount: {amount:C}. Status: {status}");
    }

    public bool ValidateCard(string cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
            throw new ArgumentException("O numero do cartão é obrigatório");

        if (cardNumber.Length != 16)
            throw new ArgumentException("Cartão não é valido");

        foreach (char c in cardNumber)
        {
            if (!char.IsDigit(c))
                return false;
        }
        
        Console.WriteLine($"Card {cardNumber} é valido");
        return true;
    }

    public string GetPaymentStatus(int transactionId)
    {
        var transaction = _transactions.Find(t => t.Id == transactionId);

        if (transaction != null)
        {
            Console.WriteLine($"Transaction #{transaction.Id} status:{transaction.Status}");
            return transaction.Status;
        }
        
        Console.WriteLine($"Transaction #{transactionId} not found.");
        return "NotFound";
    }
}

class  Program
{
    static void Main(string[] args)
    {
        var payment = new CredicardPayment();
        
        if (payment.ValidateCard("1234567890123456"))
        {
            payment.ProcessPayment(2000);  
            payment.ProcessPayment(6000);  

            payment.GetPaymentStatus(1);   
            payment.GetPaymentStatus(2);   
            payment.GetPaymentStatus(3);   
        }
    }
}