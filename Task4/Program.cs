var actor = new Actor("Yusuf Rahmon", 25, "Male");
actor.AddMovie("Iron Man");
actor.AddMovie("Shrek");
actor.AddMovie("Tom and Jerry");


System.Console.WriteLine(actor.GetInfo());

System.Console.WriteLine(actor.AboutMovie());
int i=1;
foreach (var movies in actor.GetMoviesPlayed())
{
    System.Console.WriteLine($"{i}. {movies}");
    i++;
}