# Pratik - Polymorphism Uygulaması

Bu proje, polymorphism prensibini kullanarak geometrik şekillerin alanını hesaplayan bir uygulamadır. Kare, dikdörtgen ve dik üçgen nesneleri için alan hesaplaması yapar ve sonuçları konsol ekranına yazdırır.

## Proje Yapısı

### Sınıflar:
1. **BaseGeometricShape**: Tüm geometrik şekiller için temel olan soyut (abstract) sınıftır. `Genişlik` ve `Yükseklik` özellikleriyle alan hesaplamasını ve sonucu ekrana yazdırmayı sağlar. Diğer sınıflar bu sınıftan türetilir.
2. **Triangle**: Dik üçgenin alanını hesaplayan sınıf. Alan hesaplaması, `(Genişlik x Yükseklik) / 2` formülü ile yapılır.
3. **Rectangle**: Dikdörtgenin alanını hesaplayan sınıf. Alan hesaplaması, `Genişlik x Yükseklik` formülü ile yapılır.
4. **Square**: Karenin alanını hesaplayan sınıf. Alan hesaplaması, `Genişlik x Yükseklik` formülü ile yapılır.

### Özellikler (Property'ler):
- **_width (Genişlik)**: Geometrik şeklin genişliğini temsil eder.
- **_height (Yükseklik)**: Geometrik şeklin yüksekliğini temsil eder.

### Metotlar:
- **CalculateArea()**: Her sınıfta, geometrik şeklin alanını hesaplayan metot. `BaseGeometricShape` sınıfında sanal (virtual) olarak tanımlanmış, diğer sınıflarda geçersiz kılınarak (override) özelleştirilmiştir.
- **DisplayResult()**: Alan hesaplama sonucunu konsol ekranına yazdıran metot. Her sınıfta özelleştirilmiştir.

## Kullanım

Proje, her bir geometrik şekil için bir nesne oluşturur, genişlik ve yükseklik değerleri atanır, ardından alan hesaplanarak sonuçlar ekrana yazdırılır.

### Örnek Kullanım:

```csharp
BaseGeometricShape triangle = new Triangle();
triangle._height = 8;
triangle._width = 5;
triangle.DisplayResult();

BaseGeometricShape square = new Square();
square._height = 9;
square._width = 10;
square.DisplayResult();

BaseGeometricShape rectangle = new Rectangle();
rectangle._height = 10;
rectangle._width = 5;
rectangle.DisplayResult();
