﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*Si vogliono confrontare 5 diversi modelli di tablet. Le caratteristiche dei tablet utili per la soluzione di questo
problema sono: la marca, la velocità (espressa in GHz), la dimensione dello schermo (espresso in pollici) e la
durata della batteria (espressa in mAh, milliampere-ora). Ogni caratteristica viene codificata come un attributo
privato della classe. I valori di questi attributi vengono letti con il metodo leggiDati e vengono visualizzati con
il metodo stampaDati. A ogni modello viene assegnato un punteggio nel seguente modo: per la velocità del
processore vengono assegnati 10 punti per ogni GHz, per la dimensione dello schermo è assegnato un punto
per ogni pollice, per la durata della batteria è assegnato un punto per ogni migliaio di mAh. Dopo aver inserito i
dati dei 5 modelli, calcola il punteggio medio assegnato ai tablet e mostra i dati del tablet e di quello peggiore.
Il punteggio viene calcolato con il metodo punteggio.*/

namespace Rota_Thomas___6___Esercitazione_Tablet
{
    public class Tablet
    {
        private string _marca;
        private double _velocita;
        private int _dimensione;
        private int _durataBatteria;

        public Tablet()
        {
            _marca = string.Empty;
            _velocita = 0;
            _dimensione = 0;
            _durataBatteria = 0;
        }
        public Tablet(string m, double vel, int dim, int batteryCapacity)
        {
            _marca = m;
            _velocita = vel;
            _dimensione = dim;
            _durataBatteria = batteryCapacity;
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public double Velocita
        {
            get { return _velocita; }
            set { _velocita = value; }
        }
        public int Dimensione
        {
            get { return _dimensione; }
            set { _dimensione = value; }
        }
        public int DurataBatteria
        {
            get { return _durataBatteria; }
            set { _durataBatteria = value; }
        }
        public int[] Punteggio(Tablet[] t)
        {
            int[] p = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {

            }
            return p;
        }
        public string StampaDati(Tablet[] t)
        {
            string vis = string.Empty;
            for (int i = 0; i < t.Length; i++)
                vis += $"{t[i].Marca}; {t[i].Velocita} GHz; {t[i].Dimensione} pollici; {t[i].DurataBatteria} mAh; Punteggio\n";
            return vis;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int dim = 5;
            Tablet[] t = new Tablet[dim];
            for (int i = 0; i < dim; i++)
            {
                Console.Write($"Inserire la marca del {i+1} tablet: ");
                string brand = Console.ReadLine();

                Console.Write($"Inserire cognome la velocità del {i+1} tablet in GHz: ");
                double spd = double.Parse(Console.ReadLine());

                Console.Write($"Inserire la dimensione del {i+1} tablet in pollici: ");
                int dms = int.Parse(Console.ReadLine());

                Console.Write($"Inserire la durata della batteria del {i+1} tablet in mAh: ");
                int battery = int.Parse(Console.ReadLine());

                t[i] = new Tablet(brand, spd, dms, battery);
                Console.Clear();
            }
            Console.Clear();

            Console.WriteLine("Tablets:");
            Console.WriteLine(t[0].StampaDati(t));
        }
    }
}
