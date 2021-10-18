using System.Collections.Generic;

namespace AirbnbClone.API.Models.Response
{
    public class PlaceResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Space { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal WeeklyPrice { get; set; }
        public decimal MonthlyPrice { get; set; }
        public decimal CleaningFee { get; set; }
        public decimal ExtraPeople { get; set; }
        public Images Images { get; set; }
        public Address Address { get; set; }
    }
    
    public class Location
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
        public bool IsLocationExact { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string GovernmentArea { get; set; }
        public string Market { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public Location Location { get; set; }
    }
    
    public class Images
    {
        public string ThumbnailUrl { get; set; }
        public string MediumUrl { get; set; }
        public string PictureUrl { get; set; }
        public string XlPictureUrl { get; set; }
    }
}