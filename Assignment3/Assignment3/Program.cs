Console.WriteLine("Part A");
/* Explain  .csproj 

1- target framework (version ex: .NET10)
2- Enable - Disable Features 
3- package or library use 
4- output type (ex: exe)
5- SDK Type

*/

//------------------------------------ 

/*  Program.cs (Entry Point  => start runtime exexution)

Program.cs is the entry point of the application — the file that contains the Main method,
which is the first code that runs when the program starts.

*/

//-----------------------------------------------

/* obj /, and bin/.

bin:
The folder where your program's final, ready-to-run files go (like the .exe or .dll).

obj:
A temporary folder the compiler uses while building your project, to help it build faster next time.

*/
//-----------------------------------------------------

/* Sln vs Slnx 

sln (classic): old format, hard to read, can cause conflicts when 
teammates edit it at the same time — but works with almost every tool.

slnx (new): newer XML format, easy to read and edit — but not fully 
supported everywhere yet.

*/

//--------------------------------------------
//Part B  
Console.WriteLine("Part B");
RunTypesDemo();
static void RunTypesDemo()
{
    // 1. Variables & Types

    int age = 22;
    long population = 1000000L;
    double price = 19.99;
    decimal salary = 15000.50m;
    bool isActive = true;
    char grade = 'A';
    string name = "Sherif";
    var number = 42;

    Console.WriteLine($"int: {age}, Type: {age.GetType()}");
    Console.WriteLine($"long: {population}, Type: {population.GetType()}");
    Console.WriteLine($"double: {price}, Type: {price.GetType()}");
    Console.WriteLine($"decimal: {salary}, Type: {salary.GetType()}");
    Console.WriteLine($"bool: {isActive}, Type: {isActive.GetType()}");
    Console.WriteLine($"char: {grade}, Type: {grade.GetType()}");
    Console.WriteLine($"string: {name}, Type: {name.GetType()}");
    Console.WriteLine($"var: {number}, Type: {number.GetType()}");

    // 2. Implicit conversion

    int intValue = 100;
    long longValue = intValue;

    char character = 'A';
    int charValue = character;

    Console.WriteLine($"int to long: {longValue}");
    Console.WriteLine($"char to int: {charValue}");

    // No cast is required because these conversions are implicitly supported by C#.

    // 3. Explicit conversion

    double decimalValue = 9.8;

    int castResult = (int)decimalValue;
    int convertResult = Convert.ToInt32(decimalValue);

    Console.WriteLine($"(int): {castResult}");
    Console.WriteLine($"Convert.ToInt32: {convertResult}");

    // (int) truncates the fractional part, while Convert.ToInt32 rounds the value.

    // 4. Integer division

    int integerDivision = 5 / 2;
    double doubleDivision = 5.0 / 2;

    Console.WriteLine($"5 / 2: {integerDivision}");
    Console.WriteLine($"5.0 / 2: {doubleDivision}");

    // Integer division discards the fractional part, while double division keeps it.

    // 5. Boxing / Unboxing

    int originalValue = 42;
    object boxedValue = originalValue;

    Console.WriteLine($"After boxing: {boxedValue}");

    int unboxedValue = (int)boxedValue;

    Console.WriteLine($"After unboxing: {unboxedValue}");

    // 6. Parsing

    string validInput = "42";
    int parsedValue = int.Parse(validInput);

    Console.WriteLine($"Parsed value: {parsedValue}");

    string invalidInput = "abc";
    bool success = int.TryParse(invalidInput, out int tryParsedValue);

    Console.WriteLine($"TryParse succeeded: {success}");

    if (!success)
    {
        Console.WriteLine("Parsing failed.");
    }

    // 7. float to decimal

    float floatValue = 10.5f;

    // decimal decimalValue = floatValue;

    decimal convertedDecimal = (decimal)floatValue;

    Console.WriteLine($"float to decimal: {convertedDecimal}");

    // The implicit conversion is not allowed because float to decimal may involve precision differences,
    // so an explicit cast is required.
}