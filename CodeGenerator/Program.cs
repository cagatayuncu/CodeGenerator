
Console.WriteLine("Kaç adet kod üretmek istersiniz?");
int numberOfCodes = Convert.ToInt32(Console.ReadLine());
string characters = "ACDEFGHKLMNPRTXYZ234579";
int length = 8;
var random = new Random();
var codes = new List<string>();

while (codes.Count < numberOfCodes)
{
    var result = new string(Enumerable.Repeat(characters, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    if (!codes.Contains(result))
    {
        codes.Add(result);
    }
}

Console.WriteLine("Üretilen Kodlar: ");
foreach (var code in codes)
{
    Console.WriteLine(code);
}
