using System.Diagnostics;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;







Student student = new Student(Name(), Surname(), Group(), Point(), Graduated());

student.NameSurname();
student.UserData();
student.ReturnPoint();



static string Name()
{

    bool result = false;
    string ad =string.Empty;
    while (!result)
    {
        Console.WriteLine("Zehmet olmasa adinizi daxil edin");
        ad = Console.ReadLine();

        int comparename;

        int.TryParse(ad, out comparename);
        if (comparename==0)
        {
            result = true;
        }
        
    }
    char[] arr = ad.ToCharArray();
    arr[0] = char.ToUpper(arr[0]);
    return new string(arr);



}
static string Surname()
{
   bool result2 =false;
    string soyad =string.Empty;
    while (!result2) {
        Console.WriteLine("Zehmet olmasa soyadinizi daxil edin");
        soyad = Console.ReadLine();
        int comparesurname;
        int.TryParse(soyad, out comparesurname);    
        if (comparesurname == 0)
        {
            result2 = true;

        }
    }
    char[] arr2 = soyad.ToCharArray();
    arr2[0] = char.ToUpper(arr2[0]);
    return new string(arr2);



}
static string Group()
{
    string qrup;
    Console.WriteLine("Zehmet olmasa qrupunuzu daxil edin");
    qrup = Console.ReadLine();
    return qrup;
}
static int Point()
{

   
    int comparepoint=0;
    bool comparestatus = false;

  
    while(!comparestatus)
    {
        Console.WriteLine("Zehmet olmasa balinizi daxil edin");
        string bal = Console.ReadLine();
        int.TryParse(bal,out comparepoint );
        if(comparepoint>0&&comparepoint<=100)
        {
           comparestatus = true;
        }



    }


    return comparepoint;

}
static bool Graduated()
{
    
    bool comparegradu=false;
    string grade;
    bool gradestatus=false;

    while (!comparegradu)
    {
       Console.WriteLine("Mezunsunuzsa 1 daxil edin deyilsinizse 0 daxil edin");
        grade=Console.ReadLine();

        if(grade == "1" || grade == "0")
        {
            comparegradu = true;
            if (grade == "1")
            {
              
               gradestatus=  true;
            }

           

        }
       
    }
    return gradestatus;
}
