namespace Assignment2.Lib;
class Program {
    static void Main(string[] args) {
        Student test = new Student(2);
        test.StartDate = new DateTime(2019,8,20);
        test.EndDate = new DateTime(2022,8,20);
        test.GraduationDate = new DateTime(2022,8,20);
        test.GivenName = "lars";
        test.SurName = "larsen";
        Console.WriteLine(test.StudentStatus);
    }
}