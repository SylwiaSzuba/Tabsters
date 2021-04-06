using Models;
using System;
using System.Collections.Generic;

namespace Tabsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Création des instances animaux.");
            Chien chien = new Chien();
            Chien chien1 = new Chien();
            Chat chat = new Chat();
            Chat chat1 = new Chat();

            Console.WriteLine("Création du magasin et ajout des animaux.");
            List<Animal> animaux = new List<Animal>() { chien, chien1, chat };
            Magasin magasin = new Magasin(animaux);   

            Console.WriteLine(magasin);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Achat d'un animal (un chat).");
            magasin.AchatAnimal(chat1);
            Console.WriteLine(magasin);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Achat de plusieurs animaux.");
            Chien chien2 = new Chien();
            animaux = new List<Animal>() { chien, chien2 };
            magasin.AchatAnimaux(animaux);

            Console.WriteLine(magasin);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Vente d'un animal qui n'est pas dans la liste.");
            magasin.VendreAnimal(new Chat());

            Console.WriteLine(magasin);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Vente du premier chien dans la liste du magasin.");
            Animal animal = magasin.Animaux.Find(x => x.Type.Equals("Chien"));
            magasin.VendreAnimal(animal);

            Console.WriteLine(magasin);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Vente d'une liste d'animaux (dont le premier vient d'être vendu).");
            magasin.VendreAnimaux(animaux);

            Console.WriteLine(magasin);
        }
    }
}
