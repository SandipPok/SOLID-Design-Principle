﻿namespace DemoLibrary.Interface
{
    public interface IPerson
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
    }
}