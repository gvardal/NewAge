using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Lyaraclar
{
    public short AracId { get; set; }

    public byte? FirmaId { get; set; }

    public bool? KiralikDemirbas { get; set; }

    public string Plaka { get; set; } = null!;

    public int? DemirbasId { get; set; }

    public byte? AracTipId { get; set; }

    public short? Gpsid { get; set; }

    public short? MarkaId { get; set; }

    public int? SurucuId { get; set; }

    public short? DepartmanId { get; set; }

    public byte[]? OndenResmi { get; set; }

    public byte[]? ArkadanResmi { get; set; }

    public byte[]? YandanResmi { get; set; }

    public string? Ogsno { get; set; }

    public DateTime? Model { get; set; }

    public DateTime? TrafigeCikisTarihi { get; set; }

    public string? Rengi { get; set; }

    public string? MotorNo { get; set; }

    public string? SaseNo { get; set; }

    public string? RuhsatSahibiTcknVn { get; set; }

    public string? RuhsatSahibiSoyadUnvan { get; set; }

    public string? RuhsatSahibiAdi { get; set; }

    public string? RuhsatSahibiAdres { get; set; }

    public short? NetAgirligi { get; set; }

    public short? AzamiYukluAgirligi { get; set; }

    public short? KatarAgirligi { get; set; }

    public short? RomorkAzamiYukluAgirligi { get; set; }

    public short? KoltukSayisi { get; set; }

    public short? AyaktaYolcuSayisi { get; set; }

    public short? SilindirHacmi { get; set; }

    public string? AracSinifi { get; set; }

    public string? Aciklama { get; set; }

    public string? TicariAdi { get; set; }

    public DateTime? KiralamaGelisTarihi { get; set; }

    public DateTime? KiralamaIadeTarihi { get; set; }

    public string? KiralananFirma { get; set; }

    public int? SatinAlmaId { get; set; }

    public int? RuhsatınVerildigiIl { get; set; }

    public int? TescilSiraNo { get; set; }

    public DateTime? IlkTescilTarihi { get; set; }

    public DateTime? TescilTarihi { get; set; }

    public DateTime? MuayeneTarihi { get; set; }

    public DateTime? EgzozEmisyonTarihi { get; set; }

    public string? TrafikSigortaSirketi { get; set; }

    public DateTime? TrafikSigortaTarihi { get; set; }

    public string? KaskoSirketi { get; set; }

    public DateTime? KaskoTarihi { get; set; }

    public DateTime? SonGuncellemeTarihi { get; set; }

    public virtual PLyaracTipi? AracTip { get; set; }

    public virtual Fdemirba? Demirbas { get; set; }

    public virtual Ikorganizasyonlar? Departman { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual Lygpstanim? Gps { get; set; }

    public virtual ICollection<LyaracIslemi> LyaracIslemis { get; set; } = new List<LyaracIslemi>();

    public virtual PLyaracMarkasi? Marka { get; set; }

    public virtual Psehirler? RuhsatınVerildigiIlNavigation { get; set; }

    public virtual Ikcalisanlar? Surucu { get; set; }

    public virtual ICollection<YmbakimEkibi> YmbakimEkibis { get; set; } = new List<YmbakimEkibi>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
