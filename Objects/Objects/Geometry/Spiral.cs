using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects.Primitive;
using Speckle.Core.Kits;
using Speckle.Core.Models;

namespace Objects.Geometry
{
  public enum SpiralType
  {
    Arithmetic, // Archimedean
    Euler, // clothoid, Cornu
    Fibonacci, // golden
    Hyperbolic,
    Lituus,
    Logarithmic,
    Parabolic // Fermat's
  }

  public class Spiral : Base, ICurve, IHasBoundingBox
  {
    public Point startPoint { get; set; }
    public Point endPoint { get; set; }
    public double startAngle { get; set; }
    public double endAngle { get; set; }
    public Plane plane { get; set; }
    public double turns { get; set; }
    public Vector pitchAxis { get; set; } = new Vector();
    public double angle { get; set; }

    public double slope { get; set; }

    public double pitch { get; set; } = 0;

    //public SpiralType spiralType { get; set; }

    public Polyline displayValue { get; set; }

    public Box bbox { get; set; }

    public double length { get; set; }

    public Interval domain { get; set; }

    public string units { get; set; }

    public Spiral() { }
  }
}
