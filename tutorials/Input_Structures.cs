using System;

class Program
{
static void Main()
{
// 1. Call the static class directly (no "new" keyword needed!)
string nameInput = InputCollector.Ask("Enter employee name: ");
string roleInput = InputCollector.Ask("Enter employee role: ");

// 2. Pass those strings into a new User object
User employee = new User(nameInput, roleInput);

// 3. Display the data from the object
Console.WriteLine($"\nSuccessfully created Profile: {employee.Name} ({employee.Role})");
}
}

// A static helper class for capturing input
static class InputCollector
{
public static string Ask(string prompt)
{
Console.Write(prompt);
return Console.ReadLine();
}
}

// A data class to hold the profile information
class User
{
public string Name { get; set; }
public string Role { get; set; }

// Constructor to build the user object
public User(string name, string role)
{
Name = name;
Role = role;
}
}