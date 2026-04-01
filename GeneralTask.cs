/*1*//*
using System;

class Program
{
    static void Main()
    {
        int[] ededler = new int[5];

        Console.WriteLine("5 ədəd daxil edin:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i + 1}-ci ədədi daxil edin: ");
            ededler[i] = Convert.ToInt32(Console.ReadLine());
        }

        MinMaxTap(ededler);
    }

    static void MinMaxTap(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];

            if (arr[i] > max)
                max = arr[i];
        }

        Console.WriteLine("Ən kiçik ədəd: " + min);
        Console.WriteLine("Ən böyük ədəd: " + max);
    }
}*/








/*2*//*
using System;

class Program
{
    static int Cem(int a, int b)
    {
        return a + b;
    }

    static double Cem(double a, double b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        int x = 5;
        int y = 7;
        Console.WriteLine("Int cəmi: " + Cem(x, y));

        double d1 = 5.5;
        double d2 = 3.2;
        Console.WriteLine("Double cəmi: " + Cem(d1, d2));
    }
}*/








/*3*//*
using System;

class Program
{
    static double Hesabla(double eded, bool kub = false)
    {
        if (kub)
            return eded * eded * eded;
        else
            return eded * eded;
    }

    static void Main(string[] args)
    {
        Console.Write("Ədədi daxil edin: ");
        double eded = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kub hesablansın? (bəli/xeyr): ");
        string cavab = Console.ReadLine();

        if (cavab.ToLower() == "bəli")
            Console.WriteLine("Kub: " + Hesabla(eded, true));
        else
            Console.WriteLine("Kvadrat: " + Hesabla(eded));
    }
}*/









/*4*//*
using System;

class Program
{
    static void TekCutSay(int[] arr)
    {
        int tek = 0;
        int cut = 0;

        foreach (int eded in arr)
        {
            if (eded % 2 == 0)
                cut++;
            else
                tek++;
        }

        Console.WriteLine("Tək ədədlərin sayı: " + tek);
        Console.WriteLine("Cüt ədədlərin sayı: " + cut);

        if (tek > cut)
            Console.WriteLine("Tək ədədlər çoxdur");
        else
            Console.WriteLine("Cüt ədədlər çoxdur");
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 4, 7, 8, 3, 6, 9 };

        TekCutSay(arr);
    }
}*/









/*//5
using System;

class Program
{
    static void AdSoyadYaz(string ad, string soyad = "Naməlum")
    {
        Console.WriteLine("Ad: " + ad);
        Console.WriteLine("Soyad: " + soyad);
    }

    static void Main(string[] args)
    {
        Console.Write("Adı daxil edin: ");
        string ad = Console.ReadLine();

        Console.Write("Soyadı daxil edin (boş buraxa bilərsiniz): ");
        string soyad = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(soyad))
            AdSoyadYaz(ad);
        else
            AdSoyadYaz(ad, soyad);
    }
}*/








/*//6
using System;

class Program
{
    static double Hesabla(double a, double b, bool multiply = false)
    {
        if (multiply)
            return a * b;
        else
            return a + b;
    }

    static double Hesabla(double a, double b, double c, bool multiply = false)
    {
        if (multiply)
            return a * b * c;
        else
            return a + b + c;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("2 ədədin cəmi: " + Hesabla(4, 5));
        Console.WriteLine("2 ədədin hasili: " + Hesabla(4, 5, true));

        Console.WriteLine("3 ədədin cəmi: " + Hesabla(2, 3, 4));
        Console.WriteLine("3 ədədin hasili: " + Hesabla(2, 3, 4, true));
    }
}*/








/*//7
using System;

class Program
{
    static void ArrayCapEt(int[] arr, bool reverse = false)
    {
        if (reverse)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Normal sıra:");
        ArrayCapEt(arr);

        Console.WriteLine("\nTərs sıra:");
        ArrayCapEt(arr, true);
    }
}*/









