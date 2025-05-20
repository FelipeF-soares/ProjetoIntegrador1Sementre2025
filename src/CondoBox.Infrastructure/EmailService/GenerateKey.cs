using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.EmailService;

public static class GenerateKey
{
    public static void GeneratorAndSaveKeys()
    {
        var cryptoFolder = @"C:\InfraCondoBox";
        var cryptoPath = Path.Combine(cryptoFolder, "cryptokeys.json");

        if (File.Exists(cryptoPath))
        {
            return;
        }
        string key = GeneratorRandomStrings(32);
        string initializationVector = GeneratorRandomStrings(16);

        var data = new Keys
        {
            Key = key,
            IV = initializationVector
        };

        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(cryptoPath, json);

    }
    private static string GeneratorRandomStrings(int length)
    {
        const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var randomBytes = new byte[length];
        using var randomNumberGenerator = RandomNumberGenerator.Create();
        randomNumberGenerator.GetBytes(randomBytes);

        var result = new char[length];
        for(int i =0; i< length; i++)
        {
            result[i] = caracteres[randomBytes[i] % caracteres.Length];
        }
       
        return new string(result);
    }

    public static string RecoveryKeysByName(string key)
    {
        var cryptoFolder = @"C:\InfraCondoBox";
        var cryptoPath = Path.Combine(cryptoFolder, "cryptokeys.json");
        if (!File.Exists(cryptoPath))
        {
            throw new FileNotFoundException("Arquivo Key cryptokeys.json não encontrado");
        }
        string json = File.ReadAllText(cryptoPath);

        var keys = JsonSerializer.Deserialize<Keys>(json);
        if (key.ToLower() == "key") return keys.Key;
        if (key.ToLower() == "iv") return keys.IV;

        return string.Empty;
    }
}
