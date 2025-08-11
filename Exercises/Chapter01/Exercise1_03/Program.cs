// This method attempts to modify the received text,
// but since strings are immutable in C#, the change will not affect the original variable.
// The result of Replace is not stored or returned.

static void FormatString(string stringToFormat)
{
    stringToFormat.Replace("World", "Mars");  /* Here it returns me a modified string */
}


// This method returns a new string with "Earth" replaced by "Mars".
// Because strings are immutable, the modified value must be returned.
static string FormatReturningString(string stringToFormat)
{
    return stringToFormat.Replace("Earth", "Mars");
}

var greetings = "Hello World";
FormatString(greetings);
Console.WriteLine(greetings); // This will print "Hello World" because FormatString does not modify the original string.

var anotherGreetings = "Good morning Earth!";
Console.WriteLine(FormatReturningString(anotherGreetings)); // This will print "Hello Mars" because the method returns a new string with the modification.