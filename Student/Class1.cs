namespace Student;
public class Student
{
    int id{get;set;}
    string GivenName{get;init;}
    string Surname{get;set;}
    Status Status{get;}
    DateTime StartDate{get;set;}
    DateTime EndDate{get;set;}
    DateTime GraduationDate{get;set;}
    public Student(int id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){

    }
    public static ToString(){
        return $"Student name: {GivenName} {Surname} ID: {Id} Status: {Status}";
    }
    public getStatus(){
        if(GraduationDate != null){
            Status = Graduated;
        } else if(EndDate != null && GraduationDate == null){
            Status = Dropout;
        } else if (DateTime.Today.AddYears(-1) < StartDate){
            Status = New;
        } else{
            Status = Active;
        }
    }
    public enum Status{New, Active, Dropout, Graduated}
}
