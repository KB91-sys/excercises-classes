using System;

namespace Gitrepo_Övningar_Klasser
{

    public class Katt{

        public string namn;
        public string ras;
        public int ålder;

        public void Skälla(){
            Console.Write("En katt kan ej skälla!");
            
        }
        public void Apport(){
            Console.Write("Katten " + namn + " säger: " + "Jag orkar inte. Det blir för mycket.");
        
        }


    }



}