/*//8
using System;

class Program
{
    static void Kvadratla(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] * arr[i];
        }

        Console.WriteLine("Kvadratlanmış array:");
        foreach (int eded in arr)
        {
            Console.Write(eded + " ");
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 5 };

        Kvadratla(arr);
    }
}*/









/*//9
using System;

class Program
{
    static int SozSay(string cumle, bool ignoreCase = true)
    {
        if (ignoreCase)
            cumle = cumle.ToLower();

        string[] sozler = cumle.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

        return sozler.Length;
    }

    static void Main(string[] args)
    {
        Console.Write("Cümləni daxil edin: ");
        string cumle = Console.ReadLine();

        int say = SozSay(cumle);
        Console.WriteLine("Cümlədəki sözlərin sayı: " + say);
    }
}*/









/*//10
using System;

class Program
{
    static int MaxMinFerq(int[] arr)
    {
        if (arr.Length == 0)
            return 0;

        int max = arr[0];
        int min = arr[0];

        foreach (int eded in arr)
        {
            if (eded > max)
                max = eded;
            if (eded < min)
                min = eded;
        }

        return max - min;
    }

    static void Main(string[] args)
    {
        int[] arr = { 4, 7, 1, 9, 3 };

        int ferq = MaxMinFerq(arr);
        Console.WriteLine("Ən böyük və ən kiçik ədədlərin fərqi: " + ferq);
    }
}*/









/*//11
using System;

class Program
{
    static string Birlesdir(string s1, string s2, string s3 = ".")
    {
        return s1 + " " + s2 + " " + s3;
    }

    static void Main(string[] args)
    {
        string cumle1 = Birlesdir("Salam", "dünya");
        Console.WriteLine(cumle1); // Nəticə: Salam dünya .

        string cumle2 = Birlesdir("Mən", "gəlirəm", "sabah");
        Console.WriteLine(cumle2); // Nəticə: Mən gəlirəm sabah
    }
}*/









/*//12
using System;

class Program
{
    static int ArrayTopla(int[] arr, bool skipNegatives = false)
    {
        int cem = 0;

        foreach (int eded in arr)
        {
            if (skipNegatives && eded < 0)
                continue;
            cem += eded;
        }

        return cem;
    }

    static void Main(string[] args)
    {
        int[] arr = { 4, -2, 7, -5, 3 };

        int toplam1 = ArrayTopla(arr);
        Console.WriteLine("Bütün ədədlərin cəmi: " + toplam1);

        int toplam2 = ArrayTopla(arr, true);
        Console.WriteLine("Mənfi ədədləri saymadan cəm: " + toplam2);
    }
}*/









/*//13
using System;

class Program
{
    static void TekleriTersCapEt(int[] arr, bool includeEven = false)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (!includeEven && arr[i] % 2 == 0)
            {
                continue;
            }

            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

        Console.WriteLine("Tək ədədlər tərs sırada:");
        TekleriTersCapEt(arr);

        Console.WriteLine("Bütün ədədlər tərs sırada:");
        TekleriTersCapEt(arr, true);
    }
}*/









/*//14
using System;
using System.Collections.Generic;

class Program
{
    static void TekrarEdilenleriGoster(int[] arr)
    {
        List<int> yazilanlar = new List<int>();
        bool tekrarVar = false;

        Console.WriteLine("Təkrarlanan ədədlər:");

        for (int i = 0; i < arr.Length; i++)
        {
            int say = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    say++;
            }

            if (say > 1 && !yazilanlar.Contains(arr[i]))
            {
                Console.WriteLine(arr[i] + " → " + say + " dəfə");
                yazilanlar.Add(arr[i]);
                tekrarVar = true;
            }
        }

        if (!tekrarVar)
            Console.WriteLine("Təkrarlanan ədəd yoxdur");
    }

    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 2, 4, 5, 1 };
        int[] arr2 = { 10, 20, 30, 40 };

        Console.WriteLine("Array 1:");
        TekrarEdilenleriGoster(arr1);
        Console.WriteLine();

        Console.WriteLine("Array 2:");
        TekrarEdilenleriGoster(arr2);
    }
}*/









