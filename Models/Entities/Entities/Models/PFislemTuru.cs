using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFislemTuru
{
    public int IslemTuruId { get; set; }

    public string? IslemAciklamasi { get; set; }

    public string? EDefterKayitTuru { get; set; }

    public string? EDefterKayitTuruAciklama { get; set; }

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFykidemTazminatiIslemTurus { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFymaasOdemeIslemTurus { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();

    public virtual ICollection<PFislemTuruDetayi> PFislemTuruDetayis { get; set; } = new List<PFislemTuruDetayi>();

    public virtual ICollection<PFyfaturaHareketOzelKodlari> PFyfaturaHareketOzelKodlaris { get; set; } = new List<PFyfaturaHareketOzelKodlari>();
}
