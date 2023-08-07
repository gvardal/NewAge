using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IikullaniciGrupKatilimcilari
{
    public int KullaniciGrubuId { get; set; }

    public int KatilimciId { get; set; }

    /// <summary>
    /// 1 Yönetici, 2 Katilimci
    /// </summary>
    public byte? Posizyonu { get; set; }

    public virtual Ikcalisanlar Katilimci { get; set; } = null!;

    public virtual IikullaniciGruplari KullaniciGrubu { get; set; } = null!;
}
