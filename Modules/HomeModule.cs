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
      Get["/viewPlaces"] = _ => {
        List<Place> allLists = Place.GetAllPlaces();
        return View["viewPlaces.cshtml", allLists];
      };
      Post["/viewPlaces"] = _ => {
        Place newPlace = new Place(Request.Form["placeCity"], Request.Form["StayedDays"], Request.Form["AddPicture"]);
        List<Place> allLists = Place.GetAllPlaces();
        return View["viewPlaces.cshtml", allLists];
      };
      Get ["/clearPlaces"] = _ => {
        Place.ClearAllPlaces();
        return View["clearPlaces.cshtml"];
      };
      Get["/viewPlaces/{id}"] = parameters => {
        Place place = Place.Find(parameters.id);
        return View["/place.cshtml", place];
      };
    }
  }
}
