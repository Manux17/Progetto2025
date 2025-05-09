using System;
using System.Collections.Generic;

namespace ChiCercaTrova
{
    class Program
    {
        static void Main(string[] args)
        {
            Giocatore giocatore1 = new Giocatore();
            Giocatore giocatore2 = new Giocatore();
            Simulazione_Gioco gioco = new Simulazione_Gioco();
            
            //gioco.Dai_Carte(giocatore1, giocatore2);


            //partita infinita
            giocatore1.mazzo = new List<int> { 0, 0, 3, 0, 2, 0, 2, 0, 3, 0, 3, 1, 0, 0, 0, 0, 0, 3, 1, 0 };
            giocatore2.mazzo = new List<int> { 0, 0, 1, 0, 0, 2, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 1, 0 };

            Console.WriteLine("Carte Giocatore 1:");
            giocatore1.MostraCarte();

            Console.WriteLine("Carte Giocatore 2:");
            giocatore2.MostraCarte();

            gioco.GiocaPartita(giocatore1, giocatore2);

            Console.WriteLine("Carte Giocatore 1:");
            giocatore1.MostraCarte();

            Console.WriteLine("Carte Giocatore 2:");
            giocatore2.MostraCarte();
        }
    }
}
