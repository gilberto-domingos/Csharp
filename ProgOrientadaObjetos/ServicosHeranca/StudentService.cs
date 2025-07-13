namespace ServicosHeranca;

internal class StudentService
{
    private readonly List<Student> _students = new List<Student>();

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public List<Student> GetAllStudent()
    {
        return _students;
    }
}