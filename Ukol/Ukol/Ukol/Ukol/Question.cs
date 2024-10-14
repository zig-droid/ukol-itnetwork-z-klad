
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ukol;

internal class Question
{
    /// <summary>
    /// Metoda pro vyzvání uživatele pro zadání jména
    /// </summary>
    public void QuestionName() => Console.WriteLine("Zadejte jméno pojištěného: ");
        
    /// <summary>
    /// Metoda pro vyzvání uživatele pro zadání příjmení
    /// </summary>
    public void QuestionSurname() => Console.WriteLine("Zadejte příjmení: ");
       
    /// <summary>
    /// Metoda pro vyzvání uživatele pro zadání telefonního čísla
    /// </summary>
    public void QuestionPhoneNumber() => Console.WriteLine("Zadejte telefonní číslo: ");
    
    /// <summary>
    /// Metoda pro vyzvání uživatele pro zadání věku
    /// </summary>
    public void QuestionAge() => Console.WriteLine("Zadejte věk: ");
}
