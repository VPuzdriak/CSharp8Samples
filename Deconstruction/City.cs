namespace Deconstruction
{
    public class City
    {
        public string Name { get; }
        public string Country { get; }
        public int SetupYear { get; }

        public City(string name, string country, int setupYear)
        {
            Name = name;
            Country = country;
            SetupYear = setupYear;
        }

        public (string name, string country, int setupYear) Getinfo()
        {
            return (Name, Country, SetupYear);
        }

        public void Deconstruct(out string name, out string country, out int setupYear)
        {
            name = Name;
            country = Country;
            setupYear = SetupYear;
        }
    }
}