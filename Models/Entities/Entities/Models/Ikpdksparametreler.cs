using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpdksparametreler
{
    public byte ParametreId { get; set; }

    public bool? BordroYevmiyeTuru { get; set; }

    public DateTime? GecerlilikBaslangicTarihi { get; set; }

    public DateTime? GunKacSaat { get; set; }

    public byte? AyKacGun { get; set; }

    public byte? HesapKesimGunu { get; set; }

    public byte? MazeretIzınSuresi { get; set; }

    public DateTime? GirisCikisArasiAsgariSure { get; set; }

    public bool? BrutNet { get; set; }

    public byte? IktehlikeSinifi { get; set; }

    public decimal? IksgkisciPrimi { get; set; }

    public decimal? IksgkemekliIsciPrimi { get; set; }

    public decimal? IkissizlikIsciPrimi { get; set; }

    public decimal? IkissizlikIsverenPrimi { get; set; }

    public decimal? IkdamgaVergisi { get; set; }

    public decimal? IksgkisVerenPrimi { get; set; }

    public decimal? IksgkemekliIsVerenPrimi { get; set; }

    public decimal? Ikilk6AySgktavani { get; set; }

    public decimal? Ikikinci6AySgktavani { get; set; }

    public decimal? Ik15matrahSiniri { get; set; }

    public decimal? Ik20matrahSiniri { get; set; }

    public decimal? Ik27matrahSiniri { get; set; }

    public decimal? Ik35matrahSiniri { get; set; }

    public decimal? IkasgariUcret { get; set; }

    public decimal? IkasgariNetUcret { get; set; }

    public decimal? IkyemekIstisnasi { get; set; }

    public decimal? IkyolIstisnasi { get; set; }

    public decimal? Ikagicalisan { get; set; }

    public decimal? IkagicalismayanEs { get; set; }

    public decimal? IkagiikidenAzCocuk { get; set; }

    public decimal? IkagiikidenFazlaCocuk { get; set; }

    public decimal? IkengelliVergiIndirimiI { get; set; }

    public decimal? IkengelliVergiIndirimiIi { get; set; }

    public decimal? IkengelliVergiIndirimiIii { get; set; }

    public decimal? Ikilk6AyKidemTavani { get; set; }

    public decimal? Ikikinci6AyKidemTavani { get; set; }
}
