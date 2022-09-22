namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void GetFirstSithYear_returns_1977()
    {
        // Arrange
        var wizards = WizardCollection.Create();

        // Assert
        Assert.Equal(1977, Queries.GetFirstSithYear(wizards));

    }
}
