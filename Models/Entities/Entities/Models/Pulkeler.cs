using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Pulkeler
{
    public short Id { get; set; }

    public string? Ulkeadi { get; set; }

    public string? Bolgesi { get; set; }

    public string? TelefonKodu { get; set; }

    public string? UlkeKodu { get; set; }

    public string? EnulkeAdi { get; set; }

    public string? GtbulkeKodlari { get; set; }

    public virtual ICollection<FybankaHesabi> FybankaHesabis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<IkacikPozisyonlar> IkacikPozisyonlars { get; set; } = new List<IkacikPozisyonlar>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<IkegitimBilgileri> IkegitimBilgileris { get; set; } = new List<IkegitimBilgileri>();

    public virtual ICollection<IkisDeneyimleri> IkisDeneyimleris { get; set; } = new List<IkisDeneyimleri>();

    public virtual ICollection<MiyambarBilgisi> MiyambarBilgisis { get; set; } = new List<MiyambarBilgisi>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PFyvergiDaireleri> PFyvergiDaireleris { get; set; } = new List<PFyvergiDaireleri>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisis { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<Psehirler> Psehirlers { get; set; } = new List<Psehirler>();
}
