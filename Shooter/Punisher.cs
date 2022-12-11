//program işə düşəndə ekranda yazılar  çıxsın +
//1. Gülləni tək tək at+
//2. Güllənin hamısını birdən at+
//3. mərmini yenidən doldur+
//4. oyundan çıx+
//5. mərmi sayını gösdər+
//(DİQQƏT!!!)
//Əgər 1 2 3 4 5 xarici bir rəqəm daxil olarsa düzgün rəqəm daxil edin deyə  mesaj çıxarsın +

//mərmi sayı 30 dan başlasın və 0 olanda mərmini yenidən doldur deyə mesaj çıxarsın+
//user 1-ə klikləsə  mərmi 1 azalsın və güllə atıldı deyə mesaj çıxarsın +
//user 2-ə klikləsə mərminin hamısı boşalsın+
//user  3-ə klikləsə mərmilər 30-a bərabər  olsun+
//user 4-ə  klikləsə oyun dayanısn +
//user 5-ə  klikləsə mərmi sayını gösdərsin +
//(Klikləsə deyəndə yəni 1 daxil edərsəni nəzərdə tuturam)+
//Uğurlar: qaranlıq məqam olarsa taskla əlaqədar Whatsapp-qurupuna yazın+
//Method-dan istifadə vacibdir 

using System;

Console.WriteLine("1.Gulleni tek tek at");
Console.WriteLine("2.Gullenin hamısını birdən at");
Console.WriteLine("3.Mermini yeniden doldur");
Console.WriteLine("4.Oyundan cıx");
Console.WriteLine("5.Mermi sayını gosder");


do
{
    try
    {

        int bullet = 30;
        int exitCount = 0;


        int num = int.Parse(Console.ReadLine());


        while (numCheck(num)<=0||numCheck(num)>=6)
        {
            Console.WriteLine("Zehmet olmasa 1-5 kimi eded daxil edin");
            num=Convert.ToInt32(Console.ReadLine());
        }

        do
        {

            switch (numCheck(num))

            {
                case 1:
                    if (bulletCount(bullet)>0)
                    {
                        bullet=bulletCount(bullet-1);
                        Console.WriteLine("Gulle atildi");
                    }
                    break;
                case 2:
                    if (bulletCount(bullet)>0)
                    {
                        Console.WriteLine("Gullenin  hamisi atildi");
                        bullet=bulletCount(bullet-bullet);
                    }
                    break;
                case 3:
                    if (bullet==30)
                    {
                        Console.WriteLine("Mermi artiq 30-a tamamlanib ");
                    }
                    else
                    {
                        bullet=30;
                        Console.WriteLine("Mermi 30-a tamamlandi");
                    }
                    break;
                case 4:
                    if (count(exitCount)==true)
                    {
                        Console.WriteLine("Oyundan cixmaq istediyive eminsen?");
                        exitCount++;
                    }
                    else
                    {
                        return;
                    }
                    break;
                case 5:
                    Console.WriteLine(bullet);
                    break;
            }
            num=int.Parse(Console.ReadLine());

        } while (bullet>=0);



        //Check input
        static int numCheck(int number)
        {
            if (number>0&&number<6)
            {
                return number;
            }
            else
            {
                return number;
            }

        }

        //Checkbullet
        static int bulletCount(int bulletNumber)
        {
            if (bulletNumber==0)
            {
                Console.WriteLine("Merminiz  bitdi yeniden doldurmaq ucun 3e basin");
            }

            return bulletNumber;
        }
        static bool count(int num)
        {
            if (num==0)
            {

                return true;
            }
            else
            {
                return false;
            }



        }
    }
    catch
    {
        Console.WriteLine("Zehmet olmasa 1-5 kimi eded daxil edin");
    }
} while (true);