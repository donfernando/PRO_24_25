namespace ProyectoEstudiante;

public class Persona {
	public string Nombre { get; }
	public int Edad { get; }

	protected DNI _dni;

	public String Dni {
		get{
			return _dni.ToString();
		}
	}
	// public DNI Dni {
	// 	get{
	// 		return _dni;
	// 	}
	// }

	public Persona(int e, long nDni, char lDni):this("Desconocido",e,nDni,lDni) { }

	public Persona(string n, int e, long nDni, char lDni) {
		this._dni = new DNI(nDni, lDni);
		this.Nombre = n;
		this.Edad = e;
	}

	public override bool Equals(object? obj) {
		if (obj == null || GetType() != obj.GetType())
			return false;
		Persona otraPersona = (Persona)obj;
		return _dni.Equals(otraPersona._dni);
	}
	public override int GetHashCode() {
		return _dni.GetHashCode();
	}
	public override string ToString() {
		return $"> {Nombre}[{_dni.nDni}-{_dni.lDni}] ({Edad} años.)";
	}
}