/*//15
using System;

class Program
{
    static void SaitleriSay()
    {
        Console.Write("Mətni daxil edin: ");
        string metn = Console.ReadLine();

        int saitSay = 0;
        string saitler = "aeiouAEIOU";

        for (int i = 0; i < metn.Length; i++)
        {
            if (saitler.Contains(metn[i]))
            {
                saitSay++;
            }
        }

        if (saitSay > 0)
            Console.WriteLine("Mətndə saitlərin sayı: " + saitSay);
        else
            Console.WriteLine("Sait yoxdur");
    }

    static void Main(string[] args)
    {
        SaitleriSay();
    }
}*/









/*//16
using System;

class Program
{
    static void MusbetEdedleriTopla()
    {
        int cem = 0;

        while (true)
        {
            Console.Write("Ədəd daxil edin (mənfi daxil edəndə dayanar): ");
            string input = Console.ReadLine();

            int eded = Convert.ToInt32(input);

            if (eded < 0)
            {
                Console.WriteLine("Mənfi ədəd daxil edildi, dövr dayandırılır.");
                break;
            }

            cem += eded;
        }

        Console.WriteLine("Daxil edilmiş müsbət ədədlərin cəmi: " + cem);
    }

    static void Main(string[] args)
    {
        MusbetEdedleriTopla();
    }
}*/









/*//17
using System;
using System.Collections.Generic;

class Program
{
    static void TelebeAdlariniTopla()
    {
        List<string> adlar = new List<string>();

        while (true)
        {
            Console.Write("Tələbə adı daxil edin (dayandırmaq üçün 'quit' yazın): ");
            string ad = Console.ReadLine();

            if (ad.ToLower() == "quit")
                break;

            if (!string.IsNullOrWhiteSpace(ad))
                adlar.Add(ad);
        }

        if (adlar.Count > 0)
        {
            Console.WriteLine("\nDaxil edilmiş tələbə adları:");
            foreach (string a in adlar)
            {
                Console.WriteLine(a);
            }
        }
        else
        {
            Console.WriteLine("Heç bir tələbə adı daxil edilməyib");
        }
    }

    static void Main(string[] args)
    {
        TelebeAdlariniTopla();
    }
}*/








/*//Tak1
using System;

class Product
{
    public string Ad { get; set; }
    public double Qiymet { get; set; }

    public Product(string ad, double qiymet)
    {
        Ad = ad;
        Qiymet = qiymet;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Məhsul: " + Ad);
        Console.WriteLine("Qiymət: " + Qiymet + " AZN");
    }
}

class FoodProduct : Product
{
    public DateTime SonIstifadeTarixi { get; set; }

    public FoodProduct(string ad, double qiymet, DateTime sonTarix)
        : base(ad, qiymet)
    {
        SonIstifadeTarixi = sonTarix;
    }

    public void ShowFoodInfo()
    {
        ShowInfo();
        Console.WriteLine("Son istifadə tarixi: " + SonIstifadeTarixi.ToShortDateString());
    }
}

class ElectronicProduct : Product
{
    public int ZemanetMuddeti { get; set; }

    public ElectronicProduct(string ad, double qiymet, int zemanet)
        : base(ad, qiymet)
    {
        ZemanetMuddeti = zemanet;
    }

    public void ShowElectronicInfo()
    {
        ShowInfo();
        Console.WriteLine("Zəmanət müddəti: " + ZemanetMuddeti + " ay");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FoodProduct meyvə = new FoodProduct("Alma", 1.5, new DateTime(2026, 4, 10));
        FoodProduct süd = new FoodProduct("Süd", 2.3, new DateTime(2026, 4, 5));

        Console.WriteLine("Food Products:");
        meyvə.ShowFoodInfo();
        Console.WriteLine();
        süd.ShowFoodInfo();
        Console.WriteLine();

        ElectronicProduct telefon = new ElectronicProduct("Smartfon", 1200, 24);
        ElectronicProduct televizor = new ElectronicProduct("Televizor", 1800, 36);

        Console.WriteLine("Electronic Products:");
        telefon.ShowElectronicInfo();
        Console.WriteLine();
        televizor.ShowElectronicInfo();
    }
}*/









