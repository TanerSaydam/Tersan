# Clean Code - Temiz Kod

## Temiz Kodun �nemi ve Avantajlar�
- Data �yi Okunabilirlik: Temiz kod, daha net ve d�zenli bir yap�ya sahiptir. Bu, kodun hem sizin hemde ekip arkada�lar�n�z taraf�ndan daha kolay anla��lmas�n� sa�lar.
- Kolay Bak�m ve G�ncelleme: D�zenli ve iyi organize edilmi� kod, hatalar� bulmay� ve d�zeltmeyi, ayr�ca gelecekti g�ncellemeleri yapmay� kolayla�t�r�r
- Azalt�lm�� Hata Riski: Temiz ve iyi yap�land�r�lm�� kod, hata yapma olas�l���n� azalt�r ��nk� her bir b�l�m�n amac� ve i�levi a��kt�r
- Data Etkili �� Birli�i: Ekip �al��mas�nda, di�er geli�tiricilerin kodunuzu okumas� ve anlamas� daha kolay olur. Bu, i� birli�ini ve ekip i�indeki verimlili�i art�r�r.
- S�rd�r�lebilirlik ve �l�eklendirilebilir: Temiz kod, sistemlerin zaman i�inde s�rd�r�lebilir ve �l�eklenebilir olmas�n� sa�lar. Gelecekle eklemeler ve de�i�iklikler daha az zorlukla ger�ekle�ebilir
- Perfomans �yile�tirmeleri: Temiz kod, genellikle gereksiz karma��kl�klardan ar�nd�r�lm�� olmal�d�r, bu da sistemin performans�n�n iyile�tirilmesine baz� senaryolarda yard�mc� olur
- Profesyonellik: Temiz kod yazmak, profesyonellik g�stergesidir ve yaz�l�m m�hendisli�i alan�nda sayg�nl���n�z� art�rabilir
- H�zl� ��ren ve Adaptasyon: Yeni geli�tiriciler, temiz ve d�zenli kod sayesinde mevcut projelere daha h�zl� adapte olabilir ve ��renme s�reci k�sal�r

## Kod Kalitesini De�erlendirme Kriterleri
- Temizlik ve Okunabilirlik: Kodun okunmas� ve anla��lmas� kolay olmal�d�r. �yi yorumlar, uygun de�i�ken ve fonksiyon isimleri ve tutarl� kod formatlamas� bu kategoriye girer.
- S�rd�r�lebilirlik: Kodun gelecekteki geli�tirmelere ve de�i�ikliklere kolayca adapte olabilmesi gerekir. Bu mod�ler yap�, yeniden kullanabilir bile�enler(component) ve g��l� bir mimari tasar�m� i�erir
- Test Edilebilirlik: �yi bir kod kolayca test edilebilir olmal�d�r. Bu, unit testlerin yaz�lmas�n� kolayla�t�ran ve kodun beklenen davran���n� do�rulayan bir yap� i�erir
- Verimlilik: Kodun kaynaklar�(CPU Bellek vb) verimli bir �ekilde kullanmas� �nemlidir. Bu, gereksiz hesaplamalardan ka��nmay� ve algoritmik verimlili�i i�erir.
- G�venilirlik ve Sa�laml�k: Kod hatalara ve beklenmedik durumlara kar�� dayan�kl� olmal�d�r. Hata i�leme ve �zel durum y�netimi bu kategoriye girer
- G�venlik: Kod, g�venlik a��klar�na kar�� korunmal�d�r.
- Uyum ve Standartlara Ba�l�l�k: Kodun, ilgili end�stri standartlar�na ve kodlama kulavuzlar�na uygun olmas� gerekir.
- D�k�mantasyon: �yi belgelenmi� kod, ba�kalar� taraf�ndan daha kolay anla��l�r ve kullan�l�r. Fonksiyonlar�n, s�n�flar�n ve mod�llerin a��k ve anla��l�r d�k�mantasyonu bu kategoriye girer

## Kod Okunabilirli�i ve S�rd�r�lebilirlik
### Kodun Okunabilirli�i
- A��klay�c� �simlendirme: De�i�kenler, fonksiyonlar, s�n�flar ve di�er kod elemanlar� i�in a��k ve anlaml� isimlendirmeler kullan�lmal�
- Yorum ve D�k�mantasyon: Kodun amac�n� ve karma��k b�l�mlerini a��klama i�in yorumlar kullanmak, Ayr�ca, API'lar ve k�t�phaneler i�in kapsaml� d�k�mantasyon sa�lamak
- Tutarl� Formatlama: Tutarl� girintileme, sat�r uzunluklar� ve di�er formatlama kurallar� kullanarak kodun g�rsel olarak d�zenli olmas�n� sa�lamak
- Basit ve A��kl�k: M�mk�n oldu�unda basit ve anla��l�r yap�lar kullanmak, karma��kl�k ka��nmak

### S�rd�r�lebilirlik
- Mod�ler Yap�: Kodun ba��ms�z mod�llere veya bile�enlere ayr�lmas� gerekir, bu sayede her bir par�an�n ayr� ayr� g�ncellenebilir ve test edilebilir olmas� laz�m
- Yeniden Kullan�labilirlik: Kodun yeniden kullan�labilir bile�enler �eklinde tasarlanmas�, bu sayede yeni projelerde veya mod�llerle tekrar kullan�labilmesi
- Test Edilebilirlik: Kodun, Unit testler ve/veya entegrasyon testleri ile kolayca test edilebilmesi
- Esneklik ve Geni�letilebilirlik: Kodun yeni gereksinimlere ve de�i�ikliklere kolayca adapte edilebilir olmas�, bunun i�in temiz mimari (Clean Architecture) ve tasar�m prensiplerinin uygulamas� gerekir

## �simlendirme Standartlar� ve Anlaml� De�i�len �simleri
- Camel Case => �lk harf k���k sonraki her kelimenin ilk harfi b�y�k
- Pascal Case => Her kelimenin ilk harfi b�y�k
- Kebab Case => kelimeler (-) orta �izgi ile birle�tirilirler

Yanl�� Kullan�m: kAdi 
Do�ru Kullan�m: kullaniciAdi
```csharp
List<User> users = context.Users.ToList().Where(user => )
```

## Fonsiyon Boyutu ve Karma��kl���
- 20-30 aras�nda olmal