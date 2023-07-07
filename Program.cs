﻿ using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using KESCHA.Classes;

//ozgaruvchilar
string ism;//odamning ismi
int yosh;//odamning yoshi
string password;
//parol

key:
System.Console.WriteLine(" men bilan gaplashish uchun parolni kiriting");
password =Console.ReadLine();
//mantiqiy qismi
if (password != "password" )
{
    System.Console.WriteLine("\n");
    System.Console.WriteLine("parol notog'ri iltimos qaytadan urinib koring");
    goto key;
}
else
{
    System.Console.WriteLine("\nparol tog'ri davom etishingiz mumkin\n");
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


kescha.yoshFarqiTaqqosla(yosh);
kescha.dostlarBilanTanishuv(ism,yosh);