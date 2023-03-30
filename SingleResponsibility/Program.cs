// See https://aka.ms/new-console-template for more information

using SingleResponsability;

Journal journal = new Journal();
journal.AddEntry("First entry");
journal.AddEntry("second entry");


Persistance persistance = new Persistance();
string fileName = @"C:\Users\Public\Documents\journal.txt";
persistance.SaveToFile(journal, fileName, true);
Console.WriteLine(persistance.Load(fileName));