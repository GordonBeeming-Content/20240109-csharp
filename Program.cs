var name = "Gordon";
FormattableString stringLiteral = $@"
Hi { name },

Strings are cool!
";

Console.WriteLine(stringLiteral.Format);
System.Console.WriteLine(stringLiteral.ArgumentCount);

System.Console.WriteLine(stringLiteral.GetArguments()[0]);
