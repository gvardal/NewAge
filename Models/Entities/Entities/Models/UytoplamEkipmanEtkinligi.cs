using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UytoplamEkipmanEtkinligi
{
    public int Teeid { get; set; }

    public int? KonumId { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? ToplamKullanilabilirZaman { get; set; }

    public decimal? HaftasonuTatil { get; set; }

    public byte? VardiyaId { get; set; }

    public int? CalisanId { get; set; }

    public decimal? TalepYok { get; set; }

    public decimal? DigerKullanilmayanGunler { get; set; }

    public decimal? MakineKullanimZamani { get; set; }

    public decimal? PlanliBakim { get; set; }

    public decimal? UrunDegisimi { get; set; }

    public decimal? StartUpShutDown { get; set; }

    public decimal? PlanliToplantiEgitim { get; set; }

    public decimal? YemekCayMolalari { get; set; }

    public decimal? MakineUrunDenemeleri { get; set; }

    public decimal? UretimZamani { get; set; }

    public decimal? Ariza { get; set; }

    public decimal? ProsesProblemleri { get; set; }

    public decimal? FabrikaProblemleri { get; set; }

    public decimal? ElemanEksikligi { get; set; }

    public decimal? MakineCalismaZamani { get; set; }

    public decimal? Fire { get; set; }

    public decimal? YenidenIsleme { get; set; }

    public decimal? UretimHiziKayiplari { get; set; }

    public decimal? VerimliCalismaZamani { get; set; }

    public decimal? YatirimVerimliligi { get; set; }

    public decimal? YatirimKullanimOrani { get; set; }

    public decimal? OperasyonVerimliligi { get; set; }

    public decimal? CalismaVerimliligi { get; set; }

    public decimal? KapasiteKullanimi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikpdksvardiya? Vardiya { get; set; }
}
