public class Actor
{
    string _fullName;
    int _age;
    string _gender;
    List<string> _moviesPlayed = new List<string>();

    public void AddMovie(string movieTitle)
    {
        _moviesPlayed.Add(movieTitle);
    }
    public List<string> GetMoviesPlayed()
    {
        return _moviesPlayed;
    }
    public void SetAge(int age)
    {
        _age = age;
    }
    public int GetAge()
    {
        return _age;
    }
    public void SetGender(string gender)
    {
        _gender = gender;
    }
    public string GetGender()
    {
        return _gender;
    }

    public Actor(string fullName, int age, string gender)
    {
        _fullName = fullName;
        _age = age;
        _gender = gender;
    }
     public string GetInfo()
    {
        return $"Actor's Name: {_fullName}\nAge: {_age}\nGender: {_gender}";
    }
    public string AboutMovie()
    {
        return $"Movies Played by  {_fullName}. : ";

    }

}