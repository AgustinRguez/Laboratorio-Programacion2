﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Cliente CCliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                bool respuesta = this + value;
            }
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if(c == item)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                n.caja.Atender(n.CCliente);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ClientePendiente
        {
            get
            {
                return this.clientes.Count();
            }
        }
    }
}
