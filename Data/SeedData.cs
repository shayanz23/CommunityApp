using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommunityApp.Models;

namespace CommunityApp.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }
        public static List<Province> GetProvinces()
        {
            List<Province> Provinces = new List<Province>() {
                new Province() {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia"
                },
                new Province() {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                },
                new Province() {
                    ProvinceCode = "SK",
                    ProvinceName = "Saskatchewan"
                },
                new Province() {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario"
                }
            };

            return Provinces;
        }

        public static List<City> GetCities()
        {
            List<City> Cities = new List<City>() {
                new City() {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 675218,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 2,
                    CityName = "Victoria",
                    Population = 344615,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 3,
                    CityName = "Kelowna",
                    Population = 142146,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 4,
                    CityName = "Calgary",
                    Population = 1096833,
                    ProvinceCode = "AB"
                },
                new City() {
                    CityId = 5,
                    CityName = "Edmonton",
                    Population = 960015,
                    ProvinceCode = "AB"
                },
                new City() {
                    CityId = 6,
                    CityName = "Red Deer",
                    Population = 100418,
                    ProvinceCode = "AB"
                },
                new City() {
                    CityId = 7,
                    CityName = "Toronto",
                    Population = 2930000,
                    ProvinceCode = "ON"
                },
                new City() {
                    CityId = 8,
                    CityName = "Ottawa",
                    Population = 934243,
                    ProvinceCode = "ON"
                },
                new City() {
                    CityId = 9,
                    CityName = "Hamilton",
                    Population = 536917,
                    ProvinceCode = "ON"
                },
            };

            return Cities;
        }
    }
}