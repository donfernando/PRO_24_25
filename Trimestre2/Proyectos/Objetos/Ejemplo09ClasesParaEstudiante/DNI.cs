namespace ProyectoEstudiante;
    public class DNI {
        public long nDni { get; }
        public char lDni { get; }

        public DNI(long num, char l) {
            char lValida = LetraValida(num);
            l = Char.ToUpper(l);
			if (l != lValida)
                throw new Exception($"Dni incorrecto. Letra esperada: {lValida}");
            nDni = num;
            lDni = l;
        }
        private static char LetraValida(long n)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int pos = (int)(n % 23);
            return letras[pos];
        }
		public override string ToString() {
			return $"{nDni}{lDni}";
		}

		public override bool Equals(object? obj) {
			if (obj == null || GetType() != obj.GetType())
				return false;
			DNI otro = (DNI)obj;
			return nDni == otro.nDni;
		}
        public override int GetHashCode() {
            return nDni.GetHashCode();
        }
	}

