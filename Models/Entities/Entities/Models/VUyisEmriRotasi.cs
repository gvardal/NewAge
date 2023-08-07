﻿using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyisEmriRotasi
{
    public int IsEmriRotaId { get; set; }

    public long IsEmriId { get; set; }

    public string? OperasyonuKodu { get; set; }

    public int? OncekiIsEmriRotaId { get; set; }

    public byte? Sira { get; set; }

    public int? KonumId { get; set; }

    public short? IslemTuruId { get; set; }

    public int? CalisanId { get; set; }

    public decimal? CalisanSayisi { get; set; }

    public byte? RotaDurumu { get; set; }

    public byte? HazirlikDurumu { get; set; }

    public string? Aciklama { get; set; }

    public decimal? PlanlananGirdi { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public DateTime? EnErkenBaslamaTarihi { get; set; }

    public bool? Sabitlenmis { get; set; }

    public float? PlanlananTamamlanmaZamani { get; set; }

    public float? HazirlamaSuresi { get; set; }

    public float? IslemSuresi { get; set; }

    public float? StandartSure { get; set; }

    public float? Mesafe { get; set; }

    public short? OnSeriKontrolAdedi { get; set; }

    public decimal? LotBuyuklugu { get; set; }

    public decimal? OrtalamaCevrimSuresi { get; set; }

    public DateTime? SonCevrimZamani { get; set; }

    public decimal? GerceklesenCikti { get; set; }

    public short? Fire { get; set; }

    public decimal? TamamlanmaOrani { get; set; }

    public string? VardiyaKodu { get; set; }

    public decimal? SonVardiyaMiktari { get; set; }

    public short? GozSayisi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public decimal? GerceklesenTamamlanmaZamani { get; set; }

    public short? IsAkisSoruGrubuId { get; set; }

    public short? IsAkisSoruGrubuIdara { get; set; }

    public short? IsAkisSoruGrubuIdson { get; set; }

    public string? KaliteKontrolRaporu { get; set; }

    public bool? Tamamlandi { get; set; }

    public decimal? SaatlikUcreti { get; set; }

    public float? PlanlananMaliyet { get; set; }

    public decimal? GerceklesenMaliyet { get; set; }

    public int? EkipmanId { get; set; }

    public bool? IsEmriOnayi { get; set; }

    public int? Onaylayan { get; set; }

    public int? MakinaId { get; set; }

    public int? YevmiyeKaydiId { get; set; }

    public bool? TopluKayit { get; set; }

    public bool? ManuelIsciZamanKarti { get; set; }

    public long? EnvanterId { get; set; }

    public long? UretimVerisiId { get; set; }

    public short? PaletNo { get; set; }

    public int? KutuNo { get; set; }

    public bool? OtomatikDurus { get; set; }

    public int? FasonUrunId { get; set; }

    public decimal? KullanilanMiktar { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public int? SecenId { get; set; }

    public bool? Secili { get; set; }
}
