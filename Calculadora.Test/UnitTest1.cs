namespace Calculadora.Test
{
    public class UnitTest1
    {
        //Fact
        //Se utiliza para definir un método de prueba que verifica un hecho específico, no se utilizan datos externos en el método de prueba.

        [Fact]
        public void CalculatorSum()
        {
            var s1 = 10;
            var s2 = 20;


            int expected = Calculadora.Calculator.Suma(s1,s2);

            Assert.Equal(30, expected);


        }
        //Theory
        //Se utiliza para definir un método de prueba que se ejecutará múltiples veces con diferentes conjuntos de datos (datos de entrada).

        [Theory]
        [InlineData(10,5,5)]
        public void CalculatorRes(int r1,int r2,int expected)
        {


            int result = Calculadora.Calculator.Resta(r1, r2);

            Assert.Equal(expected, result);


        }



        [Theory]
        [InlineData(5,5,25)]

        public void CalcutorMult(int m1,int m2,int expected)
        {
            int result = Calculadora.Calculator.Multipliacion(m1,m2);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(100,5,20)]

        public void CalculatorDiv(double d1,double d2,int expected)
        {
            double result = Calculadora.Calculator.Division(d1,d2);


             Assert.Equal(expected, result);

        }
    }
}