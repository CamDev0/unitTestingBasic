namespace testing_NUnit;

//Type of test

[TestFixture]
public class ResultadoTest
{
    [Test]
    public void TestQuePass()
    {
        Assert.Pass();
    }

    [Test, Ignore("Fail ignorado")]
    public void TestQueFail()
    {
        int valor = 5;
        Assert.AreEqual(4, valor);
    }

    [Test]
    public void TestQueInconclusive()
    {
        Assert.Inconclusive();
    }

    [Test, Ignore("Ignorado ...")]
    public void TestQueIgnored()
    {
        Assert.Ignore();
    }
}