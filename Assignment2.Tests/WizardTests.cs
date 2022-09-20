namespace Assignment2.Tests;

public class WizardTests
{
    /*[Fact]
    public void WizardCollection_contains_2_wizards()
    {
        var wizards = WizardCollection.Create();

        Assert.Equal(2, wizards.Count());
    }*/

    [Theory]
    [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
    [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
    public void Spot_check_wizards(string name, string medium, int year, string creator)
    {
        var wizards = WizardCollection.Create();

        Assert.Contains(wizards, w => w == new Wizard(name, medium, year, creator));
    }

    [Fact]
    public void WizardRowlingCreatedLinq()
    {
        Assert.Equal(new[]{"Harry James Potter","Albus Percival Wulfric Brian Dumbledore"},Queries.LinqWizardsRowling());
    }

    [Fact]
    public void WizardRowlingCreatedExtensions()
    {
        Assert.Equal(new[]{"Harry James Potter","Albus Percival Wulfric Brian Dumbledore"},Queries.ExtensionsWizardRowling());
    }

    [Fact]
    public void WizardFirstSithLordLinq()
    {
        Assert.Equal(1977,Queries.LinqFirstSithLord());
    }

    [Fact]
    public void WizardFirstSithLordExtensions()
    {
        Assert.Equal(1977,Queries.ExtensionsFirstSithLord());
    }

    [Fact]
    public void WizardUniqueHarryLinq()
    {
        var list = Queries.LinqUniqueHarry();
        var vals = new[]{("Harry James Potter",1997),("Albus Percival Wulfric Brian Dumbledore",1997)};

        for(int i = 0; i < list.Count(); i++){
            Assert.Equal(vals[i],list.ElementAt(i));
        }
    }

    [Fact]
    public void WizardUniqueHarryExtensions()
    {
        var list = Queries.ExtensionsUniqueHarry();
        var vals = new[]{("Harry James Potter",1997),("Albus Percival Wulfric Brian Dumbledore",1997)};

        for(int i = 0; i < list.Count(); i++){
            Assert.Equal(vals[i],list.ElementAt(i));
        }
    }
}

