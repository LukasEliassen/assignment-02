using System.Linq;

namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void DalegatesReverseString()
    {
        Assert.Equal(".orebil atrop tare alucihev cnuN",Delegates.RevStr("Nunc vehicula erat porta libero."));
    }

    [Fact]
    public void DalegatesDecimalsProduct(){
        Assert.Equal(50,Delegates.DecPro(5,10));
    }

    [Fact]
    public void DalagatesNumericalEqual()
    {
        Assert.Equal(true,Delegates.NumEqu(42," 0042"));
    }
}
