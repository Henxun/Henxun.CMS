using NUnit.Framework;

namespace Henxun.Cms.Test
{
    public class Tests
    {
        CodeGeneratorTest codeGeneratorTest;
        [SetUp]
        public void Setup()
        {
            codeGeneratorTest = new CodeGeneratorTest();
        }

        [Test]
        public void Test1()
        {
            // Assert.Pass();
            codeGeneratorTest.GeneratorModelForSqlServer();
        }
    }
}