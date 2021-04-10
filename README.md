# SOLID Prensipleri
**Robert Martin**‘in sunumu ile ortaya çıkan **Dependency Managament**(Bağımlılık Yönetimi) biçiminin, ilkelerinin baş harflerinin SOLID ismini oluşturması sonucu bu prensiplerin bütününe SOLID denmiştir.

Bu prensipleri sıralar isek,

***Single Responsibility Principle***

***Open Closed Principle***

***Liskov Substitution Principle***

***Interface Segregation Principle***

***Dependency Inversion Principle***

## [***Single Responsibility Principle***](https://github.com/MesutGzl/SOLID_Prensipleri/tree/master/1-SRP)

Bu ilkeye göre bir sınıfın ya da methodun yalnızca bir sorumluluğu olması gerekmektedir. Örnek vermek gerekir ise kullanıcıların bilgilerinin tutulduğu bir 
sınıfta mail gönderme methodunun bulunması yanlıştır.
Bu durumdaki gibi bir classı sorumluluğu dışında method yığınları ile doldurmak ileride başımızı çok ağrıtacaktır. Belirli sorumluluğa ait methodları ayrı classlar
içerisinde toplamak bize ileride değişiklik yapacağımız ve ekleyeceğimiz yeni özellikler üzerinde çalışırken yaşanacak olan kargaşayı minimuma indirecektir.

## [***Open Closed Principle***](https://github.com/MesutGzl/SOLID_Prensipleri/tree/master/2-OCP)

Bu ilkeye göre objeler yada entityler genişlemeye açık ama değişikliğe kapalı olmalıdır.  Yeni gelecek özellikler için varolan kodu değiştirmeden, varolan yapıyı bozmadan 
istediğimiz özelliği kazandırmak için Open Closed Prensibine uymamız gerekmektedir.

## [***Liskov Substitution Principle***](https://github.com/MesutGzl/SOLID_Prensipleri/tree/master/3-LSP)

Liskov’un yerine geçme prensibine göre türetilmiş sınıflar, alt sınıflarıyla yer değiştirebilmeli ve türetilmiş sınıf ile aynı davranışı sergilemelidir.

## [***Interface Segregation Principle***](https://github.com/MesutGzl/SOLID_Prensipleri/tree/master/4-ISP)

Client'lar ihtiyaç duymadıkları bir interface'i kullanmaya zorlanmamalı veya ihtiyaç duyduğu interface'e ait tek bir metod için bütün interface'in metodları implemente 
etmemelidir. Interface Segregation prensibi bu gibi durumlar için interface'lerinizi ayırın ve bir interface'e gerektiğinden fazla görev yüklemeyin der. Böylelikle client 
geliştirmesini yaparken ihtiyaç duymadığı hiç bir metodu implemente etmek zorunda kalmayacaktır.


