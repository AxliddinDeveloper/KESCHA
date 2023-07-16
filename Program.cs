﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using KESCHA.Classes;

namespace KASCHA
{
    class Program
    {
        static void Main()
        {
            Animal kescha = new Animal("KESCHA", 3);
            //ozgaruvchilar
            string foydalanuvchiIsmi; //odamning ismi
            int foydalanuvchiYoshi;   //odamning yoshi
            string password, hohish;
            //parol

            do
            {
                Console.Write("Men bilan gaplashish uchun parolni kiriting!: ");
                password = Console.ReadLine();
                if (password != "parol")
                {
                    Console.WriteLine("\nParol noto'g'ri, qayta urinib ko'ring\n");
                }
            } 
            while(password != "parol");
            {
                Console.WriteLine("\nParol to'g'ri, davom etishingiz mumkin\n");
            }

            //tanishuv
            Console.Write("Assalomu alaykum \niltimos ismingizni kiriting!: ");
            foydalanuvchiIsmi = Convert.ToString(Console.ReadLine());
            kescha.salomlash(foydalanuvchiIsmi);

            Console.Write($"yoshing nechchida?  ");
            foydalanuvchiYoshi = Convert.ToInt32(Console.ReadLine());

            kescha.yoshFarqiniHisoblavaQaytarma(foydalanuvchiYoshi);

            kescha.yoshFarqiTaqqosla(foydalanuvchiYoshi);

            Console.WriteLine(" \nsenga men o\'zimning dostlarim haqida gapirib berishimni hohlisanmi? ");

            hohish = Convert.ToString(Console.ReadLine());

            kescha.dostlarBilanTanishuv(foydalanuvchiIsmi, foydalanuvchiYoshi, hohish);
        }
    }
}
