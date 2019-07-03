using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator1;
using NUnit.Framework;

namespace CalcMutantTestCase
{
   
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input13point4and15point6_Returns29point0()
        {

            //Arrange
            double number1 = 13.4;
            double number2 = 15.6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubstraction_Input23point6and14point6_Returns9point0()
        {

            //Arrange
            double number1 = 23.0;
            double number2 = 14.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input13point0and15point_Returns195point0()
        {

            //Arrange
            double number1 = 13.0;
            double number2 = 15.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input33point0and11point0_Returns3point0()
        {

            //Arrange
            double number1 = 33.0;
            double number2 = 11.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetAddition_Input113point4and115point6_Returns229point0()
        {

            //Arrange
            double number1 = 113.4;
            double number2 = 115.6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubstraction_Input123point6and114point6_Returns90point0()
        {

            //Arrange
            double number1 = 123.6;
            double number2 = 114.6;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input130point0and150point_Returns1950point0()
        {

            //Arrange
            double number1 = 130.0;
            double number2 = 150.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input66point0and22point0_Returns3point0()
        {

            //Arrange
            double number1 = 66.0;
            double number2 = 22.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetAddition_Input82point4and17point6_Returns100point0()
        {

            //Arrange
            double number1 = 82.4;
            double number2 = 17.6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubstraction_Input33point6and24point6_Returns58point0()
        {

            //Arrange
            double number1 = 33.6;
            double number2 = 24.6;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input12point0and15point_Returns180point0()
        {

            //Arrange
            double number1 = 12.0;
            double number2 = 15.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input99point0and11point0_Returns9point0()
        {

            //Arrange
            double number1 = 99.0;
            double number2 = 11.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input1and3_Returns0point33()
        {

            //Arrange
            double number1 = 1;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input2and1_Returns2()
        {

            //Arrange
            double number1 = 2;
            double number2 = 1;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input9and3_Returns3()
        {

            //Arrange
            double number1 = 9;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}