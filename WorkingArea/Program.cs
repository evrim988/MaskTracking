// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Hi("Ayşe");
Hi("Elif");
Hi("Ahmet");
Hi();



int sonuc = Topla(3,5);

string[] students = new string[3];
students[0] = "Engin";
students[1] = "Ayşe";
students[2] = "Aleyna";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine("Öğrenci Adı: " + students[i]);
}

//foreach (var item in students)
//{
//    Console.WriteLine(item);
//}

static void Hi(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba: " + isim);
}

static int Topla(int sayi1,int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine(sonuc);
    return sonuc;
}

