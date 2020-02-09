using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace HappyTravelTest.DTO.NetstormingResponseObjects
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot("envelope", Namespace = "", IsNullable = false)]
    public class NetstormingResponse
    {
        private envelopeHeader headerField;

        private envelopeResponse responseField;

        /// <remarks />
        public envelopeHeader header
        {
            get => headerField;
            set => headerField = value;
        }

        /// <remarks />
        public envelopeResponse response
        {
            get => responseField;
            set => responseField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeHeader
    {
        private ulong timestampField;

        private envelopeHeaderVersion versionField;

        /// <remarks />
        public envelopeHeaderVersion version
        {
            get => versionField;
            set => versionField = value;
        }

        /// <remarks />
        public ulong timestamp
        {
            get => timestampField;
            set => timestampField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeHeaderVersion
    {
        private string hostField;

        private int portField;

        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public int port
        {
            get => portField;
            set => portField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string host
        {
            get => hostField;
            set => hostField = value;
        }

        /// <remarks />
        [XmlText]
        public string Value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponse
    {
        private envelopeResponseActive activeField;

        private envelopeResponseAddress addressField;

        private envelopeResponseAirconditioning airconditioningField;

        private envelopeResponseBabysitting babysittingField;

        private envelopeResponseBoutique boutiqueField;

        private envelopeResponseCity cityField;

        private envelopeResponseClassification classificationField;

        private envelopeResponseCountry countryField;

        private envelopeResponseDescription descriptionField;

        private envelopeResponseFacilities facilitiesField;

        private envelopeResponseFax faxField;

        private envelopeResponseFilm filmField;

        private envelopeResponseGym gymField;

        private envelopeResponseHairdreyer hairdreyerField;

        private envelopeResponseHotelfacilities hotelfacilitiesField;

        private envelopeResponseID idField;

        private envelopeResponseLastmodified lastmodifiedField;

        private envelopeResponseLG lgField;

        private envelopeResponseLocation locationField;

        private envelopeResponseLT ltField;

        private envelopeResponseMetro metroField;

        private envelopeResponseName nameField;

        private envelopeResponseNosmoking nosmokingField;

        private envelopeResponsePark_auto park_autoField;

        private envelopeResponsePicture[] picturesField;

        private envelopeResponsePool_hot pool_hotField;

        private envelopeResponsePosition positionField;

        private string productField;

        private string restaurantsField;

        private envelopeResponseRoomsfacilities roomsfacilitiesField;

        private envelopeResponseSauna saunaField;

        private envelopeResponseSheets sheetsField;

        private envelopeResponseShops shopsField;

        private envelopeResponseShuttle_apt shuttle_aptField;

        private envelopeResponseShuttle_center shuttle_centerField;

        private envelopeResponseSolarium solariumField;

        private envelopeResponseStars starsField;

        private envelopeResponseStation stationField;

        private envelopeResponseTelephone telephoneField;

        private envelopeResponseTennis tennisField;

        private string typeField;

        private envelopeResponseVote voteField;

        private envelopeResponseZone zoneField;

        [XmlText()]
        public string value { get; set; }

        /// <remarks />
        public envelopeResponseNosmoking nosmoking
        {
            get => nosmokingField;
            set => nosmokingField = value;
        }

        /// <remarks />
        public envelopeResponseClassification classification
        {
            get => classificationField;
            set => classificationField = value;
        }

        /// <remarks />
        public envelopeResponsePark_auto park_auto
        {
            get => park_autoField;
            set => park_autoField = value;
        }

        /// <remarks />
        public envelopeResponseTelephone telephone
        {
            get => telephoneField;
            set => telephoneField = value;
        }

        /// <remarks />
        public envelopeResponseFacilities facilities
        {
            get => facilitiesField;
            set => facilitiesField = value;
        }

        /// <remarks />
        public envelopeResponseVote vote
        {
            get => voteField;
            set => voteField = value;
        }

        /// <remarks />
        public envelopeResponseID id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks />
        public envelopeResponseFilm film
        {
            get => filmField;
            set => filmField = value;
        }

        /// <remarks />
        public envelopeResponseLG lg
        {
            get => lgField;
            set => lgField = value;
        }

        /// <remarks />
        public envelopeResponseZone zone
        {
            get => zoneField;
            set => zoneField = value;
        }

        /// <remarks />
        public envelopeResponseTennis tennis
        {
            get => tennisField;
            set => tennisField = value;
        }

        /// <remarks />
        public envelopeResponseLT lt
        {
            get => ltField;
            set => ltField = value;
        }

        /// <remarks />
        public envelopeResponseStation station
        {
            get => stationField;
            set => stationField = value;
        }

        /// <remarks />
        public envelopeResponseLocation location
        {
            get => locationField;
            set => locationField = value;
        }

        /// <remarks />
        public envelopeResponseStars stars
        {
            get => starsField;
            set => starsField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilities hotelfacilities
        {
            get => hotelfacilitiesField;
            set => hotelfacilitiesField = value;
        }

        /// <remarks />
        public envelopeResponseHairdreyer hairdreyer
        {
            get => hairdreyerField;
            set => hairdreyerField = value;
        }

        /// <remarks />
        public envelopeResponseFax fax
        {
            get => faxField;
            set => faxField = value;
        }

        /// <remarks />
        public envelopeResponseDescription description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        /// <remarks />
        public envelopeResponsePool_hot pool_hot
        {
            get => pool_hotField;
            set => pool_hotField = value;
        }

        /// <remarks />
        public envelopeResponseBoutique boutique
        {
            get => boutiqueField;
            set => boutiqueField = value;
        }

        /// <remarks />
        public envelopeResponseLastmodified lastmodified
        {
            get => lastmodifiedField;
            set => lastmodifiedField = value;
        }

        /// <remarks />
        public envelopeResponseGym gym
        {
            get => gymField;
            set => gymField = value;
        }

        /// <remarks />
        public envelopeResponseSauna sauna
        {
            get => saunaField;
            set => saunaField = value;
        }

        /// <remarks />
        public envelopeResponseShuttle_apt shuttle_apt
        {
            get => shuttle_aptField;
            set => shuttle_aptField = value;
        }

        /// <remarks />
        public envelopeResponseShuttle_center shuttle_center
        {
            get => shuttle_centerField;
            set => shuttle_centerField = value;
        }

        /// <remarks />
        public envelopeResponseAddress address
        {
            get => addressField;
            set => addressField = value;
        }

        /// <remarks />
        public envelopeResponseActive active
        {
            get => activeField;
            set => activeField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilities roomsfacilities
        {
            get => roomsfacilitiesField;
            set => roomsfacilitiesField = value;
        }

        /// <remarks />
        public envelopeResponseAirconditioning airconditioning
        {
            get => airconditioningField;
            set => airconditioningField = value;
        }

        /// <remarks />
        public envelopeResponseBabysitting babysitting
        {
            get => babysittingField;
            set => babysittingField = value;
        }

        /// <remarks />
        public envelopeResponseName name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public envelopeResponseMetro metro
        {
            get => metroField;
            set => metroField = value;
        }

        /// <remarks />
        public envelopeResponseCountry country
        {
            get => countryField;
            set => countryField = value;
        }

        /// <remarks />
        public envelopeResponseSheets sheets
        {
            get => sheetsField;
            set => sheetsField = value;
        }

        /// <remarks />
        public envelopeResponseCity city
        {
            get => cityField;
            set => cityField = value;
        }

        /// <remarks />
        public envelopeResponseSolarium solarium
        {
            get => solariumField;
            set => solariumField = value;
        }

        /// <remarks />
        public envelopeResponsePosition position
        {
            get => positionField;
            set => positionField = value;
        }

        /// <remarks />
        public envelopeResponseShops shops
        {
            get => shopsField;
            set => shopsField = value;
        }

        /// <remarks />
        [XmlArrayItem("picture", IsNullable = false)]
        public envelopeResponsePicture[] pictures
        {
            get => picturesField;
            set => picturesField = value;
        }

        /// <remarks />
        public string restaurants
        {
            get => restaurantsField;
            set => restaurantsField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string product
        {
            get => productField;
            set => productField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseNosmoking
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseClassification
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePark_auto
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseTelephone
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseFacilities
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseVote
    {
        private decimal valueField;

        /// <remarks />
        [XmlAttribute]
        public decimal value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseID
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseFilm
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseLG
    {
        private decimal valueField;

        /// <remarks />
        [XmlAttribute]
        public decimal value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseZone
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseTennis
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseLT
    {
        private decimal valueField;

        /// <remarks />
        [XmlAttribute]
        public decimal value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseStation
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseLocation
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseStars
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilities
    {
        private envelopeResponseHotelfacilitiesAnimals animalsField;

        private envelopeResponseHotelfacilitiesBar barField;

        private envelopeResponseHotelfacilitiesBeauty beautyField;

        private envelopeResponseHotelfacilitiesBusstop busstopField;

        private envelopeResponseHotelfacilitiesCarrental carrentalField;

        private envelopeResponseHotelfacilitiesCheckin checkinField;

        private envelopeResponseHotelfacilitiesCoach_dropoff coach_dropoffField;

        private envelopeResponseHotelfacilitiesCoach_parking coach_parkingField;

        private envelopeResponseHotelfacilitiesConference conferenceField;

        private envelopeResponseHotelfacilitiesDblext dblextField;

        private envelopeResponseHotelfacilitiesDbl dblField;

        private envelopeResponseHotelfacilitiesDinner dinnerField;

        private envelopeResponseHotelfacilitiesEnd_porter end_porterField;

        private envelopeResponseHotelfacilitiesEnd_roomservice end_roomserviceField;

        private envelopeResponseHotelfacilitiesGarage_auto garage_autoField;

        private envelopeResponseHotelfacilitiesInternet internetField;

        private envelopeResponseHotelfacilitiesLaundry laundryField;

        private envelopeResponseHotelfacilitiesLifts liftsField;

        private envelopeResponseHotelfacilitiesLightboard lightboardField;

        private envelopeResponseHotelfacilitiesLobby_size lobby_sizeField;

        private envelopeResponseHotelfacilitiesMic micField;

        private envelopeResponseHotelfacilitiesPark_bus park_busField;

        private envelopeResponseHotelfacilitiesPool_close pool_closeField;

        private envelopeResponseHotelfacilitiesPool_open pool_openField;

        private envelopeResponseHotelfacilitiesProjector projectorField;

        private envelopeResponseHotelfacilitiesQdr qdrField;

        private envelopeResponseHotelfacilitiesSgl sglField;

        private envelopeResponseHotelfacilitiesShuttle_station shuttle_stationField;

        private envelopeResponseHotelfacilitiesSoccer soccerField;

        private envelopeResponseHotelfacilitiesStart_porter start_porterField;

        private envelopeResponseHotelfacilitiesStart_roomservice start_roomserviceField;

        private envelopeResponseHotelfacilitiesSuites suitesField;

        private envelopeResponseHotelfacilitiesTravel_agency travel_agencyField;

        private envelopeResponseHotelfacilitiesTrp trpField;

        private envelopeResponseHotelfacilitiesTwnext twnextField;

        private envelopeResponseHotelfacilitiesTwn twnField;

        private envelopeResponseHotelfacilitiesVoltage voltageField;

        /// <remarks />
        public envelopeResponseHotelfacilitiesDbl dbl
        {
            get => dblField;
            set => dblField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesTravel_agency travel_agency
        {
            get => travel_agencyField;
            set => travel_agencyField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesStart_porter start_porter
        {
            get => start_porterField;
            set => start_porterField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesSgl sgl
        {
            get => sglField;
            set => sglField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesConference conference
        {
            get => conferenceField;
            set => conferenceField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesProjector projector
        {
            get => projectorField;
            set => projectorField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesMic mic
        {
            get => micField;
            set => micField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesTwn twn
        {
            get => twnField;
            set => twnField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesDinner dinner
        {
            get => dinnerField;
            set => dinnerField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesStart_roomservice start_roomservice
        {
            get => start_roomserviceField;
            set => start_roomserviceField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesLifts lifts
        {
            get => liftsField;
            set => liftsField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesEnd_porter end_porter
        {
            get => end_porterField;
            set => end_porterField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesInternet internet
        {
            get => internetField;
            set => internetField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesSoccer soccer
        {
            get => soccerField;
            set => soccerField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesLobby_size lobby_size
        {
            get => lobby_sizeField;
            set => lobby_sizeField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesSuites suites
        {
            get => suitesField;
            set => suitesField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesLaundry laundry
        {
            get => laundryField;
            set => laundryField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesBeauty beauty
        {
            get => beautyField;
            set => beautyField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesCheckin checkin
        {
            get => checkinField;
            set => checkinField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesPark_bus park_bus
        {
            get => park_busField;
            set => park_busField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesCarrental carrental
        {
            get => carrentalField;
            set => carrentalField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesGarage_auto garage_auto
        {
            get => garage_autoField;
            set => garage_autoField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesEnd_roomservice end_roomservice
        {
            get => end_roomserviceField;
            set => end_roomserviceField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesCoach_dropoff coach_dropoff
        {
            get => coach_dropoffField;
            set => coach_dropoffField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesBusstop busstop
        {
            get => busstopField;
            set => busstopField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesAnimals animals
        {
            get => animalsField;
            set => animalsField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesLightboard lightboard
        {
            get => lightboardField;
            set => lightboardField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesDblext dblext
        {
            get => dblextField;
            set => dblextField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesBar bar
        {
            get => barField;
            set => barField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesQdr qdr
        {
            get => qdrField;
            set => qdrField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesPool_close pool_close
        {
            get => pool_closeField;
            set => pool_closeField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesShuttle_station shuttle_station
        {
            get => shuttle_stationField;
            set => shuttle_stationField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesTwnext twnext
        {
            get => twnextField;
            set => twnextField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesTrp trp
        {
            get => trpField;
            set => trpField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesPool_open pool_open
        {
            get => pool_openField;
            set => pool_openField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesCoach_parking coach_parking
        {
            get => coach_parkingField;
            set => coach_parkingField = value;
        }

        /// <remarks />
        public envelopeResponseHotelfacilitiesVoltage voltage
        {
            get => voltageField;
            set => voltageField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesDbl
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesTravel_agency
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesStart_porter
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesSgl
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesConference
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesProjector
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesMic
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesTwn
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesDinner
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesStart_roomservice
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesLifts
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesEnd_porter
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesInternet
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesSoccer
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesLobby_size
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesSuites
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesLaundry
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesBeauty
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesCheckin
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesPark_bus
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesCarrental
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesGarage_auto
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesEnd_roomservice
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesCoach_dropoff
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesBusstop
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesAnimals
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesLightboard
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesDblext
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesBar
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesQdr
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesPool_close
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesShuttle_station
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesTwnext
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesTrp
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesPool_open
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesCoach_parking
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHotelfacilitiesVoltage
    {
        private int valueField;

        /// <remarks />
        [XmlAttribute]
        public int value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseHairdreyer
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseFax
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseDescription
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePool_hot
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseBoutique
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseLastmodified
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseGym
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseSauna
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseShuttle_apt
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseShuttle_center
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseAddress
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseActive
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilities
    {
        private envelopeResponseRoomsfacilitiesAlarm alarmField;

        private envelopeResponseRoomsfacilitiesFlatiron flatironField;

        private envelopeResponseRoomsfacilitiesMinibar minibarField;

        private envelopeResponseRoomsfacilitiesModem modemField;

        private envelopeResponseRoomsfacilitiesPantsiron pantsironField;

        private envelopeResponseRoomsfacilitiesPaytv paytvField;

        private envelopeResponseRoomsfacilitiesRadio radioField;

        private envelopeResponseRoomsfacilitiesRairconditioning rairconditioningField;

        private envelopeResponseRoomsfacilitiesRfacilities rfacilitiesField;

        private envelopeResponseRoomsfacilitiesRtelephone rtelephoneField;

        private envelopeResponseRoomsfacilitiesSafe safeField;

        private envelopeResponseRoomsfacilitiesTV tvField;

        private envelopeResponseRoomsfacilitiesTvsat tvsatField;

        private envelopeResponseRoomsfacilitiesWifi wifiField;

        /// <remarks />
        public envelopeResponseRoomsfacilitiesRfacilities rfacilities
        {
            get => rfacilitiesField;
            set => rfacilitiesField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesFlatiron flatiron
        {
            get => flatironField;
            set => flatironField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesMinibar minibar
        {
            get => minibarField;
            set => minibarField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesTV tv
        {
            get => tvField;
            set => tvField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesPantsiron pantsiron
        {
            get => pantsironField;
            set => pantsironField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesAlarm alarm
        {
            get => alarmField;
            set => alarmField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesSafe safe
        {
            get => safeField;
            set => safeField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesPaytv paytv
        {
            get => paytvField;
            set => paytvField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesWifi wifi
        {
            get => wifiField;
            set => wifiField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesRtelephone rtelephone
        {
            get => rtelephoneField;
            set => rtelephoneField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesTvsat tvsat
        {
            get => tvsatField;
            set => tvsatField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesRadio radio
        {
            get => radioField;
            set => radioField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesModem modem
        {
            get => modemField;
            set => modemField = value;
        }

        /// <remarks />
        public envelopeResponseRoomsfacilitiesRairconditioning rairconditioning
        {
            get => rairconditioningField;
            set => rairconditioningField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesRfacilities
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesFlatiron
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesMinibar
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesTV
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesPantsiron
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesAlarm
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesSafe
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesPaytv
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesWifi
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesRtelephone
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesTvsat
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesRadio
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesModem
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseRoomsfacilitiesRairconditioning
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseAirconditioning
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseBabysitting
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseName
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseMetro
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseCountry
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseSheets
    {
        private envelopeResponseSheetsTxt txt_exteriorField;

        private envelopeResponseSheetsTxt txt_generalField;

        private envelopeResponseSheetsTxt txt_lobbyField;

        private envelopeResponseSheetsTxt txt_positionField;

        private envelopeResponseSheetsTxt txt_restaurantField;

        private envelopeResponseSheetsTxt txt_roomsField;

        /// <remarks />
        public envelopeResponseSheetsTxt txt_rooms
        {
            get => txt_roomsField;
            set => txt_roomsField = value;
        }

        /// <remarks />
        public envelopeResponseSheetsTxt txt_general
        {
            get => txt_generalField;
            set => txt_generalField = value;
        }

        /// <remarks />
        public envelopeResponseSheetsTxt txt_restaurant
        {
            get => txt_restaurantField;
            set => txt_restaurantField = value;
        }

        /// <remarks />
        public envelopeResponseSheetsTxt txt_exterior
        {
            get => txt_exteriorField;
            set => txt_exteriorField = value;
        }

        /// <remarks />
        public envelopeResponseSheetsTxt txt_position
        {
            get => txt_positionField;
            set => txt_positionField = value;
        }

        /// <remarks />
        public envelopeResponseSheetsTxt txt_lobby
        {
            get => txt_lobbyField;
            set => txt_lobbyField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseSheetsTxt
    {
        private string caField;

        private string deField;

        private string enField;

        private string esField;

        private string frField;

        private string hrField;

        private string itField;

        private string jaField;

        private string plField;

        private string ptbrField;

        private string ruField;

        private string slField;

        private string zhField;

        /// <remarks />
        public string ru
        {
            get => ruField;
            set => ruField = value;
        }

        /// <remarks />
        public string fr
        {
            get => frField;
            set => frField = value;
        }

        /// <remarks />
        public string en
        {
            get => enField;
            set => enField = value;
        }

        /// <remarks />
        public string zh
        {
            get => zhField;
            set => zhField = value;
        }

        /// <remarks />
        public string hr
        {
            get => hrField;
            set => hrField = value;
        }

        /// <remarks />
        public string ca
        {
            get => caField;
            set => caField = value;
        }

        /// <remarks />
        public string de
        {
            get => deField;
            set => deField = value;
        }

        /// <remarks />
        public string it
        {
            get => itField;
            set => itField = value;
        }

        /// <remarks />
        [XmlElement("pt-br")]
        public string ptbr
        {
            get => ptbrField;
            set => ptbrField = value;
        }

        /// <remarks />
        public string es
        {
            get => esField;
            set => esField = value;
        }

        /// <remarks />
        public string sl
        {
            get => slField;
            set => slField = value;
        }

        /// <remarks />
        public string ja
        {
            get => jaField;
            set => jaField = value;
        }

        /// <remarks />
        public string pl
        {
            get => plField;
            set => plField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseCity
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseSolarium
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePosition
    {
        private envelopeResponsePositionAirport airportField;

        private envelopeResponsePositionApt_distance apt_distanceField;

        private envelopeResponsePositionApt_time apt_timeField;

        private envelopeResponsePositionBus_distance bus_distanceField;

        private envelopeResponsePositionBus_time bus_timeField;

        private envelopeResponsePositionCenter_distance center_distanceField;

        private envelopeResponsePositionCenter_time center_timeField;

        private envelopeResponsePositionDimora dimoraField;

        private envelopeResponsePositionFairs fairsField;

        private envelopeResponsePositionMetro_distance metro_distanceField;

        private envelopeResponsePositionMetro_time metro_timeField;

        private envelopeResponsePositionStation_distance station_distanceField;

        private envelopeResponsePositionStation_time station_timeField;

        /// <remarks />
        public envelopeResponsePositionApt_time apt_time
        {
            get => apt_timeField;
            set => apt_timeField = value;
        }

        /// <remarks />
        public envelopeResponsePositionStation_distance station_distance
        {
            get => station_distanceField;
            set => station_distanceField = value;
        }

        /// <remarks />
        public envelopeResponsePositionStation_time station_time
        {
            get => station_timeField;
            set => station_timeField = value;
        }

        /// <remarks />
        public envelopeResponsePositionCenter_time center_time
        {
            get => center_timeField;
            set => center_timeField = value;
        }

        /// <remarks />
        public envelopeResponsePositionMetro_time metro_time
        {
            get => metro_timeField;
            set => metro_timeField = value;
        }

        /// <remarks />
        public envelopeResponsePositionCenter_distance center_distance
        {
            get => center_distanceField;
            set => center_distanceField = value;
        }

        /// <remarks />
        public envelopeResponsePositionMetro_distance metro_distance
        {
            get => metro_distanceField;
            set => metro_distanceField = value;
        }

        /// <remarks />
        public envelopeResponsePositionApt_distance apt_distance
        {
            get => apt_distanceField;
            set => apt_distanceField = value;
        }

        /// <remarks />
        public envelopeResponsePositionFairs fairs
        {
            get => fairsField;
            set => fairsField = value;
        }

        /// <remarks />
        public envelopeResponsePositionAirport airport
        {
            get => airportField;
            set => airportField = value;
        }

        /// <remarks />
        public envelopeResponsePositionBus_time bus_time
        {
            get => bus_timeField;
            set => bus_timeField = value;
        }

        /// <remarks />
        public envelopeResponsePositionBus_distance bus_distance
        {
            get => bus_distanceField;
            set => bus_distanceField = value;
        }

        /// <remarks />
        public envelopeResponsePositionDimora dimora
        {
            get => dimoraField;
            set => dimoraField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionApt_time
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionStation_distance
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionStation_time
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionCenter_time
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionMetro_time
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionCenter_distance
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionMetro_distance
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionApt_distance
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionFairs
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionAirport
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionBus_time
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionBus_distance
    {
        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePositionDimora
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponseShops
    {
        private bool valueField;

        /// <remarks />
        [XmlAttribute]
        public bool value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class envelopeResponsePicture
    {
        private string srcField;

        private int typeField;

        /// <remarks />
        [XmlAttribute]
        public string src
        {
            get => srcField;
            set => srcField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public int type
        {
            get => typeField;
            set => typeField = value;
        }
    }
}