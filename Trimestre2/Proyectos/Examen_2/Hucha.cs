public class Hucha {
	private decimal saldo;
	private List<Movimiento> movimientos = new List<Movimiento>();

	// public Hucha() : this(10) {
	// }
	public Hucha() {
		saldo = 10;
	}

	public Hucha(decimal cantidadInicial) {
		if (cantidadInicial < 0) {
			throw new Exception("La cantidad inicial no puede ser negativa.");
		}
		saldo = cantidadInicial;
	}

	public void Añadir(decimal cantidad) {
		if (cantidad < 0) {
			RegistrarMovimiento("Operación anulada por valor negativo", -cantidad, saldo);
		} else {
			saldo += cantidad;
			RegistrarMovimiento("Añadido", cantidad, saldo);
		}
	}

	public void Sacar(decimal cantidad) {
		if (cantidad < 0) {
			RegistrarMovimiento("Operación anulada por valor negativo ", -cantidad, saldo);
		} else if (cantidad > saldo) {
			RegistrarMovimiento("Operación anulada por saldo insuficiente ", cantidad, saldo);
		} else {
			saldo -= cantidad;
			RegistrarMovimiento("Sacado", cantidad, saldo);
		}
	}

	public void Vaciar() {
		RegistrarMovimiento("Vaciado", saldo, 0);
		saldo = 0;
	}

	public decimal Saldo() {
		return saldo;
	}

	public override string ToString() {
		string s = "";
		foreach (Movimiento m in movimientos)
			s += m + "\n";
		return s + $"--->  [Ahorrado: {saldo}]";
	}
	public override bool Equals(object? obj) {
		if (obj == null || obj.GetType() != GetType())
			return false;
		Hucha h = (Hucha)obj;
		return saldo == h.saldo;
	}
	public override int GetHashCode() {
		return saldo.GetHashCode();
	}

	private void RegistrarMovimiento(string tipo, decimal cantidad, decimal saldoResultante) {
		movimientos.Add(new Movimiento(tipo, cantidad, saldoResultante));
	}
}
