using System;
using System.Reflection;

namespace UnitTesting
{
    class Program  {

        static void Main(String[] args)
        {
            
        }

        static void PruebaLengthHellois5()
        {
            //arrange -> Valor a verificar
            var stringTest = "Hello";
            //act -> Obtenemos la acción que se va a verificar
            var length = stringTest.Length;
            //assert -> Validamos si se cumple
            Assert.Que(length == 1);
        }

        static void PruebaWordContains()
        {
            //Arrange -> Preparo lo que voy a testear
            var stringTest = "Hello";

            //Act -> Ejecuto lo que estoy probando
            var contain_o = stringTest.Contains("o");

            //Asert -> Verifico si el resultado es el esperado
            Assert.Que(contain_o);
        }
    }
}

