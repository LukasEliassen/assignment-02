namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void ExtensionFlattenNumbers()
    {
        IEnumerable<IEnumerable<int>> xs = new [] { new[] {1, 2}, new[] {3, 4}, new[] {5, 6} };
        Assert.Equal(new [] {1,2,3,4,5,6},Extensions.Flatten(xs));    
    }

    [Fact]
    public void ExtensionFilterDivisible7Grater42()
    {
        int[] ys = new[] { 70, 35, 105, 20, 42 };
        Assert.Equal(new[] {70,105},Extensions.Filter(ys,x => (x%7)==0 && x >42));
    }

    [Fact]
    public void ExtensionFilterLeapYears()
    {
        int[] ys = new[] { 2001, 1995, 2024, 1988, 2000 };
        Assert.Equal(new[]{2024,1988,2000},Extensions.Filter(ys,y => (y % 4 == 0 && (y % 100 != 0 || y % 400 == 0))));
    }

    [Fact]
    public void ExtensionIsURISecureTrue()
    {
        Uri url = new Uri("https://www.google.com");
        Assert.Equal(true,url.IsSecure());
    }

    [Fact]
    public void ExtensionIsURISecureFalse()
    {
        Uri url = new Uri("http://www.google.com");
        Assert.Equal(false,url.IsSecure());
    }

    [Fact]
    public void ExtensionWordCount()
    {
        string words = "Morbi pulvinar iaculis felis ac consectetur. Suspendisse tempus ligula nec tincidunt ullamcorper. Curabitur auctor euismod ligula at semper. Etiam sed.";
        Assert.Equal(20,words.WordCount());
    }
}
