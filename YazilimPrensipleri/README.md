# Yazýlým Prensipleri

## SOLID
Yazýlým geliþtirme ve nesne yönelimli tasarýmda beþ temel prensibi ifade eder. Herbir harf bir pensibe karþýlýk gelir ve yazýlýmýn daha anlaþýlýr, esnek ve sürdürülebilir olmasýný amaçlar. Bu prensipler, yazýlýmýn bakýmýný ve geniþletilebilirliðini kolaylaþtýrýr, yaný sýra kodun kýrýlabilirliðini azaltýr.

1. S: Single Resposnbility Principle (Tek Sorumluluk Ýlkesi)
Taným: Bir sýnýfýn (ya da bir metodun) yanlýzca bir sebepten dolayý deðiþmesi gerektiðini belirtir. Yani her sýnýf yanlýzca bir iþlevi yerine getirmelidir.
Amaç: Karmaþýklýðý azaltmak ve sýnýflarýn deðiþime karþý daha dayanýklý olmasýný saðlamak.


2. O: Open/Closed Prenciple (Açýk/Kapalý Prensibi)
Taným: Yazýlým varlýklarýnýn (sýnýflar, modüller, fonsiyonlar vb.) geniþletmeye açýk, deðiþime kapalý olmasýný amaçlar.
Amaç: Mevcun kodun deðiþtilmesine gerek kalmadan yeni iþlevselliðinin eklenmesini kolaylaþtýrmak


3. L: Liskov Substitution Principle(Liskov'un Yerine Geçme Prensinsibi)
Taným: Alt sýnýflarýn, üst sýnýflarýn yerine geçebilmesi gerektiðini ifade eder. Bir alt sýnýfýn nesnesi, üst sýnýfýn nesnesiyle yer deðiþtirdiðinde, sistem hala doðru çalýþmalýdýr.
Amaç: Sýnýf hiyerarþilerinin saðlam bir þekilde tasarlanmasýný saðlamak ve alt sýnýflarýn doðru bir þekilde implemente edilmesini teþvik etmek eyi amaçlar

4. I: Interface Segregation Principle (Arayüz Ayýrma Prensibi)
Taným: Büyük, þiþkin Arayüzler yerine daha küçük ve daha spesifik arayüzlerin kullanýlmasý gerektiðini belirtir. Bir sýnýf, kullanmadýðý metodlarý içeren bir arayüzü uygulamamalýdýr.
Amaç: Sýnýflarýn gereksiz baðýmlýlýklardan kaçýnmasýný saðlayarak daha esnek yapýlar oluþturmasýný amaçlar

5) D: Dependency Inversion Principle (Baðýmlýlýklarýn Tersine Çevrilme Prensibi)
Taným: Yüksek seviye modüllerin düþük seviye modüllere doðrudan baðlý olmamasý, bunun yerine soyutlamalar aracýlýðýyla etkileþimde bulunmasý gerektiðini ifade eder. Soyurlamalar detaylara, detaylar soyutlamalara baðýmlý olmamalýdýr.
Amaç: Modüller arasýndaki baðlantýyý gevþetmek ve kodun test edilebilirliðini artýrmak.

## LOD (Law Of Demeter) Veya 'Least Knowledge Principle
Yazýlým tasarýmdaki bir nesnenin sýnýrlý bilgiye sahio olmasýný ve sadece yakýn çevreyle etkileþimde bulunmasý gerektiðini belirten bir prensiptir.

## SOC Seperation Of Concerns Principle
Bir uygulamanýn veya sistemin farklý bölümlerinin birbirinden ayrý tutulmasý prensibidir.

Example:
1. MVC
2. Katmanlý Mimari
3. Servis Odaklý Mimari (SOA)

## GRASP (General Resposinbility Assignment Software Patterns)
1. Information Expert (Bilgi Uzmaný): Sorumluluklarýn, bu sorumluluklarý yerine getirmek için gerekli bilgiye sahip olan nesnelere atanmasý gerektiðini belirtir
2. Create (Oluþturucu): Bir nesnenin oluþturulmasýnýn kim tarafýndan yapýlmasý gerektiðini açýklar. Genellikle, bir nesneyi içeren veya kaydeden, onu sýkça kullanacak olan ya da baþlatma verilerine sahip olan nesneler oluþturucu olarak seçilir.
3. Controller: Bir sistemin, UI katmaný ve iþ mantýðý katmaný arasýndaki bir aracý görevi görür. Sistem olaylarýný ve iþlemleri yönetmek için kullanýlýr
4. Low Coupling (Düþük Baðlantý): Nesneler arasýndaki baðýmlýklarý azaltmayý önerir. Düþük baðlantý, esneklik ve yeniden kullanýlabilirliði artýrýr
5. High Cohesion (Yüksek Baðdaþlýlýk): Bir nesnenin veya sýnýfýn yanlýzca ilgili ve çok alaklý sorumluluklarý barýndýrmasý gerektiðini belirtir. Yüksek baðdaþýklýlýk, anlaþýlabilirliði ve bakýmý kolaylaþtýrýr
6. Polymorphism (Çok biçimlilik): Tip hiyeraþisinde deðiþikliklere tepki vermek için arayüz tabanýný çok biçimlilik kullanmayý önerir. 
7. Pure Fabrication (Saf Uydurma): Sistemin iþ mantýðýnýn parçasý olmayan, ancak geliþtirme sürecini kolaylaþtýran nesnelerin oluþturulmasýný önerir
8. Indirection (Dolaylýlýk): Bir bileþeni baþka bir bileþenden ayýrmak için ara bir bileþen kullanmayý önerir. Bu, baðlantý azaltmaya yardýmcý olur.
9. Proteted Variations (Korunan Deðiþiklikler): Sistemi belirsiz gelecekteki deðiþikliklerden korumak için arayüzler ve sotur sýnýflar gibi mekanizmalarýn kullanýlmasýný önler

## DRY (Don't Repeat Yourself)

## KISS (Keep It Simple, Stupid)

## YAGNI (You Aren't Gonna Need It)

## CQRS (Command Query Responsbility Segregation)

## TDD (Test Driven Development)
Kod yazmadan önce testi yazmalýyýz

## BDD (Behavior-Driven Development)
Yazýlýmýn davranýþýný tanýmlayan testlerle geliþtirme yapmayý vurgulayan

## Fail Fast
Hatalarýn münkün olduðunda erken ortaya çýkmasýný amaçlayan

## DDD (Domain-Driven Design)

## Composition Over Inheritance
Kalýtým yerine bileþenleri tercih etmeyi öneren