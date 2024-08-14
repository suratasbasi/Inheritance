namespace Inheritance
{
    public class Program
    {
        static void Main()
        {
            Ogrenci ogrenci = new Ogrenci("Gökçe", "Bahadır", 14423);
            ogrenci.OgrenciNoBilgisi();

            Ogretmen ogretmen = new Ogretmen("Ali Rıza", "Bey", 38000);
            ogretmen.MaasBilgisi();
        }
    }
}