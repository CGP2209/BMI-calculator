using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Udregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");

            string navn = Console.ReadLine();

            Console.WriteLine("Indtast din højde");

            double højde = Convert.ToDouble(Console.ReadLine());
            højde = højde / 100;

            Console.WriteLine("Indtast din vægt");

            double vægt = Convert.ToDouble(Console.ReadLine());

            Double BMI = (vægt / (højde * højde));

            Console.WriteLine("Navn: " + navn);
            Console.WriteLine("Højde: " +højde);
            Console.WriteLine("Vægt; " + vægt);
            Console.WriteLine("Din BMI er " + BMI);

            if (BMI < 18.5)
                Console.WriteLine("Du er undervægtig");
            else if (BMI < 24.9)
                Console.WriteLine("du er normalvægtig");
            else if (BMI < 30.0)
                Console.WriteLine("Du er overvægtig");
            else
                Console.WriteLine("du er svært overvægtig");

            Console.WriteLine("\ndone");

            Console.ReadLine();


        }
    }
}
