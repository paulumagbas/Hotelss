using System;
using System.Collections.Generic;
       
public class Hotel
{
    public string Name { get; set; }
    public string Location { get; set; }
    public double Rating { get; set; }
    public double PricePerNight { get; set; }
    public string Facilities { get; set; }
    public string Activities { get; set; }

    public Hotel(string name, string location, double rating, double pricePerNight, string facilities, string activities)
    {
        Name = name;
        Location = location;
        Rating = rating;
        PricePerNight = pricePerNight;
        Facilities = facilities;
        Activities = activities;
    }
}
