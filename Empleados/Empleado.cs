using System;
using System.Collections.Generic;

namespace Empleados
{
    internal class Empleado
    {
        // Variables miembro de la clase Empleado.
        private string nombre;
        private int numeroEmpleado;
        private decimal salario;
        private bool activo; // Estado del empleado (activo o inactivo).

        // Constructor para inicializar un empleado con estado activo por defecto.
        public Empleado(string nombre, int numeroEmpleado, decimal salario)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
            this.activo = true; // Estado activo por defecto
        }

        // Constructor adicional para permitir especificar el estado del empleado.
        public Empleado(string nombre, int numeroEmpleado, decimal salario, bool activo)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
            this.activo = activo;
        }

        // Método para mostrar los detalles del empleado.
        public void MostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, número de empleado: {numeroEmpleado}, Salario: {salario:C}, Estado: {estado}");
        }

        // Método para obtener el número de empleado.
        public int ObtenerNumeroEmpleado()
        {
            return this.numeroEmpleado;
        }

        // Método para cambiar el estado del empleado.
        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true; // Activar empleado
                Console.WriteLine("Empleado activo.");
            }
            else if (nuevoEstado == 0)
            {
                activo = false; // Desactivar empleado
                Console.WriteLine("Empleado desactivado.");
            }
            else
            {
                Console.WriteLine("Estado no válido.");
            }
        }
        // Método para aumentar el salario en un porcentaje dado.
        public void AumentarSalario(decimal porcentaje)
        {
            salario += salario * (porcentaje / 100);
            Console.WriteLine($"El salario de {nombre} ha sido aumentado en un {porcentaje}%");
        }  
    }
}
