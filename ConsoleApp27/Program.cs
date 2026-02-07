using System;

public class BahaSenpai
{
    public (double lesserCursed, double greaterCursed) Curse(double weaponDamage)
    {
        double lesserCursed = weaponDamage * 0.5;
        double greaterCursed = weaponDamage * 0.25;
        return (lesserCursed, greaterCursed);
    }
}