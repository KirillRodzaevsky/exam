using System;
class Program
{
    static void Main()
    {
        FIO f = new FIO("Салахов", "Кирилл", "Иванович");
        f.GetFIO();


    }
}

class FIO
{
    public string FirstName {  get; set; }
    public string LastName { get; set; }
    public string SurName { get; set; }
    
    public FIO(string Surname, string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.SurName = Surname;
    }

    public void GetFIO()
    {
        Console.WriteLine($"{SurName} {FirstName.Substring(0, 1)}. {LastName.Substring(0, 1)}.");
        Console.WriteLine();
    }
}