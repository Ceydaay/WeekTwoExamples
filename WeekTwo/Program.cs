using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        /* 
         //1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?
        
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın");

        Console.WriteLine("---------------------------------------------------------");

        // 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

        int number  = 0;
        string text = "Ha bu akan dereler";
        {
            Console.WriteLine(text);
            Console.WriteLine(number);
        }

        Console.WriteLine("----------------------------------------------------------");
        

        //3 - Rastgele bir sayı üretip , ekrana yazdırınız.
        
        Random rnd = new Random();

        int randomNum = rnd.Next(0, 100);
        
            Console.WriteLine("rastgele sayınız: " + randomNum);
        
       

        //4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
        Random rnd = new Random();

        int randomNum = rnd.Next(0, 100);

        int bolumdenKalan = randomNum % 3;

        Console.WriteLine("YOUR RANDOM NUMBER: " + randomNum);
        Console.WriteLine("remainder after dividing a number by 3: " + bolumdenKalan);

        

        // 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

        Console.WriteLine("Yaşınızı giriniz");
        
        int age = Convert.ToInt32(Console.ReadLine());
        
        
            if(age < 18)
            {
             Console.WriteLine("-");
            }
            else 
            {
            Console.WriteLine("+");
            }
             
         

        // 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

        string message = "Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.";

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(message);
        }

       

        // 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz. 

        Console.WriteLine("Gülse Birsel");
        string text1 = Console.ReadLine();
        Console.WriteLine("Demet Evgar");
        string text2 = Console.ReadLine();


        Console.WriteLine("Değiştirmeden önce: Gülse Birsel " + text1 + ", Demet Evgar  " + text2);

        // Metinlerin yerlerini değiştir  
        string temp = text1;
        text1 = text2;
        text2 = temp;

        // Metinleri değiştirdikten sonra ekrana yazdır
        Console.WriteLine("Değiştirdikten sonra: Demet Evgar  " + text2 + ", Gülse Birsel  " + text1);

        


        //8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.



       static void benDegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");

        }
        benDegerDondurmem();

        

        // 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.



       

        static int Toplam (int num1, int num2)
        {
            return num1 + num2;
        }

        // static void Main değerini en başta yazdığımız için şimdi yazma gereği duymuyoruz.
        {
           int sonuc = Toplam(5, 10);

            Console.WriteLine("sonuc" + sonuc);
        }
        

        // 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.



        bool kullaniciGirisi()
        {
            return true;    // KULLANICI GİRİŞİ KONTROLÜ YAPILAN YER 
        }

        bool deger = kullaniciGirisi();

        if (deger)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        

        //  11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

       int EnYasli(int yas1, int yas2, int yas3)
        {
            int max1 = Math.Max(yas1, yas2);
          
            return Math.Max(max1, yas3);
        }
        Console.WriteLine("first person age");
        int yas1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("first person age");
        int yas2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("first person age");
        int yas3 = Convert.ToInt32(Console.ReadLine());

        int enBuyuk = EnYasli(yas1, yas2, yas3);
        Console.WriteLine("en büyük" + enBuyuk);

        
       
    
// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

/*Console.WriteLine("Birinci ismi giriniz:");
string name1 = Console.ReadLine();

Console.WriteLine("İkinci ismi giriniz:");
string name2= Console.ReadLine();

Console.WriteLine("---------İlk Durum-------");
Console.WriteLine("Birinci isim" + name1);
Console.WriteLine("İkinci isim" + name2);


DegerDegistir(ref name1, ref name2);


Console.WriteLine("---------Son Durum-------");
Console.WriteLine("Birinci isim:" + name1);
Console.WriteLine("İkinci isim:" + name2);


void DegerDegistir(ref string n1,ref string n2)
{
    string gecici = n1;
    n1 = n2;
    n2 = gecici;


}



//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

static void Main()
{
    Console.WriteLine("Sayı giriniz");
    int sayi = 0; Convert.ToInt32(Console.ReadLine());

    // Sayının çift olup olmadığını kontrol eden metodu çağır
    bool ciftMi = CiftMi(sayi);

    // Sonucu ekrana yazdır
    Console.WriteLine(ciftMi);
}
    static bool CiftMi(int sayi)
    {
        if (sayi % 2 == 0)

            return true;
       
    else return false;
       

}*

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.WriteLine("Hızınızı Giriniz");
int speed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Gittiğiniz Zaman Giriniz");
int time = Convert.ToInt32(Console.ReadLine());

int gidilenYol = GidilenYol(speed, time);
Console.WriteLine("Gittiğiniz Yol: " + gidilenYol + " km");

int GidilenYol(int h1, int t1)
{
    return h1 * t1; 
} 


//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

Console.WriteLine("Dairenin yarıçapını giriniz: ");
int yariCap = Convert.ToInt32(Console.ReadLine());

double alanHesabi = Alan(yariCap);
Console.WriteLine("Dairenizin alanı:" + alanHesabi);

double Alan(int x) 
    {
    double pi = Math.PI;
    return Math.Pow(x, 2) * pi;
   
}*/

//17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string cumle = "Zaman bir GeRi SayIm";

string buyukHarf = cumle.ToUpper();
string kucukHarf = cumle.ToLower();

Console.WriteLine("Büyük Harf:" + buyukHarf);
Console.WriteLine("Küçük Harf:" + kucukHarf);


//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string cumle = "    Selamlar   ";

cumle = cumle.Trim();

Console.WriteLine("Düzenlenmiş Metin:" + cumle);




    }


}