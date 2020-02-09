using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyTravelTest.Dependencies;
using HappyTravelTest.DTO.ApiResponseObjects;
using HappyTravelTest.Exceptions;
using HappyTravelTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HappyTravelTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelInfoController : ControllerBase
    {
        private readonly INetstormingService nsService;

        public HotelInfoController(INetstormingService nsService)
        {
            this.nsService = nsService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ApiResponse> Get([FromQuery]int? hotelId, [FromQuery]string language)
        {
            if (string.IsNullOrWhiteSpace(language))
                language = "en";

            if (!nsService.IsLanguageAcceptable(language))
                throw new BadRequestException("Language not supported");

            if (!hotelId.HasValue)
                throw new BadRequestException("hotelId parameter is mandatory");

            var response = await nsService.GetInfoAsync(hotelId.Value, language);

            return response;
        }
    }
}
