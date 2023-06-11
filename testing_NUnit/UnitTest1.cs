namespace testing_NUnit;

public class Tests
{
        [Test]
        public  void LengthHellois5()
        {
            //arrange -> Valor a verificar
            var stringTest = "Hello";
            //act -> Obtenemos la acción que se va a verificar
            var length = stringTest.Length;
            //assert -> Validamos si se cumple
            Assert.AreEqual(5, length);
        }

        [Test]
        public void WordContains()
        {
            //Arrange -> Preparo lo que voy a testear
            var stringTest = "Hello";

            //Act -> Ejecuto lo que estoy probando
            var contain_o = stringTest.Contains("o");

            //Asert -> Verifico si el resultado es el esperado
            Assert.IsTrue(contain_o);

        }
    
        [Test]
        public void PruebaEjemplo(){
            bool rpta = true;
            Assert.IsTrue(rpta);
        }
}