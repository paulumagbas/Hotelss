using System;

class Program
{
    static void Main(string[] args)
    {
        TravelDestinations.TravelPicker();
    }
}

class TravelDestinations
{
    public static void TravelPicker()
    {
        bool shouldContinue = true;
        while (shouldContinue)
        {
            Console.WriteLine("Hi! Welcome to Destination Picker. Where would you like to travel?:\n");

            Console.WriteLine("1. Beach");
            Console.WriteLine("2. National Park");
            Console.WriteLine("3. City");
            Console.WriteLine("4. Exit");

            Console.WriteLine("\nEnter the number of a destination to learn more: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayBeachDestinations();
                    break;
                case 2:
                    DisplayNationalParkDestinations();
                    break;
                case 3:
                    DisplayCityDestinations();
                    break;
                case 4:
                    shouldContinue = false; // Exit the program
                    Console.WriteLine("Thank you for using Destination Picker!");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayBeachDestinations()
    {
        Console.WriteLine("\nHere is a list of beaches to travel:");
        Console.WriteLine("1. Boracay, Philippines");
        Console.WriteLine("2. Maldives");
        Console.WriteLine("3. Palawan, Philippines");

        Console.WriteLine("\nEnter the number of a beach to see available hotels and activities: ");

        int innerChoice = Convert.ToInt32(Console.ReadLine());

        switch (innerChoice)
        {
            case 1:
                DisplayBeachHotels("Boracay, Philippines");
                break;
            case 2:
                DisplayBeachHotels("Maldives");
                break;
            case 3:
                DisplayBeachHotels("Palawan, Philippines");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void DisplayBeachHotels(string beach)
    {
        Console.WriteLine($"\nHere are some available hotels in {beach}:");
        Console.WriteLine("1. Aqua Boracay");
        Console.WriteLine("2. Feliz Hotel Boracay");
        Console.WriteLine("3. Crimson Resort and Spa Boracay");
        Console.WriteLine("4. Coast Boracay");
        Console.WriteLine("5. The Strand Boutique Resort");

        Console.WriteLine("\nEnter the number of a hotel to see more information: ");

        int hotelChoice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        switch (hotelChoice)
        {
            case 1:
                Hotel aquaBoracay = new Hotel("Aqua Boracay", "Boracay, Philippines", 4.5, 200, "Beachfront, swimming pool, spa", "Scuba diving, snorkeling, island hopping");
                DisplayHotelInformation(aquaBoracay);
                break;
            case 2:
                Hotel felizHotelBoracay = new Hotel("Feliz Hotel Boracay", "Boracay, Philippines", 4, 150, "Beachfront, restaurant, gym", "Jet skiing, parasailing, sunset cruises");
                DisplayHotelInformation(felizHotelBoracay);
                break;
            case 3:
                Hotel crimsonResortBoracay = new Hotel("Crimson Resort and Spa Boracay", "Boracay, Philippines", 5, 300, "Private beach, infinity pool, spa", "Yoga classes, beach volleyball, paddleboarding");
                DisplayHotelInformation(crimsonResortBoracay);
                break;
            case 4:
                Hotel coastBoracay = new Hotel("Coast Boracay", "Boracay, Philippines", 4, 180, "Beachfront, poolside bar, fitness center", "Snorkeling tours, island hopping, beach parties");
                DisplayHotelInformation(coastBoracay);
                break;
            case 5:
                Hotel strandBoutiqueResort = new Hotel("The Strand Boutique Resort", "Boracay, Philippines", 4.5, 220, "Beachfront, restaurant, rooftop bar", "Spa treatments, yoga sessions, sunset sailing");
                DisplayHotelInformation(strandBoutiqueResort);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void DisplayNationalParkDestinations()
    {
        Console.WriteLine("\nHere is a list of national parks to travel:");
        Console.WriteLine("1. Yellowstone National Park, USA");
        Console.WriteLine("2. Banff National Park, Canada");
        Console.WriteLine("3. Plitvice Lakes National Park, Croatia");

        Console.WriteLine("\nEnter the number of a national park to see available hotels and activities: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                DisplayNationalParkHotels("Yellowstone National Park, USA");
                break;
            case 2:
                DisplayNationalParkHotels("Banff National Park, Canada");
                break;
            case 3:
                DisplayNationalParkHotels("Plitvice Lakes National Park, Croatia");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void DisplayNationalParkHotels(string park)
    {
        Console.WriteLine($"\nHere are some available hotels in {park}:");
        Console.WriteLine("1. Old Faithful Inn");
        Console.WriteLine("2. Lake Yellowstone Hotel and Cottages");
        Console.WriteLine("3. Canyon Lodge and Cabins");
        Console.WriteLine("4. Yellowstone Park Hotel");
        Console.WriteLine("5. Kelly Inn-West Yellowstone");

        Console.WriteLine("\nEnter the number of a hotel to see more information: ");

        int hotelChoice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        switch (hotelChoice)
        {
            case 1:
                Hotel oldFaithfulInn = new Hotel("Old Faithful Inn", "Yellowstone National Park, USA", 4.5, 250, "Historic lodge, restaurant, gift shop", "Hiking, wildlife watching, geysers");
                DisplayHotelInformation(oldFaithfulInn);
                break;
            case 2:
                Hotel lakeYellowstoneHotel = new Hotel("Lake Yellowstone Hotel and Cottages", "Yellowstone National Park, USA", 4, 300, "Lakefront views, dining room, lounge", "Fishing, boating, guided tours");
                DisplayHotelInformation(lakeYellowstoneHotel);
                break;
            case 3:
                Hotel canyonLodge = new Hotel("Canyon Lodge and Cabins", "Yellowstone National Park, USA", 4, 200, "Lodge rooms, cabins, dining options", "Hiking, horseback riding, camping");
                DisplayHotelInformation(canyonLodge);
                break;
            case 4:
                Hotel yellowstoneParkHotel = new Hotel("Yellowstone Park Hotel", "Yellowstone National Park, USA", 3.5, 180, "Hotel rooms, restaurant, lounge", "Wildlife tours, photography workshops, rafting");
                DisplayHotelInformation(yellowstoneParkHotel);
                break;
            case 5:
                Hotel kellyInnWestYellowstone = new Hotel("Kelly Inn-West Yellowstone", "Yellowstone National Park, USA", 3, 150, "Hotel rooms, indoor pool, hot tub", "Snowmobiling, cross-country skiing, snowshoeing");
                DisplayHotelInformation(kellyInnWestYellowstone);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void DisplayCityDestinations()
    {
        Console.WriteLine("\nHere is a list of cities to travel:");
        Console.WriteLine("1. New York City, USA");
        Console.WriteLine("2. Tokyo, Japan");
        Console.WriteLine("3. Dubai, UAE");

        Console.WriteLine("\nEnter the number of a city to see available hotels and activities: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                DisplayCityHotels("New York City, USA");
                break;
            case 2:
                DisplayCityHotels("Tokyo, Japan");
                break;
            case 3:
                DisplayCityHotels("Dubai, UAE");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void DisplayCityHotels(string city)
    {
        Console.WriteLine($"\nHere are some available hotels in {city}:");
        Console.WriteLine("1. Gansevoort Meatpacking NYC");
        Console.WriteLine("2. Moxy NYC Times Square");
        Console.WriteLine("3. The Westin New York at Times Square");
        Console.WriteLine("4. The Knickerbocker");
        Console.WriteLine("5. Royalton Park Avenue");

        Console.WriteLine("\nEnter the number of a hotel to see more information: ");

        int hotelChoice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        switch (hotelChoice)
        {
            case 1:
                Hotel gansevoortMeatpacking = new Hotel("Gansevoort Meatpacking NYC", "New York City, USA", 4.5, 350, "Rooftop pool, spa, restaurant", "Shopping, sightseeing, Broadway shows");
                DisplayHotelInformation(gansevoortMeatpacking);
                break;
            case 2:
                Hotel moxyNYCTimesSquare = new Hotel("Moxy NYC Times Square", "New York City, USA", 4, 250, "Bar, fitness center, lounge", "Times Square exploration, museums, nightlife");
                DisplayHotelInformation(moxyNYCTimesSquare);
                break;
            case 3:
                Hotel westinNYC = new Hotel("The Westin New York at Times Square", "New York City, USA", 4.5, 300, "Fitness studio, restaurant, business center", "Central Park visits, Broadway shows, shopping");
                DisplayHotelInformation(westinNYC);
                break;
            case 4:
                Hotel knickerbocker = new Hotel("The Knickerbocker", "New York City, USA", 4, 280, "Rooftop bar, restaurant, fitness center", "Statue of Liberty tour, Empire State Building, theaters");
                DisplayHotelInformation(knickerbocker);
                break;
            case 5:
                Hotel royaltonParkAvenue = new Hotel("Royalton Park Avenue", "New York City, USA", 4.5, 320, "Rooftop pool, lounge, fitness center", "High Line park, shopping in SoHo, art galleries");
                DisplayHotelInformation(royaltonParkAvenue);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void DisplayHotelInformation(Hotel hotel)
    {
        Console.WriteLine(hotel.Name);
        Console.WriteLine($"Location: {hotel.Location}");
        Console.WriteLine($"Rating: {hotel.Rating} stars");
        Console.WriteLine($"Price per night: ${hotel.PricePerNight}");
        Console.WriteLine($"Facilities: {hotel.Facilities}");
        Console.WriteLine($"Activities: {hotel.Activities}");

}
