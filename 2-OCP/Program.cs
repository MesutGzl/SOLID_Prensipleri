using OCP.BadExample;
using OCP.GoodExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BadExample

            /*Burada Araba ve Otobüs üreten bir fabrikamız var. Bu yaptığımız örnek şu anda sorunsuz bir şekilde çalışmaktadır. Fakat fabrikamız Kamyon ya da Motorsiklet üretme kararı alır ise bazı eklemeler yapmamız gerekmektedir. Kamyon üretme kararını aldığını varsayar isek,
             * VehicleType classımızda Truck diye bir enum daha eklememiz gerekiyor.
             * Truck adında bir class oluşturup Vehicle classından inherit almasını sağlamamız gerekiyor.
             * VehicleFactory classına Car ve Bus sınıfı için yaptığımız gibi ProduceTruck classını switch case blockları içerisine eklemeli ve gerekli methodu da yazmalıyız.
             * Son olarak aşağıda bulunan kodlara yazmış olduğumuz kodları kullanmak için method çağrılarını yapmamız gerekiyor.
             
            Bu yaptığımız işlemler uymaya çalıştığımız prensibe uygun olmayan işlemler yaptık. Open-Closed Prensibine göre gelişime açık fakat değişime kapalı işlemler yapmamız gerekiyor. Fakat biz projedeki çoğu yere müdahale ettik.
            */
            VehicleFactory vehicleFactory1 = new VehicleFactory();
            vehicleFactory1.ProduceVehicle(new Car()); //Burada bir araba üretilmesini istedik.

            VehicleFactory vehicleFactory2 = new VehicleFactory();
            vehicleFactory2.ProduceVehicle(new Bus());//Burada bir otobüs üretilmesini istedik.

            Console.ReadLine();
            #endregion

            #region GoodExample
            //Yaptığımız değişiklikler ile projemizi kolay geliştirilebilir hale getirdik. Çekirdek yani core tarafındaki kodlamayı gelişime açık, büyük ve köklü değişimlere kapalı hale getirmiş olduk.
            //Artık yeni bir araç eklemek istediğimizde iş yükümüz çok hafiflemiş şekilde kısa bir süre içerisinde eklemeyi yapabiliriz.
            /*Bu eklemeyi Motorsiklet olarak varsayar isek yapacağımız işlemler şunlar olacaktır.
             * Motorcycle adında bir class açıp Vehicle classından kalıtım almasını sağlıyoruz. Kalıttığımız sınıftan gelen methodumuzun içerisine gerekli kodlamayı yapıyoruz.
             * Daha sonra tek yapmamız gereken Program.cs'de yani alt satırda bulunan kod grubuna Motorcycle sınıfımızın instance'ını alıp üretime başlamasını sağlıyoruz
                
               BadExample'de gördüğünüz gibi bir aracı eklemek için çok çaba sarf ettik. Bu prensibe uyarak işimizi kolaylaştırmış olduk.
             */

            VehicleFactoryGood vehicleFactoryGood1 = new VehicleFactoryGood();
            vehicleFactoryGood1.ProduceVehicle(new CarGood());//Burada bir araba üretilmesini istedik.

            VehicleFactoryGood vehicleFactoryGood2 = new VehicleFactoryGood();
            vehicleFactoryGood2.ProduceVehicle(new BusGood());//Burada bir otobüs üretilmesini istedik.

            VehicleFactoryGood vehicleFactoryGood3 = new VehicleFactoryGood();
            vehicleFactoryGood3.ProduceVehicle(new TruckGood());//Burada bir kamyon üretilmesini istedik.

            Console.Read();
            #endregion
        }
    }
}
