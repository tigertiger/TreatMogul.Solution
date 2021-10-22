using System.Collections.Generic;
using System;

namespace TreatMogul.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<Recipe>();
    }

    public int FlavorId {get; set; }
    public string Taste {get; set;}
    public string Cautions {get; set;}
    public virtual ICollection<Recipe> JoinEntities {get;}
  }
}