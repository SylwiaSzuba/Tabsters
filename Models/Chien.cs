using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    // La classe Chien hérite de la classe abstaite Animal, de ses variables prix et type ainsi que de ses fonctions. 
    public class Chien : Animal
    {
        // Constructeur de la classe Chien dont les attributs ne changent jamais. 
        // prix=100€
        // type="Chien"
        // Pour cette raison elle ne possède qu'un constructeur par défaut.
        public Chien()
        {
            this.prix = 100;
            this.type = "Chien";
        }
    }
}
