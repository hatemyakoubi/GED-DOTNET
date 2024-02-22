using System;
using System.Collections.Generic;

namespace Project.NET.Models;

public partial class Action
{
    public int Id { get; set; }

    public int? UtilisateurId { get; set; }

    public string TypeAction { get; set; } = null!;

    public DateTime DateAction { get; set; }

    public virtual User? Utilisateur { get; set; }
}
