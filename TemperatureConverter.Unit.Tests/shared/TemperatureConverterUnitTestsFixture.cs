using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter.Unit.Tests.shared
{
    public class TemperatureConverterUnitTestsFixture : IDisposable
    {
        public TemperatureConverter TemperatureConverter { get; private set; }

        public TemperatureConverterUnitTestsFixture()
        {
            TemperatureConverter = new TemperatureConverter();
        }

        public void Dispose()
        {
        }
    }
}

