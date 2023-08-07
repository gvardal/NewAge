using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Kysurecler
{
    public short SurecId { get; set; }

    public byte? FirmaId { get; set; }

    public string? SurecKodu { get; set; }

    /// <summary>
    /// Bilgilendirme Süreci
    /// Onay Süreci
    /// </summary>
    public byte? SurecTipi { get; set; }

    public string SurecAdi { get; set; } = null!;

    public string? SurecinAmaci { get; set; }

    public string? Girdileri { get; set; }

    public string? Ciktilari { get; set; }

    public int? IlgiliUnvanId { get; set; }

    public int? SurecSahibiId { get; set; }

    public int? IlgiliScientaSureci { get; set; }

    public short? EtkilesenProses1 { get; set; }

    public short? EtkilesenProses2 { get; set; }

    public short? EtkilesenProses3 { get; set; }

    public short? EtkilesenProses4 { get; set; }

    public string? DiagramEklentiDosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Kysurecler? EtkilesenProses1Navigation { get; set; }

    public virtual Kysurecler? EtkilesenProses2Navigation { get; set; }

    public virtual Kysurecler? EtkilesenProses3Navigation { get; set; }

    public virtual Kysurecler? EtkilesenProses4Navigation { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<IihaberBandi> IihaberBandis { get; set; } = new List<IihaberBandi>();

    public virtual ICollection<Kysurecler> InverseEtkilesenProses1Navigation { get; set; } = new List<Kysurecler>();

    public virtual ICollection<Kysurecler> InverseEtkilesenProses2Navigation { get; set; } = new List<Kysurecler>();

    public virtual ICollection<Kysurecler> InverseEtkilesenProses3Navigation { get; set; } = new List<Kysurecler>();

    public virtual ICollection<Kysurecler> InverseEtkilesenProses4Navigation { get; set; } = new List<Kysurecler>();

    public virtual ICollection<Kydof> Kydofs { get; set; } = new List<Kydof>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlanis { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();

    public virtual ICollection<KyriskYonetimi> KyriskYonetimis { get; set; } = new List<KyriskYonetimi>();

    public virtual ICollection<KysurecSahipleri> KysurecSahipleris { get; set; } = new List<KysurecSahipleri>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? SurecSahibi { get; set; }

    public virtual ICollection<UyisAkisSoruGruplari> UyisAkisSoruGruplaris { get; set; } = new List<UyisAkisSoruGruplari>();
}
