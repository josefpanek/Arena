using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    /// <summary>
    /// Třída reprezentuje hrací kostku
    /// </summary>
    class Kostka
    {
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random random;
        /// <summary>
        /// Počet stěn kostky
        /// </summary>
        private int pocetSten;
        public override string ToString()
        {
            return String.Format("Kostka s {0} stěnami", pocetSten);
        }
        /// <summary>
        /// Vykoná hod kostkou
        /// </summary>
        /// <returns>Číslo od 1 do počtu stěn</returns>
        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }
        /// <summary>
        /// Vykoná hod kostkou
        /// </summary>
        /// <returns>Číslo od 1 do počtu stěn</returns>
        public Kostka(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
        }
        /// <summary>
        /// Vrátí počet stěn hrací kostky
        /// </summary>
        /// <returns>počet stěn hrací kostky</returns>
        public int VratPocetSten()
        {
            return pocetSten;
        }
        /// <summary>
        /// Vykoná hod kostkou
        /// </summary>
        /// <returns>Číslo od 1 do počtu stěn</returns>
        public int Hod()
        {
            return random.Next(1, pocetSten + 1);
        }
    }
}