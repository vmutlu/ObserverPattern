# Observe Design Pattern 

Observer tasarım deseni, Bir nesnede meydana gelen değişikliği içinde bulunduğu listedeki tüm elemanlara bildiren davranışsal bir tasarım desenidir.

**Wikipedia'ya göre;**<br>
Observer tasarım deseni, özne olarak adlandırılan bir nesnenin, observers olarak adlandırılan bağımlılarının bir listesini tuttuğu ve genellikle methodlarının birini çağırarak herhangi bir durum değişikliğini otomatik olarak bildirdiği bir yazılım tasarım kalıbıdır.

## :pushpin:Observe Design Pattern
<p align="center">
<img src="https://user-images.githubusercontent.com/50150182/130359841-28b156ff-367c-4a1b-86b6-87dbf1414a22.png">
<br>    
<em>Kaynak: https://github.com/yusufyilmazfr/tasarim-desenleri-turkce-kaynak#-observer</em>
</p>

* * *

Observer: Değişimden etkilenecek, izleyecek olan sınıfların uyguladığı arayüzdür. Duruma göre soyut sınıf (abstract class) da olabilir.

ConcreteObserver: Observer arayüzünü uygulayan, değişimi takip eden sınıflardır. Değişim update metotu ile bildirilir.

Observable: Takip edilecek olan yapımızdır. İçerisinde Observer (değişimden etkilenecek) nesneleri tutar.

ConcreteObservable: Observer sınıfından türerler.

### Senaryo

Bu projede Senaryo olarak bir kargo şirketinde siparişte olan bir ürünü ele alalım. Ürün durumu değiştikten sonra takip eden kullanıcılara bir mesaj(sms,email vb.) gittiğini düşünelim.

<p align="center">
<img src="https://user-images.githubusercontent.com/50150182/130360187-09271d15-761d-4e7a-affa-a901e2c1405c.JPG">
<br>    
<em>Proje UML Diyagramı</em>
</p>

Diyelim ki sipariş her güncellendiğinde müşteriye e-posta veya sms göndermek için bir iş isterimiz var. Yukarıdaki IOrderObserver'ı implemente eden bir sınıf oluşturarak bu özelliği uygulamanıza kolayca ekleyebilirsiniz . 
<br>
İşte böyle bir sınıfa bir örnek.<hr>
![6](https://user-images.githubusercontent.com/50150182/130360646-61bbd7e1-76a1-491c-90f9-5947c7efaba7.JPG)
![7](https://user-images.githubusercontent.com/50150182/130360647-a8023306-28fb-4e55-b2bb-ac566f828f88.JPG)

![3](https://user-images.githubusercontent.com/50150182/130360162-4900955e-c6e7-4287-bdea-2a8e4b0a9678.JPG)

Kullanıcı ekrandaki siparişin durumunu değiştirince abone olan abonelerinde bilgilendirildiğini görüyorsunuz.

## :pushpin:Özetle
Özetle Observer tasarım deseni yararlıdır ve bir nesnenin başka bir nesneyi gözlemlemesi ve başka bir nesnenin durumu değiştiğinde bildirim alması gereken durumlarda kullanılabilir. :wave:








