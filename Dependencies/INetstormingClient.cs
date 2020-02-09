using System.Threading.Tasks;
using HappyTravelTest.DTO.NetstormingResponseObjects;

namespace HappyTravelTest.Dependencies
{
    public interface INetstormingClient
    {
        Task<NetstormingResponse> GetInfo(int hotelId);
    }
}
