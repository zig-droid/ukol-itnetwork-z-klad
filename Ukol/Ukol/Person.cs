
namespace Ukol;

class Person
{
    private string firstName;
    private string lastName;
    private int phoneNumber;
    private int age;

    public string FirstName { get => firstName; private set => firstName = value; } 
    public string LastName { get => lastName; private set => lastName = value; }
    public int PhoneNumber { get => phoneNumber; private set => phoneNumber = value; }
    public int Age { get => age; private set => age = value; }
    /// <summary>
    /// inicializace třídy a obsahu jména, příjmení, atd
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="telNumber"></param>
    /// <param name="age"></param>
    public Person(string firstName, string lastName, int telNumber, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = telNumber;
        Age = age;            
    }
    /// <summary>
    /// metoda pro výpis osob, vrací textový formát zprávy
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return ($"{FirstName, 5} {LastName, 10} {Age, 10} {PhoneNumber, 5}");
    }
}
