
namespace Ukol;

class InjuredPerson
{
	// inicializuji si proměnné
	string firstName;
	string lastName;
	int phoneNumber;
	int age;
	Question qestionName = new Question();
	TextError error = new TextError();
	/// <summary>
	/// kolekce kam se ukládají osoby
	/// </summary>
	private List<Person> persons = new List<Person>();
	/// <summary>
	/// metoda pro přidání osoby do kolekce
	/// </summary>
	public void PersonAdd()
	{
		qestionName.QuestionName();
		while (string.IsNullOrWhiteSpace(firstName = Console.ReadLine().Trim()) || firstName.Any(char.IsDigit))
			error.WriteMessage();

		qestionName.QuestionSurname();
		while (string.IsNullOrWhiteSpace(lastName = Console.ReadLine().Trim()) || lastName.Any(char.IsDigit))
			error.WriteMessage();

		qestionName.QuestionPhoneNumber();
		while (!int.TryParse(Console.ReadLine(), out phoneNumber))
			error.WriteMessage();

		qestionName.QuestionAge();
		while (!int.TryParse(Console.ReadLine(), out age))
			error.WriteMessage();

		persons.Add(new Person(firstName, lastName, phoneNumber, age));

		Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...\n");
	}
	/// <summary>
	/// metoda pro zobrazení všech pojištěných osob
	/// </summary>
	public void ViewAllPerson()
	{
		if (persons.Count == 0)
		{
			Console.WriteLine("Seznam je prázdný");
			Console.WriteLine("Pokračujte libovolnou klávesou...\n");
			return;
		}

		Console.WriteLine("Seznam pojištěných osob: ");
		for (int i = 0; i < persons.Count; i++)
		{
			var contact = persons[i];
			Console.WriteLine($"{i + 1,5} {contact.FirstName,10} {contact.LastName,10} {contact.Age,10} {contact.PhoneNumber,10}");
		}
		Console.WriteLine("Pokračujte libovolnou klávesou...\n");
	}
	/// <summary>
	/// metoda pro výpis konkrétní osoby
	/// </summary>
	public void ViewPerson()
	{
		qestionName.QuestionName();
		while (string.IsNullOrWhiteSpace(firstName = Console.ReadLine().Trim()) || firstName.Any(char.IsDigit))
			error.WriteMessage();

		qestionName.QuestionSurname();
		while (string.IsNullOrWhiteSpace(lastName = Console.ReadLine().Trim()) || lastName.Any(char.IsDigit))
			error.WriteMessage();

		var p = from person in persons
				where ((person.FirstName == firstName) && (person.LastName == lastName))
				select person;
		
		persons.ForEach(p => Console.WriteLine("\n" + p + "\n"));
  
		Console.WriteLine("Pokračujte libovolnou klávesou...\n");
	}
}
