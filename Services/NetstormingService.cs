using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using HappyTravelTest.Dependencies;
using HappyTravelTest.Dependencies.Repositories;
using HappyTravelTest.DTO.ApiResponseObjects;
using HappyTravelTest.DTO.NetstormingResponseObjects;
using HappyTravelTest.Exceptions;

namespace HappyTravelTest.Services
{
    public class NetstormingService : INetstormingService
    {
        #region private enums

        private enum DirectionType
        {
            Metro,
            Station,
            Airport,
            Bus,
            Center,
            Fair
        }

        private enum Stars
        {
            OneStar = 1,
            TwoStars = 2,
            ThreeStars = 3,
            FourStars = 4,
            FiveStars = 5
        }

        private enum TextualDescriptionType
        {
            General,
            Exterior,
            Lobby,
            Position,
            Room,
            Restaurant
        }

        #endregion

        private readonly INetstormingClient nsClient;
        private readonly INetstormingRepository repo;

        private readonly string[] aceptableLanguages =
            {"ru", "en", "fr", "zh", "hr", "ca", "de", "it", "es", "sl", "ja", "pl", "pt-br"};

        public bool IsLanguageAcceptable(string language) => aceptableLanguages.Contains(language.ToLower());

        public NetstormingService(INetstormingClient nsClient, INetstormingRepository repo)
        {
            this.nsClient = nsClient;
            this.repo = repo;
        }

        public async Task<ApiResponse> GetInfoAsync(int hotelId, string languageName)
        {
            languageName = languageName.ToLower();

            ApiResponse response;

            try
            {
                var nsInfo = await nsClient.GetInfo(hotelId);
                response = ApplyNetstormingInfo(nsInfo, languageName);
            }
            catch (NotFoundException) { throw; }
            catch (NetstormingException) { throw; }
            catch
            {
                throw new NetstormingException("Unexpected exception while querying netstorming api");
            }

            try
            {
                await ApplyDatabaseInfo(response, languageName);
            }
            catch
            {
                throw new DatabaseException("Unexpected exception while querying the database");
            }

            return response;
        }

        #region process netstorming data

        private ApiResponse ApplyNetstormingInfo(NetstormingResponse info, string languageName)
        {
            var response = info.response;

            return new ApiResponse
            {
                id = response.id.value.ToString(),
                name = response.name.value,
                nsCategory = response.classification.value,
                category = null,

                contacts = new Contacts
                {
                    email = null,
                    fax = response.fax.value,
                    telephone = response.telephone.value
                },

                nsDescription = response.description.value,

                location = new Location
                {
                    city = null,
                    address = response.address.value,
                    cityCode = response.city.value,
                    cityZone = null,
                    cityZoneCode = response.zone.value,
                    coordinates = new Coordinates {latitude = response.lt.value, longitude = response.lg.value},
                    country = null,
                    countryCode = response.country.value,
                    directions = GetDirections(response),
                    isHistoricalBuilding = response.position.dimora.value,
                    locationDescriptionCode = null
                },

                pictures = GetPictures(response),

                rating = ((Stars) response.stars.value).ToString(),

                schedule = new Schedule
                {
                    checkInTime = response.hotelfacilities.checkin.value,
                    portersStartTime = response.hotelfacilities.start_porter.value,
                    portersEndTime = response.hotelfacilities.end_porter.value,
                    roomServiceStartTime = response.hotelfacilities.start_roomservice.value,
                    roomServiceEndTime = response.hotelfacilities.end_roomservice.value
                },

                textualDescriptions = GetTextualDescriptions(response, languageName),

                hotelAmenities = new Hotelamenities
                {
                    airConditioning = response.airconditioning.value,
                    areAnimalsAllowed = response.hotelfacilities.animals.value,
                    babySitting = response.babysitting.value,
                    bar = response.hotelfacilities.bar.value,
                    beauty = response.hotelfacilities.beauty.value,
                    boutique = response.boutique.value,
                    busStop = response.hotelfacilities.busstop.value,
                    coachDropOff = response.hotelfacilities.coach_dropoff.value,
                    dinner = response.hotelfacilities.dinner.value,
                    disabledFacilities = response.facilities.value,
                    garage = response.hotelfacilities.garage_auto.value,
                    gym = response.gym.value,
                    hairDryer = response.hairdreyer.value,
                    heatedPools = response.pool_hot.value,
                    inHotelCarRental = response.hotelfacilities.carrental.value,
                    inHotelShuttleStation = response.hotelfacilities.shuttle_station.value,
                    inHotelTravelAgency = response.hotelfacilities.travel_agency.value,
                    insidePool = response.hotelfacilities.pool_close.value,
                    internetConnection = response.hotelfacilities.internet.value,
                    laundry = response.hotelfacilities.laundry.value,
                    lightBoard = response.hotelfacilities.lightboard.value,
                    mic = response.hotelfacilities.mic.value,
                    noSmokingRooms = response.nosmoking.value,
                    outsidePool = response.hotelfacilities.pool_open.value,
                    parking = response.park_auto.value,
                    parkingForBuses = response.hotelfacilities.park_bus.value,
                    parkingForCoaches = response.hotelfacilities.coach_parking.value,
                    projector = response.hotelfacilities.projector.value,
                    roomForFilming = response.film.value,
                    sauna = response.sauna.value,
                    shops = response.shops.value,
                    shuttleForAirport = response.shuttle_apt.value,
                    shuttleForCenter = response.shuttle_center.value,
                    soccerField = response.hotelfacilities.soccer.value,
                    solarium = response.solarium.value,
                    tennisCourts = response.tennis.value,
                    otherFacilities = false, // Не приходит в ответе от Netstorming API
                },

                roomAmenities = new Roomamenities
                {
                    airConditioningInRooms = response.roomsfacilities.rairconditioning.value,
                    alarm = response.roomsfacilities.alarm.value,
                    disabledFacilitiesInRooms = response.roomsfacilities.rfacilities.value,
                    flatIron = response.roomsfacilities.flatiron.value,
                    miniBar = response.roomsfacilities.minibar.value,
                    pantsIron = response.roomsfacilities.pantsiron.value,
                    payPerViewTv = response.roomsfacilities.paytv.value,
                    radio = response.roomsfacilities.radio.value,
                    safeBox = response.roomsfacilities.safe.value,
                    satelliteTv = response.roomsfacilities.tvsat.value,
                    telephoneInRooms = response.roomsfacilities.rtelephone.value,
                    tv = response.roomsfacilities.tv.value
                    // cableNetworkConnection
                    // wifiNetworkConnection
                },

                additionalInfo = new Additionalinfo
                {
                    conferenceRoomCount = response.hotelfacilities.conference.value.ToString(),
                    doubleRoomCount = response.hotelfacilities.dbl.value.ToString(),
                    elevatorCount = response.hotelfacilities.lifts.value.ToString(),
                    extendedDoubleRoomCount = response.hotelfacilities.dblext.value.ToString(),
                    extendedTwinRoomCount = response.hotelfacilities.twnext.value.ToString(),
                    lobbySize = response.hotelfacilities.lobby_size.value,
                    quadrupleRoomCount = response.hotelfacilities.qdr.value.ToString(),
                    singleRoomCount = response.hotelfacilities.sgl.value.ToString(),
                    suiteRoomCount = response.hotelfacilities.suites.value.ToString(),
                    tripleRoomCount = response.hotelfacilities.trp.value.ToString(),
                    twinRoomCount = response.hotelfacilities.twn.value.ToString(),
                    voltage = response.hotelfacilities.voltage.value.ToString()
                }
            };
        }

