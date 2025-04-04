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
        public List<int> mazzo = new List<int>();

        // Metodo per aggiungere una o più carte al mazzo del giocatore
        public void PrendiCarte(List<int> carte)
        {
            mazzo.AddRange(carte); // Aggiunge le carte ricevute alla lista Mazzo
        }

        // Metodo per mostrare le carte attualmente nel mazzo del giocatore
        public void MostraCarte()
        {
            Console.WriteLine("Carte: " + string.Join(", ", mazzo)); // Stampa tutte le carte del giocatore separate da virgola
        }

        public List<int> GiocaCarta(int cartaAvv)
        {
            List<int> carteGiocate = new List<int>();  // Lista per memorizzare le carte giocate

            if (cartaAvv == 0 || cartaAvv == 1)
            {
                // Se l'avversario gioca la carta 0 o 1, prendi una carta dal mazzo
                carteGiocate.Add(mazzo[0]);
                mazzo.RemoveAt(0);  // Rimuovi la carta dal mazzo
            }
            else if (cartaAvv == 2)
            {
                // Se l'avversario gioca la carta 2, prendi due carte dal mazzo
                carteGiocate.Add(mazzo[0]);
                mazzo.RemoveAt(0);
                carteGiocate.Add(mazzo[0]);
                mazzo.RemoveAt(0);
            }
            else if (cartaAvv == 3)
            {
                // Se l'avversario gioca la carta 3, prendi tre carte dal mazzo
                carteGiocate.Add(mazzo[0]);
                mazzo.RemoveAt(0);
                carteGiocate.Add(mazzo[0]);
                mazzo.RemoveAt(0);
                carteGiocate.Add(mazzo[0]);
                mazzo.RemoveAt(0);
            }

            // Altrimenti, non succede nulla (nessuna carta viene giocata)
            return carteGiocate;  // Restituisci la lista di carte giocate
        }
        


    }
}
