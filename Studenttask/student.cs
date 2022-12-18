using System.Collections.Specialized;

public class Student
{
    string name;
    string surname;
    string group;
    int point;
    bool isgraduated;


    public Student(string ad, string soyad, string qrup, int bal, bool mezun)
    {
        //Console.WriteLine(ad);
        //Console.WriteLine(soyad);
        //Console.WriteLine(qrup);
        //Console.WriteLine(point);
        //Console.WriteLine(mezun);
        name = ad;
        surname = soyad;
        group = qrup;
        point = bal;
        isgraduated = mezun;
    }


    //public string Name
    //{
    //    get
    //    {
    //        char[] arr = name.ToCharArray();
    //        arr[0] = char.ToUpper(arr[0]);



    //        return new string(arr); ;

         
    //    }
    //    set
    //    {
           
    //        char[] a = Name.ToCharArray();
    //        a[0] = char.ToUpper(a[0]);
    //        name = value;


    //    }
    //}



 





    public void NameSurname()
    {
        Console.WriteLine($"{name}" + " " + surname);


    }
    public void UserData()
    {
        Console.WriteLine("Ad:" + name);
        Console.WriteLine("Soyad:" + surname);
        Console.WriteLine("Qrup:" + group);
        Console.WriteLine("Bal:" + point);

        if (isgraduated = true)
        {
            Console.WriteLine("Bu telebe mezun olub");
        }
        else
        {
            Console.WriteLine("Bu telebe mezun olmayib ");

        }


    }
    public void ReturnPoint()
    {
        if (point >= 80)
        {
            Console.WriteLine("Siz ikinci imtahanda istirak ede bilersiniz");
        }
        else
        {
            Console.WriteLine("Siz ikinci imtahanda istirak ede bilmezsiniz");
        }
    }

}
