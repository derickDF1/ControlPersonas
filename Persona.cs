using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonas
{
    class Persona
    {
        //String S mayuscula Trae varias funciones con el punto
        //string s minuscula  solo es para declarar variable
        //Campos y Propiedades
        //Campos, Privasdos para cumplir con el encapsulado
        String dpi;
        String nombre;
        String apellido;
        DateTime fechaNacimiento;
        int otroDato;

        //Encapsulado
        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int OtroDato { get => otroDato; set => otroDato = value; }

        //Constructor de la clase:
        //Código que se ejecuta al crearse un objeto de esta clase
        //Por ejemplo inicializar variables
        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            fechaNacimiento = DateTime.Now;
        }


        //Métodos: Acciones que se realizan
        public void InicialMayus ()
        {
            if (nombre.Length > 0)
            {
                StringBuilder nombreMasyucula = new StringBuilder(nombre);
                nombreMasyucula[0] = char.ToUpper(nombreMasyucula[0]);
                nombre = nombreMasyucula.ToString();
            }

            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();
            }
        }

        public string normalizaNombre()
        {
            
            return "hola";
        }

        public int edad()
        {
            int edad = 0;
            //Calcular edad
            int mesNacimiento = fechaNacimiento.Month;
            int añoNacimiento = fechaNacimiento.Year;
            int diaNacimiento = fechaNacimiento.Day;

            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year;
            int diaActual = DateTime.Now.Day;

            if (mesActual > mesNacimiento)
            {
                edad = (añoActual - añoNacimiento);
                
            }
            else if ((mesActual >= mesNacimiento)&&(diaActual >= diaNacimiento))
            {
                edad = (añoActual - añoNacimiento);
            }
            else
            {
                edad = (añoActual - añoNacimiento) - 1;
            }
            return edad;
        }


        //Propiedades
        //get  obtiene el valor 
        //a = DPI;

        // set cuando se le asigna un valor 


    }
}
