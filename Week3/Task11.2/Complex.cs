namespace Task11._2
{
    struct Complex
    {
        public double Value;

        public static implicit operator Complex(double argument)
        {
            Complex result = new Complex();
            result.Value = argument;
            return result;
        }

        public static explicit operator double(Complex argument)
        {
            return argument.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Complex argument = (Complex)obj;
            return (Value == argument.Value);
        }

        public static bool operator ==(Complex argument1, Complex argument2)
        {
            if (argument1.Value == argument2.Value)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Complex argument1, Complex argument2)
        {
            if (argument1.Value != argument2.Value)
            {
                return true;
            }
            return false;
        }

        public static Complex operator +(Complex argument1, Complex argument2)
        {
            Complex result = new Complex();
            result.Value = argument1.Value + argument2.Value;
            return result;
        }

        public static Complex operator -(Complex argument1, Complex argument2)
        {
            Complex result = new Complex();
            result.Value = argument1.Value - argument2.Value;
            return result;
        }

        public static Complex operator *(Complex argument1, Complex argument2)
        {
            Complex result = new Complex();
            result.Value = argument1.Value * argument2.Value;
            return result;
        }

        public static Complex operator /(Complex argument1, Complex argument2)
        {
            Complex result = new Complex();
            result.Value = argument1.Value / argument2.Value;
            return result;
        }
    }
}
