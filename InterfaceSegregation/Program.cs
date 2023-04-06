// See https://aka.ms/new-console-template for more information


using InterfaceSegregation;

OldPrinter oldPrinter = new OldPrinter();
oldPrinter.Print();

NewPrinter newPrinter = new NewPrinter();
newPrinter.Print();
newPrinter.Scan();