using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter.Integration.Tests.shared
{
    public class TemperatureConverterIntegrationTestsFixture : IDisposable
    {
        public TemperatureConverter TemperatureConverter { get; private set; }

        public TemperatureConverterIntegrationTestsFixture()
        {
            TemperatureConverter = new TemperatureConverter();
        }

        public void Dispose()
        {
        }
    }
}

