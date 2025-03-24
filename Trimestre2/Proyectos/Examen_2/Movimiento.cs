public class Movimiento {
	private string Tipo;
	private decimal Cantidad;
	private decimal SaldoResultante;

	public Movimiento(string tipo, decimal cantidad, decimal saldoResultante) {
		if (cantidad < 0 || saldoResultante < 0)
			throw new Exception("Solo se admiten cantidades positivas");
		Tipo = tipo;
		Cantidad = cantidad;
		SaldoResultante = saldoResultante;
	}

	public override string ToString() {
		return $"{Tipo}: {Cantidad} (Saldo: {SaldoResultante})";
	}
}