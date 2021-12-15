string Name = "";
string Surname = "";
Console.WriteLine("Veuillez entrer votre nom");
Name = Console.ReadLine();
Console.WriteLine("Veuillez entre votre nom");
Surname = Console.ReadLine();
Console.WriteLine($"Bonjour {Name} {Surname}, nous sommes le {DateTime.Now.ToLongDateString()}, comment allez-vous?");
