using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ComputerAPI.Models;

public partial class Osystem
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<Comp> Comps { get; set; } = new List<Comp>();
}
