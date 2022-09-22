namespace Assignment2;

public class Queries
{
    
    public static IEnumerable<string> getWizardWithConstrainEx(WizardCollection wizards) {
        var harryCharacters = wizards.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name);
        return harryCharacters;
    }

    public static IEnumerable<string> getWizardWithConstrain(WizardCollection wizards) {
        var harryCharacters = 
            from w in wizards
            where w.Creator.Contains("Rowling")
            select w.Name;
        return harryCharacters;
    }
    public static int? GetFirstSithYearEx(WizardCollection wizards) {
        var result = wizards.Where(w => w.Name.Contains("Darth"));
        return result.Min(w => w.Year);
    }

    public static int? GetFirstSithYear(WizardCollection wizards) {
        var result = 
            from w in wizards
            where w.Name.Contains("Darth")
            select w.Year;
        return result.Min();
    }
    
    public static IEnumerable<(string name, int? year)> GetHarryPotterCharactersEx(WizardCollection wizards) {
        return wizards.Where(w => w.Medium.Contains("Harry Potter")).Select(w => (w.Name, w.Year)).Distinct();
    } 

    public static IEnumerable<(string name, int? year)> GetHarryPotterCharacters(WizardCollection wizards) {
        var result = 
            from w in wizards
            where w.Medium.Contains("Harry Potter")
            select (w.Name, w.Year);
        return result;
        
    }
    public static IEnumerable<string> GetReversedOrderedListEX(WizardCollection wizards) {
        var orderedList = wizards.OrderByDescending(w => w.Name);
        var result = orderedList.GroupBy(w => w.Creator).Reverse();
        return result.SelectMany(group => group).Select(w => w.Name).Distinct();
    }

    public static IEnumerable<string> GetReversedOrderedList(WizardCollection wizards) {
        var result = 
            from w in wizards
            orderby w.Name descending
            group w.Name by w.Creator;
        return result.Reverse().SelectMany(group => group).Distinct();;
    }
}
