 using System;
 using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

//ozgaruvchilar
string keschaIsm = "KESCHA";
int keschaYosh = 6;
string ism;
int yosh;
int yoshFarqi; // odam bilan keschaning orasidagi yosh farqi
int yoshFarqiIkki; // agar keschaning yoshi odamnikidan katta bolsa shular orasidagi farq
 string password = "";
do
{
    System.Console.WriteLine("ismingiz: ");
    ism = System.Console.ReadLine();

    System.Console.Write("men bilan gaplashish uchun parolni kiriting: ");
    password = Console.ReadLine();

}while ( password != "passwordd" || ism != "Axliddin");

//tanishuv
System.Console.WriteLine($"salom {ism}!");
System.Console.Write($"Salom mening ismim {keschaIsm}");
System.Console.Write($"mening yoshim {keschaYosh} da senikichi  {ism}?  ");
yosh = Convert.ToInt32(Console.ReadLine());

yoshFarqi = yosh - keschaYosh;
if (yosh > keschaYosh)
{
    System.Console.WriteLine($"Ooo! sen mendan {yoshFarqi} yosh katta ekansan");
}else if (yosh == keschaYosh)
{
    System.Console.WriteLine("men sen bilan tengdosh ekanman");
}
else
{
    yoshFarqiIkki = keschaYosh - yosh;
    System.Console.WriteLine($"sen mendan {yoshFarqiIkki} yoshga kichik ekaansan ");
}
int[] dostlarYoshi = {4, 3, 6};
string[] dostlarNomi = {"vasya", "katya", "ivan"};
System.Console.WriteLine("kel senga men o\'zimning dostlarim haqida gapirib beraman");
System.Console.WriteLine($" {dostlarNomi[0]}, {dostlarNomi[1]} va {dostlarNomi[2]}");
System.Console.WriteLine($"{dostlarNomi[0]}ning yoshi {dostlarYoshi[0]}da");
System.Console.WriteLine($"{dostlarNomi[1]}ning yoshi {dostlarYoshi[1]}da");
System.Console.WriteLine($"{dostlarNomi[2]}ning yoshi {dostlarYoshi[2]}da");
