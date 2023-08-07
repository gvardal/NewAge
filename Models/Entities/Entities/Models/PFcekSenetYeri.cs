using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFcekSenetYeri
{
    public byte YerId { get; set; }

    public string? Yer { get; set; }

    public int? CekMuhasebeHesapKoduId { get; set; }

    public int? SenetMuhasebeHesapKoduId { get; set; }

    public int? IcekMuhasebeHesapKoduId { get; set; }

    public int? IicekMuhasebeHesapKoduId { get; set; }

    public int? IiicekMuhasebeHesapKoduId { get; set; }

    public int? IvcekMuhasebeHesapKoduId { get; set; }

    public int? IsenetMuhasebeHesapKoduId { get; set; }

    public int? IisenetMuhasebeHesapKoduId { get; set; }

    public int? IiisenetMuhasebeHesapKoduId { get; set; }

    public int? IvsenetMuhasebeHesapKoduId { get; set; }

    public virtual FyhesapPlani? CekMuhasebeHesapKodu { get; set; }

    public virtual ICollection<FcekSenetGecmisi> FcekSenetGecmisiOncekiYers { get; set; } = new List<FcekSenetGecmisi>();

    public virtual ICollection<FcekSenetGecmisi> FcekSenetGecmisiYers { get; set; } = new List<FcekSenetGecmisi>();

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual FyhesapPlani? IcekMuhasebeHesapKodu { get; set; }

    public virtual FyhesapPlani? IicekMuhasebeHesapKodu { get; set; }

    public virtual FyhesapPlani? IiicekMuhasebeHesapKodu { get; set; }

    public virtual FyhesapPlani? IiisenetMuhasebeHesapKodu { get; set; }

    public virtual FyhesapPlani? IisenetMuhasebeHesapKodu { get; set; }

    public virtual FyhesapPlani? IsenetMuhasebeHesapKodu { get; set; }

    public virtual FyhesapPlani? IvcekMuhasebeHesapKodu { get; set; }

    public virtual FyhesapPlani? IvsenetMuhasebeHesapKodu { get; set; }

    public virtual FyhesapPlani? SenetMuhasebeHesapKodu { get; set; }
}
