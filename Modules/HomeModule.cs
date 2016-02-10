using Nancy;
using Places.Objects;
using System.Collections.Generic;

namespace PlacesName
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["formPlaces.cshtml"];
      Post["/viewPlaces"] = _ => {
        Place newPlace = new Place(Request.Form["placeCity"]);
        List<Place> allLists = Place.GetAllCities();
        return View["viewPlaces.cshtml", allLists];
      };
    }
  }
}
