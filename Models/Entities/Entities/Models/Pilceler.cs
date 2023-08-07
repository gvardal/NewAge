using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Pilceler
{
    public int IlceId { get; set; }

    public int? IlId { get; set; }

    public string? IlceKodu { get; set; }

    public string Ad { get; set; } = null!;

    public double? Enlem { get; set; }

    public double? Boylam { get; set; }

    public double? Kdenlem { get; set; }

    public double? Kdboylam { get; set; }

    public double? Gbenlem { get; set; }

    public double? Gbboylam { get; set; }

    public virtual ICollection<FybankaHesabi> FybankaHesabis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual Psehirler? Il { get; set; }

    public virtual ICollection<MiyambarBilgisi> MiyambarBilgisis { get; set; } = new List<MiyambarBilgisi>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisis { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
