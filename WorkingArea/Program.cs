// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Human humans = new Human();

humans.Name = "Evrim";


#region Değiskenler


string mesaj = "Merhaba";
double tutar = 1000000;
int sayi = 100;
bool isLogin = false;

Console.WriteLine("Sonuç: " + tutar * 1.18);

Console.WriteLine(mesaj);

Console.WriteLine("Kullanıcı Giriş Yaptı Mı: " + isLogin); 
#endregion


public class Human
{
    [DisplayName("Ad")]
    public string Name { get; set; }
    [DisplayName("Soyad")]
    public string SurName { get; set; }

    [DisplayName("Doğum Tarihi")]
    public int BirthdayDate { get; set; }

    [DisplayName("Tc Kimlik Numarası")]
    public long TCNumber { get; set; }

}
