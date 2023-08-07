using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KygenelOlgunlukSeviyesi
{
    public int OlgunlukSeviyesiId { get; set; }

    public string? MaliYil { get; set; }

    public string? MaliAy { get; set; }

    public bool? Aktif { get; set; }

    public int CalisanId { get; set; }

    public string? OncekiDonem { get; set; }

    public string? OdgenelOlgunlukPuani { get; set; }

    public decimal? HedefGenelOlgunluk { get; set; }

    public decimal GenelOlgunlukPuani { get; set; }

    public string? OdprhedefProsesBilgi { get; set; }

    public decimal? PrhedefProsesBilgi { get; set; }

    public decimal? PrprosesBilgiPuani { get; set; }

    public string? PrprosesBilgiAciklama { get; set; }

    public string? OdPrprosesSinavi { get; set; }

    public byte? PrprosesSinavi { get; set; }

    public string? OdpriamirPuani { get; set; }

    public byte? PriamirPuani { get; set; }

    public string? PriamirAciklama { get; set; }

    public string? OdpriiamirPuani { get; set; }

    public byte? PriiamirPuani { get; set; }

    public string? PriiamirAciklama { get; set; }

    public string? OdisgolgunlukPuani { get; set; }

    public decimal? HedefIsgolgunluk { get; set; }

    public decimal? IsgolgunlukPuani { get; set; }

    public string? Isgaciklama { get; set; }

    public string? OdisghedefRiskBildirimSayisi { get; set; }

    public decimal? IsghedefRiskBildirimSayisi { get; set; }

    public string? OdisgriskBildirimSayisi { get; set; }

    public decimal? IsgriskBildirimSayisi { get; set; }

    public string? IsgriskBildirimAciklama { get; set; }

    public string? Odisgsdrd { get; set; }

    public decimal? Isgsdrd { get; set; }

    public string? Isgsdrdaciklama { get; set; }

    public string? Odisgdurdurma { get; set; }

    public decimal? Isgdurdurma { get; set; }

    public string? IsgdurdurmaAciklama { get; set; }

    public string? OdhedefSiolgunluk { get; set; }

    public decimal? HedefSiolgunluk { get; set; }

    public string? OdsiolgunlukPuani { get; set; }

    public decimal? SiolgunlukPuani { get; set; }

    public string? OdsifabrikaHedefleriPuani { get; set; }

    public decimal? SifabrikaHedefleriPuani { get; set; }

    public string? SifabrikaHedefleriAciklama { get; set; }

    public string? OdsibolumHedefleriPuani { get; set; }

    public decimal? SibolumHedefleriPuani { get; set; }

    public string? SibolumHedefleriAciklama { get; set; }

    public string? OdsiyillikProjelerPuani { get; set; }

    public decimal? SiyillikProjelerPuani { get; set; }

    public string? SiyillikProjelerAciklama { get; set; }

    public string? OdsikokNedenAnalizPuani { get; set; }

    public decimal? SikokNedenAnalizPuani { get; set; }

    public string? SikokNedenAnalizAciklama { get; set; }

    public string? OdsioneriPuani { get; set; }

    public decimal? SioneriPuani { get; set; }

    public string? OdsihedefOneriSayisi { get; set; }

    public decimal? SihedefOneriSayisi { get; set; }

    public string? OdsioneriSayisi { get; set; }

    public byte? SioneriSayisi { get; set; }

    public string? SioneriAciklama { get; set; }

    public string? OdsiuygulananOneriSayisi { get; set; }

    public byte? SiuygulananOneriSayisi { get; set; }

    public string? SiuygulananOneriAciklama { get; set; }

    public string? OdsihedefTpmpuani { get; set; }

    public decimal? SihedefTpmpuani { get; set; }

    public string? Odsitpmpuani { get; set; }

    public decimal? Sitpmpuani { get; set; }

    public string? Odsitpmsayisi { get; set; }

    public byte? Sitpmsayisi { get; set; }

    public string? Sitpmaciklama { get; set; }

    public string? OdsikapatilanTpmsayisi { get; set; }

    public byte? SikapatilanTpmsayisi { get; set; }

    public string? SikapatilanTpmaciklama { get; set; }

    public string? OdsihedefCalistayKatilim { get; set; }

    public decimal? SihedefCalistayKatilim { get; set; }

    public string? OdsicalistayKatilimPuani { get; set; }

    public decimal? SicalistayKatilimPuani { get; set; }

    public string? OdsicalistayKatilimSayisi { get; set; }

    public byte? SicalistayKatilimSayisi { get; set; }

    public string? SicalistayKatilimAciklama { get; set; }

    public string? Odsihedef6S { get; set; }

    public decimal? Sihedef6S { get; set; }

    public string? Odsi6spuani { get; set; }

    public decimal? Si6spuani { get; set; }

    public string? Odsi6ssayisi { get; set; }

    public byte? Si6ssayisi { get; set; }

    public string? Odikdegerler { get; set; }

    public decimal? Ikdegerler { get; set; }

    public string? Odikdisiplin { get; set; }

    public decimal? Ikdisiplin { get; set; }

    public string? IkdisiplinAciklama { get; set; }

    public string? Odikisghatasi { get; set; }

    public decimal? Ikisghatasi { get; set; }

    public string? OdikkaliteHatasi { get; set; }

    public decimal? IkkaliteHatasi { get; set; }

    public string? Odik6shatasi { get; set; }

    public decimal? Ik6shatasi { get; set; }

    public string? Surec1Aciklama { get; set; }

    public decimal? HedefSurec1 { get; set; }

    public decimal? Surec1 { get; set; }

    public string? Surec2Aciklama { get; set; }

    public decimal? HedefSurec2 { get; set; }

    public decimal? Surec2 { get; set; }

    public string? Surec3Aciklama { get; set; }

    public decimal? HedefSurec3 { get; set; }

    public decimal? Surec3 { get; set; }

    public decimal? HedefDegerler { get; set; }

    public decimal? Degerler { get; set; }

    public string? DegerAciklama { get; set; }

    public byte? HedefMusteriOdaklilik { get; set; }

    public byte? MusteriOdaklilik { get; set; }

    public string? MusteriOdaklilikAciklama { get; set; }

    public string? OdmusteriCezaPuani1 { get; set; }

    public decimal? MusteriCezaPuani1 { get; set; }

    public string? MusteriCeza1Aciklama { get; set; }

    public string? OdmusteriCezaPuani2 { get; set; }

    public decimal? MusteriCezaPuani2 { get; set; }

    public string? MusteriCeza2Aciklama { get; set; }

    public string? OdkdcezaPuani { get; set; }

    public decimal? KdcezaPuani { get; set; }

    public string? KdcezaAciklama { get; set; }

    public string? OdisKazasiCezaPuani { get; set; }

    public decimal? IsKazasiCezaPuani { get; set; }

    public string? IsKazasiCezaAciklama { get; set; }

    public string? OdalanKademeliDenetimPuani { get; set; }

    public decimal? AlanKademeliDenetimPuani { get; set; }

    public string? AlanKademeliDenetimAciklama { get; set; }

    public string? Hedef1Aciklama { get; set; }

    public string? Hedef1 { get; set; }

    public string? Hedef2Aciklama { get; set; }

    public string? Hedef2 { get; set; }

    public string? Hedef3Aciklama { get; set; }

    public string? Hedef3 { get; set; }

    public string? Hedef4Aciklama { get; set; }

    public string? Hedef4 { get; set; }

    public string? Hedef5Aciklama { get; set; }

    public string? Hedef5 { get; set; }

    public string? Hedef6Aciklama { get; set; }

    public string? Hedef6 { get; set; }

    public string? BolumHedefleri1 { get; set; }

    public string? BolumHedefleri2 { get; set; }

    public string? BolumHedefleri3 { get; set; }

    public string? BolumHedefleri4 { get; set; }

    public string? Proje1 { get; set; }

    public string? Proje2 { get; set; }

    public string? Proje3 { get; set; }

    public string? Proje4 { get; set; }

    public string? Gpsdurumu { get; set; }

    public string? Aciklama { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;
}
