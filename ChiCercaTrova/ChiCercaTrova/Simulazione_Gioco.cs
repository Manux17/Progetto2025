using System;
using System.Collections.Generic;

namespace ChiCercaTrova
{
    class Simulazione_Gioco
    {
        // Metodo che distribuisce le carte ai due giocatori
        public void Dai_Carte(Giocatore g1, Giocatore g2)
        {
            // Creazione del mazzo di carte con valori predefiniti
            List<int> mazzo = new List<int> { 1, 1, 2, 2, 3, 3, 0, 0, 0, 0 };

            Random r = new Random();

            int dimensione = mazzo.Count;
            int i;

            // Ciclo per assegnare le carte a ciascun giocatore
            for (int k = 0; k < dimensione / 2; k++)
            {
                // Estrazione casuale di una carta per il primo giocatore
                i = r.Next(mazzo.Count);
                g1.PrendiCarte(new List<int> { mazzo[i] });
                mazzo.RemoveAt(i);

                // Estrazione casuale di una carta per il secondo giocatore
                i = r.Next(mazzo.Count);
                g2.PrendiCarte(new List<int> { mazzo[i] });
                mazzo.RemoveAt(i);
            }
        }
        public void GiocaPartita(Giocatore g1, Giocatore g2)
        {
            List<int> carte_Giocate = new List<int>(); 

            while (g1.mazzo.Count > 0 && g2.mazzo.Count > 0)
            {
                if (g1.ControllaEGioca(carte_Giocate))
                {
                    g2.PrendiCarte(carte_Giocate);
                    carte_Giocate.Clear();
                }
                if (g2.ControllaEGioca(carte_Giocate))
                {
                    g1.PrendiCarte(carte_Giocate);
                    carte_Giocate.Clear();

                }
            }

            if (g1.mazzo.Count == 0)
            {
                Console.WriteLine("Ha vinto il giocatore 2");
            }
            else
            {
                Console.WriteLine("Ha vinto il giocatore 1");

            }
        }
    }
}