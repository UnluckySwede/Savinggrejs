using System;
using System.Text.Json;

string pickupStatus = "placeholder";
string equipStatus = "placeholder";

Crab weapon = new Crab()
{
    PickedUp = false,
    Durability = 0,
    IsEquipped = false,
    Name = "none",
    Dmg = 0,
};

Console.WriteLine("You've enchanted a crab, do you wish to pick it up?");
Console.WriteLine("1. Yes");
Console.WriteLine("2. No");

pickupStatus = Console.ReadLine();

if (pickupStatus == "1")
{
    weapon.PickedUp = true;
}
Console.WriteLine("What do you wish to name it?");
weapon.Name = Console.ReadLine();

Console.WriteLine($"Do you wish to equip {weapon.Name}?");
Console.WriteLine("1. Yes");
Console.WriteLine("2. No");

equipStatus = Console.ReadLine();

if (equipStatus == "1")
{
    weapon.IsEquipped = true;
}

bool lyckadDurability = false;
while (lyckadDurability == false)
{
    Console.WriteLine("How much durability do you wish to give it?");
    int durabilityStatus;
    lyckadDurability = int.TryParse(Console.ReadLine(), out durabilityStatus);
    weapon.Durability = durabilityStatus;
}
bool lyckadDmg = false;
while (lyckadDmg == false)
{
    Console.WriteLine("How much damage do you wish to give it?");
    int dmgStatus;
    lyckadDmg = int.TryParse(Console.ReadLine(), out dmgStatus);
    weapon.Dmg = dmgStatus;
}

string weaponText = JsonSerializer.Serialize<Crab>(weapon);

File.WriteAllText("Crab.json", weaponText);

Console.Clear();

string jsonText = File.ReadAllText("crab.json");

Console.WriteLine(weaponText);

Console.ReadLine();
