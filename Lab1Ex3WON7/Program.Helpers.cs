partial class Program
{
    static (int,uint) ReadNumber(uint numarCifre)
    {
        Console.WriteLine($"Scrieti un numar intreg pentru a i se afisa ultimele {numarCifre} cifre");
        if (!int.TryParse(Console.ReadLine(), out int numar))
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            ReadNumber(numarCifre);
        }
        return (numar, numarCifre);
    }
    static void ShowLastDigits(in (int numar,uint NUMAR_CIFRE) date)
    {
        var numarString = date.numar.ToString();
        Console.WriteLine(numarString.Substring((int)(numarString.Length - date.NUMAR_CIFRE)));
    }
}