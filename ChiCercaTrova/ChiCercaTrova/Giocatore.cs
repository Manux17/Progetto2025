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
            mazzo.AddRange(carte); // Aggiunge le carte ricevute alla lista Mazzo
        }

        // Metodo per mostrare le carte attualmente nel mazzo del giocatore
        public void MostraCarte()
        {
            Console.WriteLine("Carte: " + string.Join(", ", mazzo)); // Stampa tutte le carte del giocatore separate da virgola
        }

        // Metodo per giocare le carte  
        public bool GiocaCarta(int cartaAvv, List<int> carteGiocate)
        {
            if (cartaAvv == 0)
            {
                carteGiocate.Add(mazzo[0]);
                mazzo.RemoveAt(0);
            }
            else if (cartaAvv == 1)
            {
                carteGiocate.Add(mazzo[0]);
                int primaCarta = mazzo[0];
                mazzo.RemoveAt(0);

                if (primaCarta != 1 && primaCarta != 2 && primaCarta != 3)
                {
                    return true;
                }
            }
            else if (cartaAvv == 2)
            {
                // Gioca la prima carta
                carteGiocate.Add(mazzo[0]);
                int primaCarta = mazzo[0];
                mazzo.RemoveAt(0);

                // Se la prima carta NON è 1, 2 o 3, gioca anche la seconda
                if (primaCarta != 1 && primaCarta != 2 && primaCarta != 3)
                {
                    carteGiocate.Add(mazzo[0]);
                    int secondaCarta = mazzo[0];
                    mazzo.RemoveAt(0);

                    if (secondaCarta != 1 && secondaCarta != 2 && secondaCarta != 3)
                    {
                        return true;
                    }
                }
            }
            else if (cartaAvv == 3)
            {
                // Gioca la prima carta
                carteGiocate.Add(mazzo[0]);
                int primaCarta = mazzo[0];
                mazzo.RemoveAt(0);

                // Se la prima carta NON è 1, 2 o 3, procedi
                if (primaCarta != 1 && primaCarta != 2 && primaCarta != 3)
                {
                    // Gioca la seconda
                    carteGiocate.Add(mazzo[0]);
                    int secondaCarta = mazzo[0];
                    mazzo.RemoveAt(0);

                    // Se anche la seconda NON è 1, 2 o 3, gioca la terza
                    if (secondaCarta != 1 && secondaCarta != 2 && secondaCarta != 3)
                    {
                        carteGiocate.Add(mazzo[0]);
                        int terzaCarta = mazzo[0];
                        mazzo.RemoveAt(0);

                        // Se anche la seconda NON è 1, 2 o 3, gioca la terza
                        if (terzaCarta != 1 && terzaCarta != 2 && terzaCarta != 3)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public bool ControllaEGioca(List<int> carteGiocate)
        {
            int ultimaCarta;

            if (carteGiocate.Count > 0)
            {
                ultimaCarta = carteGiocate[carteGiocate.Count - 1]; // Prendi l'ultima carta
            }
            else
            {
                ultimaCarta = 0;
            }

            return GiocaCarta(ultimaCarta, carteGiocate);  // Gioca in base a quella
        }


    }
}