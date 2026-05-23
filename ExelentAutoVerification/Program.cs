using System;
using ExelentAutoVerify.Models;
using ExelentAutoVerify.Services;

namespace ExelentAutoVerify
{
    public class Program
    {
        // dll call
        public static void Run() => Main(null);

        // app entry
        private static void Main(string[] args)
        {
            Console.WriteLine("Doğrulanıyor...");
            UserInfo? result = AutoVerification.Verify();

            if (result == null)
            {
                Console.WriteLine("IP ile eşleşen kullanıcı bulunamadı.");
                Console.ReadLine();
                return;
            }

            UserInfo user = result.Value;

            Console.WriteLine("Kullanıcı     : " + user.Username);
            Console.WriteLine("Bakiye        : " + user.Balance + " TL");
            Console.WriteLine("Trade URL     : " + (user.TradeUrl ?? "Tanımlı değil"));

            Console.WriteLine("\nLisanslar:");
            if (user.Purchases != null && user.Purchases.Length > 0)
            {
                foreach (var p in user.Purchases)
                {
                    Console.WriteLine("  Ürün ID     : " + p.ProductId);
                    Console.WriteLine("  Ürün Adı    : " + p.ProductName);
                    Console.WriteLine("  Fiyat       : " + p.Price + " TL");
                    Console.WriteLine("  Bitiş       : " + p.ExpiresAt);
                    Console.WriteLine("  Satın Alım  : " + p.PurchasedAt);
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Lisans yok.");

            Console.WriteLine("\nHourBoost Lisansları:");
            if (user.HourboostPurchases != null && user.HourboostPurchases.Length > 0)
            {
                foreach (var p in user.HourboostPurchases)
                {
                    Console.WriteLine("  Ürün ID     : " + p.ProductId);
                    Console.WriteLine("  Ürün Adı    : " + p.ProductName);
                    Console.WriteLine("  Fiyat       : " + p.Price + " TL");
                    Console.WriteLine("  Bitiş       : " + p.ExpiresAt);
                    Console.WriteLine("  Satın Alım  : " + p.PurchasedAt);
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("HourBoost lisansı yok.");

            Console.WriteLine("\nMarket Alımları:");
            if (user.MarketPurchases != null && user.MarketPurchases.Length > 0)
            {
                foreach (var m in user.MarketPurchases)
                {
                    Console.WriteLine("  Item ID     : " + m.ItemId);
                    Console.WriteLine("  Item Adı    : " + m.ItemName);
                    Console.WriteLine("  Item Tipi   : " + m.ItemType);
                    Console.WriteLine("  Adet        : " + m.Quantity);
                    Console.WriteLine("  Birim Fiyat : " + m.UnitPrice + " TL");
                    Console.WriteLine("  Toplam      : " + m.TotalPrice + " TL");
                    Console.WriteLine("  Trade URL   : " + m.TradeUrl);
                    Console.WriteLine("  Satın Alım  : " + m.PurchasedAt);
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Market alımı yok.");

            Console.WriteLine("\nCihazlar:");
            if (user.Devices != null && user.Devices.Length > 0)
            {
                foreach (var d in user.Devices)
                {
                    Console.WriteLine("  OS          : " + d.Os);
                    Console.WriteLine("  CPU Core    : " + d.CpuCores);
                    Console.WriteLine("  RAM         : " + d.RamGb + " GB");
                    Console.WriteLine("  GPU         : " + d.Gpu);
                    Console.WriteLine("  Timezone    : " + d.Timezone);
                    Console.WriteLine("  Son Giriş   : " + d.LastLogin);
                    Console.WriteLine("  IP          : " + d.Ip);
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Cihaz yok.");

            Console.WriteLine("Token         : " + user.Token);


            Console.ReadLine();
        }

        // Exelent & HourBoost login
        internal void Login(UserInfo user) => user.Login();
    }
}
