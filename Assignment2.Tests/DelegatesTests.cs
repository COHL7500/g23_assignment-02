

namespace Assignment2.Tests;

public class DelegatesTests
{
    public delegate string Reverse(string s);
    public delegate double CalcProduct(double x, double y);

    public delegate bool IsStringEqualInt(string x, int y);
    Reverse rev = delegate(string str) { 
            return new string(str.Reverse().ToArray());
    };

    CalcProduct product = delegate(double x, double y) { 
            return x*y;
    };

    IsStringEqualInt stringAndInt = delegate(string str, int y) { 
            int x;
            bool res = int.TryParse(str.Trim(), out x); 
            return res && x == y;
    };

    [Fact]
    public void ReverseString()
    {
        Assert.Equal("dlroW olleH", rev("Hello World"));
    }

    [Fact]
    public void Product_Of_Two_Ints()
    {
        Assert.Equal(303.104,64613, product(46.31,6545.123));
    }

    [Fact]
    public void Test_42_Equal_String()
    {
        Assert.True(stringAndInt(" 0042", 42));
    }

    [Fact]
    public void Test_42_Not_Equal_String()
    {
        Assert.False(stringAndInt("Hello world", 42));
    }

    [Fact]
    public void Test_999_Not_Equal_String()
    {
        Assert.False(stringAndInt(" 01042", 999));
    }
}
