using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyfinansalDonemler
{
    public int FinansalDonemId { get; set; }

    public byte? FirmaId { get; set; }

    public string? MaliYil { get; set; }

    public string? MaliAy { get; set; }

    public string? MaliDonem { get; set; }

    public bool? Aktif { get; set; }

    public DateTime? MaliDonemBaslangic { get; set; }

    public DateTime? MaliDonemBitis { get; set; }

    public int? YevmiyeKayitNo { get; set; }

    public bool? MaliDonemKapandi { get; set; }

    public bool? SatisFaturasiIslemiKapat { get; set; }

    public bool? AlisFaturasiIslemiKapat { get; set; }

    public bool? KdvbeyannamesiVerildi { get; set; }

    public bool? KurFarkiHesaplandi { get; set; }

    public string? KurFarkiReferansKodu { get; set; }

    public bool? MaliyetMuhasebesiHesaplandi { get; set; }

    public bool? EDefterOlusturuldu { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FykasaIslemleri> FykasaIslemleris { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<FysatilanMalinMaliyetDetayi> FysatilanMalinMaliyetDetayis { get; set; } = new List<FysatilanMalinMaliyetDetayi>();

    public virtual ICollection<FysatilanMalinMaliyeti> FysatilanMalinMaliyetis { get; set; } = new List<FysatilanMalinMaliyeti>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<IkmaasOdeme> IkmaasOdemes { get; set; } = new List<IkmaasOdeme>();

    public virtual ICollection<PFymaliyetYeriDetayi> PFymaliyetYeriDetayis { get; set; } = new List<PFymaliyetYeriDetayi>();
}
