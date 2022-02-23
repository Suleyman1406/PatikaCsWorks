namespace project_1
{
    class Program
    {
        public static void Main(string[] args)

        {
            List<Directory> directories = new List<Directory>();
            directories.Add(new Directory("Ayse", "Yilmaz", 54621621562));
            directories.Add(new Directory("Firat", "Elmaz", 541625266));
            directories.Add(new Directory("Burak", "Demirel", 54514851));
            directories.Add(new Directory("Ahmet", "Firinci", 541589526154));
            directories.Add(new Directory("Ceyda", "Usta", 58752515652));
            PhoneNumberOperation pno = new PhoneNumberOperation(directories);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(6) Çıkış");
                Console.WriteLine("---------------------------------");
                bool isNumeric = int.TryParse(Console.ReadLine(), out int selectedOperation);
                if (!isNumeric || selectedOperation < 1 || selectedOperation > 6)
                {
                    Console.WriteLine("Lutfen doğru işlem numarasını giriniz!");
                    continue;
                }
                switch (selectedOperation)
                {
                    case 1:
                        pno.SaveNewDirectory();
                        break;
                    case 2:
                        pno.RemoveDirectory();
                        break;
                    case 3:
                        pno.UpdateDirectory();
                        break;
                    case 4:
                        pno.ListDirectiories();
                        break;
                    case 5:
                        pno.SearchDirectiories();
                        break;
                    case 6:
                        Console.WriteLine("Çıkış yapıldı.");
                        return;
                }

            }
        }
    }

}