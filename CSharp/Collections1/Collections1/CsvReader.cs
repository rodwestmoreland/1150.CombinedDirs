using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Collections1
{
    class CsvReader
    {
        private string _csvPath;
        public CsvReader(string csvfilePath)
        {
            this._csvPath = csvfilePath;

        }
        public Dictionary<string, Country> ReadCountries()
        {
            var countries = new Dictionary<string, Country>();
          
            using (StreamReader sr = new StreamReader(_csvPath))
            {
                sr.ReadLine();
                
                string csvLine;
                while ((csvLine = sr.ReadLine()) != null )
                {
                    Country country = ReadCountryFromFile(csvLine);
                    countries.Add(country.Code, country);

                }
                
            };
            return countries;
        }
        public Country ReadCountryFromFile(string csvLine)
        {
            {
                string[] parts = csvLine.Split(new char[]{','});
                string name = parts[0];
                string code = parts[1];
                string region = parts[2];
                int pop = int.Parse(parts[3]);
                return new Country(name,code,region,pop);

            }
        }
    }
}
