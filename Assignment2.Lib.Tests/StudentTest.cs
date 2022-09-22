using System;
using Xunit;

namespace Assignment2.Lib.testStudents;

public class StudenttestStudent
{
    [Fact]
    public void testStudent_Student_Status_Return_New()
    {
        Student testStudent = new Student(1);
        testStudent.StartDate = new DateTime(2024,8,20);
        testStudent.EndDate = new DateTime(2027,8,20);
        Assert.Equal(Status.NEW, testStudent.StudentStatus);
    }

    [Fact]
    public void testStudent_Student_Status_Return_Active()
    {
        Student testStudent = new Student(1);
        testStudent.StartDate = new DateTime(2021,8,20);
        testStudent.EndDate = new DateTime(2024,8,20);
        Assert.Equal(Status.Active, testStudent.StudentStatus);
    }

    [Fact]
    public void testStudent_Student_Status_Return_DropOut()
    {
        Student testStudent = new Student(1);
        testStudent.StartDate = new DateTime(2019,8,20);
        testStudent.EndDate = new DateTime(2022,8,20);
        Assert.Equal(Status.DropOut, testStudent.StudentStatus);
    }

    [Fact]
    public void testStudent_Student_Invalid_EndDate_Throw_Ex()
    {
        Student testStudent = new Student(1);
        testStudent.StartDate = new DateTime(2019,8,20);
        Assert.Throws<ArgumentException>(() => testStudent.EndDate = new DateTime(2018,8,20));
    }

    [Fact]
    public void testStudent_Student_Invalid_StartDate_Throw_Ex()
    {
        Student testStudent = new Student(1);
        testStudent.EndDate = new DateTime(2018,8,20);
        Assert.Throws<ArgumentException>(() => testStudent.StartDate = new DateTime(2019,8,20));
    }

    [Fact]
    public void testStudent_Student_Invalid_GraduationDate_Throw_Ex()
    {
        Student testStudent = new Student(1);
        testStudent.StartDate = new DateTime(2024,8,20);
        testStudent.EndDate = new DateTime(2027,8,20);
        Assert.Throws<ArgumentException>(() => testStudent.GraduationDate = new DateTime(2025,8,20));
    }
}