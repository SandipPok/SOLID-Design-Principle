using DemoLibrary.Interface;
using DIPDemo;

class Program
{
    static void Main(string[] args)
    {
        //IPerson owner = new Person
        //{
        //    FirstName = "Tom",
        //    LastName = "Holland",
        //    EmailAddress = "tom@holland.com",
        //    PhoneNumber = "1234567890"
        //};

        //Chore chore = new Chore
        //{
        //    ChoreName = "Take out the trash",
        //    Owner = owner
        //};

        IPerson owner = Factory.CreatePerson();

        owner.FirstName = "Tom";
        owner.LastName = "Holland";
        owner.EmailAddress = "tom@holland.com";
        owner.PhoneNumber = "1234567890";

        IChore chore = Factory.CreateChore();

        chore.ChoreName = "Take out the trash";
        chore.Owner = owner;

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();

        Console.ReadLine();
    }
}