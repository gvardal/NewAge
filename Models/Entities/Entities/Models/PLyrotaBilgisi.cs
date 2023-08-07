using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PLyrotaBilgisi
{
    public byte RotaId { get; set; }

    public string? RotaAdi { get; set; }

    public virtual ICollection<Miysahesaplar> MiysahesaplarRotaBilgisi1Navigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarRotaBilgisi2Navigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarRotaBilgisi3Navigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<Ikcalisanlar> Calisans { get; set; } = new List<Ikcalisanlar>();
}
