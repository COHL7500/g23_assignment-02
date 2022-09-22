namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Test_URI_With_HTTPS_Returns_True()
    {
        string uri = "https://example.com";
        Assert.True(uri.isSecure());
    }

    [Fact]
    public void Test_URI_Without_HTTPS_Returns_True()
    {
        string uri = "http://example.com";
        Assert.False(uri.isSecure());
    }

    [Fact]
    public void Test_WordCount_Text_With_28_Words_Return_28()
    {
        string text = "RegExr9 was created by gskinner.com, and is proudly hosted by Media Temple. Edit the Expression & Text to see matches. Roll over matches or the expression for details.";
        Assert.Equal(28, text.WordCount());
    }
    
    [Fact]
    public void Test_WordCount_Text_With_8_Words_Return_8()
    {
        string text = "Explain describes your expression in plain English. he's";
        Assert.Equal(8, text.WordCount());
    }
}
