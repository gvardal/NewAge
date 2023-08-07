using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class BugunIseGelenler
{
    public int Id { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public string? Birimi { get; set; }

    public string? Unvani { get; set; }

    public string? CalismaGrubu { get; set; }

    public DateTime? Giris { get; set; }

    public DateTime? Cikis { get; set; }

    public DateTime? Tarih { get; set; }
}
