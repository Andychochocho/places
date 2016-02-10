using System.Collections.Generic;
namespace Places.Objects
{
  public class Place
  {
    private string _cityName;
    private static List<Place> _instances = new List<Place> {};
    public Place(string CityName)
    {
      _cityName = CityName;
      _instances.Add(this);
    }
    public string GetCities()
    {
      return _cityName;
    }
    public void SetCities(string newCityName)
    {
      newCityName = _cityName;
    }
    public static List<Place> GetAllPlaces()
    {
      return _instances;
    }
    public static void ClearAllPlaces()
    {
      _instances.Clear();
    }
  }
}
