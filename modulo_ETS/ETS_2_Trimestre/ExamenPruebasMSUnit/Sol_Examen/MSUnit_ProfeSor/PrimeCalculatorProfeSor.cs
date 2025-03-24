namespace MSUnit_ProfeSor;

public class PrimeCalculatorProfeSor {
	public static bool IsPrime(int number) {
		bool r = number >= 2;
		for (int i = 2; i * i <= number; i++)
			if (number % i == 0) r = false;
		return r;
	}
}
