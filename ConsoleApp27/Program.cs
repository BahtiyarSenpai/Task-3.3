using System;

public class BahaSenpai
{
    public (string title, int newPower) BecomeWarrior(string fullName, int power)
    {
        string title = $"{fullName} the warrior";
        int newPower = power;
        return (title, newPower);
    }

    // Вызов:ll
    // var (title, power) = BecomeWarrior("Frodo", 5);
}