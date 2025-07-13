using ServicosHeranca;

class Program
{
    public static void Main(string[] args)
    {

        var productService = new ProductService();
        
        productService.AddProductPromotional(new ProductPromotional("Camisa",27.50m, 0.10m));
        productService.AddProductPromotional(new ProductPromotional("Cinto",18.50m, 0.10m));
        productService.AddProductPromotional(new ProductPromotional("Camisa",200.00m, 0.10m));

        var products = productService.GetAllProductPromotional();
        foreach (var product in products)
        {
           Console.WriteLine(product.DisplayInformation()); 
        }

        var studentService = new StudentService();
        
        studentService.AddStudent(new Student("Leadro", 22, 489849));
        studentService.AddStudent(new Student("Roberto", 18, 48989849));
        studentService.AddStudent(new Student("Alessandra", 18, 11189849));
        
        var alunos = studentService.GetAllStudent();
        
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno.DisplayInformation());
        }
    }
}