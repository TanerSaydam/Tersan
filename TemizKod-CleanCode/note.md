# Clean Code - Temiz Kod

## Temiz Kodun Önemi ve Avantajlarý
- Data Ýyi Okunabilirlik: Temiz kod, daha net ve düzenli bir yapýya sahiptir. Bu, kodun hem sizin hemde ekip arkadaþlarýnýz tarafýndan daha kolay anlaþýlmasýný saðlar.
- Kolay Bakým ve Güncelleme: Düzenli ve iyi organize edilmiþ kod, hatalarý bulmayý ve düzeltmeyi, ayrýca gelecekti güncellemeleri yapmayý kolaylaþtýrýr
- Azaltýlmýþ Hata Riski: Temiz ve iyi yapýlandýrýlmýþ kod, hata yapma olasýlýðýný azaltýr çünkü her bir bölümün amacý ve iþlevi açýktýr
- Data Etkili Ýþ Birliði: Ekip çalýþmasýnda, diðer geliþtiricilerin kodunuzu okumasý ve anlamasý daha kolay olur. Bu, iþ birliðini ve ekip içindeki verimliliði artýrýr.
- Sürdürülebilirlik ve Ölçeklendirilebilir: Temiz kod, sistemlerin zaman içinde sürdürülebilir ve ölçeklenebilir olmasýný saðlar. Gelecekle eklemeler ve deðiþiklikler daha az zorlukla gerçekleþebilir
- Perfomans Ýyileþtirmeleri: Temiz kod, genellikle gereksiz karmaþýklýklardan arýndýrýlmýþ olmalýdýr, bu da sistemin performansýnýn iyileþtirilmesine bazý senaryolarda yardýmcý olur
- Profesyonellik: Temiz kod yazmak, profesyonellik göstergesidir ve yazýlým mühendisliði alanýnda saygýnlýðýnýzý artýrabilir
- Hýzlý Öðren ve Adaptasyon: Yeni geliþtiriciler, temiz ve düzenli kod sayesinde mevcut projelere daha hýzlý adapte olabilir ve öðrenme süreci kýsalýr

## Kod Kalitesini Deðerlendirme Kriterleri
- Temizlik ve Okunabilirlik: Kodun okunmasý ve anlaþýlmasý kolay olmalýdýr. Ýyi yorumlar, uygun deðiþken ve fonksiyon isimleri ve tutarlý kod formatlamasý bu kategoriye girer.
- Sürdürülebilirlik: Kodun gelecekteki geliþtirmelere ve deðiþikliklere kolayca adapte olabilmesi gerekir. Bu modüler yapý, yeniden kullanabilir bileþenler(component) ve güçlü bir mimari tasarýmý içerir
- Test Edilebilirlik: Ýyi bir kod kolayca test edilebilir olmalýdýr. Bu, unit testlerin yazýlmasýný kolaylaþtýran ve kodun beklenen davranýþýný doðrulayan bir yapý içerir
- Verimlilik: Kodun kaynaklarý(CPU Bellek vb) verimli bir þekilde kullanmasý önemlidir. Bu, gereksiz hesaplamalardan kaçýnmayý ve algoritmik verimliliði içerir.
- Güvenilirlik ve Saðlamlýk: Kod hatalara ve beklenmedik durumlara karþý dayanýklý olmalýdýr. Hata iþleme ve özel durum yönetimi bu kategoriye girer
- Güvenlik: Kod, güvenlik açýklarýna karþý korunmalýdýr.
- Uyum ve Standartlara Baðlýlýk: Kodun, ilgili endüstri standartlarýna ve kodlama kulavuzlarýna uygun olmasý gerekir.
- Dökümantasyon: Ýyi belgelenmiþ kod, baþkalarý tarafýndan daha kolay anlaþýlýr ve kullanýlýr. Fonksiyonlarýn, sýnýflarýn ve modüllerin açýk ve anlaþýlýr dökümantasyonu bu kategoriye girer

## Kod Okunabilirliði ve Sürdürülebilirlik
### Kodun Okunabilirliði
- Açýklayýcý Ýsimlendirme: Deðiþkenler, fonksiyonlar, sýnýflar ve diðer kod elemanlarý için açýk ve anlamlý isimlendirmeler kullanýlmalý
- Yorum ve Dökümantasyon: Kodun amacýný ve karmaþýk bölümlerini açýklama için yorumlar kullanmak, Ayrýca, API'lar ve kütüphaneler için kapsamlý dökümantasyon saðlamak
- Tutarlý Formatlama: Tutarlý girintileme, satýr uzunluklarý ve diðer formatlama kurallarý kullanarak kodun görsel olarak düzenli olmasýný saðlamak
- Basit ve Açýklýk: Mümkün olduðunda basit ve anlaþýlýr yapýlar kullanmak, karmaþýklýk kaçýnmak

### Sürdürülebilirlik
- Modüler Yapý: Kodun baðýmsýz modüllere veya bileþenlere ayrýlmasý gerekir, bu sayede her bir parçanýn ayrý ayrý güncellenebilir ve test edilebilir olmasý lazým
- Yeniden Kullanýlabilirlik: Kodun yeniden kullanýlabilir bileþenler þeklinde tasarlanmasý, bu sayede yeni projelerde veya modüllerle tekrar kullanýlabilmesi
- Test Edilebilirlik: Kodun, Unit testler ve/veya entegrasyon testleri ile kolayca test edilebilmesi
- Esneklik ve Geniþletilebilirlik: Kodun yeni gereksinimlere ve deðiþikliklere kolayca adapte edilebilir olmasý, bunun için temiz mimari (Clean Architecture) ve tasarým prensiplerinin uygulamasý gerekir

## Ýsimlendirme Standartlarý ve Anlamlý Deðiþlen Ýsimleri
- Camel Case => Ýlk harf küçük sonraki her kelimenin ilk harfi büyük
- Pascal Case => Her kelimenin ilk harfi büyük
- Kebab Case => kelimeler (-) orta çizgi ile birleþtirilirler

Yanlýþ Kullaným: kAdi 
Doðru Kullaným: kullaniciAdi
```csharp
List<User> users = context.Users.ToList().Where(user => )
```

## Fonsiyon Boyutu ve Karmaþýklýðý
- 20-30 arasýnda olmalý