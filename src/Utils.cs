namespace OrchardCoreContrib.Library;

/// <summary>
/// Represents a utility class that provides methods for generating greeting messages.
/// </summary>
public static class Utils
{
    /// <summary>
    /// Creates a personalized greeting message using the specified first and last names.
    /// </summary>
    /// <param name="firstName">The first name to include in the greeting. Cannot be null.</param>
    /// <param name="lastName">The last name to include in the greeting. Cannot be null.</param>
    /// <returns>A string containing the greeting message formatted as "Hello, {firstName} {lastName}!".</returns>
    public static string Greeting(string firstName, string lastName) => $"Hello, {firstName} {lastName}!";
}
