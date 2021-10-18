using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace AirbnbClone.Domain.Models
{
    public class Images
    {
        [BsonElement("thumbnail_url")]
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        [BsonElement("medium_url")]
        [JsonProperty("medium_url")]
        public string MediumUrl { get; set; }
        [BsonElement("picture_url")]
        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; }
        [BsonElement("xl_picture_url")]
        [JsonProperty("xl_picture_url")]
        public string XlPictureUrl { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Host
    {
        [BsonElement("host_id")]
        [JsonProperty("host_id")]
        public string HostId { get; set; }
        [BsonElement("host_url")]
        [JsonProperty("host_url")]
        public string HostUrl { get; set; }
        [BsonElement("host_name")]
        [JsonProperty("host_name")]
        public string HostName { get; set; }
        [BsonElement("host_location")]
        [JsonProperty("host_location")]
        public string HostLocation { get; set; }
        [BsonElement("host_about")]
        [JsonProperty("host_about")]
        public string HostAbout { get; set; }
        [BsonElement("host_thumbnail_url")]
        [JsonProperty("host_thumbnail_url")]
        public string HostThumbnailUrl { get; set; }
        [BsonElement("host_picture_url")]
        [JsonProperty("host_picture_url")]
        public string HostPictureUrl { get; set; }
        [BsonElement("host_neighbourhood")]
        [JsonProperty("host_neighbourhood")]
        public string HostNeighbourhood { get; set; }
        [BsonElement("host_is_superhost")]
        [JsonProperty("host_is_superhost")]
        public bool HostIsSuperhost { get; set; }
        [BsonElement("host_has_profile_pic")]
        [JsonProperty("host_has_profile_pic")]
        public bool HostHasProfilePic { get; set; }
        [BsonElement("host_identity_verified")]
        [JsonProperty("host_identity_verified")]
        public bool HostIdentityVerified { get; set; }
        [BsonElement("host_listings_count")]
        [JsonProperty("host_listings_count")]
        public int HostListingsCount { get; set; }
        [BsonElement("host_total_listings_count")]
        [JsonProperty("host_total_listings_count")]
        public int HostTotalListingsCount { get; set; }
        [BsonElement("host_verifications")]
        [JsonProperty("host_verifications")]
        public List<string> HostVerifications { get; set; }
    }

    public class Location
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
        [BsonElement("is_location_exact")]
        [JsonProperty("is_location_exact")]
        public bool IsLocationExact { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string Suburb { get; set; }
        [BsonElement("government_area")]
        [JsonProperty("government_area")]
        public string GovernmentArea { get; set; }
        public string Market { get; set; }
        public string Country { get; set; }
        [BsonElement("country_code")]
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        public Location Location { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Place
    {
        [BsonId]
        [BsonElement("_id")]
        [JsonProperty("_id")]
        public string Id { get; set; }
        [BsonElement("listing_url")]
        [JsonProperty("listing_url")]
        public string ListingUrl { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Space { get; set; }
        public string Description { get; set; }
        [BsonElement("neighborhood_overview")]
        [JsonProperty("neighborhood_overview")]
        public string NeighborhoodOverview { get; set; }
        public string Notes { get; set; }
        public string Transit { get; set; }
        public string Access { get; set; }
        public string Interaction { get; set; }
        [BsonElement("house_rules")]
        [JsonProperty("house_rules")]
        public string HouseRules { get; set; }
        [BsonElement("property_type")]
        [JsonProperty("property_type")]
        public string PropertyType { get; set; }
        [BsonElement("room_type")]
        [JsonProperty("room_type")]
        public string RoomType { get; set; }
        [BsonElement("bed_type")]
        [JsonProperty("bed_type")]
        public string BedType { get; set; }
        [BsonElement("minimum_nights")]
        [JsonProperty("minimum_nights")]
        public string MinimumNights { get; set; }
        [BsonElement("maximum_nights")]
        [JsonProperty("maximum_nights")]
        public string MaximumNights { get; set; }
        [BsonElement("cancellation_policy")]
        [JsonProperty("cancellation_policy")]
        public string CancellationPolicy { get; set; }
        public int Accommodates { get; set; }
        public int Bedrooms { get; set; }
        public int Beds { get; set; }
        [BsonElement("number_of_reviews")]
        [JsonProperty("number_of_reviews")]
        public int NumberOfReviews { get; set; }
        public int Bathrooms { get; set; }
        public List<string> Amenities { get; set; }
        public decimal Price { get; set; }
        [BsonElement("weekly_price")]
        [JsonProperty("weekly_price")]
        public decimal WeeklyPrice { get; set; }
        [BsonElement("monthly_price")]
        [JsonProperty("monthly_price")]
        public decimal MonthlyPrice { get; set; }
        [BsonElement("cleaning_fee")]
        [JsonProperty("cleaning_fee")]
        public decimal CleaningFee { get; set; }
        [BsonElement("extra_people")]
        [JsonProperty("extra_people")]
        public decimal ExtraPeople { get; set; }
        [BsonElement("guests_included")]
        [JsonProperty("guests_included")]
        public int GuestsIncluded { get; set; }
        public Images Images { get; set; }
        public Host Host { get; set; }
        public Address Address { get; set; }
    }
}