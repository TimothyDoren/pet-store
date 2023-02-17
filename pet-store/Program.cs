using pet_store;

IPet[] pets = new IPet[]
{
    new Dog() { Name = "Fido"},
    new Cat() { Name = "Felix"},
    new Duck() { Name = "Donald"},
    new Cow() { Name = "Daisy"},
    new Ferret() { Name = "Todd"}
};
foreach(var pet in pets)
{
    Console.WriteLine($"{pet.Name} says {pet.Speak()}");
}