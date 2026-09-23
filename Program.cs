int totalSteps = 50;

        for (int step = 1; step <= totalSteps; step++)
        {
            Console.WriteLine($"Loading... Step {step} of {totalSteps}");
        }

        Console.WriteLine("\nDungeon is ready. Enter now!");




        using System;

namespace BattleSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Meminta input dari pengguna
            Console.Write("Input character's name: ");
            string name = Console.ReadLine();

            Console.Write("Input number of battles: ");
            int battles = int.Parse(Console.ReadLine());

            Console.Write("Input EXP gained per battle: ");
            int expPerBattle = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            int totalExp = 0;

            // 2. Menggunakan for loop untuk menampilkan log setiap pertarungan
            for (int i = 1; i <= battles; i++)
            {
                int previousExp = totalExp;
                totalExp += expPerBattle;

                Console.WriteLine($"Battle {i} | EXP gained: {expPerBattle} | Total EXP: {totalExp}");

                // Fitur Bonus: Menampilkan pesan jika total EXP mencapai kelipatan 100
                // Logika ini memastikan milestone tercetak meskipun EXP melompati angka 100 
                // (misal: dari 90 langsung ke 120, milestone 100 tetap tercetak)
                int prevMilestone = previousExp / 100;
                int currMilestone = totalExp / 100;

                if (currMilestone > prevMilestone && currMilestone > 0)
                {
                    for (int m = prevMilestone + 1; m <= currMilestone; m++)
                    {
                        Console.WriteLine($"* Milestone reached! Total EXP: {m * 100} *");
                    }
                }
            }

            // 3. Menampilkan ringkasan setelah loop selesai
            Console.WriteLine("\n=== BATTLE COMPLETE ===");
            Console.WriteLine($"Character : {name}");
            Console.WriteLine($"Battles   : {battles}");
            Console.WriteLine($"Total EXP : {totalExp}");
        }
    }
}