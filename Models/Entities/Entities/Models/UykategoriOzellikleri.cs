using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UykategoriOzellikleri
{
    public long KategoriOzellikleriId { get; set; }

    public int? UrunKategorisiId { get; set; }

    public short? OzellikGrubuId { get; set; }

    public short? OzellikTuruId { get; set; }

    public byte? KodlamaTuruId { get; set; }

    public byte? OncelikSirasi { get; set; }

    public string? Aciklama { get; set; }

    public string? VarsayilanDeger { get; set; }

    public bool? SiparisOzelligi { get; set; }

    public bool? OpsiyonelOzellik { get; set; }

    public bool? AnaUrunOzellik { get; set; }

    public string? OzellikEtkiDuzeyi { get; set; }

    public virtual PUykodlamaTuru? KodlamaTuru { get; set; }

    public virtual PUyozellikGrubu? OzellikTuru { get; set; }

    public virtual PUyozellikTuru? OzellikTuruNavigation { get; set; }

    public virtual UyurunKategorisi? UrunKategorisi { get; set; }
}
