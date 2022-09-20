using System;
using System.Linq;

namespace Assignment2;

public class Queries
{
    static Wizard[] wizards = WizardCollection.Create().ToArray();

    public static IEnumerable<string> LinqWizardsRowling()
    {
        return from w in wizards where w.Creator == "J.K.Rowling" select w.Name;
    }

    public static IEnumerable<string> ExtensionsWizardRowling()
    {
        return wizards.Where(x => x.Creator == "J.K.Rowling").Select(x => x.Name);
    }

    public static int? LinqFirstSithLord()
    {
        return (from w in wizards where w.Name == "Darth Vader" select w.Year).First();
    }

    public static int? ExtensionsFirstSithLord()
    {
        return wizards.Where(x => x.Name == "Darth Vader").Select(x => x.Year).First();
    }

    public static IEnumerable<(string,int?)> LinqUniqueHarry()
    {
        var list = from w in wizards where w.Medium.Equals("Harry Potter") group w.Year by w.Name into g select g;
        foreach(var tuple in list){
            yield return new Tuple<string,int>(tuple);
        }
    }

    public static IEnumerable<(string,int?)> ExtensionsUniqueHarry()
    {
        return wizards.Where(x => x.Medium == "Harry Potter").Select(x => (x.Name,x.Year)).Distinct();
    }
/*
    public static IEnumerable<(string,string)> LinqCreatorWizardReverseOrder()
    {
        //return from w in wizards orderby w.Creator descending group w.Name by w.Creator into g select (g.Key);
    }*/
}
