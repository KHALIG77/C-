using ConsoleApp1;





StudentServices studentServices = new StudentServices();

do {
    Info();
    int number = Numbercheck();
    switch (number)
    {
       
        
 
        case 1:
            bool status2 = false;
            while (status2 == false)
            {
                //Yeni Student Elave Edilmesi
                Console.WriteLine("Zehmet olmasa Ad Daxil Edin");
                string Name = Console.ReadLine();

                Console.WriteLine("Zehmet olmasa Soyad Daxil Edin");
                string Surname = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa Ortlamani Daxil Edin");
                int Average=int.Parse(Console.ReadLine());  
                status2 = studentServices.Create(Name, Surname,Average);
            }
            
          
            break;
        case 2:
            //Studentin Silinmesi

            Console.WriteLine("Zehmet olmasa id daxil edin");
            int Id = int.Parse(Console.ReadLine());
            studentServices.Delete(Id);
            break;
       case 3:
            //Studentin Edit olunmasi
            Console.WriteLine("Zehmet olmasa id daxil edin");

            int Id1 = int.Parse(Console.ReadLine());
            string Name1 = Console.ReadLine();
            string Surname1 = Console.ReadLine();

            studentServices.Edit(Id1, Name1, Surname1);
              break;
        case 4:
            //Butun Studentlerin Cagirilmasi 
            studentServices.GetAll();
            break;
        case 5:

            //Id ye gore studentin tapilmasi
            int Id2 = int.Parse(Console.ReadLine());

            studentServices.GetByID(Id2);
            break;
        case 0:
            return;
            

    }
    Console.Clear();
} while(true);








 static int Numbercheck() {

    int number = 0;
    bool status = true;

    while (status)
     {
        var s = int.TryParse(Console.ReadLine(), out number);

        if (s)
        {
            if (number >= 0 && number <= 5)
            {
                status = false;
            }
            else
            {
                Console.WriteLine("Zehmet olmasa 0-5 intervalinda eded daxil edin");
            }
        }
        else 
        {
            Console.WriteLine("Zehmet olmasa eded daxil edin");
        }

    }


    return  number;
}
 static void Info()
{
    Console.WriteLine("Asagidakilardan birini etmek ucun qarsisindaki reqemi yazin");
    Console.WriteLine("1.Yeni telebe elave etmek");
    Console.WriteLine("2.Telebenin sistemden silinmesi");
    Console.WriteLine("3.Telebenin ad ve soyadini deyismek");
    Console.WriteLine("4.Butun telebeler haqqinda melumat");
    Console.WriteLine("5.Idisine gore telebenin tapilmasi");


}


