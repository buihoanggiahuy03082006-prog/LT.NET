using System;
using System.Reflection;

namespace NetInfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("==========================================");
            Console.WriteLine("       THÔNG TIN MÔI TRƯỜNG THỰC THI");
            Console.WriteLine("==========================================");

            // 1. Thông tin CLR / .NET
            Console.WriteLine("\n--- THÔNG TIN .NET / CLR ---");

            Console.WriteLine($"Phiên bản CLR/.NET: {Environment.Version}");

            // Sử dụng System.Reflection
            Assembly assembly = typeof(object).Assembly;
            Console.WriteLine($"Assembly CoreLib: {assembly.GetName().Name}");
            Console.WriteLine($"Phiên bản CoreLib: {assembly.GetName().Version}");

            // 2. Thông tin máy tính và người dùng
            Console.WriteLine("\n--- THÔNG TIN HỆ THỐNG ---");

            Console.WriteLine($"Tên máy tính: {Environment.MachineName}");
            Console.WriteLine($"Tên người dùng: {Environment.UserName}");

            // 3. Hệ điều hành và kiến trúc CPU
            Console.WriteLine("\n--- HỆ ĐIỀU HÀNH / CPU ---");

            Console.WriteLine($"Hệ điều hành: {Environment.OSVersion}");
            Console.WriteLine($"Kiến trúc tiến trình: {(Environment.Is64BitProcess ? "64-bit" : "32-bit")}");
            Console.WriteLine($"Kiến trúc hệ điều hành: {(Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit")}");

            // 4. Bộ nhớ do GC quản lý
            Console.WriteLine("\n--- BỘ NHỚ GARBAGE COLLECTOR ---");

            long memory = GC.GetTotalMemory(false);

            Console.WriteLine($"Bộ nhớ GC đang quản lý: {memory:N0} bytes");
            Console.WriteLine($"Bộ nhớ GC đang quản lý: {memory / 1024.0 / 1024.0:F2} MB");

            Console.WriteLine("\n==========================================");
            Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}