using System;

public class BahaSenpai
{
    public string GetTitle(string firstName, string lastName, string job)
    {
        string title = firstName + " " + lastName + " the " + job;
        return title;
    }
}