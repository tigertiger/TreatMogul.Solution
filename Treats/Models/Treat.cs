using System.Collections.Generic;
using System;

namespace Treats.Models
{
  public class Treat
  {
    public Treat()
    {
        this.JoinEntities = new HashSet<Recipe>();
    }

    public int TreatId { get; set; }
    public string Crub { get; set; }
    public virtual ICollection<Recipe> JoinEntities { get;}

  }
} 