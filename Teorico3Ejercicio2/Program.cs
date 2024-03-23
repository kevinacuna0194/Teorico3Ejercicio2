namespace Teorico3Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Una liga amateur de fútbol nos contrata para diseñar su sistema de gestión
             * A los organizadores de la liga le interesa registrar partidos entre equipos. **/

            // Ejemplo de uso
            Equipo equipo1 = new Equipo("Equipo A", "Departamento A");
            Equipo equipo2 = new Equipo("Equipo B", "Departamento B");

            Partido partido1 = new Partido(equipo1, equipo2, DateTime.Now, 2, 1);

            // Mostrar el resultado del partido en consola
            partido1.MostrarResultado();
        }
    }
}
