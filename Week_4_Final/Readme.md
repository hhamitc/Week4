# Week 4 Final Project - Cihaz Üretim Simülasyonu

Bu proje, bir cihaz üretim simülasyonudur. Kullanıcıdan alınan bilgiler doğrultusunda **telefon** veya **bilgisayar** nesneleri oluşturur ve her iki cihaz türüne özel özellikler sağlar. Cihaz bilgileri kullanıcının girişiyle tanımlanır ve cihaz türüne göre ek bilgiler kullanıcıya sunulur.

## Proje Özeti
Bu proje, kullanıcıya cihaz türü seçimi sunar ve bu seçim doğrultusunda cihazın seri numarası, ürün adı, açıklama ve işletim sistemi gibi bilgilerini kullanıcıdan alır. Seçilen cihaz türüne göre farklı özellikler de sorulur:
- **Telefon**: TR Lisans durumu (Evet/Hayır)
- **Bilgisayar**: USB port sayısı (2 veya 4) ve Bluetooth durumu (Var/Yok)

Projede, `Phone` ve `Computer` sınıfları `BaseMachine` sınıfından türetilmiştir ve her iki cihaz tipi için ortak bilgiler `BaseMachine` sınıfında tanımlanmıştır.

## Nasıl Çalıştırılır?
Projeyi çalıştırmak için aşağıdaki adımları izleyin:

1. **Proje Dosyalarını İndirin**: 
   Bu projeyi yerel makinenize klonlayın veya zip dosyasını indirip açın.

2. **IDE veya Editör**:
   Visual Studio veya Visual Studio Code gibi bir C# IDE'si kullanarak projeyi açın.

3. **Proje Yapılandırması**:
   Çalıştırmadan önce `Week_4_Final` adındaki namespace ve class yapısının projenizde doğru konumda olduğundan emin olun.

4. **Programı Başlatın**:
   `Program.cs` dosyasını çalıştırarak projeyi başlatın. Konsol ekranında cihaz türü seçiminizi yaparak (1: Telefon, 2: Bilgisayar) adımları izleyebilirsiniz.

## Kullanılan Teknolojiler
Bu proje, **C#** dili ve .NET Framework'ü kullanılarak geliştirilmiştir. Projede kullanılan temel C# kavramları ve yapılar:
- **Classes ve Inheritance (Kalıtım)**: `BaseMachine` sınıfı temel özellikleri tanımlarken, `Phone` ve `Computer` sınıfları cihaz türüne göre genişletilmiştir.
- **Polymorphism (Çok Biçimlilik)**: `DisplayInfo()` metoduyla, her sınıf kendi cihaz bilgilerini ekrana yazdırır.
- **Encapsulation (Kapsülleme)**: Özelliklerin sınıflarda özel veya korumalı şekilde tanımlanması ve gerekli kontrollerin yapılmasıyla veri güvenliği sağlanır.

## Proje Detayları
- **`BaseMachine` Sınıfı**: Cihazların ortak özelliklerini ve üretim tarihini içerir. `DisplayInfo()` metodu ile cihaz bilgilerini konsola yazdırır.
- **`Phone` Sınıfı**: `TRLicensed` özelliği ile telefonun Türkiye lisansına sahip olup olmadığını kontrol eder. Hatalı girişlerde lisans durumu "hayır" olarak atanır.
- **`Computer` Sınıfı**: `UsbPortCount` ve `Bluetooth` özellikleri ile USB port sayısını ve Bluetooth durumunu kontrol eder. Hatalı girişlerde varsayılan değerler atanır.

## Örnek Kullanım
Programı başlattığınızda:
1. Telefon üretmek için **1**, bilgisayar üretmek için **2** tuşlarına basarak seçim yapın.
2. Seçtiğiniz cihaz türüne göre istenen bilgileri girin.
3. Cihaz bilgileri ekrana yazdırılacaktır.
4. Yeni bir ürün oluşturmak için **E** tuşuna basabilirsiniz. Aksi durumda program sonlanacaktır.

## Ek Bilgiler
Bu projede `goto` ifadesi ile döngü yapısı sağlanmıştır. `goto Begin;` ifadesi, kullanıcının hatalı girişlerinde başlangıç noktasına dönerek cihaz seçim ekranını yeniden görüntülemektedir. `goto` kullanımı genellikle önerilmese de burada kullanıcı deneyimini kolaylaştırmak adına tercih edilmiştir.


