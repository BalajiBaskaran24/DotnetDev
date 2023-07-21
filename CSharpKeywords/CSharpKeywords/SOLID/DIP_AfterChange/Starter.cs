namespace CSharpRef.SOLID.DIP_AfterChange;
class Starter
{
    static void Main(string[] args)
    {
        IPerson owner = Factory.CreatePerson();

        owner.FirstName = "Tim";
        owner.LastName = "Corey";
        owner.EmailAddress = "tim@iamtimcorey.com";
        owner.PhoneNumber = "555-1212";

        IChore chore = Factory.CreateChore();
        chore.ChoreName = "Take out the trash";
        chore.Owner = owner;

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();

        Console.ReadLine();
    }
}
