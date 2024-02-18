partial class Program
{
    static (int,uint) ReadNumber(in uint NUMAR_CIFRE)
    {
        int numar;
        Console.WriteLine($"Scrieti un numar intreg pentru a i se afisa ultimele {NUMAR_CIFRE} cifre");
        if (!int.TryParse(Console.ReadLine(), out numar))
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            ReadNumber(NUMAR_CIFRE);
        }
        return (numar, NUMAR_CIFRE);
    }
    static void ShowLastDigits(in (int numar,uint NUMAR_CIFRE) date)
    {
        var numarString = date.numar.ToString();
        Console.WriteLine(numarString.Substring((int)(numarString.Length - date.NUMAR_CIFRE)));
    }
}