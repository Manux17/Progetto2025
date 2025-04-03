using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiCercaTrova
{
    class Giocatore
    {
        // Lista che rappresenta il mazzo personale del giocatore
        public List<int> Mazzo = new List<int>();

        // Metodo per aggiungere una o più carte al mazzo del giocatore
        public void PrendiCarte(List<int> carte)
        {
            Mazzo.AddRange(carte); // Aggiunge le carte ricevute alla lista Mazzo
        }

        // Metodo per mostrare le carte attualmente nel mazzo del giocatore
        public void MostraCarte()
        {
            Console.WriteLine("Carte: " + string.Join(", ", Mazzo)); // Stampa tutte le carte del giocatore separate da virgola
        }

    }
}
