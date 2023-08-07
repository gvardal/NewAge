using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyisAlani
{
    public byte IsAlaniId { get; set; }

    public string? Aciklama { get; set; }

    public decimal? GenelYonetimGideriParametresi { get; set; }

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleris { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayis { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<IkacikPozisyonlar> IkacikPozisyonlars { get; set; } = new List<IkacikPozisyonlar>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<IkmaasOdeme> IkmaasOdemes { get; set; } = new List<IkmaasOdeme>();

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
