using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabotnik rabotnik = new Rabotnik();                   
            double z= rabotnik.Zarplata();
            Console.WriteLine(z);
            Console.WriteLine(rabotnik.GetInfo());

            rabotnik.SetStavka(600.0);
            rabotnik.SetDni(17);
            z = rabotnik.Zarplata();
            Console.WriteLine(z);
            Console.WriteLine(rabotnik.GetInfo());

            Rabotnik r2 = new Rabotnik("Misha", "Babaev", 5000,30);             
            Console.WriteLine(r2.Zarplata());
            Console.WriteLine(r2.GetInfo());
            

            Console.ReadKey();


        }
        class Rabotnik
        {
             string name;
             string surname;
             double stavka;
             int dni;
             double zarplata;
            public Rabotnik()
            {
                name = "Alexander";
                surname = "Dolgopolov";
                stavka = 500;
                dni = 24;
            }
            public Rabotnik(string n,string sn,double st,int d)
            {
                name = n;
                surname = sn;
                stavka = st;
                dni = d;
            }
            public string GetInfo()
            {

                string s = string.Format("Имя: {0}  Фамилия: {1} Ставка:{2} Дни:{3} Зарплата:{4}", name, surname, stavka, dni, zarplata);
                return s;
            }
            public double Zarplata()
            {
                zarplata = stavka * dni;
                return zarplata;
            }
            public void SetName(string n)
            {
                name = n;

            }
            public void SetStavka(double st)
            {
                stavka = st;

            }
            public void SetDni(int d)
            {
                dni = d;

            }
        }
    }
}
