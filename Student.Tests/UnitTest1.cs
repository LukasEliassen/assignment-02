namespace Student.Tests;

public class UnitTest1
{
    [Fact]
    public void StudentTest()
    {
        var student = new Student(0,"a","b",DateTime.Now.AddYears(-1),DateTime.Now.AddYears(1),DateTime.Now.AddYears(1));
        Assert.Equal("Student name: a b, ID: 0, Status: Active",student.ToString());
    }

    [Fact]
    public void DatetimeStudentTest(){
        var student1 = new Student(0,"a","b",DateTime.Now.AddDays(-4),DateTime.Now.AddYears(2),DateTime.Now.AddYears(2));
        var student2 = new Student(1,"c","d",DateTime.Now.AddDays(-4),DateTime.Now.AddYears(2),null);
        var student3 = new Student(2,"e","f",DateTime.Now.AddYears(-4),DateTime.Now.AddYears(-2),DateTime.Now.AddYears(-2));
        var student4 = new Student(3,"g","h",DateTime.Now.AddYears(-1),DateTime.Now.AddYears(1),DateTime.Now.AddYears(1));

        Assert.Equal("Student name: a b, ID: 0, Status: New",student1.ToString());
        Assert.Equal("Student name: c d, ID: 1, Status: Dropout",student2.ToString());
        Assert.Equal("Student name: e f, ID: 2, Status: Graduated",student3.ToString());
        Assert.Equal("Student name: g h, ID: 3, Status: Active",student4.ToString());
    }

    [Fact]
    public void ImmutableStudentEqualityTest()
    {
        DateTime start = DateTime.Now.AddYears(-1);
        DateTime end = DateTime.Now.AddYears(1);
        DateTime graduate = end;

        var student1 = new ImmutableStudent(0,"a","b",start,end,graduate);
        var student2 = new ImmutableStudent(0,"a","b",start,end,graduate);

        Assert.Equal(true,student1 == student2);
    }

    [Fact]
    public void ImmutableStudentToStringTest(){
        var student = new ImmutableStudent(3,"g","h",DateTime.Now.AddYears(-1),DateTime.Now.AddYears(1),DateTime.Now.AddYears(1));
        Assert.Equal("Student name: g h, ID: 3, Status: Active",student.ToString());
    }
}