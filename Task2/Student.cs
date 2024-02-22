public class Student
{
    string _fullName;
    int _age;
    int _grade;

    public void Study()
    {
        System.Console.WriteLine($"{_fullName} is studying.");
    }
    public void SetGrade(int newGrade)
    {
        _grade = newGrade;
    }
    public int GetGrade()
    {
        return _grade;
    }
    public Student()
    {

    }
    public Student(string fullName, int age)
    {
        _fullName = fullName;
        _age = age;
    }
    public Student(string fullName, int age, int grade)
    {
        _fullName = fullName;
        _age = age;
        _grade = grade;
    }
}