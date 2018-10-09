using System;
using Xunit;

namespace katasolving.test
{
    public class SolversTest
    {
        [Theory]
        [InlineData(93, 1, 22, "5D0116")]
        [InlineData(107, 67, 3, "6B4303")]
        [InlineData(0, 0, 0, "000000")]
        [InlineData(255, 255, 255, "FFFFFF")]
        public void RGBToHexTest(int r, int g, int b, string expected)
        {
            //Arrange
            Solvers solver = new Solvers();

            //Act
            string actual = solver.RGBToHex(r, g, b);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, "Even")]
        [InlineData(87, "Odd")]
        [InlineData(0, "Even")]
        public void EvenOrOddTest(int number, string expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            string actual = solvers.EvenOrOdd(number);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("hello, could you help me? I need about tree fiddy?", true)]
        [InlineData("ppjjpigsdjpgsdjpsgjpigsjpjpsjpshjpjprehgspirhgphsjgejjgspinpbisnprgj;wsejpgihsp", false)]
        public void IsLockNessMonsterTest(string sentance, bool expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            bool actual = solvers.IsLockNessMonster(sentance);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(20, 10, 10)]
        [InlineData(10, 10, 0)]
        [InlineData(50, 100, 0)]
        public void CombatTest(int health, int damage, float expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            float actual = solvers.Combat(health, damage);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(16,2,"Underweight")]
        public void BmiTest(double weight,double height,string expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            string actual = solvers.Bmi(weight, height);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0,2,3)]
        [InlineData(0,10,55)]
        public void GetSumTest(int a,int b,int expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            int actual = solvers.GetSum(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("This is a test", "test a is This")]
        public void ReverseWordsTest(string str, string expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            string actual = solvers.ReverseWords(str);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10,1,true)]
        [InlineData(13,7,false)]
        [InlineData(144,12,true)]
        public void IsDivisibleTest(int wallLength,int pixelSize,bool expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            bool actual = solvers.IsDivisible(wallLength, pixelSize);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(153, true)]
        [InlineData(12, false)]
        [InlineData(1634, true)]
        [InlineData(9999, false)]
        public void NarcissisticTest(int value, bool expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            bool actual = solvers.Narcissistic(value);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("hello world")]
        public void GreetTest(string expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            string actual = solvers.Greet();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10, 23)]
        public void SolutionTest(int value, int expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            int actual = solvers.Solution(value);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4,2)]
        [InlineData(1,0)]
        public void NthFib(int n,int expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            int actual = solvers.NthFib(n);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3,0.66,1.5,3)]
        [InlineData(3,1,1.5,-1)]
        public void BouncingBallTest(double h, double bounce, double window, double expected)
        {
            //Arrange
            Solvers solvers = new Solvers();

            //Act
            int actual = solvers.BouncingBall(h, bounce, window);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
