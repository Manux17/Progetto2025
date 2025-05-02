using System;
using System.Collections.Generic;

namespace ChiCercaTrova
{
    class Giocatore
    {
        // Lista che rappresenta il mazzo personale del giocatore
        public List<int> mazzo = new List<int>();

        // Metodo per aggiungere una o più carte al mazzo del giocatore
        public void PrendiCarte(List<int> carte)
        {
            // Aggiungo tutte le carte vinte al fondo del mazzo 
            foreach (int carta in carte)
            {
                mazzo.Add(carta);
            }
            carte.Clear();
        }
        // Metodo per mostrare le carte attualmente nel mazzo del giocatore
        public void MostraCarte()
        {
            Console.WriteLine("Carte: " + string.Join(", ", mazzo)); // Stampa tutte le carte del giocatore separate da virgola
        }

        // Gioca fino a max n carte, fermandosi se incontra una carta speciale (1,2,3)
        // Ritorna true se l'avversario deve raccogliere tutte le carte giocate
        // Metodo per giocare le carte  
        public bool GiocaCarte(int carteDaGiocare, List<int> carteGiocate)
        {
            if(carteDaGiocare == -1)
            {
                int carta = mazzo[0];
                mazzo.RemoveAt(0);
                carteGiocate.Add(carta);
                return false;
            }
            else
            {
                for (int i = 0; i < carteDaGiocare && mazzo.Count > 0; i++)
                {
                    int carta = mazzo[0];
                    mazzo.RemoveAt(0);
                    carteGiocate.Add(carta);

                    // Se la carta è una penitenza (1,2,3), interrompo e passaggio turno
                    if (carta == 1 || carta == 2 || carta == 3)
                    {
                        return false;
                    }
                }
                // Se arrivo qui, ho giocato tutte le carte richieste senza trovare penitenza
                return true;
            }
            
        }

        public bool ControllaEGioca(List<int> carteGiocate)
        {
            int ultimaCarta;

            if (carteGiocate.Count > 0)
            {
                // Prendo l'ultima carta giocata
                ultimaCarta = carteGiocate[carteGiocate.Count - 1];
            }
            else
            {
                // Nessuna carta giocata: consideriamo 0
                ultimaCarta = 0;
            }

            // Determino quante carte giocare
            int carteDaGiocare;
            if (ultimaCarta >= 1 && ultimaCarta <= 3)
            {
                carteDaGiocare = ultimaCarta;
            }
            else
            {
                carteDaGiocare = -1;
            }

            // Chiamo il metodo di gioco con il numero calcolato
            return GiocaCarte(carteDaGiocare, carteGiocate);
        }
    }
}
