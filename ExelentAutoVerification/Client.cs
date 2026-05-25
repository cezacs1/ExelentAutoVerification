using System;
using System.Diagnostics;
using ExelentAutoVerification.Models;
using ExelentAutoVerification.services;

namespace ExelentAutoVerify
{
    public class Client
    {
        private AutoVerification verificationService;
        private bool sendDiscordMsg;

        // base client
        public Client(string procName, bool SendDiscordMsg)
        {
            verificationService = new AutoVerification(procName);
            this.sendDiscordMsg = SendDiscordMsg;
        }

        // app entry
        private static void Main(string[] args) =>
            new Client
            (
                procName: Process.GetCurrentProcess().ProcessName.ToLower(),
                SendDiscordMsg: true
            ).Run();

        // dll call
        public void Run() => this.Update();

        private void Update()
        {
            Console.WriteLine("CurrentApp -> " + verificationService.ToString());
            Console.WriteLine("Doğrulanıyor...");

            UserInfo? result = verificationService.Verify(sendDiscordMsg);
            if (result == null) return;

            Console.WriteLine("Giriş başarılı.");

            UserInfo user = result.Value;

            if (verificationService.currentApp == App.CurrentAPP.DesktopApp)
            {
                PrintStatus(user);
            }
        }

        private void PrintStatus(UserInfo user)
        {
            Console.WriteLine("Kullanıcı     : " + user.Username);
            Console.WriteLine("Bakiye        : " + user.Balance + " TL");
            Console.WriteLine("Trade URL     : " + (user.TradeUrl ?? "Tanımlı değil"));
            Console.WriteLine("Steam ID      : " + (user.SteamId ?? "Trade URL tanımlı değil"));
            Console.WriteLine("Friend Code   : " + (user.FriendCode ?? "Alınamadı"));

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
    }
}