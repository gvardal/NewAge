using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFbankalar
{
    public byte BankaId { get; set; }

    public string? BankaAdi { get; set; }

    public string? BankaTuru { get; set; }

    public bool? Aktif { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual ICollection<FybankaHesabi> FybankaHesabis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplaris { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarIbanbanka1Navigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarIbanbanka2Navigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarIbanbanka3Navigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarIbanbanka4Navigations { get; set; } = new List<Miysahesaplar>();
}
