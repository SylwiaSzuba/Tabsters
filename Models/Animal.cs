using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    // La classe abstraite Animal sert de modèle aux classes Chien et Chat.  
    // Elle est également utilisée dans la classe Magasin pour déterminer les animaux qui s'y trouvent.

    public abstract class Animal
    {
        protected float prix; //Définit le prix d'achat et de vente d'un animal dans l'animalerie.
        protected string type; //Définit le type d'animal (Chien/Chat)

        // Getter de prix
        public float Prix
        {
            get { return prix; }
        }

        // Getter de type
        public string Type
        {
            get { return type; }
        }

        // Surcharge de la méthode ToString() pour la classe Animal.
        // Elle permettra un meilleur affichage des animaux présents dans l'animalerie. 
        // Retourne le type de l'instance animale sous forme "Animal: typeDeLAnimal"
        public override string ToString()
        {
            return "Animal: " + type;
        }
    }
}
