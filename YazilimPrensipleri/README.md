# Yaz�l�m Prensipleri

## SOLID
Yaz�l�m geli�tirme ve nesne y�nelimli tasar�mda be� temel prensibi ifade eder. Herbir harf bir pensibe kar��l�k gelir ve yaz�l�m�n daha anla��l�r, esnek ve s�rd�r�lebilir olmas�n� ama�lar. Bu prensipler, yaz�l�m�n bak�m�n� ve geni�letilebilirli�ini kolayla�t�r�r, yan� s�ra kodun k�r�labilirli�ini azalt�r.

1. S: Single Resposnbility Principle (Tek Sorumluluk �lkesi)
Tan�m: Bir s�n�f�n (ya da bir metodun) yanl�zca bir sebepten dolay� de�i�mesi gerekti�ini belirtir. Yani her s�n�f yanl�zca bir i�levi yerine getirmelidir.
Ama�: Karma��kl��� azaltmak ve s�n�flar�n de�i�ime kar�� daha dayan�kl� olmas�n� sa�lamak.


2. O: Open/Closed Prenciple (A��k/Kapal� Prensibi)
Tan�m: Yaz�l�m varl�klar�n�n (s�n�flar, mod�ller, fonsiyonlar vb.) geni�letmeye a��k, de�i�ime kapal� olmas�n� ama�lar.
Ama�: Mevcun kodun de�i�tilmesine gerek kalmadan yeni i�levselli�inin eklenmesini kolayla�t�rmak


3. L: Liskov Substitution Principle(Liskov'un Yerine Ge�me Prensinsibi)
Tan�m: Alt s�n�flar�n, �st s�n�flar�n yerine ge�ebilmesi gerekti�ini ifade eder. Bir alt s�n�f�n nesnesi, �st s�n�f�n nesnesiyle yer de�i�tirdi�inde, sistem hala do�ru �al��mal�d�r.
Ama�: S�n�f hiyerar�ilerinin sa�lam bir �ekilde tasarlanmas�n� sa�lamak ve alt s�n�flar�n do�ru bir �ekilde implemente edilmesini te�vik etmek eyi ama�lar

4. I: Interface Segregation Principle (Aray�z Ay�rma Prensibi)
Tan�m: B�y�k, �i�kin Aray�zler yerine daha k���k ve daha spesifik aray�zlerin kullan�lmas� gerekti�ini belirtir. Bir s�n�f, kullanmad��� metodlar� i�eren bir aray�z� uygulamamal�d�r.
Ama�: S�n�flar�n gereksiz ba��ml�l�klardan ka��nmas�n� sa�layarak daha esnek yap�lar olu�turmas�n� ama�lar

5) D: Dependency Inversion Principle (Ba��ml�l�klar�n Tersine �evrilme Prensibi)
Tan�m: Y�ksek seviye mod�llerin d���k seviye mod�llere do�rudan ba�l� olmamas�, bunun yerine soyutlamalar arac�l���yla etkile�imde bulunmas� gerekti�ini ifade eder. Soyurlamalar detaylara, detaylar soyutlamalara ba��ml� olmamal�d�r.
Ama�: Mod�ller aras�ndaki ba�lant�y� gev�etmek ve kodun test edilebilirli�ini art�rmak.

## LOD (Law Of Demeter) Veya 'Least Knowledge Principle
Yaz�l�m tasar�mdaki bir nesnenin s�n�rl� bilgiye sahio olmas�n� ve sadece yak�n �evreyle etkile�imde bulunmas� gerekti�ini belirten bir prensiptir.

## SOC Seperation Of Concerns Principle
Bir uygulaman�n veya sistemin farkl� b�l�mlerinin birbirinden ayr� tutulmas� prensibidir.

Example:
1. MVC
2. Katmanl� Mimari
3. Servis Odakl� Mimari (SOA)

## GRASP (General Resposinbility Assignment Software Patterns)
1. Information Expert (Bilgi Uzman�): Sorumluluklar�n, bu sorumluluklar� yerine getirmek i�in gerekli bilgiye sahip olan nesnelere atanmas� gerekti�ini belirtir
2. Create (Olu�turucu): Bir nesnenin olu�turulmas�n�n kim taraf�ndan yap�lmas� gerekti�ini a��klar. Genellikle, bir nesneyi i�eren veya kaydeden, onu s�k�a kullanacak olan ya da ba�latma verilerine sahip olan nesneler olu�turucu olarak se�ilir.
3. Controller: Bir sistemin, UI katman� ve i� mant��� katman� aras�ndaki bir arac� g�revi g�r�r. Sistem olaylar�n� ve i�lemleri y�netmek i�in kullan�l�r
4. Low Coupling (D���k Ba�lant�): Nesneler aras�ndaki ba��ml�klar� azaltmay� �nerir. D���k ba�lant�, esneklik ve yeniden kullan�labilirli�i art�r�r
5. High Cohesion (Y�ksek Ba�da�l�l�k): Bir nesnenin veya s�n�f�n yanl�zca ilgili ve �ok alakl� sorumluluklar� bar�nd�rmas� gerekti�ini belirtir. Y�ksek ba�da��kl�l�k, anla��labilirli�i ve bak�m� kolayla�t�r�r
6. Polymorphism (�ok bi�imlilik): Tip hiyera�isinde de�i�ikliklere tepki vermek i�in aray�z taban�n� �ok bi�imlilik kullanmay� �nerir. 
7. Pure Fabrication (Saf Uydurma): Sistemin i� mant���n�n par�as� olmayan, ancak geli�tirme s�recini kolayla�t�ran nesnelerin olu�turulmas�n� �nerir
8. Indirection (Dolayl�l�k): Bir bile�eni ba�ka bir bile�enden ay�rmak i�in ara bir bile�en kullanmay� �nerir. Bu, ba�lant� azaltmaya yard�mc� olur.
9. Proteted Variations (Korunan De�i�iklikler): Sistemi belirsiz gelecekteki de�i�ikliklerden korumak i�in aray�zler ve sotur s�n�flar gibi mekanizmalar�n kullan�lmas�n� �nler

## DRY (Don't Repeat Yourself)

## KISS (Keep It Simple, Stupid)

## YAGNI (You Aren't Gonna Need It)

## CQRS (Command Query Responsbility Segregation)

## TDD (Test Driven Development)
Kod yazmadan �nce testi yazmal�y�z

## BDD (Behavior-Driven Development)
Yaz�l�m�n davran���n� tan�mlayan testlerle geli�tirme yapmay� vurgulayan

## Fail Fast
Hatalar�n m�nk�n oldu�unda erken ortaya ��kmas�n� ama�layan

## DDD (Domain-Driven Design)

## Composition Over Inheritance
Kal�t�m yerine bile�enleri tercih etmeyi �neren