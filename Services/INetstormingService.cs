using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyTravelTest.DTO.ApiResponseObjects;

namespace HappyTravelTest.Services
{
    public interface INetstormingService
    {
        bool IsLanguageAcceptable(string language);
        Task<ApiResponse> GetInfoAsync(int hotelId, string languageName);
    }
}