        private Direction[] GetDirections(envelopeResponse response)
        {
            var rez = new List<Direction>();
            if (!string.IsNullOrWhiteSpace(response.metro.value))
            {
                rez.Add(new Direction
                {
                    type = DirectionType.Metro.ToString(),
                    name = response.metro.value,
                    distanceInKilometers = TryParseFloat(response.position.metro_distance.value),
                    timeToInMinutes = TryParseFloat(response.position.metro_time.value)
                });
            }

            if (!string.IsNullOrWhiteSpace(response.station.value))
            {
                rez.Add(new Direction
                {
                    type = DirectionType.Station.ToString(),
                    name = response.station.value,
                    distanceInKilometers = TryParseFloat(response.position.station_distance.value),
                    timeToInMinutes = TryParseFloat(response.position.station_time.value)
                });
            }

            if (!string.IsNullOrWhiteSpace(response.position.airport.value))
            {
                rez.Add(new Direction
                {
                    type = DirectionType.Airport.ToString(),
                    name = response.position.airport.value,
                    distanceInKilometers = TryParseFloat(response.position.apt_distance.value),
                    timeToInMinutes = TryParseFloat(response.position.apt_time.value)
                });
            }

            rez.Add(new Direction
            {
                type = DirectionType.Bus.ToString(),
                name = "",
                distanceInKilometers = TryParseFloat(response.position.bus_distance.value),
                timeToInMinutes = TryParseFloat(response.position.bus_time.value)
            });


            rez.Add(new Direction
            {
                type = DirectionType.Center.ToString(),
                name = null,
                distanceInKilometers = TryParseFloat(response.position.center_time.value),
                timeToInMinutes = TryParseFloat(response.position.center_distance.value)
            });

            if (!string.IsNullOrWhiteSpace(response.position.fairs.value))
            {
                rez.Add(new Direction
                {
                    type = DirectionType.Fair.ToString(),
                    name = response.position.fairs.value,
                    distanceInKilometers = null, // float.NaN,
                    timeToInMinutes = null // float.NaN
                });
            }

            return rez.ToArray();
        }

        private float? TryParseFloat(string s) => float.TryParse(s, out var val) ? val : (float?)null;

