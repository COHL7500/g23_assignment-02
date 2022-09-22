var wizards = WizardCollection.Create();

foreach (var wizard in Queries.GetReversedOrderedList(wizards))
{
    Console.WriteLine(wizard);
}
