using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SatedarikciDegerlendirme
{
    public int TedarikciDegerlendirmeId { get; set; }

    public int? TedarikciId { get; set; }

    public short? DonemId { get; set; }

    public decimal? SdpticariDurum { get; set; }

    public byte? SdpticariDurumAgirlik { get; set; }

    public decimal? Sdpgelisim { get; set; }

    public byte? SdpgelisimAgirlik { get; set; }

    public decimal? SdpkaliteyeOnem { get; set; }

    public byte? SdpkaliteyeOnemAgirlik { get; set; }

    public decimal? SdpteknikSartnameyeUyum { get; set; }

    public byte? SdpteknikSartnameyeUyumAgirlik { get; set; }

    public decimal? SdpkaliteBelgeleri { get; set; }

    public byte? SdpkaliteBelgeleriAgirlik { get; set; }

    public decimal? SdpfiyatUygunlugu { get; set; }

    public byte? SdpfiyatUygunluguAgirlik { get; set; }

    public decimal? SdptermineUyum { get; set; }

    public byte? SdptermineUyumAgirlik { get; set; }

    public decimal? SdpparcaOnaySureci { get; set; }

    public byte? SdpparcaOnaySureciAgirlik { get; set; }

    public decimal? SdpcevapVermeSuresi { get; set; }

    public byte? SdpcevapVermeSuresiAgirlik { get; set; }

    public decimal? Sdpulasilabilirlik { get; set; }

    public byte? SdpulasilabilirlikAgirlik { get; set; }

    public decimal? Sdptoplam { get; set; }

    public byte? SdptoplamAgirlik { get; set; }

    public decimal? KppsartliKabul { get; set; }

    public byte? KppsartliKabulAgirlik { get; set; }

    public decimal? Kppred { get; set; }

    public byte? KppredAgirlik { get; set; }

    public decimal? Kpptoplam { get; set; }

    public byte? KpptoplamAgirlik { get; set; }

    public decimal? LpptermineUyum { get; set; }

    public decimal? LppmiktaraUyum { get; set; }

    public decimal? Lpptoplam { get; set; }

    public byte? LpptoplamAgirlik { get; set; }

    public decimal? TedarikciPerformansPuani { get; set; }

    public DateTime? DegerlendirmeTarihi { get; set; }

    public int? DegerlendirenCalisanId { get; set; }

    public int? KontrolEdenId { get; set; }

    public bool? KontrolSonucu { get; set; }

    public DateTime? KontrolTarihi { get; set; }

    public int? OnaylayanId { get; set; }

    public bool? OnaySonucu { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DegerlendirenCalisan { get; set; }

    public virtual PSatedarikciDegerlendirmeDonemler? Donem { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? KontrolEden { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Miysahesaplar? Tedarikci { get; set; }
}
