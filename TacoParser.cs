using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                logger.LogError("Length less than 3");
                return null; 
            }

            // TODO: Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            double latitdue = ParseLatitude(cells[0]);

            //logger.LogWarning("Latitude couldn't parse");


            // TODO: Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            double longitude = ParseLongitude(cells[1]);

            // TODO: Grab the name from your array at index 2

            string name = cells[2];

            // TODO: Create a TacoBell class
            // that conforms to ITrackable

            

            // TODO: Create an instance of the Point Struct

            Point point = new Point();

            // TODO: Set the values of the point correctly (Latitude and Longitude)

            point.Latitude = latitdue;
            point.Longitude = longitude;

            // TODO: Create an instance of the TacoBell class
            // TODO: Set the values of the class correctly (Name and Location)

            TacoBell mysterymeat = new TacoBell() { Name = name, Location = point };

            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable

            return mysterymeat;
        }

        public double ParseLongitude(string line)
        {
            return double.Parse(line);
        }

        public double ParseLatitude(string line)
        {
            if (double.TryParse(line, out double latitude))
            {

            }
            return double.Parse(line);
        }
    }
}
