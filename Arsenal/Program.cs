using System.Text.Json;



File.ReadAllText(@"weapon.json");

string Json = JsonSerializer.Deserialize<Weapon>(glock);

Console.WriteLine("Hur många SLAPS oompa loompa?");

int bichAttacks = 0;
string bichAttacks = "";

while(!int.TryParse(bichAttacks, out bichAttacks))
{
    bichAttacks = Console.ReadLine();
}

int damageSum = 0;

Console.ForegroundColor = ConsoleColor.Blue;

for (int i = 0; i < bichAttacks; i++)
{
    int damage = Weapon.Attack();
    Console.WriteLine($"+{damage}");
    damageSum += damage;
}

Console.ResetColor();

Console.WriteLine($"You did a total of {damageSum} points of damage");
Console.ReadLine();


// läsa in string från weapon.json
// deserialisera från string
// skriv ut namnet på vapnet
//skriva readalltext ist icg deserialize


// Weapon glock = new Weapon()
// {
//     Name = "Glock",
//     DamageMin = 5,
//     DamageMax = 9
// };


// string Json = JsonSerializer.Serialize<Weapon>(glock);
// // Serialisera


// File.WriteAllText(@"weapon.json", Json);
// // Sparar