        private Picture[] GetPictures(envelopeResponse response)
        {
            var codeCaptionMap = new Dictionary<int, string>
            {
                [1] = "Bedroom",
                [2] = "Dining room",
                [3] = "Hall",
                [4] = "Restaurant",
                [5] = "External View",
                [6] = "Suite",
                [7] = "Deluxe room",
                [8] = "Bathroom",
                [9] = "Pool",
                [10] = "Conference room",
                [11] = "Bar",
                [12] = "Spa",
                [13] = "Solarium",
                [14] = "Gymnasium",
                [15] = "Breakfast room",
                [16] = "Garden",
                [17] = "Terrace",
                [18] = "Tennis court",
                [19] = "Soccer court",
                [20] = "Bedroom",
                [21] = "Admission",
                [22] = "Entrance",
                [23] = "View",
                [24] = "Lobby",
                [25] = "Banquet room ",
                [26] = "Map",
                [27] = "Stairs",
                [28] = "Gazebo",
                [29] = "Hallway",
                [30] = "Living Room",
                [31] = "Indoor",
                [32] = "Casinò",
                [33] = "Veranda",
                [34] = "Beach",
                [35] = "Tradition",
                [36] = "Buffet",
                [37] = "Turkish Steam Bath",
                [38] = "Heated Swimmingpool",
                [39] = "Sauna",
                [40] = "Room - Classic",
                [41] = "Indoor Swimmingpool",
                [42] = "Kitchen",
                [43] = "Meeting Room",
                [44] = "Games Room",
                [45] = "Bowling",
                [46] = "Sauna",
                [47] = "Golf Course",
                [48] = "Room - Superior",
                [49] = "Room - Family",
                [50] = "Junior Suite Room",
                [51] = "Jacuzzi",
                [52] = "Internet Point",
                [53] = "Restaurant",
                [54] = "Hall",
                [55] = "Room - Single",
                [56] = "Living Room",
                [57] = "Breakfast",
                [58] = "Room - Suite",
                [59] = "Apartment",
                [60] = "Executive Room",
                [61] = "Cottage",
                [62] = "Double Room",
                [63] = "Beauty Center",
                [64] = "Logo",
                [65] = "Disco",
                [66] = "Lobby",
                [67] = "Lobby",
                [68] = "Double Room",
                [69] = "Restaurant",
                [70] = "Garage",
                [71] = "Detail Room",
                [72] = "Room - Deluxe",
                [73] = "Facade",
                [74] = "Wellness Center",
                [75] = "Parking",
                [76] = "Exterior",
                [77] = "Congress Centre",
                [78] = "Recreation Ground",
                [79] = "Room - Triple",
                [80] = "Hotel Position",
                [81] = "Breakfast Room",
                [82] = "Activities",
                [83] = "Room - Twin",
                [84] = "Room - Business Suite",
                [85] = "Li Galli Room",
                [86] = "Apartment Sirene",
                [87] = "Apartment Bizantino",
                [88] = "Apartment Saraceno",
                [89] = "Putting Green",
                [90] = "Promenade",
                [91] = "Hotel Detail",
                [92] = "Room - Quadruple",
                [93] = "Apartment Giunone",
                [94] = "Apartment Mercurio",
                [95] = "Apartment Diana",
                [96] = "Apartment Nettuno",
                [97] = "Apartment Saraceno",
                [98] = "Apartment Minerva",
                [99] = "Outdoor Bar",
                [100] = "Indoor Bar",
                [101] = "Outdoor Restaurant",
                [102] = "Panoramic Restaurant",
                [103] = "Winter Garden",
                [104] = "Relax Room",
                [105] = "Sea",
                [106] = "Wine Cellar",
                [107] = "Fireplace",
                [108] = "Basketball Court",
                [109] = "Pine Forest",
                [110] = "Wall Painting",
                [111] = "Wine Cellar",
                [112] = "Room - Comfort",
                [113] = "Landscape",
                [114] = "Bathroom - Suite",
                [115] = "Trullo",
                [116] = "Park",
                [117] = "Roof Garden",
                [118] = "Apartment",
                [119] = "Apartment",
                [120] = "Pub",
                [121] = "Lounge Bar",
                [122] = "Gift Shop",
                [123] = "Studio Apartment",
                [124] = "Two-room Apartment",
                [125] = "Amphiteather",
                [126] = "Writing desk",
                [127] = "Villa",
                [128] = "Bungalow",
                [129] = "Patio",
                [130] = "Villa detail",
                [131] = "Detail",
                [132] = "Room - Gran Deluxe",
                [133] = "Chapel",
                [134] = "Church",
                [135] = "Sorroundings",
                [136] = "Apartment",
                [137] = "Apartment - Detail",
                [138] = "Ski Resort",
                [139] = "Relaxation",
                [140] = "Wading Pool",
                [141] = "Mountain",
                [142] = "Depandance",
                [143] = "Room - Double Club",
                [144] = "Room - Club Twin",
                [145] = "Room - Club Single",
                [146] = "Guest Room",
                [147] = "Aerial View",
                [148] = "Business Centre",
                [149] = "Dining Area",
                [150] = "Hot Spring",
                [151] = "Ballroom",
                [152] = "Health Club",
                [153] = "Night Club",
                [154] = "Balcony",
                [155] = "Floor Plan",
                [156] = "Japanese style room",
                [157] = "View of skyline",
                [158] = "Swimming Pool",
                [159] = "Theatre",
                [160] = "Bunk-Bed Room",
                [161] = "Salotto",
                [162] = "Standard Room",
                [163] = "Scenario",
                [164] = "Soggiorno E Angolo Cottura",
                [165] = "Camera Junior Suite",
                [166] = "Camera Vista Mare",
                [167] = "Superior Room",
                [168] = "Economy Room",
                [169] = "Standard Room",
                [170] = "Library",
                [171] = "Athenian Panorama Room",
                [172] = "Caffetteria",
                [173] = "Villette",
                [174] = "Dettagli Strutturali",
                [175] = "Imperial Suite",
                [176] = "Junior Suite Deluxe Room",
                [177] = "Chalet",
                [178] = "Mountain",
                [179] = "Dormitory",
                [180] = "Dormitory 4 Pax",
                [181] = "Dormitory 6 Pax",
                [182] = "Dormitory 8 Pax",
                [183] = "Premium Lake View Room",
                [184] = "Spa",
                [185] = "Executive Junior Suite Room",
                [186] = "Superior Bathroom",
                [187] = "Outdoor Swimmingpool",
                [188] = "Signature Room",
                [189] = "Signature Lake Side Room",
                [190] = "Room - Single",
                [191] = "Reception",
                [192] = "Detail",
                [193] = "Business Room",
                [194] = "Budget Room",
                [195] = "Deluxe Suite Room"
            };

            return response.pictures.Select(
                p => new Picture
                {
                    source = p.src,
                    caption = codeCaptionMap.TryGetValue(p.type, out var cap) ? cap : ""
                }).ToArray();
        }

