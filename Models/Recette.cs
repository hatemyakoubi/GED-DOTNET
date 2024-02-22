using System;
using System.Collections.Generic;

namespace Project.NET.Models;

public partial class Recette
{
    public int Id { get; set; }

    public int? CodeCentreId { get; set; }

    public string Code { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public virtual Structure? CodeCentre { get; set; }
}
