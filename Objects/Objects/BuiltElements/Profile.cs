using Objects.Geometry;
using Speckle.Core.Kits;
using Speckle.Core.Models;
using Speckle.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.BuiltElements
{
  public class Profile : Base
  {
    public List<ICurve> curves { get; set; }

    public string name { get; set; }

    public double startStation { get; set; }

    public double endStation { get; set; }

    public Polyline displayValue { get; set; }

    public string units { get; set; }

    public Profile() { }

  }
}
