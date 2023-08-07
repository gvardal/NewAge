﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities.Dupus.Entity.Models
{
    [Table("UYIsEmriRotasi", Schema = "UretimYonetimi")]
    public class UYIsEmriRotasi
    {
        public int IsEmriRotaID { get; set; }
        public long IsEmriID { get; set; }
        public UYIsEmri? IsEmri { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string? OperasyonuKodu { get; set; }
        public int? OncekiIsEmriRotaID { get; set; }
        public byte Sira { get; set; }
        public int KonumID { get; set; }
        public UYKonum? Konum { get; set; }
        public Int16 IslemTuruID { get; set; }
        public int? CalisanID { get; set; }

        [Column(TypeName = "decimal(4, 2)")]
        public decimal? CalisanSayisi { get; set; }
        public byte RotaDurumu { get; set; }
        public byte HazirlikDurumu { get; set; }
        public string? Aciklama { get; set; }
        public decimal? PlanlananGirdi { get; set; }
        public DateTime PlanlananBaslamaTarihi { get; set; }
        public DateTime PlanlananBitisTarihi { get; set; }
        public DateTime? EnErkenBaslamaTarihi { get; set; }
        public bool? Sabitlenmis { get; set; }        
        public Single? PlanlananTamamlanmaZamani { get; set; }
        public Single? HazirlamaSuresi { get; set; }
        public Single? IslemSuresi { get; set; }
        public Single? StandartSure { get; set; }
        public Single? Mesafe { get; set; }
        public int? OnSeriKontrolAdedi { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? LotBuyuklugu { get; set; }
        [Column(TypeName = "numeric(11, 3)")]
        public decimal OrtalamaCevrimSuresi { get; set; }
        public DateTime? SonCevrimZamani { get; set; }
        public decimal? GerceklesenCikti { get; set; }
        public Int16? Fire { get; set; }
        public decimal? TamamlanmaOrani { get; set; }
        public string? VardiyaKodu { get; set; } = string.Empty;

        [Column(TypeName = "numeric(8, 2)")]
        public decimal? SonVardiyaMiktari { get; set; }
        public Int16 GozSayisi { get; set; }
        public DateTime? GerceklesenBaslamaTarihi { get; set; }
        public DateTime? GerceklesenBitisTarihi { get; set; }

        [Column(TypeName = "numeric(16, 2)")]
        public decimal? GerceklesenTamamlanmaZamani { get; set; }
        public Int16? IsAkisSoruGrubuID { get; set; }
        public Int16? IsAkisSoruGrubuIDAra { get; set; }
        public Int16? IsAkisSoruGrubuIDSon { get; set; }
        public string? KaliteKontrolRaporu { get; set; }
        public bool? Tamamlandi { get; set; }
        public decimal? SaatlikUcreti { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PlanlananMaliyet { get; set; }
        public decimal? GerceklesenMaliyet { get; set; }
        public int? EkipmanID { get; set; }
        public bool? IsEmriOnayi { get; set; }
        public int? Onaylayan { get; set; }
        public int? MakinaID { get; set; }
        public int? YevmiyeKaydiID { get; set; }
        public bool TopluKayit { get; set; }
        public bool? ManuelIsciZamanKarti { get; set; }
        public Int64? EnvanterID { get; set; }
        public Int64? UretimVerisiID { get; set; }
        public int? PaletNo { get; set; }
        public int? KutuNo { get; set; }
        public bool OtomatikDurus { get; set; }
        public int? FasonUrunID { get; set; }

        [Column(TypeName = "decimal(12, 6)")]
        public decimal? KullanilanMiktar { get; set; }
        public int? SecenID { get; set; }
        public bool? Secili { get; set; }
        public int? EkleyenCalisanID { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public int? DuzenleyenCalisanID { get; set; }
        public DateTime? DuzenlemeTarihi { get; set; }
        public int? SonErisenCalisanID { get; set; }
        public DateTime? SonErisimTarihi { get; set; }
    }
}
