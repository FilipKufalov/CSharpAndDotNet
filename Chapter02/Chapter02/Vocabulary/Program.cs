// See https://aka.ms/new-console-template for more information
using System.Reflection;

System.Data.DataSet ds;
HttpClient client;

Console.WriteLine("Hello, World!");

Assembly? assembly = Assembly.GetEntryAssembly();


foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();
    }

    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount, arg2: name.Name);


}

// For text, a single letter, such as an A, is stored as a char type.
char letter = 'A';
char digit = '1';
char symbol = '$';
//Console.WriteLine(letter, digit, symbol);
char userChoice = Console.ReadKey().KeyChar;

//Console.WriteLine()
Console.WriteLine($"\n{nameof(letter)} : {letter} \n" +
    $"{nameof(digit)} : {digit} \n"+
    $"{nameof(symbol)} : {symbol} \n" +
    $"{nameof(userChoice)} : {userChoice}\n");

string firstName = "Bob";
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";

Console.WriteLine($"{nameof(firstName)} : {firstName} \n" +
    $"{nameof(lastName)} : {lastName} \n" +
    $"{nameof(phoneNumber)} : {phoneNumber}");

string fullNameWithTabSeparator = "Bob\tSmith";

Console.WriteLine(fullNameWithTabSeparator);

//var operation = "string";
//var number = 10;
//Console.WriteLine(operation);
//Console.WriteLine(number);
