using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter.Shared
{
    public class TemperatureConverterFixture : IDisposable
    {
        public TemperatureConverter TemperatureConverter { get; private set; }

        public TemperatureConverterFixture()
        {
            TemperatureConverter = new TemperatureConverter();
        }

        public void Dispose()
        {
        }
    }
}
