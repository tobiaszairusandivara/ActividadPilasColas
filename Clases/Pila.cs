using PilasColasApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasApp.Clases
{
    public class Pila : IColeccion
    {
        private object[] array;
        public Pila()
        {
            array = new object[0];
        }

        public bool Añadir(object elemento)
        {
            try
            {
                array = array.Concat((new object[1] { elemento })).ToArray();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EstaVacia()
        {
            if (array.Length == 0)
            {
                return true;
            }
            return false;
        }

        public object? Extraer()
        {
            object? elemento = null;
            if (!EstaVacia())
            {
                elemento = array[array.Length -1];
                object[] arrayTemporal = new object[0];
                for (int i = 0; i < array.Length -1; i++)
                {
                    if (array[i] != null)
                    {
                        arrayTemporal = arrayTemporal.Concat(new object[1] { array[i] }).ToArray();
                    }
                }
                array = arrayTemporal;
            }
            return elemento;
        }

        public object? Primero()
        {
            object? elemento = null;
            if (!EstaVacia())
            {
                elemento = array[array.Length - 1];
            }
            return elemento;
        }
    }
}
