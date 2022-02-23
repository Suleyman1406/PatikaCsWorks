namespace project_1
{
    class PhoneNumberOperation
    {
        private List<Directory> directories;

        public PhoneNumberOperation(List<Directory> directories)
        {
            this.directories = directories;
        }

        public void SaveNewDirectory()
        {
            Console.Write("Lütfen isim giriniz             : ");
            string name = Console.ReadLine() + "";
            Console.Write("Lütfen soyisim giriniz          : ");
            string surname = Console.ReadLine() + "";
            Console.Write("Lütfen telefon numarası giriniz : ");
            bool isNumeric = long.TryParse(Console.ReadLine(), out long phoneNumber);
            if (!isNumeric)
            {
                Console.WriteLine("Lütfen numarayı doğru formatda giriniz!");
                SaveNewDirectory();
                return;
            }
            directories.Add(new Directory(name, surname, phoneNumber));
            Console.WriteLine("Yeni rehber eklendi!");
        }

        public void RemoveDirectory()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string name = Console.ReadLine() + "";
            int index = -1;
            foreach (var d in directories)
            {
                if (d.Name == name || d.Surname == name)
                {
                    index = directories.IndexOf(d);
                    break;
                }
            }
            if (index != -1)
            {

                string res = "";
                while (true)
                {
                    Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) : ", name);
                    res = Console.ReadLine() + "";
                    if (res == "Y" || res == "y" || res == "N" || res == "n")
                    {
                        break;
                    }
                    Console.WriteLine("Lütfen doğru yazınız!");
                }
                if (res == "y" || res == "Y")
                {
                    directories.RemoveAt(index);
                    Console.WriteLine("{0} isimli kişi rehberden başarıyla silindi.", name);
                }
                else
                {
                    Console.WriteLine("{0} silme işlemi durduruldu.");
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("(1) Silmeyi sonlandırmak için ");
                    Console.WriteLine("(2) Yeniden denemek için      ");
                    bool isNumeric = int.TryParse(Console.ReadLine(), out int operationNum);
                    if (isNumeric)
                    {
                        if (operationNum == 1)
                        {
                            Console.WriteLine("{0} silme işlemi durduruldu.");
                            break;
                        }
                        else if (operationNum == 2)
                        {
                            RemoveDirectory();
                            return;
                        }
                    }
                    Console.WriteLine("Lutfen doğru işlem numarasını giriniz!");
                }
            }
        }

        public void UpdateDirectory()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string name = Console.ReadLine() + "";
            int index = -1;
            foreach (var d in directories)
            {
                if (d.Name == name || d.Surname == name)
                {
                    index = directories.IndexOf(d);
                    break;
                }
            }
            if (index != -1)
            {
                while (true)
                {
                    Console.WriteLine("Lütfen {0} isimli kişinin güncel telefon numarası giriniz :", name);
                    bool isNumeric = long.TryParse(Console.ReadLine(), out long phoneNumber);
                    if (isNumeric)
                    {
                        directories[index].PhoneNumber = phoneNumber;
                        Console.WriteLine("Güncelleme tamamlanmıştır.");
                        break;
                    }
                    Console.WriteLine("Lütfen numarayı doğru formatda giriniz!");
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("(1) Güncellemeyi sonlandırmak için ");
                    Console.WriteLine("(2) Yeniden denemek için      ");
                    bool isNumeric = int.TryParse(Console.ReadLine(), out int operationNum);
                    if (isNumeric)
                    {
                        if (operationNum == 1)
                        {
                            Console.WriteLine("{0} güncelleme işlemi durduruldu.");
                            break;
                        }
                        else if (operationNum == 2)
                        {
                            UpdateDirectory();
                            return;
                        }
                    }
                    Console.WriteLine("Lutfen doğru işlem numarasını giriniz!");
                }
            }
        }

        public void ListDirectiories()
        {
            Console.WriteLine("Telefon Rehberi : ");
            Console.WriteLine("*******************************************");
            foreach (var d in directories)
            {
                Console.WriteLine("İsim : " + d.Name);
                Console.WriteLine("Soyisim : " + d.Surname);
                Console.WriteLine("Telefon numarası : " + d.PhoneNumber);
                Console.WriteLine("-");
            }
        }

        public void SearchDirectiories()
        {


            bool withName = true;

            while (true)
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) İsim veya soyisime göre arama yapmak için");
                Console.WriteLine("(2) Telefon numarasına göre arama yapmak için");
                Console.WriteLine("(3) Çıkış");
                bool isNumeric = int.TryParse(Console.ReadLine(), out int operationNum);
                if (isNumeric)
                {
                    if (operationNum == 1)
                    {
                        withName = true;
                        break;
                    }
                    else if (operationNum == 2)
                    {
                        withName = false;
                        break;
                    }
                    else if (operationNum == 3)
                    {
                        return;
                    }
                }
                Console.WriteLine("Lutfen doğru işlem numarasını giriniz!");
            }
            string name = "";
            long phoneNumber = 0;
            if (withName)
            {
                Console.Write("İsim veya soyisim giriniz : ");
                name = Console.ReadLine() + "";
            }
            else
            {

                while (true)
                {
                    Console.Write("Telefon numarasını giriniz : ");
                    bool isNumeric = long.TryParse(Console.ReadLine(), out phoneNumber);
                    if (isNumeric)
                    {
                        break;
                    }
                    Console.WriteLine("Lütfen numarayı doğru formatda giriniz!");
                    ;
                }
            }

            Console.WriteLine("Arama Sonuçlarınız : ");
            Console.WriteLine("*******************************************");
            if (withName)
            {
                foreach (var d in directories)
                {
                    if (d.Name == name || d.Surname == name)
                    {
                        Console.WriteLine("İsim : " + d.Name);
                        Console.WriteLine("Soyisim : " + d.Surname);
                        Console.WriteLine("Telefon numarası : " + d.PhoneNumber);
                        Console.WriteLine("-");
                    }
                }
            }
            else
            {
                foreach (var d in directories)
                {
                    if (d.PhoneNumber == phoneNumber)
                    {
                        Console.WriteLine("İsim : " + d.Name);
                        Console.WriteLine("Soyisim : " + d.Surname);
                        Console.WriteLine("Telefon numarası : " + d.PhoneNumber);
                        Console.WriteLine("-");
                    }
                }
            }
        }
    }

}