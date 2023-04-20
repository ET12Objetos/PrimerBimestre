using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploObjetos
{
    public class BanquitoComputacion
    {
        //atributos (variables)
        string material;

        int cantidadPatas;

        string color;

        //comportamiento (métodos)
        public BanquitoComputacion(string unMaterial, int cantidadPatas, string color)
        {
            this.color = color;
            material = unMaterial;
            if (cantidadPatas < 0)
            {
                throw new Exception("La cantidad de patas es erronea");
            }
            else
                this.cantidadPatas = cantidadPatas;
        }

        public void Informar()
        {
            Console.WriteLine($"El color del banquito es: {color}, patas en {cantidadPatas}");
        }

        public void Pintar(string nuevoColor)
        {
            this.color = nuevoColor;
        }
    }
}