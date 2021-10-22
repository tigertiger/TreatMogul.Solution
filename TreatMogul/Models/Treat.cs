using System.Collections.Generic;
using System;

namespace TreatMogul.Models
{
  public class Treat
  {
    public Treat()
    {
        this.JoinEntities = new HashSet<Recipe>();
    }

    public int TreatId { get; set; }
    public string Crub { get; set; }
    public int BatchSize {get; set;}
    public int TreatPrice {get; set;}
    public virtual ICollection<Recipe> JoinEntities { get;}

  }
} 