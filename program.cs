using System;
using System.ComponentModel.Design;
using System.Globalization;

class Merhab
{
    static void KAZANÇ()// Aldığı puan sistemini buraya gelerek burdan bir mesaj atmasını sağladım.
    {
        if (puan == 5)
        {
            int c = rastgele.Next(1, 5);
            if (c == 5) { Console.WriteLine("B12 seviyen Everest gibi zirvede! Sana vitamin değil, başarı belgesi vermek lazım! "); }
            else if (c == 4) { Console.WriteLine("B12 seviyen uzay istasyonuna sinyal gönderiyor olmalı, bu kadar yüksek enerjiyle resmen füze gibisin!"); }
            else if (c == 3) { Console.WriteLine("5 puan! Bu kadar yüksek bir puan, senin ne kadar çalışkan ve zeki olduğunu gösteriyor."); }
            else if (c == 2) { Console.WriteLine("5 puanla bu işi bitirdin! Artık başarıda bir çıta daha yükseldin, seni kutlarım!"); }
            else { Console.WriteLine("5 puan alarak bir kez daha gösterdin ki, senin için engel diye bir şey yok! Mükemmel bir iş çıkardın!"); }
        }
        else if (puan == 4) { Console.WriteLine("LAN SEN YAPIYON HA BU SPORU"); }
        else if (puan == 3) { Console.WriteLine("VAY MÜKELMELDİN ARKADAŞ"); }
        else if (puan == 2) { Console.WriteLine("OYNADIĞINIZ İÇİN TEŞEKÜRLER BAY/BAYAN"); }
        else if (puan == 1) { Console.WriteLine("OYUNU CİDDİYE ALMAYA NE DERSİN?"); }
        else
        {
            int c = rastgele.Next(1, 5);
            if (c == 5) { Console.WriteLine("Vay arkadaş, B12 seviyen sıfırmış! Resmen vitamini bile yoklamış, 'yoklama kaçağı' çıkmış! "); }
            else if (c == 4) { Console.WriteLine("Senin B12'yi bulamadık, kayıp ilanı mı versek? 'En son sinir sisteminde görüldü' diye yazalım mı?"); }
            else if (c == 3) { Console.WriteLine("B12 seviyen öyle bir sıfır ki, rakam bile kendini boşa harcamış! Biri şarj kablosunu taksın, bu vitami nerede?"); }
            else if (c == 2) { Console.WriteLine("Senin B12 öyle eksik ki, vitaminler aralarında toplantı yapmış, 'Arkadaşımızı kaybettik, lütfen saygı duruşuna geçelim' demişler!"); }
            else { Console.WriteLine("0 hiçliği temsil eder biliyorsun DEĞİL Mİ?"); }
        }
    }
    static string[] hatalar = new string[5];//Kullanıcın girdiği doğruları ve yanlışları burada kaydettim.
    static ConsoleColor ilk = ConsoleColor.Black;
    static void not() { Console.ForegroundColor = ConsoleColor.Red; Console.Write("NOT: "); }
    static void Enter()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("<ENTER> Tuşuna basınız");
        Console.ForegroundColor = ilk;
        Console.ReadLine();

