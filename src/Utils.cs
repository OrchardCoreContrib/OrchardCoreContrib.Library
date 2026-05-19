namespace OrchardCoreContrib.Library;

public static class Utils
{
    public static string Greet(string firstName, string lastName) => $"Hello, {firstName} {lastName}!";

    public static string Greet(string name) => $"Hello, {name}!";

    public static string Greet() => $"Hello, World!";
}
