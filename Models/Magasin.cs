using System;
using System.Collections.Generic;

namespace Models
{
    // La classe Magasin sert à la gestion informatique de l'animalerie.
    public class Magasin
    {
        private List<Animal> animaux; // Définit une liste d'instances "Animal" appartenant à l'instance crée.
        private float tresorerie; // Définit la trésorerie disponible dans l'instance crée.

        // Constructeur par défaut avec une liste d'animaux vide et une trésorerie définie à 1000€. 
        public Magasin()
        {
            this.animaux = new List<Animal>();
            this.tresorerie = 1000;
        }

        // Constructeur pour un liste d'animaux définie dont on peut utiliserla trésorerie par défaut
        // ou adapter à son magasin. 
        public Magasin(List<Animal> animaux, float tresorerie = 1000)
        {
            this.animaux = animaux;
            this.tresorerie = tresorerie;
        }

        // Propriétés get de animaux et tresorerie
        public List<Animal> Animaux
        {
            get { return animaux; }
        }

        public float Tresorerie
        {
            get { return tresorerie; }
        }

        // Méthode qui permet d'ajouter un animal (en paramètre) à la liste d'animaux déjà présents.
        // Elle vérifie que l'animal ne fait pas déjà partie du magasin. 
        // Si c'est le cas elle retourne true et l'ajoute,
        // Sinon elle retourne false et émét un message de prévention.
        public bool AjouterAnimal(Animal animal)
        {
            bool ajout= false;
            if ( !animaux.Contains(animal))
            {
                animaux.Add(animal);
                ajout = true;
            }
            else
            {
                Console.WriteLine("Cet animal est déja disponible dans le magasin! Nous ne pouvons pas l'ajouter.");
            }
            return ajout;
        }

        // Méthode qui permet de supprimer un animal (en paramètre) de la liste d'animaux du magasin.
        // Elle vérifie que l'animal fait partie du magasin. 
        // Si c'est le cas elle retourne true et le supprime,
        // Sinon elle retourne false et émet un message de prévention.
        public bool SupprimerAnimal(Animal animal)
        {
            bool suppression = false;
            if (animaux.Contains(animal))
            {
                animaux.Remove(animal);
                suppression = true;
            }
            else
            {
                Console.WriteLine("Cet animal n'est pas disponible dans le magasin.");
            }
            return suppression;
        }

        // Méthode qui permet d'acheter un animal (en paramètre) par le Magasin.
        // Elle utilise la méthode AjouterAnimal(Animal animal) qui permet de vérifier que l'animal ne fait pas déjà partie du magasin.
        // Si c'est le cas, elle peut alors soustraire le prix de l'animal à la trésorerie. 
        // Ne retourne aucune valeur. 
        public void AchatAnimal(Animal animal)
        {
            bool verificationAjout= AjouterAnimal(animal);
            if (verificationAjout)
            {
                tresorerie -= animal.Prix;
            }
        }
        
        // Méthode qui permet l'achat l'une liste d'animaux (en paramètre) par le Magasin. 
        // Pour chaque animal dans la listeAnimaux elle utilise la méthode AchatAnimal(animal).
        // Ne retourne aucune valeur. 
        public void AchatAnimaux(List<Animal> listeAnimaux)
        {
            foreach (Animal animal in listeAnimaux)
            {
                AchatAnimal(animal);
            }
        }

        // Méthode qui permet de vendre un animal (en paramètre) par le Magasin.
        // Elle utilise la méthode SupprimerAnimal(Animal animal) qui permet de vérifier que l'animal fait partie du magasin.
        // Si c'est le cas, elle peut alors ajouter le prix de l'animal à la trésorerie. 
        // Ne retourne aucune valeur.
        public void VendreAnimal(Animal animal)
        {
            bool verificationSuppression = SupprimerAnimal(animal);
            if (verificationSuppression)
            {
                tresorerie += animal.Prix;
            }
        }

        // Méthode qui permet la vente d'une liste d'animaux (en paramètre) par le Magasin. 
        // Pour chaque animal dans la listeAnimaux elle utilise la méthode VendreAnimal(animal).
        // Ne retourne aucune valeur. 
        public void VendreAnimaux(List<Animal> listeAnimaux)
        {
            foreach(Animal animal in listeAnimaux)
            {
                VendreAnimal(animal);
            }
        }

        // Surcharge de la méthode ToString() pour la classe Magasin.
        // Elle permet d'afficher la liste d'animaux présents dans l'animalerie, puis l'état de trésorerie. 
        public override string ToString()
        {
            string retour = "\nLes animaux disponibles dans le magasin sont :\n";
            foreach(Animal animal in animaux)
            {
                retour = retour+ animal.ToString()+"\n";
            }
            retour += "\nTrésorerie actuelle : " + tresorerie+"\n";

            return retour;
        }
    }
}
