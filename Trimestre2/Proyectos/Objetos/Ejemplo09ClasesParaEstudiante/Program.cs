namespace EjemploUsandoLasClases;

using ProyectoEstudiante;

internal class Program {
	static void Main(string[] args) {
		Estudiante j = new Estudiante("Juana JR.", 12, 1234567, 'L');
		j.Calificar("PRO", 9.99f);
		j.Calificar("LND", 5.5f);
		j.Calificar("BAE", 6.3f);
		Console.WriteLine(j);


		// Persona p = new Persona("Juana JR.", 12, 1234568, 'C');
		// Persona otro = new Persona(2, 1234568, 'C');
		// Persona p = new Estudiante("Juana JR.", 12, 1234568, 'C');
		// Persona otro = new Estudiante(2, 1234568, 'C');
		// Console.WriteLine(p);
		// Console.WriteLine(otro);
		// Console.WriteLine(p.Equals(otro));
	}
}