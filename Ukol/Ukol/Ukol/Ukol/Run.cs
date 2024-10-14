
namespace Ukol;

internal class Run
{
	public void Cycle()
	{
		//Vytvoření objektu osoba
		InjuredPerson injuredPerson = new InjuredPerson();
		// Vytvoření objektu hlavní obrazovky
		Menu menu = new Menu();

		// Hlavní cyklus 
		char action = '0';
		while (action != '4')
		{
			menu.ViewMenu1();
			menu.ViewMenu2();
			action = Console.ReadKey().KeyChar;
			Console.WriteLine();
			switch (action)
			{
				case '1':
					injuredPerson.PersonAdd(); break;
				case '2':
					injuredPerson.ViewAllPerson(); break;
				case '3':
					injuredPerson.ViewPerson(); break;
				case '4':
					Console.WriteLine("Aplikace se ukončuje.");
					break;
				default:
					Console.WriteLine("Neplatná volba");
					break;
			}
			Console.ReadKey();
		}
	}
}
