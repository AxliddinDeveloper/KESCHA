namespace KESCHA.Classes
{
    class Animal
    {
        public string Ism { get; set;}
        public int Yosh { get; set;}
        public int yoshFarqi { get; set; }
        public int yoshFarqi2 { get; set; }
        public Animal(string ism, int yosh )
        {
            yosh = Yosh;
            ism = Ism;
        }
        public Animal()
        {
            Ism = "No name";
            Yosh = 0;
            yoshFarqi = 0;
        }

//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public Animal(
        string ism, 
        int foydalanuvchiYoshi, 
        int yosh)
        {
            Ism = ism;
            Yosh = yosh;
            yoshFarqiniHisoblaVaQaytarma( foydalanuvchiYoshi, yosh);
            yoshFarqi2 = yosh - foydalanuvchiYoshi;

        }

        public int yoshFarqiniHisobla(int foydalanuvchiYoshi)
        {
            return foydalanuvchiYoshi - Yosh;
        }
        public int yoshFarqiniHisobla(int foydalanuvchiYoshi, int yosh)
        {
            return foydalanuvchiYoshi - yosh;
        }

        public void yoshFarqiTaqqosla(int foydalanuvchiYoshi)
        {
            if (foydalanuvchiYoshi > Yosh)
            {
                Console.WriteLine($"Ooo! sen mendan {foydalanuvchiYoshi - Yosh} yosh katta ekansan");
            }
            else if (foydalanuvchiYoshi == Yosh)
            {
                Console.WriteLine("men sen bilan tengdosh ekanman");
            }
            else
            {
                Console.WriteLine($"sen mendan {foydalanuvchiYoshi - Yosh} yoshga kichik ekaansan ");
            }
        }

        public void dostlarBilanTanishuv(string foydalanuvchiIsmi,int foydalanuvchiYoshi)
        {
            int[] dostlarYoshi = {4, 3, foydalanuvchiYoshi};
            string[] dostlarNomi = {"vasya", "katya", foydalanuvchiIsmi};
            Console.WriteLine("kel senga men o\'zimning dostlarim haqida gapirib beraman");
            Console.WriteLine($" {dostlarNomi[0]}, {dostlarNomi[1]} va {dostlarNomi[2]}");
            Console.WriteLine($"{dostlarNomi[0]}ning yoshi {dostlarYoshi[0]}da");
            Console.WriteLine($"{dostlarNomi[1]}ning yoshi {dostlarYoshi[1]}da");
            Console.WriteLine($"{dostlarNomi[2]}ning yoshi {dostlarYoshi[2]}da");
        }
        private  void yoshFarqiniHisoblaVaQaytarma(int foydalanuvchiYoshi,int yosh)
        {
            yoshFarqi = foydalanuvchiYoshi - yosh;
        }

    }
}