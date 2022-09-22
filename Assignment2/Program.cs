var q = new Queries();
var wizards = WizardCollection.Create();
// Console.WriteLine(q.GetFirstSithYearEx(wizards));
// foreach (var wizard in wizards)
// {
//     Console.WriteLine(wizard);
// }
// var harryPotterCharacter = q.GetHarryPotterCharactersEx(wizards);
foreach (var wizard in q.GetReversedOrderedList(wizards))
{
    Console.WriteLine(wizard);
}
