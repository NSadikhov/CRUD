using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>() {"Ulvi","Metanet","Nicat","Seadet","Cavid"};  
            void Login()
            {
                Console.Write("Username: ");
                var username = Console.ReadLine();
                Console.Write("Password: ");
                var password = Console.ReadLine();
                if (username == "sadikhov" && password == "12345")
                {
                    Giris();
                }
                else
                {
                    Console.WriteLine("Girdiyiniz username ve ya password yanlisdir");
                    Login();
                }                
            }
            Login();
            void Giris()
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1-Melumati elave et");
                Console.WriteLine("2-Melumati gor");
                Console.WriteLine("3-Melumati deyisdir");
                Console.WriteLine("4-Melumati sil");
                Console.WriteLine("---------------------------------------");
                var reqem = Console.ReadLine();
                if (reqem =="")
                {
                    Giris();
                }
                switch (reqem)
                {
                    case "1":
                        Elave_et();
                        break;
                    case "2":
                        Gor();
                        break;
                    case "3":
                        Deyisdir();
                        break;
                    case "4":
                        Sil();
                        break;
                    default:
                        Console.WriteLine("Girdiyiniz deyer yanlisdir / Girise yonlendirildi...");
                        Giris();
                        break;
                }
            } 
            void Elave_et()
            {
                Console.Write("Melumati daxil edin: ");
                var melumat = Console.ReadLine();
                liste.Add(melumat);
                Giris();
            }
            void Gor()
            {
                var say = 0;
                foreach (var goster in liste)
                {
                    say++;
                    Console.WriteLine(say+"-"+goster);
                }
                Giris();
            }
            void Deyisdir()
            {
                var say = 0;
                foreach (var goster in liste)
                {
                    say++;
                    Console.WriteLine(say + "-" + goster);
                }              
                Console.WriteLine("Deyismek istediyiniz melumatin nomresini daxil edin: ");
                var deyis = Convert.ToInt32(Console.ReadLine());
                if (deyis <= liste.Count && deyis>0)
                {
                    Console.Write("Yeni melumati daxil edin: ");
                    var yeni_deyer = Console.ReadLine();
                    liste[deyis - 1] = yeni_deyer;
                    Giris();
                }
                else
                {
                    Console.WriteLine("Girdiyiniz deyer yanlisdir / Girise yonlendirildi...");
                    Giris();
                }
            }
            void Sil()
            {
                var say = 0;
                foreach (var goster in liste)
                {
                    say++;
                    Console.WriteLine(say + "-" + goster);
                }
                Console.WriteLine("Silmek istediyiniz melumatin nomresini daxil edin: ");
                var reqem = Convert.ToInt32(Console.ReadLine());
                if (reqem <= liste.Count && reqem > 0)
                {
                    liste.Remove(liste[reqem - 1]);
                    Giris();
                }
                else
                {
                    Console.WriteLine("Girdiyiniz deyer yanlisdir / Girise yonlendirildi...");
                    Giris();
                }
            }            
        }
    }
}
