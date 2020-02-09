using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyTravelTest.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HappyTravelTest.Dependencies.Repositories
{
    public class NetstormingRepository : INetstormingRepository
    {
        private const string DefaultLanguage = "en";
        private readonly DbContextOptions<netstormingContext> options;

        public NetstormingRepository(DbContextOptions<netstormingContext> options)
        {
            this.options = options;
        }

        public async Task<string> GetCategoryAsync(string nsCategory, string languageName)
        {
            await using var dbContext = new netstormingContext(options);
            var row = await dbContext.Categories.FirstOrDefaultAsync(c => c.Code == nsCategory);
            var json = row?.Descriptions;
            return TryGetByLanguage(json, languageName);
        }

        public async Task<string> GetDescriptionAsync(string nsDescription, string languageName)
        {
            await using var dbContext = new netstormingContext(options);
            var row = await dbContext.HotelDescriptions.FirstOrDefaultAsync(c => c.Code == nsDescription);
            var json = row?.Descriptions;
            return TryGetByLanguage(json, languageName);
        }

        public async Task<string> GetCountryNameAsync(string countryCode, string languageName)
        {
            await using var dbContext = new netstormingContext(options);
            var row = await dbContext.Countries.FirstOrDefaultAsync(c => c.Code == countryCode);
            var json = row?.Names;
            return TryGetByLanguage(json, languageName);
        }

        public async Task<string> GetCityNameAsync(string cityCode, string languageName)
        {
            await using var dbContext = new netstormingContext(options);
            var row = await dbContext.Cities.FirstOrDefaultAsync(c => c.Code == cityCode);
            var json = row?.Names;
            return TryGetByLanguage(json, languageName);
        }

        public async Task<string> GetCityZoneAsync(string cityZoneCode, string languageName)
        {
            await using var dbContext = new netstormingContext(options);
            var row = await dbContext.CityZones.FirstOrDefaultAsync(c => c.Code == cityZoneCode);
            var json = row?.Names;
            return TryGetByLanguage(json, languageName);
        }

        private string TryGetByLanguage(string jsonDictionary, string languageName)
        {
            if (string.IsNullOrWhiteSpace(jsonDictionary))
                return null;

            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonDictionary);
            dict.TryGetValue(languageName, out var val);
            if (!string.IsNullOrWhiteSpace(val))
                return val;
            
            return dict.TryGetValue(DefaultLanguage, out var valDefault) ? valDefault : null;
        }
    }
}
