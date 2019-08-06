//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewFlightPlanItem
    {
        public int Id { get; set; }
        public int taskID { get; set; }
        public int FlightPlanId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public int RegisterID { get; set; }
        public Nullable<int> FlightTypeID { get; set; }
        public string FlightType { get; set; }
        public Nullable<int> AirlineOperatorsID { get; set; }
        public string FlightNumber { get; set; }
        public int FromAirport { get; set; }
        public int ToAirport { get; set; }
        public Nullable<System.DateTime> STA { get; set; }
        public Nullable<System.DateTime> STD { get; set; }
        public int FlightH { get; set; }
        public int FlightM { get; set; }
        public string Unknown { get; set; }
        public string FlightPlan { get; set; }
        public int CustomerId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> DateActive { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public string Customer { get; set; }
        public string FromAirportName { get; set; }
        public string FromAirportIATA { get; set; }
        public string from { get; set; }
        public Nullable<int> FromAirportCityId { get; set; }
        public string ToAirportName { get; set; }
        public string ToAirportIATA { get; set; }
        public string to { get; set; }
        public Nullable<int> ToAirportCityId { get; set; }
        public Nullable<int> BaseId { get; set; }
        public string BaseName { get; set; }
        public string BaseIATA { get; set; }
        public string notes { get; set; }
        public Nullable<int> status { get; set; }
        public int progress { get; set; }
        public Nullable<decimal> duration { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public string taskName { get; set; }
        public string FromAirportCity { get; set; }
        public string ToAirportCity { get; set; }
        public Nullable<int> MSN { get; set; }
        public string Register { get; set; }
        public string AircraftType { get; set; }
        public string FlightStatus { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string FromCity { get; set; }
        public string FromContry { get; set; }
        public string FromSortName { get; set; }
        public string ToCity { get; set; }
        public string ToSortName { get; set; }
        public string ToCountry { get; set; }
        public string Manufacturer { get; set; }
        public Nullable<int> ManufacturerId { get; set; }
        public Nullable<decimal> ToLatitude { get; set; }
        public Nullable<decimal> ToLongitude { get; set; }
        public Nullable<decimal> FromLatitude { get; set; }
        public Nullable<decimal> FromLongitude { get; set; }
        public Nullable<int> RouteId { get; set; }
        public int IsApproved100 { get; set; }
        public int IsApproved50 { get; set; }
        public int IsApproved60 { get; set; }
        public int IsApproved70 { get; set; }
        public int IsApproved80 { get; set; }
        public int IsApproved90 { get; set; }
        public Nullable<int> Interval { get; set; }
        public string IntervalType { get; set; }
        public Nullable<int> BoxId { get; set; }
        public int AssignedCrewCount { get; set; }
        public int AssignedCrewProblemCount { get; set; }
    }
}
