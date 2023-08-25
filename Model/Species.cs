using CsvHelper.Configuration.Attributes;

namespace graphql_server.Model
{
    public class Species
    {
        //name,classification,designation,average_height,skin_colors,hair_colors,eye_colors,average_lifespan,language,homeworld
        [Index(0)]
        public string Name { get; set; }
        [Index(1)]
        public string Classification { get; set; }
        [Index(2)]
        public string Designation { get; set; }
        [Index(3)]
        public string AverageHeight { get; set; }
        [Index(4)]
        public string SkinColors { get; set; }
        [Index(5)]
        public string HairColors { get; set; }
        [Index(6)]
        public string EyeColors { get; set; }
        [Index(7)]
        public string AverageLifespan { get; set; }
        [Index(8)]
        public string Language { get; set; }
        [Index(9)]
        public string Homeworld { get; set; }
    }
}
