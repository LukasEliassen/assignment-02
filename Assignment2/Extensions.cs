namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri url){
        return url.AbsoluteUri.Contains("https");
    }

    public static int WordCount(this string str){
        return Regex.Split(str, @"[\s]+").Count();
    }
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items) => items.SelectMany(x => x);
    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate) => items.Where(x => predicate(x));
}
