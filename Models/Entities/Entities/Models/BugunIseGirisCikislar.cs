using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class BugunIseGirisCikislar
{
    public int Id { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public string? Birimi { get; set; }

    public string? Unvani { get; set; }

    public string? CalismaGrubu { get; set; }

    public byte[]? Resim { get; set; }

    public DateTime Tarih { get; set; }

    public string? CihazIp { get; set; }
}