        Console.Clear();
    }
    static void Rand()//Sayıları rastgele çarpmak için 5 değişken belirledim.
    {
        seçimyeri = rastgele.Next(0, x);
        seçimyeri1 = rastgele.Next(0, x);
        seçimyeri2 = rastgele.Next(0, y);
        seçimyeri3 = rastgele.Next(0, y);
        seçimyeri4 = rastgele.Next(0, z);
        seçimyeri5 = rastgele.Next(0, z);


    }
    //alt kısım her yerden ulaşmam gerekn değerleri yazdım.
    static string isim;
    static Random rastgele = new Random();
    static int seçimyeri1, seçimyeri, seçimyeri2, seçimyeri3, seçimyeri4, seçimyeri5;
    static int x, y, z, sayı, i, tsayı = 0, puan, Gsayı, h;

    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\t\t\t\tBAKALIM HAYAL GÜCÜN NASIL?");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("\nİLK BAŞTA İSMİNİ ÖGRENMEK iSTERİM:\t");
        Console.ForegroundColor = ConsoleColor.Blue;
        string kop = Console.ReadLine();
        isim = kop.ToUpper();
        Console.Clear();
        while (true)// Başlanma yerini burda düzenledim.Dönğüye sokarak hata düzeltmesi yaptım.
        {
            Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"\n\nHANGİ DÜZEYDEN BAŞLAYALIM {isim}:");
        Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n1.Düzey:Tek boyutta tahmin edebilecek misin?"); Console.BackgroundColor = ConsoleColor.Green; Console.Write("\t\t\t\t\t\t\t\t\t "); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("KOLAY");
        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\n2.boyut:Kare düşüne bilir misin?"); Console.BackgroundColor = ConsoleColor.DarkYellow; Console.Write("\t\t\t\t\t\t\t\t\t\t "); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("ORTA");
        Console.ForegroundColor = ConsoleColor.Red; Console.Write("\n3.Boyut:KÜP."); Console.BackgroundColor = ConsoleColor.Red; Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t "); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("ZOR\n\n");





    
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("DÜZEY:");
            Console.ForegroundColor = ConsoleColor.Red;
            string seçim = Console.ReadLine();


            switch (seçim)
            {
                case "1": { tekboyut(); break; }
                case "2": { IkinciBoyut(); break; }
                case "3": { UcBoyut(); break; }
                case "bir": { tekboyut(); break; }
                case "iki": { IkinciBoyut(); break; }
                case "uc": { UcBoyut(); break; }
                case "birinci": { tekboyut(); break; }
                case "ikinci": { IkinciBoyut(); break; }
                case "ucuncu": { UcBoyut(); break; }
                case "tek boyut": { tekboyut(); break; }
                case "iki boyut": { IkinciBoyut(); break; }
                case "uc boyut": { UcBoyut(); break; }
                default: { Console.WriteLine("LÜTFEN SEÇENEKLERDEN BİRİNİ GİRİNİZ"); Thread.Sleep(1350); Console.Clear(); break; }
            }
        }
        Console.ReadKey();





    }
    static void tekboyut()
    {
        Console.Clear();
        Console.WriteLine($"\t\t\t\tTEK BOYUT BÖLMÜNE HOŞ GELDİN\n\n{isim} başlamadan önce kaç sayı gireceksin?");
        x = int.Parse(Console.ReadLine());
        int[] tekboyut = new int[x];
        Console.WriteLine("Şimdi o sayıları girmeni istiyorum.");
        not();
        Console.ForegroundColor = ilk;
        Console.WriteLine("Bu sayıları aklınızda tutmanız gerekecek unutmayınız.");
        Enter();

        for (i = 0; i < x; i++)//Burda sayıları sadece (y) ekseni için istedim.
        {
            Console.Write($"{i + 1}.sayınızı giriniz:");
            tekboyut[i] = int.Parse(Console.ReadLine());
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Bunları unutmaman gerek son defa bak! ");
        Console.ForegroundColor = ilk;
        Enter();

        Console.Clear();


        for (i = 0; i < 5; i++)//Burda hem kullanıcıdan veri istedim ve aynı şekilde burda çarpma yönlendirdim.(PUAN KISMIDA DAHİL)
        {
            Rand();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{seçimyeri + 1}.sayın ile {seçimyeri1 + 1}.sayının çarpımı?");
            Console.ForegroundColor = ilk;
            tsayı = int.Parse(Console.ReadLine());
            if (tsayı == (tekboyut[seçimyeri] * tekboyut[seçimyeri1])) { puan++; Gsayı++; hatalar[i] = "+"; }
            else { Gsayı++; hatalar[i] = "-"; }


            Console.Clear();


            // Kullanıcıdan aldığım sayıları burada derledim. En son buraya giriyor ve tekrar başlamasını saplamaya yönledirilecek.
            if (Gsayı == 5) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("DENEME HAKKINIZ BİTTİ"); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write($"Oynadığınız için teşekürler "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"{isim}"); foreach (string i in hatalar) { Console.WriteLine($"{h + 1}.Sorunuz:{i}"); h++; } Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine($"Puan:{puan}"); not(); KAZANÇ(); break; }

        }

    }
    static void IkinciBoyut()
    {

        Console.Clear();
        Console.WriteLine($"\t\t\t\tIKI BOYUT BÖLMÜNE HOŞ GELDİN\n\n{isim} başlamadan kaç sütun ve satır olacak?");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("SATIR:");
        Console.ForegroundColor = ConsoleColor.Red;
        x = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("SÜTUN:");
        Console.ForegroundColor = ConsoleColor.Red;
        y = int.Parse(Console.ReadLine());
        int[,] IkinciBoy = new int[y, x];
        Console.Clear();
        Console.ForegroundColor = ilk;
        Console.WriteLine("Şimdi senden sırayla sayıları isteyecegim umarım hazırsındır?");
        not();
        Console.ForegroundColor = ilk;
        Console.WriteLine("Bu sayıları aklınızda tutmanız gerekecek unutmayınız.");
        Enter();
        for (int i = 0; i < x; i++)//Kullanıcıdan değer aldım. Bunları (x,y) şekilinde aldım.
        {
            for (int j = 0; j < y; j++)
            {
                Console.WriteLine($"Lütfen {i + 1}.Satıra yazılacak {j + 1}.sayıları giriniz");
                IkinciBoy[j, i] = int.Parse(Console.ReadLine());
            }
        }
        Console.Clear();
        for (int i = 0; i < x; i++)//Bunları ekrana yazdırdım gözüktüğü şekil.
        {
            for (int j = 0; j < y; j++)
            { Console.Write($"|  {IkinciBoy[j, i]}  |"); }
            Console.WriteLine("\n");
        }
        Console.WriteLine("\n"); Console.WriteLine("Bu şuanki fisktür umarım unutmazsın.");
        Enter();
        Console.Clear();
        for (int i = 0; i < 5; i++)//Burda hem kullanıcıdan veri istedim ve aynı şekilde burda çarpma yönlendirdim.(PUAN KISMIDA DAHİL)
        {
            Rand();
            Console.WriteLine($"{seçimyeri + 1},{seçimyeri2 + 1} ile {seçimyeri1 + 1},{seçimyeri3 + 1} çarpımı?");
            tsayı = int.Parse(Console.ReadLine());
            if (tsayı == (IkinciBoy[seçimyeri2, seçimyeri] * IkinciBoy[seçimyeri3, seçimyeri1])) { puan++; Gsayı++; hatalar[i] = "+"; }
            else { Gsayı++; hatalar[i] = "-"; }


            Console.Clear();


            // Kullanıcıdan aldığım sayıları burada derledim. En son buraya giriyor ve tekrar başlamasını saplamaya yönledirilecek.
            if (Gsayı == 5) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("DENEME HAKKINIZ BİTTİ"); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write($"Oynadığınız için teşekürler "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"{isim}"); foreach (string a in hatalar) { Console.WriteLine($"{h + 1}.Sorunuz:{a}"); h++; } Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine($"Puan:{puan}"); not(); KAZANÇ(); break; }


        }

    }
    static void UcBoyut() 
    {
        Console.Clear();
        Console.WriteLine($"\t\t\t\tÜÇ BOYUT BÖLMÜNE HOŞ GELDİN\n\n{isim} başlamadan kaç sütun ve satır olacak?");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("SATIR:");
        Console.ForegroundColor = ConsoleColor.Red;
        x = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("SÜTUN:");
        Console.ForegroundColor = ConsoleColor.Red;
        y = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("DERİNLİK:");
        Console.ForegroundColor = ConsoleColor.Red;
        z = int.Parse(Console.ReadLine());
        int[,,] UcBoy = new int[z, y, x];
        Console.Clear();
        Console.ForegroundColor = ilk;
        Console.WriteLine("Şimdi senden sırayla sayıları isteyecegim umarım hazırsındır?");
        not();
        Console.ForegroundColor = ilk;
        Console.WriteLine("Bu sayıları aklınızda tutmanız gerekecek unutmayınız.");
        Enter();
        for (int i = 0; i < x; i++)  //Sayıları istedim. Bunları (x,y,z) şeklinde istedim.
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    Console.WriteLine($"Lütfen {i + 1}.Derinliğindeki {j + 1}.Satıra {k + 1}.Sayıyı giriniz");
                    UcBoy[k, j, i] = int.Parse(Console.ReadLine());
                }
            }
        }
        Console.Clear();
        for (int i = 0; i < x; i++) //aldığım sayıları ekrana yazdırttım.
        {
            Console.WriteLine($"{i + 1}.DERİNLİK");
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    Console.Write($"|  {UcBoy[k, j, i]}  |");


                }

                Console.WriteLine("\n");
            }
        }
        Console.WriteLine("\n"); Console.WriteLine("Bu şuanki fisktür, umarım unutmazsın.");
        Enter();
        Console.Clear();
        for (int i = 0; i < 5; i++)//Burda hem kullanıcıdan veri istedim ve aynı şekilde burda çarpma yönlendirdim.(PUAN KISMIDA DAHİL)
        {
            Rand();
            Console.WriteLine($"{seçimyeri + 1},{seçimyeri2 + 1},{seçimyeri4 + 1} ile {seçimyeri1 + 1},{seçimyeri3 + 1},{seçimyeri5} çarpımı?");
            tsayı = int.Parse(Console.ReadLine());
            if (tsayı == (UcBoy[seçimyeri4, seçimyeri2, seçimyeri] * UcBoy[seçimyeri5, seçimyeri3, seçimyeri1])) { puan++; Gsayı++; hatalar[i] = "+"; }
            else { Gsayı++; hatalar[i] = "-"; }


            Console.Clear();



            // Kullanıcıdan aldığım sayıları burada derledim. En son buraya giriyor ve tekrar başlamasını saplamaya yönledirilecek.
            if (Gsayı == 5) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("DENEME HAKKINIZ BİTTİ"); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write($"Oynadığınız için teşekürler "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"{isim}"); foreach (string a in hatalar) { Console.WriteLine($"{h + 1}.Sorunuz:{a}"); h++; } Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine($"Puan:{puan}"); not(); KAZANÇ(); break; }




        }
    }
}
    

