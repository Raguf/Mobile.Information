using ClassLibrary.Helper;
using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Məhsul məlumatlarını saxlamaq üçün tip yaratmalı(class
               ve linkdeki kimi fieldləri olsun
               (İnglis dilində yazılmalıdır fieldlər)*/

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Title = "Mobile Information";

            int len; 

        note:

            len = Monitor.ReadInteger("Necə ədəd telefon olsun: ");

            if (len <= 0)
            {
                goto note;
            }

            MobileData [] mobileDatas = new MobileData[len];

            for (int i = 0; i < mobileDatas.Length; i++)

            {
                MobileData mobileData = new MobileData();

                mobileData.name = Monitor.ReadString($"{i+1}. Telefonun markasını yaz: (Samsung/Nokia/Iphone/Huawei v.s.)");
                mobileData.yearOfManufacture = Monitor.ReadInt($"{i + 1}. Telefonun istehsal ilini yaz: (il)");
                mobileData.operatingSystem = Monitor.ReadString($"{i + 1}. Telefonun əməliyyat sistemini yaz: (Android/IOS)");
                mobileData.operatingSystemVersion = Monitor.ReadString($"{i + 1}. Telefonun əməliyyat sisteminin versiyasını yaz: (1.0-8.0)");
                mobileData.numberOfCores = Monitor.ReadInt($"{i + 1}. Telefonun nüvə sayını yaz: ");
                mobileData.processorName = Monitor.ReadString($"{i + 1}. Telefonun processorun adını yaz: ");
                mobileData.processorType = Monitor.ReadString($"{i + 1}. Telefonun processorun növünü yaz: ");
                mobileData.processorSpeed = Monitor.ReadInt($"{i + 1}. Telefonun prosessor tezliyini yaz: (GHz)");
                mobileData.numberOfSimCards = Monitor.ReadInt($"{i + 1}. Telefonun SIM kartların sayını yaz: (1/2)");
                mobileData.memoryRAM = Monitor.ReadInt($"{i + 1}. Telefonun operativ yaddaşını yaz: (GB)");
                mobileData.memoryBuiltIn = Monitor.ReadInt($"{i + 1}. Telefonun daxili yaddaşını yaz: (GB)");              
                mobileData.network = Monitor.ReadString($"{i + 1}. Telefonun şəbəkəsini yaz: (G)");
                mobileData.typeOfControl = Monitor.ReadString($"{i + 1}. Telefonun idarəetmə növünü yaz: (knopka/sensor)");
                mobileData.screen = Monitor.ReadDouble($"{i + 1}. Telefonun ekranın ölçüsünü yaz: (')");
                mobileData.camera = Monitor.ReadInt($"{i + 1}. Telefonun kamerasını yaz: (mpx)");
                mobileData.frontCamera = Monitor.ReadInt($"{i + 1}. Telefonun ön kamerasını yaz: (mpx)");
                mobileData.bodyMaterial = Monitor.ReadString($"{i + 1}. Telefonun korpusun materialını yaz: (şüşə/plastik/metal)");
                mobileData.screenResolution = Monitor.ReadString($"{i + 1}. Telefonun ekran görüntüsünü yaz: (HD)");            
                mobileData.videoFormat = Monitor.ReadInt($"{i + 1}. Telefonun video formatı yaz: (1K-4K)");
                mobileData.batteryType = Monitor.ReadString($"{i + 1}. Telefonun batareya növünü yaz: ");
                mobileData.batteryCapacity = Monitor.ReadInt($"{i + 1}. Telefonun batareyanın həcmini yaz: (mAh)");
                mobileData.warranty = Monitor.ReadInt($"{i + 1}. Telefonun zəmanətini yaz: (il)");
                mobileData.weight = Monitor.ReadInt($"{i + 1}. Telefonun çəkisini yaz: (qramm");
                mobileData.color = Monitor.ReadString($"{i + 1}. Telefonun rəngini yaz: ");

                mobileDatas[i] = mobileData;
                Console.WriteLine("-----------------------------------------------------");

            }

            Console.WriteLine("########################## List of Mobilephones ###################################");

            foreach (var item in mobileDatas)
            {
                Console.WriteLine(item);
                Console.WriteLine("**************************************************");
            }
            Console.ReadKey();
        }
    }
}
