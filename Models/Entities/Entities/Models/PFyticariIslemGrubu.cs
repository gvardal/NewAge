using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyticariIslemGrubu
{
    public short TicariIslemGrubuId { get; set; }

    public string? Kodu { get; set; }

    public string? Aciklama { get; set; }

    public bool? Aktif { get; set; }

    public bool? Kdvuygulanmayacak { get; set; }

    public bool? EkVergiUygulanmayacak { get; set; }

    public bool? AbkdvmevzuatiUygulanacak { get; set; }

    public bool? KdvyansitmaUygulanacak { get; set; }

    public bool? TevkifatUygulanmayacak { get; set; }

    public bool? BagKurdanMuaf { get; set; }

    public bool? KdvindirimindenOnceHesaplanacak { get; set; }

    public bool? EkVergiCariHesabaYansitilmayacak { get; set; }

    public bool? BaglantiTabikiYapilacak { get; set; }

    public bool? SerbestBolge { get; set; }

    public bool? EkVergiBeyannameyeYansitilmayacak { get; set; }

    public bool? StopajHesapla { get; set; }

    public bool? BedelsizIhracateFatura { get; set; }

    public bool? KanunaGoreKdvduzenleme { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();
}