/*//Task2
using System;

class Travel
{
    public string Destination { get; set; }
    public double Price { get; set; }

    public Travel(string destination, double price)
    {
        Destination = destination;
        Price = price;
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine("Destination: " + Destination);
        Console.WriteLine("Price: " + Price + " USD");
    }
}

class Flight : Travel
{
    public string AirlineName { get; set; }
    public string FlightTime { get; set; }

    public Flight(string destination, double price, string airline, string time)
        : base(destination, price)
    {
        AirlineName = airline;
        FlightTime = time;
    }

    public void ShowFlightInfo()
    {
        ShowDetails();
        Console.WriteLine("Airline: " + AirlineName);
        Console.WriteLine("Flight Time: " + FlightTime);
    }
}

class Hotel : Travel
{
    public string HotelName { get; set; }
    public int StarCount { get; set; }

    public Hotel(string destination, double price, string hotelName, int stars)
        : base(destination, price)
    {
        HotelName = hotelName;
        StarCount = stars;
    }

    public void ShowHotelInfo()
    {
        ShowDetails();
        Console.WriteLine("Hotel: " + HotelName);
        Console.WriteLine("Stars: " + StarCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Flight flight1 = new Flight("Paris", 350, "Air France", "10:30");
        Flight flight2 = new Flight("London", 400, "British Airways", "14:45");

        Console.WriteLine("Flights:");
        flight1.ShowFlightInfo();
        Console.WriteLine();
        flight2.ShowFlightInfo();
        Console.WriteLine();

        Hotel hotel1 = new Hotel("Paris", 200, "Le Meurice", 5);
        Hotel hotel2 = new Hotel("London", 150, "The Ritz", 4);

        Console.WriteLine("Hotels:");
        hotel1.ShowHotelInfo();
        Console.WriteLine();
        hotel2.ShowHotelInfo();
    }
}*/









/*//Task3
using System;

class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }

    public Character(string name, int health, int power)
    {
        Name = name;
        Health = health;
        Power = power;
    }

    public virtual void ShowStats()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Health: " + Health);
        Console.WriteLine("Power: " + Power);
    }
}

class Warrior : Character
{
    public string Weapon { get; set; }

    public Warrior(string name, int health, int power, string weapon)
        : base(name, health, power)
    {
        Weapon = weapon;
    }

    public void Attack()
    {
        Console.WriteLine("Döyüşçü " + Weapon + " ilə hücum edir!");
    }

    public void ShowWarriorStats()
    {
        ShowStats();
        Console.WriteLine("Weapon: " + Weapon);
    }
}

class Wizard : Character
{
    public string MagicType { get; set; }

    public Wizard(string name, int health, int power, string magicType)
        : base(name, health, power)
    {
        MagicType = magicType;
    }

    public void CastSpell()
    {
        Console.WriteLine("Sehrbaz " + MagicType + " sehr işlədir!");
    }

    public void ShowWizardStats()
    {
        ShowStats();
        Console.WriteLine("Magic Type: " + MagicType);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Warrior warrior1 = new Warrior("Aragorn", 100, 50, "Qılınc");
        Console.WriteLine("Warrior Stats:");
        warrior1.ShowWarriorStats();
        warrior1.Attack();
        Console.WriteLine();

        Wizard wizard1 = new Wizard("Gandalf", 80, 70, "İldırım");
        Console.WriteLine("Wizard Stats:");
        wizard1.ShowWizardStats();
        wizard1.CastSpell();
    }
}*/