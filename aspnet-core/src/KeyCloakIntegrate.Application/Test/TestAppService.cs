using System.Threading.Tasks;

namespace KeyCloakIntegrate.Test
{
    public class TestAppService : KeyCloakIntegrateAppService, ITestAppService
    {
        public async Task<string> GetNameAsync()
        {
            return await Task.FromResult("Test");
        }
    }
}
