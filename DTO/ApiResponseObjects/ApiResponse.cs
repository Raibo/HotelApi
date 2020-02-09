using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using HappyTravelTest.DTO.NetstormingResponseObjects;

namespace HappyTravelTest.DTO.ApiResponseObjects
{
    [Serializable]
    public class ApiResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        [NonSerialized]
        public string nsCategory;
        public string category { get; set; }
        public Contacts contacts { get; set; }
        [NonSerialized] 
        public string nsDescription;
        public string description { get; set; }
        public Location location { get; set; }
        public Picture[] pictures { get; set; }
        public string rating { get; set; }
        public Schedule schedule { get; set; }
        public Textualdescription[] textualDescriptions { get; set; }
        public Hotelamenities hotelAmenities { get; set; }
        public Roomamenities roomAmenities { get; set; }
        public Additionalinfo additionalInfo { get; set; }
    }

    [Serializable]
    public class Contacts
    {
        public string email { get; set; }
        public string fax { get; set; }
        public string telephone { get; set; }
    }

    [Serializable]
    public class Location
    {
        public string address { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string city { get; set; }
        public string cityCode { get; set; }
        public string cityZone { get; set; }
        public string cityZoneCode { get; set; }
        public Coordinates coordinates { get; set; }
        public bool isHistoricalBuilding { get; set; }
        public string locationDescriptionCode { get; set; }
        public Direction[] directions { get; set; }
    }

    [Serializable]
    public class Coordinates
    {
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }

    [Serializable]
    public class Direction
    {
        public string name { get; set; }
        public float? distanceInKilometers { get; set; }
        public float? timeToInMinutes { get; set; }
        public string type { get; set; }
    }

    [Serializable]
    public class Schedule
    {
        public string checkInTime { get; set; }
        public string portersStartTime { get; set; }
        public string portersEndTime { get; set; }
        public string roomServiceStartTime { get; set; }
        public string roomServiceEndTime { get; set; }
    }

    [Serializable]
    public class Hotelamenities
    {
        public bool bar { get; set; }
        public bool gym { get; set; }
        public bool mic { get; set; }
        public bool sauna { get; set; }
        public bool shops { get; set; }
        public bool beauty { get; set; }
        public bool dinner { get; set; }
        public bool garage { get; set; }
        public bool busStop { get; set; }
        public bool laundry { get; set; }
        public bool parking { get; set; }
        public bool boutique { get; set; }
        public bool solarium { get; set; }
        public bool hairDryer { get; set; }
        public bool projector { get; set; }
        public bool insidePool { get; set; }
        public bool lightBoard { get; set; }
        public bool babySitting { get; set; }
        public bool heatedPools { get; set; }
        public bool outsidePool { get; set; }
        public bool soccerField { get; set; }
        public bool coachDropOff { get; set; }
        public bool tennisCourts { get; set; }
        public bool noSmokingRooms { get; set; }
        public bool roomForFilming { get; set; }
        public bool airConditioning { get; set; }
        public bool otherFacilities { get; set; }
        public bool parkingForBuses { get; set; }
        public bool inHotelCarRental { get; set; }
        public bool shuttleForCenter { get; set; }
        public bool areAnimalsAllowed { get; set; }
        public bool parkingForCoaches { get; set; }
        public bool shuttleForAirport { get; set; }
        public bool disabledFacilities { get; set; }
        public bool internetConnection { get; set; }
        public bool inHotelTravelAgency { get; set; }
        public bool inHotelShuttleStation { get; set; }
    }

    [Serializable]
    public class Roomamenities
    {
        public bool tv { get; set; }
        public bool alarm { get; set; }
        public bool radio { get; set; }
        public bool miniBar { get; set; }
        public bool safeBox { get; set; }
        public bool flatIron { get; set; }
        public bool pantsIron { get; set; }
        public bool satelliteTv { get; set; }
        public bool payPerViewTv { get; set; }
        public bool telephoneInRooms { get; set; }
        public bool wifiNetworkConnection { get; set; }
        public bool airConditioningInRooms { get; set; }
        public bool cableNetworkConnection { get; set; }
        public bool disabledFacilitiesInRooms { get; set; }
    }

    [Serializable]
    public class Additionalinfo
    {
        public string voltage { get; set; }
        public string lobbySize { get; set; }
        public string elevatorCount { get; set; }
        public string twinRoomCount { get; set; }
        public string suiteRoomCount { get; set; }
        public string doubleRoomCount { get; set; }
        public string singleRoomCount { get; set; }
        public string tripleRoomCount { get; set; }
        public string quadrupleRoomCount { get; set; }
        public string conferenceRoomCount { get; set; }
        public string extendedTwinRoomCount { get; set; }
        public string extendedDoubleRoomCount { get; set; }
    }

    [Serializable]
    public class Picture
    {
        public string source { get; set; }
        public string caption { get; set; }
    }

    [Serializable]
    public class Textualdescription
    {
        public string type { get; set; }
        public Dictionary<string, string> descriptions { get; set; }
    }

}
