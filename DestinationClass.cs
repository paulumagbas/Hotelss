using System;
using System.Collections.Generic;

public class Destination
{
    public string Name { get; set; }
    public string Location { get; set; }
    public double Rating { get; set; }

    public Destination(string name, string location, double rating)
    {
        Name = name;
        Location = location;
        Rating = rating;
    }
}
