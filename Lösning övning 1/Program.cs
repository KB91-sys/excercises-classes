using System;

namespace Gitrepo_Övningar_Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1

            //Skapa en klass för ditt favoritdjur. Skapa klassmedlemmar (både variabler & metoder) som du tycker är lämpliga. T.ex. kan djuret innehålla 
            //de publika variablerna name, race och age samt de publika metoderna Bark() & Fetch(). Skapa sedan ett testobjekt till klassen.

            bool meny = true;
            Katt minKatt = new Katt();
            
            minKatt.namn = "Bruno";
            minKatt.ras = "Bondkatt";
            minKatt.ålder = 3;
            
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
