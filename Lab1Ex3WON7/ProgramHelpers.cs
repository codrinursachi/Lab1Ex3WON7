using static System.Runtime.InteropServices.JavaScript.JSType;

partial class Program
{
    static (int,uint) ReadNumber(uint cifre)
    {
        int numar;
        Console.WriteLine($"Scrieti un numar intreg pentru a i se afisa ultimele {cifre} {nameof(cifre)}");
        if (!int.TryParse(Console.ReadLine(), out numar))
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            ReadNumber(cifre);
        }
        return (numar,cifre);
    }
    static void ShowLastDigits((int numar,uint cifre) date)
    {
        var numarString = date.numar.ToString();
        Console.WriteLine(numarString.Substring((int)(numarString.Length - date.cifre)));
    }
}