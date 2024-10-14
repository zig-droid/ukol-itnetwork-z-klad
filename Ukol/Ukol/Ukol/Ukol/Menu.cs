
namespace Ukol;

class Menu
{
    /// <summary>
    /// inicializace třídy hlavního menu
    /// </summary>
    public Menu() { }
    /// <summary>
    /// Zobrazení názvu pojišťovny na hlavní obrazovce
    /// </summary>
    public void ViewMenu1()
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("\tEvidence pojištěných");
        Console.WriteLine("---------------------------------------\n");
    }
    /// <summary>
    /// Jednotlivé položky hlavní nabídky, pro přidání a zobrazení pojištěných osob
    /// </summary>
    enum MenuItem
    {
        None = 0,
        AddPerson = 1,
        ViewAllPerson = 2,
        ViewPerson = 3,
        CloseApp = 4,
    }
    /// <summary>
    /// Zobrazení položek MenuItem
    /// </summary>
    /// <param name="menuItem"></param>
    /// <param name="itemName"></param>
    private void ViewMenuItem(MenuItem menuItem, string itemName)
    {
        Console.WriteLine($"{(int)menuItem} - {itemName}");
    }
    /// <summary>
    /// Pro výpis na hlavní obrazovce
    /// </summary>
    public void ViewMenu2()
    {
        Console.WriteLine("Vyberte si akci: \n");
        ViewMenuItem(MenuItem.AddPerson, "Přidat nového pojištěného");
        ViewMenuItem(MenuItem.ViewAllPerson, "Vypsat všechny pojištěné");
        ViewMenuItem(MenuItem.ViewPerson, "Vyhledat pojištěného");
        ViewMenuItem(MenuItem.CloseApp, "Konec");
    }

}
