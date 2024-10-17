using System.Security.Cryptography;
using System.Text.Json.Serialization;
using Microsoft.Win32.SafeHandles;

public class Weapon
{
    [JsonInclude]
    public string Name;
    
    [JsonInclude]
    public int DamageMin;
    
    [JsonInclude]
    public int DamageMax;

    public int Attack()
    {
        int slap = Random.Shared.Next(DamageMin,DamageMax);
        return slap;
    }
}
