
// See https://aka.ms/new-console-template for more information
using MyFirstGitHubClassRoomConsoleApp60;

Demo demo = new Demo();
Demo demo2 = new Demo("Thomas", "11223344", 21);

Console.WriteLine(demo.Navn);
Console.WriteLine(demo.Telefon);
Console.WriteLine(demo.Alder);

Console.WriteLine();

Console.WriteLine(demo2.Navn);
Console.WriteLine(demo2.Telefon);
Console.WriteLine(demo2.Alder);

Console.WriteLine();
Console.WriteLine("Press any key to close the program...");
Console.ReadKey();