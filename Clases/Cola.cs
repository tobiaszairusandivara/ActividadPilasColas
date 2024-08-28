using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PilasColasApp.Interfaces;

namespace PilasColasApp.Clases
{
    public class Cola : IColeccion
    {
        private List<Object> array;
        private int next;
        public Cola()
        {
            array = new List<Object>();
            next = array.Count;
        }

        public List<Object> Array { get { return array; }  set { this.array = value; } }
        public int Next { get { return next; } set { this.Next = value; } }

        public bool Añadir(object elemento)
        {
            try
            {
                array.Add(elemento);
                next = array.Count;
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool EstaVacia()
        {
            if (array.Count == 0)
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
                elemento = array[0];
                for (int i = 0; i < next - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array.RemoveAt(next - 1);
            }
            return elemento;
        }

        public object? Primero()
        {
            object? elemento = null;
            if (!EstaVacia())
            {
                elemento = array[0];
            }
            return elemento;
        }
    }
}
