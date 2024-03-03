//This is a comment to my code

//rakendus küsib kasutajalt sisesta tema nime
//rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter your name");
//string- sõne
string userName;


userName= Console.ReadLine();

//string interpolation

Console.WriteLine($"Hello, {userName!}!");