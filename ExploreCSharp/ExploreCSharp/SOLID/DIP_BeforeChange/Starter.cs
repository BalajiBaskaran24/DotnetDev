﻿namespace ExploreCSharp.SOLID.DIP_BeforeChange;
class Starter
{
    public static void Execute()
    {
        Person owner = new Person
        {
            FirstName = "Tim",
            LastName = "Corey",
            EmailAddress = "tim@iamtimcorey.com",
            PhoneNumber = "555-1212"
        };

        Chore chore = new Chore
        {
            ChoreName = "Take out the trash",
            Owner = owner
        };

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();

        Console.ReadLine();
    }
}

