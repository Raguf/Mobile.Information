using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MobileData
    {
        public int id;
        public string name;                   // Telefonun markası
        public int yearOfManufacture;         // Telefonun istehsal ili
        public string operatingSystem;        // Telefonun əməliyyat sistemi
        public string operatingSystemVersion; // Telefonun əməliyyat sisteminin versiyası
        public int numberOfCores;             // Telefonun nüvə sayı
        public string processorType;          // Telefonun processorun növü
        public int numberOfSimCards;          // Telefonun SIM kartların sayını
        public int memoryRAM;                 // Telefonun operativ yaddaşı
        public int memoryBuiltIn;             // Telefonun daxili yaddaşı
        public string processorName;          // Telefonun processorun adı
        public double processorSpeed;         // Telefonun prosessor tezliyi
        public string network;                // Telefonun şəbəkəsi
        public string typeOfControl;          // Telefonun idarəetmə növü
        public double screen;                 // Telefonun ekranın ölçüsü
        public int camera;                    // Telefonun kamerası
        public int frontCamera;               // Telefonun ön kamerası
        public string bodyMaterial;           // Telefonun korpusun materialı
        public string screenResolution;       // Telefonun ekran görüntüsü
        public int videoFormat;               // Telefonun video formatı
        public string batteryType;            // Telefonun batareya növü
        public int batteryCapacity;           // Telefonun batareyanın həcmi
        public int warranty;                  // Telefonun zəmanəti
        public int weight;                    // Çəki
        public string color;                  // Rəng

        int counter = 0;

        public MobileData()
        {
            counter++;
            id = counter;
        }
        public override string ToString()
        {
            return $"No: {id}\n" + $"name: {name}\n" + 
                $"yearOfManufacture: {yearOfManufacture}\n" +
                $"operatingSystem: {yearOfManufacture}\n" + 
                $"operatingSystemVersion: {operatingSystemVersion}\n" +
                $"numberOfCores: {numberOfCores}\n" +
                $"processorType: {processorType}\n" +
                $"numberOfSimCards: {numberOfSimCards}\n" +
                $"memoryRAM: {memoryRAM}\n" +
                $"memoryBuiltIn: {memoryBuiltIn}\n" +
                $"processorName: {processorName}\n" +
                $"processorSpeed: {processorSpeed}\n" +
                $"network: {network}\n" +
                $"typeOfControl: {typeOfControl}\n" +
                $"screen: {screen}\n" +
                $"camera: {camera}\n" +
                $"frontCamera: {frontCamera}\n" +
                $"bodyMaterial: {bodyMaterial}\n" +
                $"screenResolution: {screenResolution}\n" +
                $"videoFormat: {videoFormat}\n" +
                $"batteryType: {batteryType}\n" +
                $"batteryCapacity: {batteryCapacity}\n" +
                $"warranty: {warranty}\n" + 
                $"weight: {weight}\n" +
                $"color: {color}\n";
                
        }
    }
}
