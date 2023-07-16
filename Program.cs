﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using KESCHA.Classes;

//ozgaruvchilar
string ism;//odamning ismi
int yosh;//odamning yoshi
string password, hohish;
//parol


do
{
    Console.WriteLine("Men bilan gaplashish uchun parolni kiriting");
    password = Console.ReadLine();
    if (password != "parol")
    {
        Console.WriteLine("\nParol noto'g'ri, qayta urinib ko'ring\n");
    }
} 
while (password != "parol");
{
    Console.WriteLine("\nParol to'g'ri, davom etishingiz mumkin\n");
}



//tanishuv
Console.Write("Assalomu alaykum \niltimos ismingizni kiriting!: ");

ism = Convert.ToString(Console.ReadLine());
Console.WriteLine($"salom {ism}!");

Console.Write($"yoshing nechchida?  ");
yosh = Convert.ToInt32(Console.ReadLine());

    // Animal metodi
Animal kescha = new Animal("KESCHA", yosh, 3);
kescha.Yosh = 3;

Console.WriteLine(" senga men o\'zimning dostlarim haqida gapirib berishimni hohlisanmi? ");
hohish = Convert.ToString(Console.ReadLine());
kescha.yoshFarqiTaqqosla(yosh);
kescha.dostlarBilanTanishuv(ism,yosh,hohish);