using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyTravelTest.Dependencies.Repositories
{
    public interface INetstormingRepository
    {
        Task<string> GetCategoryAsync(string nsCategory, string languageName);
        Task<string> GetDescriptionAsync(string nsDescription, string languageName);
        Task<string> GetCountryNameAsync(string countryCode, string languageName);
        Task<string> GetCityNameAsync(string cityCode, string languageName);
        Task<string> GetCityZoneAsync(string cityZoneCode, string languageName);
    }
}
