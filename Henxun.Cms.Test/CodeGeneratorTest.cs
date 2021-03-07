using Henxun.Cms.Core.CodeGenerator;
using Henxun.Cms.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using NUnit.Framework;

namespace Henxun.Cms.Test
{
    class CodeGeneratorTest
    {
        [Fact]
        public void GeneratorModelForSqlServer()
        {
            var serviceProvider = Common.BuildServiceForSqlServer();
            var codeGenerator = serviceProvider.GetRequiredService<CodeGenerator>();
            codeGenerator.GenerateTemplateCodesFromDatabase(true);
            //Assert.AreEqual("SQLServer", DataBaseType.SqlServer.ToString());

        }
    }
}
