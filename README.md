# FirmWebApp_Asp.Net_Core_MVC

Bu projede, .NET Core MVC tabanlı bir web uygulaması oluşturulmuş ve DevExtreme kütüphanesi kullanılarak bir izleme ekranı tasarlanmıştır. Bu izleme ekranı, fabrikadaki test alanlarını ve bu alanlara yerleştirilmiş test makinelerini görsel olarak yönetmenizi sağlar.
Makineler, belirli bir layout içinde konumlandırılmış ve çalışma durumlarına göre renklendirilmiştir.

## Proje İçeriği

Proje aşağıdaki adımları içermektedir:

1. CRUD İşlemleri ve Popup Pencereleri:
   - Layout ve Machine nesneleri için CRUD işlemleri sağlayan popup pencereleri oluşturulmuştur. Örnek olarak 2 layout ve her layoutta 3 makine kaydı oluşturulmuştur.

2. DevExtreme Kütüphanesinin Eklenmesi:
   - .NET Core tabanlı bir web uygulaması oluşturulmuştur.
   - DevExtreme kütüphanesi projeye eklenmiş ve bu kütüphane, zengin kullanıcı arayüzü bileşenleri sağlamaktadır.

3. Layout ve Göster Butonunun Oluşturulması:
   - İzleme ekranı için layout tasarımı yapılmıştır. "Göster" butonu, izleme ekranını açmak için kullanılmaktadır.

4. DevExtreme Diagram Bileşeninin Kullanımı:
   - İzleme ekranında DevExtreme Diagram bileşeni kullanılmıştır. Bu bileşen, nesneleri görsel olarak düzenlemenizi ve göstermenizi sağlar.

5. Diagram Boyutlandırması:
   - Diagram ekranı, layout nesnesinde belirtilen genişlik ve yüksekliğe göre boyutlandırılmaktadır.

6. Makina Nesnelerinin Eklenmesi:
   - İlgili layout üzerine, her bir makine kaydının belirtilen koordinatlarına ve boyutlarına uygun dikdörtgen nesneleri eklenmiştir.

7. Mouse Hover İşlevselliği:
   - Dikdörtgen nesnelerin üzerine gelindiğinde, info1 ve info2 alanları mouse hover özelliği ile görüntülenmektedir.

8. DevExtreme Demo Uygulamalarının İncelenmesi:
   - DevExtreme'in demo uygulamaları incelenerek, bileşenlerin kullanımı ve örnek kodlar öğrenilmiştir.

## Nasıl Başlayabilirsiniz

1. Bu projeyi klonlayın veya indirin.
2. Projeyi bir .NET Core geliştirme ortamında açın.
3. Gerekli paketleri yüklemek için NuGet Package Manager'ı kullanın.
4. Proje dosyalarını derleyin ve uygulamayı başlatın.
5. Layout ve makine kayıtlarını oluşturarak izleme ekranını kullanmaya başlayın.

## Daha Fazla Bilgi

Projede kullanılan DevExtreme bileşenleri hakkında daha fazla bilgi için [DevExtreme Belgeleri](https://js.devexpress.com/Documentation/)ni ziyaret edebilirsiniz. Ayrıca, DevExtreme'in demo uygulamalarını inceleyerek örnek kodlar bulabilirsiniz.

## Lisans

Bu proje [Lisans Adı] ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasını inceleyebilirsiniz.
