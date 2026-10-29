using ApiTestApp.Interfaces;
using ApiTestApp.Models;

namespace ApiTestApp.Services
{
    public class TestInformationService: ITestInformationService
    {


        public async Task<List<TestInfoDto>> GetTestInfoAsync(int id)
        {
            var rand = new Random();

            List<TestInfoDto> testInfoDtoList = new List<TestInfoDto>();

            string[] words = { "Bold", "Think", "Friend", "Pony", "Fall", "Easy" };

            for (int i = 0; i < id; i++)
            {
                var testInfo = new TestInfoDto
                {
                    Id = rand.Next(1000, 10000).ToString(),
                    randomword = words[rand.Next(0, words.Length)]
                };

                testInfoDtoList.Add(testInfo);
            }

            return testInfoDtoList;

        }
    }
}
