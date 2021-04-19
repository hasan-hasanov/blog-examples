using System;
using System.Threading;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;

namespace BleConsoleDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var watcher = new BluetoothLEAdvertisementWatcher();
            watcher = new BluetoothLEAdvertisementWatcher()
            {
                ScanningMode = BluetoothLEScanningMode.Passive
            };

            watcher.Received += Watcher_Received;
            watcher.Start();

            await Task.Delay(Timeout.Infinite);
        }

        private static async void Watcher_Received(
            BluetoothLEAdvertisementWatcher sender,
            BluetoothLEAdvertisementReceivedEventArgs args)
        {
            var device = await BluetoothLEDevice.FromBluetoothAddressAsync(args.BluetoothAddress);
            if (device != null)
            {
                Console.WriteLine(device.BluetoothAddress);
            }
        }
    }
}
