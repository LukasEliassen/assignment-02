namespace Student;
public class Student
{
    int id{get;init;}
    string GivenName{get;set;}
    string Surname{get;set;}
    Status Stats{get;}
    DateTime StartDate{get;set;}
    DateTime EndDate{get;set;}
    DateTime? GraduationDate{get;set;}

    public Student(int id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime? GraduationDate){
        this.id = id;
        this.GivenName = GivenName;
        this.Surname = Surname;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.GraduationDate = GraduationDate;
        this.Stats = getStatus();
    }

    public override string ToString(){
        return $"Student name: {GivenName} {Surname}, ID: {id}, Status: {Stats}";
    }
    private Status getStatus(){
        if(GraduationDate == null) return Status.Dropout;
        else if(GraduationDate < DateTime.Now) return Status.Graduated;
        else if (DateTime.Today < StartDate.AddDays(7)) return Status.New;
        else return Status.Active;
    }
    private enum Status{New, Active, Dropout, Graduated}
}

public record ImmutableStudent
{
    int id{get;init;}
    string GivenName{get;init;}
    string Surname{get;init;}
    Status Stats{get;init;}
    DateTime StartDate{get;init;}
    DateTime EndDate{get;init;}
    DateTime? GraduationDate{get;init;}

    public ImmutableStudent(int id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime? GraduationDate){
        this.id = id;
        this.GivenName = GivenName;
        this.Surname = Surname;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.GraduationDate = GraduationDate;
        this.Stats = getStatus();
    }

    public override string ToString(){
        return $"Student name: {GivenName} {Surname}, ID: {id}, Status: {Stats}";
    }
    private Status getStatus(){
        if(GraduationDate == null) return Status.Dropout;
        else if(GraduationDate < DateTime.Now) return Status.Graduated;
        else if (DateTime.Today < StartDate.AddDays(7)) return Status.New;
        else return Status.Active;
    }
    private enum Status{New, Active, Dropout, Graduated}
}

