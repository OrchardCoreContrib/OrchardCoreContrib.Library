namespace OrchardCoreContrib.Library;

public static class Utils
{
    [Obsolete("Use Greeting(string firstName, string lastName) instead.")]
    public static string Greet(string firstName, string lastName) => $"Hello, {firstName} {lastName}!";

    [Obsolete("Use Greeting(string name) instead.")]
    public static string Greet(string name) => $"Hello, {name}!";

    [Obsolete("Use Greeting() instead.")]
    public static string Greet() => $"Hello, World!";

    public static string Greeting(string firstName, string lastName) => $"Hello, {firstName} {lastName}!";

    public static string Greeting(string name) => $"Hello, {name}!";

    public static string Greeting() => $"Hello, World!";
}
