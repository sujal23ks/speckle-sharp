﻿using System;
using Objects.Geometry;
using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;
using System.Linq;
using Objects.Utils;
using Speckle.Newtonsoft.Json;

namespace Objects.BuiltElements.Revit
{
  public class FreeformElement : Base , IDisplayMesh
  {
    public Base parameters { get; set; }
    
    public string elementId { get; set; }
    
    /// <summary>
    /// DEPRECATED. Sets the geometry contained in the FreeformElement. This field has been deprecated in favor of `baseGeometries`
    /// to align with Revit's API. It remains as a setter-only property for backwards compatibility.
    /// It will set the first item on the baseGeometries list, and instantiate a list if necessary.
    /// </summary>
    [JsonIgnore]
    [SchemaIgnore]
    public Base baseGeometry {
      set
      {
        if (baseGeometries == null) baseGeometries = new List<Base> { value };
        else if (baseGeometries.Count == 0) baseGeometries.Add(value);
        else baseGeometries[0] = value;
      }
    }

    [DetachProperty]
    [Chunkable]
    public List<Base> baseGeometries { get; set; }
    
    [DetachProperty]
    public Mesh displayMesh { get; set; }

    public string units { get; set; }

    public FreeformElement() { }

    
    [SchemaDeprecated, SchemaInfo("Freeform element", "Creates a Revit Freeform element using a list of Brep or Meshes.", "Revit", "Families")]
    public FreeformElement(Base baseGeometry, List<Parameter> parameters = null)
    {
      if (!IsValidObject(baseGeometry))
        throw new Exception("Freeform elements can only be created from BREPs or Meshes");
      this.baseGeometry = baseGeometry;
      this.parameters = parameters.ToBase();
    }
    
    [SchemaInfo("Freeform element", "Creates a Revit Freeform element using a list of Brep or Meshes.", "Revit", "Families")]
    public FreeformElement(List<Base> baseGeometries, List<Parameter> parameters = null)
    {
      this.baseGeometries = baseGeometries;
      if (!IsValid())
        throw new Exception("Freeform elements can only be created from BREPs or Meshes");
      this.parameters = parameters.ToBase();
    }
    
    public bool IsValid() => baseGeometries.All(IsValidObject);
    
    public bool IsValidObject(Base @base) =>
      @base is Mesh
      || @base is Brep
      || @base is Geometry.Curve;
  }
}
