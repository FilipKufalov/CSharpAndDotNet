string text = "w3resource";

Console.WriteLine(text.Remove(text.IndexOf("3", StringComparison.Ordinal), text.IndexOf("3", StringComparison.Ordinal)));
Console.WriteLine(text.Remove(text.LastIndexOf("e"), 1));
Console.WriteLine(text.Remove(text.IndexOf("w"), 1));


void test(string text)
{
    text = text;
}

test("lol");