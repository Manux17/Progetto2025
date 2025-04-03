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

            Random r = new Random(); // Generatore di numeri casuali

            // Ciclo per assegnare 5 carte a ciascun giocatore
            for (int k = 0; k < 5; k++)
            {
                // Estrazione casuale di una carta per il primo giocatore
                int i = r.Next(mazzo.Count); // Genera un indice casuale valido
                g1.PrendiCarte(new List<int> { mazzo[i] }); // Assegna la carta al giocatore 1
                mazzo.RemoveAt(i); // Rimuove la carta assegnata dal mazzo

                // Estrazione casuale di una carta per il secondo giocatore
                i = r.Next(mazzo.Count); // Genera un nuovo indice casuale
                g2.PrendiCarte(new List<int> { mazzo[i] }); // Assegna la carta al giocatore 2
                mazzo.RemoveAt(i); // Rimuove la carta assegnata dal mazzo
            }
        }
    }
}
