using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_5
{
    /// <summary>
    /// Futbol porra baten informazioa gordetzen duen klasea.
    /// </summary>
    class Porra
    {
        private string izena, irabazlea, finalista, goleatzailea;
        private int puntuak;

        /// <summary>
        /// Parte-hartzailearen edo taldearen izena lortu edo ezartzen du.
        /// </summary>
        public string Izena { get => izena; set => izena = value; }

        /// <summary>
        /// Irabazlea lortu edo ezartzen du.
        /// </summary>
        public string Irabazlea { get => irabazlea; set => irabazlea = value; }

        /// <summary>
        /// Finalista lortu edo ezartzen du.
        /// </summary>
        public string Finalista { get => finalista; set => finalista = value; }

        /// <summary>
        /// Goleatzaile nagusia lortu edo ezartzen du.
        /// </summary>
        public string Goleatzailea { get => goleatzailea; set => goleatzailea = value; }

        /// <summary>
        /// Puntuak lortu edo ezartzen ditu.
        /// </summary>
        public int Puntuak { get => puntuak; set => puntuak = value; }

        /// <summary>
        /// Porra objektu berri bat sortzen du.
        /// </summary>
        /// <param name="i">Parte-hartzailearen izena</param>
        /// <param name="ir">Irabazlea</param>
        /// <param name="fi">Finalista</param>
        /// <param name="go">Goleatzailea</param>
        /// <param name="p">Hasierako puntuak</param>
        public Porra(string i, string ir, string fi, string go, int p)
        {
            this.izena = i;
            this.irabazlea = ir;
            this.finalista = fi;
            this.goleatzailea = go;
            this.puntuak = p;
        }

        /// <summary>
        /// Porra datuak testu moduan pantailaratzeko erabiltzen da.
        /// </summary>
        /// <returns>Porra-ren informazioa string formatuan</returns>
        public string Pantailaratu()
        {
            return "TALDEA=" + izena + ", bere IRABAZLEA=" + irabazlea + ", beste FINALISTA=" + finalista + ", GOLEATZAILEA=" + goleatzailea + " eta PUNTUAK=" + puntuak;
        }

        /// <summary>
        /// Objektuaren testu errepresentazioa bueltatzen du.
        /// </summary>
        /// <returns>Porra-ren datuak string batean</returns>
        public override string ToString()
        {
            return izena + "-" + irabazlea + "-" + finalista + "-" + goleatzailea + "-" + puntuak;
        }

        /// <summary>
        /// Irabazlea asmatu bada puntuak gehitzen ditu.
        /// </summary>
        /// <returns>Puntu berriak</returns>
        public int AsmatuIrabazlea()
        {
            return (puntuak + 25);
        }

        /// <summary>
        /// Bi finalistak asmatu badira puntuak gehitzen ditu.
        /// </summary>
        /// <returns>Puntu berriak</returns>
        public int AsmatuBiFinalistak()
        {
            return (puntuak + 20);
        }

        /// <summary>
        /// Goleatzailea asmatu bada puntuak gehitzen ditu.
        /// </summary>
        /// <returns>Puntu berriak</returns>
        public int Goleko()
        {
            return (puntuak + 3);
        }
    }
}