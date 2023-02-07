using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TemperatureConverter.Shared
{
    [CollectionDefinition("TemperatureConverter Collection")]
    public class TemperatureConverterCollection : ICollectionFixture<TemperatureConverterFixture> { }
}
