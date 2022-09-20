namespace Assignment2;

public delegate string ReverseString(string str);
public delegate Decimal DecimalProduct(Decimal a, Decimal b);
public delegate bool NumericalEqual(int num, string str);

public static class Delegates
{
    public static ReverseString RevStr = delegate(string str) {
        return string.Join("",str.Reverse());
    };

    public static DecimalProduct DecPro = delegate(Decimal a, Decimal b) {
        return Decimal.Multiply(a,b);
    };

    public static NumericalEqual NumEqu = delegate(int num, string str){
        return Int32.Parse(str).Equals(num);
    };
}
