namespace ProyectoEstudiante;

public class Calificacion {
	public String Asignatura { get; }
	public float Nota { get; }

	public Calificacion(String _asignatura, float _nota) {
		if (_nota < 0 || _nota > 10)
			throw new ArgumentException("Calificación no válida");
		Asignatura = _asignatura;
		Nota = _nota;
	}

	public override string ToString() {
		return $" * {Asignatura} ({Nota})";
	}
}