using System;

class Program
{
    static void Main(string[] args)
    {
        //Erişim Belirteçleri 
        // private 
        // public 
        // Internal
        // Protected
        Calısan calısan1 = new Calısan();
        calısan1.Ad = "Emre Can";
        calısan1.Soyad = "Sarı";
        calısan1.Departman = "Barista";
        calısan1.No = 28282828;
        calısan1.ekranaYazdır();
        Console.WriteLine("********************");
        Telefon emreTelefon = new Telefon();
        emreTelefon.Islemci = "Ios";
        emreTelefon.Model = "Iphone 7";
        emreTelefon.SeriNo = 11111;
        emreTelefon.ekranaYazdır();
    }
}

class Calısan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;    
    public void ekranaYazdır()
    {
        Console.WriteLine("Calısanın Adı : {0}",Ad);
        Console.WriteLine("Calısanın Soyadı : {0}",Soyad);
        Console.WriteLine("Calısanın Numarası : {0}",No);
        Console.WriteLine("Calısanın Departmanı : {0}",Departman);
    }
}

class Telefon
{
    public string Islemci;
    public string Model;
    public int SeriNo;
    public void ekranaYazdır()
    {
        Console.WriteLine("Telefonun İşlemcisi : {0}",Islemci);
        Console.WriteLine("Telefonun Modeli : {0}",Model);
        Console.WriteLine("Telefonun Seri Numarası : {0}",SeriNo);
    }
}