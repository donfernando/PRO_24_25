namespace ProyectoEstudiante;

public class Estudiante : Persona, IComparable<Estudiante>
{
	private List<Calificacion> calificaciones = new List<Calificacion>();

	public Estudiante(int e, long nDni, char lDni) : this("Anónimo", e, nDni, lDni) { }
	//public Estudiante(int e, long nDni, char lDni):base(e,nDni,lDni) { }

	public static List<Estudiante> FiltraAprobados(List<Estudiante> l)
	{
		int i;
		List<Estudiante> listaFinal = new List<Estudiante>();
		foreach (Estudiante e in l) {
			//if (TodoAprobado(e))
			if (e.TodoAprobado())
					listaFinal.Add(e);
		}
		return listaFinal;
	}

	public static bool TodoAprobado(Estudiante e) {
		bool resul=false;
		if (e.calificaciones.Count != 0) {
			i = 0;
			while (i < e.calificaciones.Count && e.calificaciones[i].Nota >= 5)
				i++;
			if (i == e.calificaciones.Count)
				resul=true;
		}
		return resul;
	}
	public bool TodoAprobado() {
		bool resul=false;
		if (calificaciones.Count != 0) {
			i = 0;
			while (i < calificaciones.Count && calificaciones[i].Nota >= 5)
				i++;
			if (i == calificaciones.Count)
				resul=true;
		}
		return resul;
	}



	public void Calificar(String asignatura, float nota)
	{
		calificaciones.Add(new Calificacion(asignatura, nota));

		/*
		Crear nueva Calificacion
		busqueda lineal:
		 - Mientras queden datos en la lista "calificaciones" y
		   la nueva nota sea <= que la nota de la actual calificacion de la lista, 
		       pasar  a la siguiente calificacion de la lista     (i++)
		 - Si encontre una calificación en la lista menor que la nueva,
		      insertar en su posicion la calificacion nueva
		   SINO
		      añadirla al final

		*/
	}

	public float NotaMedia()
	{
		float tot = 0;
		float media;
		if (calificaciones.Count != 0)
		{
			foreach (Calificacion c in calificaciones)
			{
				tot += c.Nota;
			}
			media = tot / calificaciones.Count;
		}
		else
			media = -1;
		return media;
	}

	public int CompareTo(Estudiante? otro)
	{
		if (otro == null)
			return 1;
		return NotaMedia().CompareTo(otro.NotaMedia());
	}


	public override string ToString()
	{
		String s = "Alumno: \n" + base.ToString();
		foreach (Calificacion c in calificaciones)
		{
			s += "\n  " + c;
		}
		return s;
	}
}
