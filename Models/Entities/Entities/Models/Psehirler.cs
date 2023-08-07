using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Psehirler
{
    public int Id { get; set; }

    public string? IlTrafikKodu { get; set; }

    public string? SehirAdi { get; set; }

    public string? Bolgesi { get; set; }

    public short? UlkeId { get; set; }

    public double? Enlem { get; set; }

    public double? Boylam { get; set; }

    public double? Kdenlem { get; set; }

    public double? Kdboylam { get; set; }

    public double? Gbenlem { get; set; }

    public double? Gbboylam { get; set; }

    public virtual ICollection<FybankaHesabi> FybankaHesabis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual ICollection<IkacikPozisyonlar> IkacikPozisyonlars { get; set; } = new List<IkacikPozisyonlar>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<IkegitimBilgileri> IkegitimBilgileris { get; set; } = new List<IkegitimBilgileri>();

    public virtual ICollection<IkisDeneyimleri> IkisDeneyimleris { get; set; } = new List<IkisDeneyimleri>();

    public virtual ICollection<Lyaraclar> Lyaraclars { get; set; } = new List<Lyaraclar>();

    public virtual ICollection<MiyambarBilgisi> MiyambarBilgisis { get; set; } = new List<MiyambarBilgisi>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PFyvergiDaireleri> PFyvergiDaireleris { get; set; } = new List<PFyvergiDaireleri>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisis { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<Pilceler> Pilcelers { get; set; } = new List<Pilceler>();

    public virtual Pulkeler? Ulke { get; set; }

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
