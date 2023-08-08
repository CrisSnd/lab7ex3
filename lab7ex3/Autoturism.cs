using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab7ex3
{
    internal class Autoturism
    {

        private static void InregistreazaAutoturism(Autoturism autoturism)
        {
            NrTotalAutoturisme++;

            if (VehiculPutereMaxima == null || autoturism.motor.Putere > VehiculPutereMaxima.motor.Putere)
            {
                VehiculPutereMaxima = autoturism;
            }
        }


        public static int NrTotalAutoturisme
        {
            get; private set;
        }


        public static Autoturism VehiculPutereMaxima
        {
            get; private set;
        }


        private readonly string marca;
        private readonly string model;
        private readonly int anFabricatie;
        private readonly Motor motor;




        public Autoturism(string marca, string model, int anFabricatie, Motor moto, int nrUsi)
        {
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.motor = moto;


            //Atribuire parametrii catre metoda
            InregistreazaAutoturism(this);
        }




        public string Description
        {
            get
            {
                return $"{marca}, {model}, {anFabricatie}, {motor.CapacitateCilindrica}, {motor.Putere}, {motor.Combustibil}";
            }


        }
    }
}


