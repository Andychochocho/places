using Nancy;
// Replace sample.objects
using Places.Objects;
using System.Collections.Generic;

// Replace namespace
namespace Places
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["Places.cshtml"];
      };
    }
  }
}
