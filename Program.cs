using System;
//ozgaruvchilar
string keschaIsm = "KESCHA";
int keschaYosh = 6;
string ism;
int yosh;
int yoshFarqi; // odam bilan keschaning orasidagi yosh farqi
int yoshFarqiIkki; // agar keschaning yoshi odamnikidan katta bolsa shular orasidagi farq
//tanishuv
System.Console.Write($"Salom mening ismim {keschaIsm} senikichi? ");
ism = System.Console.ReadLine();

System.Console.WriteLine($"salom {ism}!");
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