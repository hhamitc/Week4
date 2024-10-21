# Hafta 4 - Kalıtım Örneği

Bu proje, C# dilinde kalıtım (inheritance) konusunu örneklemek amacıyla oluşturulmuştur. Projede `BaseKisi` adında soyut bir sınıf ve bu sınıftan türetilmiş `Ogrenci` ve `Ogretmen` sınıfları bulunmaktadır.

## Sınıflar

### BaseKisi

- `Ad`: Kişinin adı.
- `Soyad`: Kişinin soyadı.

### Ogrenci

- `OgrenciNo`: Öğrencinin numarası.
- `OgrenciBilgileri()`: Öğrencinin bilgilerini ekrana yazdırır.

### Ogretmen

- `Maas`: Öğretmenin maaşı.
- `OgretmenBilgileri()`: Öğretmenin bilgilerini ekrana yazdırır.

## Kullanım

Programın ana sınıfı `Program` sınıfıdır. Bu sınıfta `Ogrenci` ve `Ogretmen` sınıflarından nesneler oluşturulup, bu nesnelerin bilgileri ekrana yazdırılmaktadır.