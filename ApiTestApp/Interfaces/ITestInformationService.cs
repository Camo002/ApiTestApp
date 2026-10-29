using ApiTestApp.Models;

namespace ApiTestApp.Interfaces
{
    public interface ITestInformationService
    {
        Task<List<TestInfoDto>> GetTestInfoAsync(int id);
    }
}
