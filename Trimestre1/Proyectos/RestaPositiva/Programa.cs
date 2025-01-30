//using System;
public class Resta_Positiva {
	public static void Main(string[] args) {
		int numero2, numero1;
        int resultado;

		Console.Write("Num: ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Num: ");
		numero2 = Convert.ToInt32(Console.ReadLine());
		if (numero1 >= numero2)
			resultado = numero1 - numero2;
		else
			resultado = numero2 - numero1;
		Console.WriteLine(resultado);

	}
}
