namespace Assignment2.Lib;
public class Student
{   
    private DateTime _startDate;
    private DateTime _endDate;
    private DateTime? _graduationDate;
    public int Id {get; init;}
    public string? GivenName {get; set;}
    public string? SurName {get; set;}
    public Status? StudentStatus {get {return getStudentStatus();}}
    public DateTime StartDate {
        get {return _startDate;}
        set {
            if(_endDate.Equals(new DateTime())) _startDate = value;
            else if( _endDate.CompareTo(value) > 0 ) _startDate = value;
            else throw new ArgumentException();
        }
    }
    public DateTime EndDate {
        get {return _endDate;}
        set {
            if(_startDate.Equals(new DateTime())) _endDate = value;
            else if( _startDate.CompareTo(value) < 0 ) _endDate = value;
            else throw new ArgumentException();
        }
    }
    public DateTime? GraduationDate {
        get {return _graduationDate;}
        set {
            if(_endDate.Equals(new DateTime())) _graduationDate = value;
            else if( _endDate.CompareTo(value) == 0 ) _graduationDate = value;
            else throw new ArgumentException();
        }
    }

    public Student(int id) {
        this.Id = id;
    }

    private Status? getStudentStatus() { 
        if(_startDate.Equals(new DateTime())) return null;
        DateTime now = DateTime.Now;
        if(now.CompareTo(StartDate) < 0) {
            return Status.NEW;
        } else if (now.CompareTo(EndDate) < 0) {
            return Status.Active;
        } else if (now.CompareTo(EndDate) > 0 && _graduationDate == null) {
            return Status.DropOut;
        } 
        return Status.Graduated;
    }
    public override string ToString() {
        return $"Id: {Id}, GivenName: {GivenName}, SurName: {SurName}, Status: {StudentStatus}, StartDate: {StartDate}, EndDate: {EndDate}, GraduationDate: {GraduationDate}";
    }
}
