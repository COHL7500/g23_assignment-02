namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void GetFirstSithYear_returns_1977()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        var result = Queries.GetFirstSithYear(wizards);

        // Assert
        result.Should().Be(1977);
    }
    
    [Fact]
    public void GetFirstSithYearEx_returns_1977()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        var result = Queries.GetFirstSithYearEx(wizards);

        // Assert
        result.Should().Be(1977);
    }

    [Fact]
    public void getWizardWithConstrain_returns_all_rowling_wizards()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        string[] expected =
        {
            "Voldemort", 
            "Harry Potter", 
            "Dumbledore",
        };
        var result = Queries.getWizardWithConstrain(wizards);
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void getWizardWithConstrainEx_returns_all_rowling_wizards()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        string[] expected =
        {
            "Voldemort", 
            "Harry Potter", 
            "Dumbledore",
        };
        var result = Queries.getWizardWithConstrainEx(wizards);
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void getHarryPotterCharacters_returns_all_entries_with_HarryPotter_medium()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        (string, int?)[] expected =
        {
            ("Voldemort", 1997),
            ("Harry Potter", 1997),
            ("Dumbledore", 1997)
        };
        
        var result = Queries.GetHarryPotterCharacters(wizards);
        
        // Assert
        Assert.Equal(expected.AsEnumerable(), result);
    }
    
    [Fact]
    public void getHarryPotterCharactersEx_returns_all_entries_with_HarryPotter_medium()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        (string, int?)[] expected =
        {
            ("Voldemort", 1997),
            ("Harry Potter", 1997),
            ("Dumbledore", 1997)
        };
        
        var result = Queries.GetHarryPotterCharactersEx(wizards);
        
        // Assert
        Assert.Equal(expected.AsEnumerable(), result);
    }
    
    [Fact]
    public void getReversedOrderedList_returns_reverse_order_by_creator_list()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        string[] expected =
        {
            "Darth Vader", 
            "Darth Sidious", 
            "Darth Maul", 
            "Sauron", 
            "Saruman",
            "Morgoth",
            "Gandalf",
            "Voldemort",
            "Harry Potter",
            "Dumbledore"
        };

        var result = Queries.GetReversedOrderedList(wizards);
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void getReversedOrderedListEx_returns_reverse_order_by_creator_list()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        string[] expected =
        {
            "Darth Vader", 
            "Darth Sidious", 
            "Darth Maul", 
            "Sauron", 
            "Saruman",
            "Morgoth",
            "Gandalf",
            "Voldemort",
            "Harry Potter",
            "Dumbledore"
        };

        var result = Queries.GetReversedOrderedListEX(wizards);
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    
}
