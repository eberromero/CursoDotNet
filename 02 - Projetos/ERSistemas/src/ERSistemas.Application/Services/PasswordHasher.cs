using System.Security.Cryptography;

namespace ERSistemas.Application.Services;

public class PasswordHasher
{
    public string Hash(string senha)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);

        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
            senha,
            salt,
            100_000,
            HashAlgorithmName.SHA256,
            32);

        return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
    }

    public bool Verify(string senha, string senhaHash)
    {
        string[] partes = senhaHash.Split(':');

        if (partes.Length != 2)
            return false;

        byte[] salt = Convert.FromBase64String(partes[0]);
        byte[] hashEsperado = Convert.FromBase64String(partes[1]);

        byte[] hashCalculado = Rfc2898DeriveBytes.Pbkdf2(
            senha,
            salt,
            100_000,
            HashAlgorithmName.SHA256,
            32);

        return CryptographicOperations.FixedTimeEquals(
            hashCalculado,
            hashEsperado);
    }
}