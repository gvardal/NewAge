using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyisEmriRotaOnculleri
{
    public int IsEmriRotaOnculId { get; set; }

    public int? OncekiIsEmriRotaId { get; set; }

    public int? SonrakiIsEmriRotaId { get; set; }

    public string? Tur { get; set; }

    public decimal? Oteleme { get; set; }

    public virtual UyisEmriRotasi? OncekiIsEmriRota { get; set; }

    public virtual UyisEmriRotasi? SonrakiIsEmriRota { get; set; }
}
