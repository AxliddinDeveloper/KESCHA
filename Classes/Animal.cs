namespace KESCHA.Classes
{
    class Animal
    {
        public string Ism { get; set;}
        
        public int yoshFarqi { get; set; }
        public int yoshFarqi2 { get; set; }
        public int hayvonYoshi { get; set; }
        public string aniqlanmaganIsm = "Aniqlanmagan Ism";
        public Animal(string ism, int yosh )
        
        {
             hayvonYoshi = yosh;
            Ism = ism;
        }
        public Animal()
        {
            Ism = "No name";
            hayvonYoshi = 0;
            yoshFarqi = 0;
        }
        public void dasturParoli(string password)
        {
            
        }

        public void salomlash(string foydalanuvchiIsmi)
        {
            if (foydalanuvchiIsmi == "")
            {
                System.Console.WriteLine($"salom! {aniqlanmaganIsm} ");
            }
            else
            {
                Console.WriteLine($"salom {foydalanuvchiIsmi}!");
            }
        }

        public void yoshFarqiniHisoblavaQaytarma(int foydalanuvchiYoshi)
        {
            yoshFarqi = foydalanuvchiYoshi - hayvonYoshi;
        }

        public int yoshFarqiniHisobla(int foydalanuvchiYoshi, int yosh)
        {
            return foydalanuvchiYoshi - yosh;
        }
        

        public void yoshFarqiTaqqosla(int foydalanuvchiYoshi)
        {
            if (foydalanuvchiYoshi > hayvonYoshi)
            {
                Console.WriteLine($"Ooo! sen mendan {foydalanuvchiYoshi - hayvonYoshi} yosh katta ekansan");
            }
            else if (foydalanuvchiYoshi == hayvonYoshi)
            {
                Console.WriteLine("men sen bilan tengdosh ekanman");
            }
            else
            {
                Console.WriteLine($"sen mendan {foydalanuvchiYoshi - hayvonYoshi} yoshga kichik ekaansan ");
            }
        }

        public void dostlarBilanTanishuv(string foydalanuvchiIsmi,int foydalanuvchiYoshi,string foydalanuvchiHohishi)
        {
            int[] dostlarYoshi = {4, 3, foydalanuvchiYoshi};
            string[] dostlarNomi = {"vasya", "katya", foydalanuvchiIsmi};
            if (foydalanuvchiHohishi  == "ha")
            {
                for (int i = 0; i < dostlarNomi.Length; i++)
                {
                    Console.WriteLine($" {dostlarNomi[i]},");
                    Console.WriteLine($"{dostlarNomi[i]}ning yoshi {dostlarYoshi[i]}da.");
                }
            }
            else 
            {
                System.Console.WriteLine("");
            }
        
        }
        private void yoshFarqiniHisoblaQaytarma(int foydalanuvchiYoshi,int yosh)
        {
            yoshFarqi = foydalanuvchiYoshi - yosh;
        }

    }
}