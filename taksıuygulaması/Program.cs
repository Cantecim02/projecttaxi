using System;

class Program
{
    static void Main()
    {
        
        float acilisUcreti = 150;
        float kmUcreti = 25;

     
        Console.Write("Gidilen mesafeyi (km) girin: ");
        bool kmOk = float.TryParse(Console.ReadLine(), out float mesafe);

        if (!kmOk || mesafe < 0)
        {
            Console.WriteLine("Geçersiz mesafe girdiniz.");
            return;
        }


        Console.Write("Gece tarifesi uygulanıyor mu? (E/H): ");
        string cevap = Console.ReadLine().ToUpper();
        bool geceTarifesi = cevap == "E";

      
        float toplamUcret = acilisUcreti + (mesafe * kmUcreti);

        if (geceTarifesi)
        {
            toplamUcret *= 1.20f; // %20 zam
        }

     
        Console.WriteLine($"\nToplam Ücret: {toplamUcret} TL");
    }
}
