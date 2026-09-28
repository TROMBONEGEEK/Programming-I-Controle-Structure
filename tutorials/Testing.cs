/*  Class = container for related code
Method = an action/function inside the class
Main() = the method where the program begins executing
static = allows Main() to belong directly to the class
void = Main() doesn't return a value
namespace = organizes your code
using = lets you conveniently use code from another namespace
using System;
namespace TourOfCsharp;
*/
using System.Data.SqlTypes;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World");
    }
}

class Code
{
    public static bool Or(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => true,
            (true, false) => true,
            (false, true) => true,
            (false, false) => false,
        };
    public static bool And(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => true,
            (true, false) => false,
            (false, true) => false,
            (false, false) => false,
        };
    public static bool Xor(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => false,
            (true, false) => true,
            (false, true) => true,
            (false, false) => false,
        };
}
