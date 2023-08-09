using System.ComponentModel.DataAnnotations.Schema;

namespace Dupus.Entity.Models.ProductionManagment
{
    [Table("UYIsEmriRotasi", Schema = "UretimYonetimi")]
    public class WorkOrderRoute
    {
        public int IsEmriRotaID { get; set; }
        public long IsEmriID { get; set; }
        public WorkOrder? IsEmri { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string? OperasyonuKodu { get; set; }
        public int? OncekiIsEmriRotaID { get; set; }
        public byte Sira { get; set; }
        public int KonumID { get; set; }
        public Locations? Konum { get; set; }
        public short IslemTuruID { get; set; }
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
        public float? PlanlananTamamlanmaZamani { get; set; }
        public float? HazirlamaSuresi { get; set; }
        public float? IslemSuresi { get; set; }
        public float? StandartSure { get; set; }
        public float? Mesafe { get; set; }
        public int? OnSeriKontrolAdedi { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? LotBuyuklugu { get; set; }
        [Column(TypeName = "numeric(11, 3)")]
        public decimal OrtalamaCevrimSuresi { get; set; }
        public DateTime? SonCevrimZamani { get; set; }
        public decimal? GerceklesenCikti { get; set; }
        public short? Fire { get; set; }
        public decimal? TamamlanmaOrani { get; set; }
        public string? VardiyaKodu { get; set; } = string.Empty;

        [Column(TypeName = "numeric(8, 2)")]
        public decimal? SonVardiyaMiktari { get; set; }
        public short GozSayisi { get; set; }
        public DateTime? GerceklesenBaslamaTarihi { get; set; }
        public DateTime? GerceklesenBitisTarihi { get; set; }

        [Column(TypeName = "numeric(16, 2)")]
        public decimal? GerceklesenTamamlanmaZamani { get; set; }
        public short? IsAkisSoruGrubuID { get; set; }
        public short? IsAkisSoruGrubuIDAra { get; set; }
        public short? IsAkisSoruGrubuIDSon { get; set; }
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
        public long? EnvanterID { get; set; }
        public long? UretimVerisiID { get; set; }
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
