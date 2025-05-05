using System;
using System.Collections.Generic;

namespace ChiCercaTrova
{
    class Simulazione_Gioco
    {
        // Metodo che distribuisce le carte ai due giocatori
        public void Dai_Carte(Giocatore g1, Giocatore g2)
        {
            List<int> mazzo = new List<int> { 1, 1, 2, 2, 3, 3, 0, 0, 0, 0 };
            Random r = new Random();
            while (mazzo.Count > 0)
            {
                int idx = r.Next(mazzo.Count);
                g1.PrendiCarte(new List<int> { mazzo[idx] });
                mazzo.RemoveAt(idx);

                idx = r.Next(mazzo.Count);
                g2.PrendiCarte(new List<int> { mazzo[idx] });
                mazzo.RemoveAt(idx);
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
                }

                if(g2.mazzo.Count > 0)
                {
                    if (g2.ControllaEGioca(carte_Giocate))
                    {
                        g1.PrendiCarte(carte_Giocate);
                    }
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