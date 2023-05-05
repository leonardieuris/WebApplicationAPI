namespace WebApplicationAPI.CalculatorModule
{
    public class Adder : ICalculator
    {
        public int Calculate(int x, int y) => x + y;

    }
}
