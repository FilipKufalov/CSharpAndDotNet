using static System.Console;

string password = "ninja";

if (password.Length < 8)
{
    Console.WriteLine("Your password is short!");
} 
else
{
    Console.WriteLine("Your password is good!");
}

object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

Random random = new Random();
int number = random.Next(0, 6);

switch (number)
{
    case 0:
        Console.WriteLine(0);
        break;
    case 1:
        Console.WriteLine(1);
        break;
    case 2:
        Console.WriteLine(2);
        break;
    case 3:
        Console.WriteLine(3);
        break;
    case 4:
        Console.WriteLine(4);
        break;
    case 5:
        goto A_label;
        //break;
    default:
        Console.WriteLine("Unknown");
        break;
}

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

string path = @"C:\CodeAcademy\FullStackDevelopment\CSharpAndDotNet\Chapter03";

Write("Press R for read-only or W for writable: ");
//WriteLine(Path.Combine(path, "file.txt"));
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? s;

if(key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);
}
else
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);
}

string message;

switch (s)
{
    case FileStream writableFile when s.CanWrite:
        message = "The stream is a file that I can write to.";
        break;
    case FileStream readOnlyFile:
        message = "The stream is a read-only file.";
        break;
    case MemoryStream ms:
        message = "The stream is a memory address";
        break;
    default:
        message = "The stream is some other type.";
        break;
    case null:
        message = "The stream is null";
        break;
}

message = s switch
{
    FileStream writableFile when s.CanWrite => "The stream is a file that I can write to.",
    FileStream readOnlyFile => "The stream is a read-only file.",
    MemoryStream ms => "The stream is a memory address",
    null => "The stream is null",
    _ => "The stream is some other type."
};

WriteLine(message);