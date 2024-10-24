Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Hello, World!");
Console.WriteLine("I live in Denmark");
Console.WriteLine("I love pandas");

string text = System.IO.File.ReadAllText("panda-info.txt");
Console.WriteLine($"Here in info from the file 👉 {text}. ");