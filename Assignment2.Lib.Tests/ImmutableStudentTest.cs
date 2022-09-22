using System;
using Xunit;

namespace Assignment2.Lib.testStudents;

public class ImmutableStudentTest
{
    [Fact]
    public void testStudent_ImmutableStudent_Equality_Of_Two_Equal_Record_Return_True()
    {
        int id = 0;
        string givenName = "test";
        string surName = "tester";
        DateTime startDate = new DateTime(2024,8,20);
        DateTime endDate = new DateTime(2024,8,20);
        DateTime graduationDate = new DateTime(2027,8,20);
        ImmutableStudent testStudent1 = new ImmutableStudent(id, givenName, surName, startDate, endDate, graduationDate);
        ImmutableStudent testStudent2 = new ImmutableStudent(id, givenName, surName, startDate, endDate, graduationDate);
        Assert.True(testStudent1.Equals(testStudent2));
    }

    [Fact]
    public void testStudent_ImmutableStudent_Equality_Of_Two_Not_Equal_Record_Return_False()
    {
        int id = 0;
        string givenName = "test";
        string surName = "tester";
        DateTime startDate = new DateTime(2024,8,20);
        DateTime endDate = new DateTime(2024,8,20);
        DateTime graduationDate = new DateTime(2027,8,20);
        ImmutableStudent testStudent1 = new ImmutableStudent(id, givenName, surName, startDate, endDate, graduationDate);
        ImmutableStudent testStudent2 = new ImmutableStudent(2, givenName, surName, startDate, endDate, graduationDate);
        Assert.False(testStudent1.Equals(testStudent2));
    }

    [Fact]
    public void testStudent_ImmutableStudent_To_String()
    {
        int id = 0;
        string givenName = "test";
        string surName = "tester";
        DateTime startDate = new DateTime(2024,8,20);
        DateTime endDate = new DateTime(2024,8,20);
        DateTime graduationDate = new DateTime(2027,8,20);
        ImmutableStudent testStudent = new ImmutableStudent(id, givenName, surName, startDate, endDate, graduationDate);
        Assert.Equal("ImmutableStudent { Id = 0, GivenName = test, SurName = tester, StartDate = 20.08.2024 00.00.00, EndDate = 20.08.2024 00.00.00, GraduationDate = 20.08.2027 00.00.00, StudentStatus = NEW }", testStudent.ToString());
    }
}