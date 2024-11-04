// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Jet3UpInterfaces.Services;
using IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Aerotec.Data.UnitTest
{
    /// <summary>
    /// We need to run in debug mode since in release mode we use real implementations in IoC.
    /// </summary>
    public class Tests
    {
        private IClientService _clientService;
        [SetUp]
        public void Setup()
        {
            _clientService = IoCContainer.Instance.Services.GetRequiredService<IClientService>();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}