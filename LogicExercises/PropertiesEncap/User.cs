// https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-properties

namespace PropertiesEncap;

public class User
{
    private string _password;


    public User(string password)
    {
        Password = password;
    }
    
    public string Password
    {
        get => _password;
        set => _password = value != null && value.Length >= 6 ?
            throw new InvalidOperationException("Senha fraca ou inválida!") : value;

    } 
}