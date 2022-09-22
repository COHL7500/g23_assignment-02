namespace Assignment2.Lib;
public record ImmutableStudent(int Id, string GivenName, string SurName, DateTime StartDate, DateTime EndDate, DateTime? GraduationDate) {
    public Status? StudentStatus {get {return getStudentStatus();}}

    private Status? getStudentStatus() { 
        if(StartDate.Equals(new DateTime())) return null;
        DateTime now = DateTime.Now;
        if(now.CompareTo(StartDate) < 0) {
            return Status.NEW;
        } else if (now.CompareTo(EndDate) < 0) {
            return Status.Active;
        } else if (now.CompareTo(EndDate) > 0 && GraduationDate == null) {
            return Status.DropOut;
        } 
        return Status.Graduated;
    }
};