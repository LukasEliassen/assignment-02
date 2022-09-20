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
        var list = from w in wizards where w.Medium.Equals("Harry Potter") group w by w.Name;
        foreach(var group in list){
            yield return (group.ElementAt(0).Name,group.ElementAt(0).Year);
        }
    }

    public static IEnumerable<(string,int?)> ExtensionsUniqueHarry()
    {
        return wizards.Where(x => x.Medium == "Harry Potter").Select(x => (x.Name,x.Year)).Distinct();
    }

    public static IEnumerable<(string,string)> LinqCreatorWizardReverseOrder()
    {
        var list = from w in wizards orderby w.Creator descending, w.Name group w by w.Creator;
        foreach(var group in list){
            foreach(var wizard in group){
                yield return (wizard.Creator,wizard.Name);
            }
        }
    }

    public static IEnumerable<(string,string)> ExtensionsCreatorWizardReverseOrder()
    {
        var list = wizards.OrderByDescending(x => x.Creator).ThenBy(x => x.Name).GroupBy(x => x.Creator);
        foreach(var group in list){
            foreach(var wizard in group){
                yield return (wizard.Creator,wizard.Name);
            }
        }
    }
}
