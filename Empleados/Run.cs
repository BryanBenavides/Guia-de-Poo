using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class Run
    {
        static void Main()
        {
            Console.WriteLine("Aplicación de Gestión de Empleados");

            // Crear una lista para almacenar empleados.
            List<Empleado> listaEmpleado = new List<Empleado>();

            // Agregar empleados de ejemplo a la lista.
            listaEmpleado.Add(new Empleado("Juan", 101, 30000));
            listaEmpleado.Add(new Empleado("María", 102, 35000));
            listaEmpleado.Add(new Empleado("Pedro", 103, 32000, false)); // Empleado inactivo

            // Mostrar los detalles de cada empleado en la lista.
            foreach (var empleado in listaEmpleado)
            {
                empleado.MostrarDetalles();
            }

            // Cambiar el estado de un empleado por su número de empleado.
            int numeroEmpleadoCambiarEstado = 103;
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleado, numeroEmpleadoCambiarEstado);

            if (empleadoCambiarEstado != null)
            {
                // Cambiar el estado a activo (1) o inactivo (0).
                empleadoCambiarEstado.CambiarEstado(1);
                empleadoCambiarEstado.MostrarDetalles();
            }
            else
            {
                Console.WriteLine($"Empleado con número {numeroEmpleadoCambiarEstado} no encontrado");
            }

            // Aumentar el salario de un empleado por su número de empleado.
            int numeroEmpleadoAumentarSalario = 102;
            Empleado empleadoAumentarSalario = BuscarEmpleado(listaEmpleado, numeroEmpleadoAumentarSalario);

            if (empleadoAumentarSalario != null)
            {
                // Aumentar el salario en un 10%.
                empleadoAumentarSalario.AumentarSalario(10);
                empleadoAumentarSalario.MostrarDetalles();
            }
            else
            {
                Console.WriteLine($"Empleado con número {numeroEmpleadoAumentarSalario} no encontrado");
            }
        }

        // Método para buscar un empleado por su número de empleado.
        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
        {
            foreach (var empleado in empleados)
            {
                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {
                    return empleado;
                }
            }
            return null;
        }
    }
}