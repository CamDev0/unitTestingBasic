using System;
using System.Reflection;

namespace UnitTesting
{
    class Program  {

        static void Main(String[] args)
        {
            //La lógica detecta automáticamente los methods que inician con "Prueba" y los ejecuta

            //Obtiene los métodos publicos estáticos.
            var methods = typeof(Program).GetMethods(BindingFlags.Public | BindingFlags.Static);
            var testSuccess = 0;
            var testFailed = 0;

            foreach (var method in methods)
            {
                if(method.Name.StartsWith("Prueba"))
                {
                    try{
                        method.Invoke(null, null);
                        testSuccess++;
                    }
                    catch{
                        testFailed++;
                    }
                }
            }

            Console.WriteLine($"Tests Success: {testSuccess}");
            Console.WriteLine("Tests Failed: " + testFailed);
        }

        public static void PruebaQueLengthHellois5()
        {
            //arrange -> Valor a verificar
            var stringTest = "Hello";
            //act -> Obtenemos la acción que se va a verificar
            var length = stringTest.Length;
            //assert -> Validamos si se cumple
            Assert.Que(length == 5);
        }

        public static void PruebaQueWordContains()
        {
            //Arrange -> Preparo lo que voy a testear
            var stringTest = "Hello";

            //Act -> Ejecuto lo que estoy probando
            var contain_o = stringTest.Contains("o");

            //Asert -> Verifico si el resultado es el esperado
            Assert.Que(contain_o);
        }
    
        public static void PruebaEjemplo(){
            bool rpta = false;
            Assert.Que(rpta);
        }
    }
}

