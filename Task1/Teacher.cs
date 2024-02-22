public class Teacher
{
    string _fullName;
    string _subject;
    int _experience;

     public Teacher()
    {
        
    }

    public Teacher(string name, string subject)
    {
        _fullName=name;
        _subject = subject;
    }

    public Teacher(string name, string subject, int experience)
    {
        _fullName = name;
        _subject = subject;
        _experience = experience;
    }
    public void Teach()
    {
        System.Console.WriteLine($"{_fullName} is teaching {_subject}");
    }

    public void SetExperience(int years)
    {
        _experience = years;
    }
    
    public int GetExperience()
    {
        return _experience;
    }

   
}