using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpdkscalismaGrubu
{
    public byte CalismaGrubuId { get; set; }

    public string? Aciklama { get; set; }

    public string? BordroHesaplamaModeli { get; set; }

    public bool? VarsayilanTakvim { get; set; }

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<IkpdkscalisanVardiyaPlani> IkpdkscalisanVardiyaPlanis { get; set; } = new List<IkpdkscalisanVardiyaPlani>();

    public virtual ICollection<IkpdksgunlukCalismaPlani> IkpdksgunlukCalismaPlanis { get; set; } = new List<IkpdksgunlukCalismaPlani>();

    public virtual ICollection<Uykonum> Uykonums { get; set; } = new List<Uykonum>();
}
