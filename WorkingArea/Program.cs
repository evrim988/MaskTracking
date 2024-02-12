// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
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

students = new string[4];
students[3] = "Emre";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine("Öğrenci Adı: " + students[i]);
}

//foreach (var item in students)
//{
//    Console.WriteLine(item);
//}

string[] city1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] city2 = new[] { "Bursa", "Edirne", "Kırklareli" };

//foreach (string item in city1)
//{
//    Console.WriteLine(item);
//}


List<string> newCity1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
newCity1.Add("İzmir");
foreach (var item in newCity1)
{
    Console.WriteLine(item);
}



city2 = city1;
city1[0] = "Adana";
//Console.WriteLine(city2[0]);

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;

//Console.WriteLine(sayi2);
Person person = new Person();
person.FirstName = "Evrim";
person.LastName = "Çalışkan";
person.NationalIdentity = 31102248786;
person.DateOfBirthdate = 1998;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);


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

