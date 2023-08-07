using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyuretimPlaniListesi
{
    public string? KonumKodu { get; set; }

    public string? KonumAdi { get; set; }

    public string? Kodu { get; set; }

    public string? IslemTuruAdi { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public string? UretimTuru { get; set; }

    public string? Durum { get; set; }

    public long UretimPlaniId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public string? UretimPlaniKodu { get; set; }

    public byte? RevizyonNo { get; set; }

    public byte? UretimPlaniTuruId { get; set; }

    public int? MiysahesapId { get; set; }

    public int? ProjeId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public int? SiparisId { get; set; }

    public int? UrunId { get; set; }

    public decimal? UretimMiktari { get; set; }

    public decimal? StokMiktari { get; set; }

    public decimal? FireMiktari { get; set; }

    public int? LotBuyuklugu { get; set; }

    public string? Oncelik { get; set; }

    public DateTime PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitimTarihi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitimTarihi { get; set; }

    public decimal? GerceklesenSure { get; set; }

    public string? Aciklama { get; set; }

    public string? UretimHatti { get; set; }

    public decimal? UretimKatsayisi { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? KesimIsEmriNo { get; set; }

    public int? KonumId { get; set; }

    public decimal? KullanilabilirFireOrani { get; set; }

    public decimal? HurdaOrani { get; set; }

    public short? IslemTuruId { get; set; }

    public decimal? IslemSuresi { get; set; }

    public string? CamdosyaYolu { get; set; }

    public bool? UretimPlaniOnayi { get; set; }

    public int? Onaylayan { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeKaydiTarihi { get; set; }

    public int? YevmiyeKaydiYapanId { get; set; }

    public long? YevmiyeDefteriId { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public byte? DurumId { get; set; }

    public byte? KonumTuruId { get; set; }

    public bool? KesimIslemi { get; set; }
}
