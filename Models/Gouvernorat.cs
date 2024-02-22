using System;
using System.Collections.Generic;

namespace Project.NET.Models;

public partial class Gouvernorat
{
    public int Id { get; set; }

    public string Identifiant { get; set; } = null!;

    public string Libelle { get; set; } = null!;
}