        private Textualdescription[] GetTextualDescriptions(envelopeResponse response, string languageName)
        {
            var textualDescriptionsMap = new Dictionary<TextualDescriptionType, Func<envelopeResponseSheetsTxt>>
            {
                [TextualDescriptionType.General] = () => response.sheets.txt_general,
                [TextualDescriptionType.Exterior] = () => response.sheets.txt_exterior,
                [TextualDescriptionType.Lobby] = () => response.sheets.txt_lobby,
                [TextualDescriptionType.Position] = () => response.sheets.txt_position,
                [TextualDescriptionType.Room] = () => response.sheets.txt_rooms,
                [TextualDescriptionType.Restaurant] = () => response.sheets.txt_restaurant
            };

            var languageMap = new Dictionary<string, Func<envelopeResponseSheetsTxt, string>>
            {
                ["ru"] = x => x.ru,
                ["en"] = x => x.en,
                ["fr"] = x => x.fr,
                ["zh"] = x => x.zh,
                ["hr"] = x => x.hr,
                ["ca"] = x => x.ca,
                ["de"] = x => x.de,
                ["it"] = x => x.it,
                ["es"] = x => x.es,
                ["sl"] = x => x.sl,
                ["ja"] = x => x.ja,
                ["pl"] = x => x.pl,
                ["pt-br"] = x => x.ptbr
            };

            // если встретится неизвестный язык, вернем пустоту
            try
            {
                return textualDescriptionsMap.Select(
                        x => new Textualdescription
                        {
                            type = x.Key.ToString(),
                            descriptions = new Dictionary<string, string>
                                {[languageName] = languageMap[languageName](x.Value())}
                        })
                    // Если описание пустое, то не добавляем его
                    .Where(x => x.descriptions.Values.Any(v => !string.IsNullOrWhiteSpace(v)))
                    .ToArray();
            }
            catch
            {
                return new Textualdescription[0];
            }
        }

        #endregion

        #region process database data
        
        private async Task ApplyDatabaseInfo(ApiResponse response, string languageName)
        {
            var tasks = new Func<Task>[]
            {
                async () => response.category = await repo.GetCategoryAsync(response.nsCategory, languageName),
                async () => response.description = await repo.GetDescriptionAsync(response.nsDescription, languageName),
                async () => response.location.country = await repo.GetCountryNameAsync(response.location.countryCode, languageName),
                async () => response.location.city = await repo.GetCityNameAsync(response.location.cityCode, languageName),
                async () => response.location.cityZone = await repo.GetCityZoneAsync(response.location.cityZoneCode, languageName)
            };
            await Task.WhenAll(tasks.Select(t => t()));
        }

        #endregion
    }
}
