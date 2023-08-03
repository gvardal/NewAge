SELECT B.UrunID,D.IsEmriRotaID as taskId,C.Adi as taskName
,D.PlanlananBaslamaTarihi,D.PlanlananBitisTarihi,D.KonumID as resourceId
,D.OncekiIsEmriRotaID as predecessor, D.PlanlananTamamlanmaZamani/60
,B.UretimMiktari
,D.PlanlananGirdi 
,D.GerceklesenCikti
  FROM [ProgeScienta].[UretimYonetimi].[UYIsEmri] B 
  LEFT JOIN [ProgeScienta].[UretimYonetimi].[UYUrunler] C ON C.UrunID = B.UrunID
  LEFT JOIN [ProgeScienta].[UretimYonetimi].[UYIsEmriRotasi] D ON D.IsEmriID=B.IsEmriID
  Where B.IsEmriDurumID not in (0,7,8) and B.UrunID=7806
  Order By d.IsEmriRotaID
