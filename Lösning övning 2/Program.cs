using System;

namespace Gitrepo_Övningar_Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1 - del 2

            //Gör om så att variablerna i din djur-klass är osynliga, private. De skall istället göras om till egenskaper (get & set).
            // Använd egenskaperna i ett testobjekt.

            bool meny = true;
            Katt minKatt = new Katt();
            
            //minKatt.namn = "Bruno";
            //minKatt.ras = "Bondkatt";
            //minKatt.ålder = 3;


            minKatt.Namn = "Bruno";
            minKatt.Ras = "Bondkatt";
            minKatt.Ålder = 3;

            

            System.Console.WriteLine("Information om katten: \nNamn: " + minKatt.Namn +  "\nÅlder: " + minKatt.Ålder + "\nRas: " + minKatt.Ras);
            System.Console.WriteLine("Skriv in vad katten ska göra: \"skälla\" eller \"apport\"");
            string svar = Console.ReadLine();


            while(meny == true){
                if(svar == "skälla"){
                    minKatt.Skälla();
                    meny = false;
                }
                else if(svar == "apport"){
                    minKatt.Apport();
                    meny = false;
                }


            }
            
            

        }
    }
}
