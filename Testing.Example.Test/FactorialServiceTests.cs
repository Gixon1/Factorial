using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.Example.Test
{
   public class FactorialServiceTests
    {
        [Fact]
        public void TestFactorialZero(){
            //inicializar - Arrage

            FactorialService service = new FactorialService();


            // Estimular el codigo  o actuar  - Act
            int result = service.Calculate(0);

            // Resultado se ejecuto   -  Assert
            Assert.Equal(1, result);


        }

        [Fact]
        public void TestFactorialFive() {

            FactorialService service = new FactorialService();

            int result = service.Calculate(5);

            Assert.Equal(120, result);


        }

    }
}
