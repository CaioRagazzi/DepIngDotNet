using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using WebApi;
using Xunit;

namespace XUnitTestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            List<String> output = new List<string>
            {
                "text",
                "text",
                "text",
            };

            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IWeatherForecast>()
                    .Setup(x => x.Weathers("teste"))
                    .Returns()
            }
        }
    }
}
