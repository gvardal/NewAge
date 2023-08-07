using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class ByyillikBakimPlani
{
    public int BakimPlaniId { get; set; }

    public byte? FirmaId { get; set; }

    public bool? ArizaBakim { get; set; }

    public short? ArizaBakimCinsiId { get; set; }

    public short? ArizaBakimAciklamaId { get; set; }

    public string? Aciklama { get; set; }

    public byte? DurumId { get; set; }

    public int? KonumId { get; set; }

    public int? MakinaId { get; set; }

    public int? BildirenCalisanId { get; set; }

    public int? BakimEkibiId { get; set; }

    public byte? BakimArizaTuruId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public string? Konu { get; set; }

    public string? YapilanBakimOnarim { get; set; }

    public short? DokumanAdi { get; set; }

    public short? IsAkisSoruGrubuId { get; set; }

    public string? BakimPeriyodu { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public int? GerceklesenSure { get; set; }

    public int? BakimYapanCalisanId { get; set; }

    public bool? Garanti { get; set; }

    public bool? Servis { get; set; }

    public bool? ParcaDegisimi { get; set; }

    public short? BakimSozlesmesiId { get; set; }

    public decimal? OnarimMaliyeti { get; set; }

    public bool? EpostaGonderildi { get; set; }

    public string? EpostaGonderen { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual PByarizaBakimAciklamasi? ArizaBakimAciklama { get; set; }

    public virtual PByarizaBakimCinsi? ArizaBakimCinsi { get; set; }

    public virtual PByarizaBakimTuru? BakimArizaTuru { get; set; }

    public virtual YmbakimEkibi? BakimEkibi { get; set; }

    public virtual Sysasozlesmeler? BakimSozlesmesi { get; set; }

    public virtual Ikcalisanlar? BakimYapanCalisan { get; set; }

    public virtual Ikcalisanlar? BildirenCalisan { get; set; }

    public virtual ICollection<BydegisenParcaListesi> BydegisenParcaListesis { get; set; } = new List<BydegisenParcaListesi>();

    public virtual PBybakimDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual UyisAkisSoruGruplari? IsAkisSoruGrubu { get; set; }

    public virtual UyisEmriRotasi? IsEmriRota { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual Fdemirba? Makina { get; set; }

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileris { get; set; } = new List<UyisAkisVerileri>();
}
