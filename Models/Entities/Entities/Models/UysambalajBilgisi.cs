using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UysambalajBilgisi
{
    public int AmbalajBilgisiId { get; set; }

    public int? OncekiAmbalajBilgisiId { get; set; }

    public int? AmbalajMalzemeId { get; set; }

    public byte? AmbalajTipiId { get; set; }

    public int? KategoriId { get; set; }

    public int? UrunId { get; set; }

    public int? MalzemeId { get; set; }

    public string? BarkodNo { get; set; }

    public short? AmbalajGrubuId { get; set; }

    public string? BaskiTeknigi { get; set; }

    public string? BaskiRengi { get; set; }

    public string? YapismaSekli { get; set; }

    public string? MalzemeYapisi { get; set; }

    public string? MalzemeOzelligi { get; set; }

    public string? MalzemeOlcusuTipi { get; set; }

    public decimal? MalzemeOlcusuEn { get; set; }

    public decimal? MalzemeOlcusuEnMin { get; set; }

    public decimal? MalzemeOlcusuEnMaks { get; set; }

    public decimal? MalzemeOlcusuBoy { get; set; }

    public decimal? MalzemeOlcusuBoyMin { get; set; }

    public decimal? MalzemeOlcusuBoyMaks { get; set; }

    public string? BobinIcCap { get; set; }

    public string? BobinDisCap { get; set; }

    public string? Alan { get; set; }

    public int? AmbalajOlcuBirimi { get; set; }

    public string? AmbalajGramaji { get; set; }

    public string? AmbalajGramajiMin { get; set; }

    public string? AmbalajGramajiMaks { get; set; }

    public string? AdetGramaji { get; set; }

    public string? Bct { get; set; }

    public string? Ect { get; set; }

    public string? SogukYapismaKuvveti { get; set; }

    public string? AtikSembolu { get; set; }

    public string? ResimDosyasi { get; set; }

    public string? CizimDosyasi { get; set; }

    public string? BicakIziDosyasi { get; set; }

    public virtual UysambalajMalzemeleri? AmbalajMalzeme { get; set; }

    public virtual PolcuBirimleri? AmbalajOlcuBirimiNavigation { get; set; }

    public virtual PUysambalajTipi? AmbalajTipi { get; set; }

    public virtual ICollection<UysambalajBilgisi> InverseOncekiAmbalajBilgisi { get; set; } = new List<UysambalajBilgisi>();

    public virtual UyurunKategorisi? Kategori { get; set; }

    public virtual Uyurunler? Malzeme { get; set; }

    public virtual UysambalajBilgisi? OncekiAmbalajBilgisi { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
