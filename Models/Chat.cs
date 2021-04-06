using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    // La classe Chat hérite de la classe abstaite Animal, de ses variables prix et type ainsi que de ses fonctions. 
    public class Chat:Animal
    {
        // Constructeur de la classe Chat dont les attributs ne changent jamais. 
        // prix=110€
        // type="Chat"
        // Pour cette raison elle ne possède qu'un constructeur par défaut.
        public Chat()
        {
            this.prix = 110;
            this.type = "Chat";
        }
    }
}
