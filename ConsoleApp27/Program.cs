using System;

public class BahaSenpai
{
    public (string enchantedWeapon, int newHealth) EnchantAndAttack(int targetHealth, int damage, string weapon)
    {
        int enchantedDamage = damage + 10;
        int newHealth = targetHealth - enchantedDamage;
        string enchantedWeapon = "enchanted " + weapon;

        return (enchantedWeapon, newHealth);
    }
}