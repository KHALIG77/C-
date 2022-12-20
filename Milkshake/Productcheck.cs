
        public class Productcheck
        {
            protected string name;
            protected int price;
            protected int count;

    public Productcheck(int volume,int fatrate)
    {

    }
            public Productcheck()

            {
                Console.WriteLine("Zehmet olmasa mehsulun adini daxil edin");
                string namecheck = Console.ReadLine();
                bool Allstatus = true;
                bool pricestatus = true;
                bool countstatus = true;




                while (Allstatus)
                {
                    if (string.IsNullOrEmpty(namecheck))
                    {
                        Console.WriteLine("Zehmet olmasa bos qoymayin ad daxil edin");
                        namecheck= Console.ReadLine();
                        continue;

                    }
                    else
                    {
                        this.name=namecheck;


                    }
                    Console.WriteLine("Zehmet olmasa mehsulun qiymetini daxil edin");

                    while (pricestatus)
                    {


                        string pricecheck = Console.ReadLine();
                        if (string.IsNullOrEmpty(pricecheck))

                        {
                            Console.WriteLine("Zehmet olmasa bos qoymayin qiymet daxil edin");
                            continue;
                        }

                        else
                        {

                            int pricecheck2 = int.Parse(pricecheck);


                            if (pricecheck2>0)
                            {

                                price=pricecheck2;
                            }
                            else
                            {
                                Console.WriteLine("Zehmet olmasa 0 den boyuk bir qiymet daxil edin");
                                continue;
                            }
                        }
                        pricestatus= false;
                    }


                    Console.WriteLine("Zehmet olmasa mehsul miqdarini daxil edin");
                    while (countstatus)
                    {


                        string countcheck = Console.ReadLine();
                        if (string.IsNullOrEmpty(countcheck))

                        {
                            Console.WriteLine("Zehmet olmasa bos qoymayin ad daxil edin");
                            continue;
                        }

                        else
                        {

                            int countcheck2 = int.Parse(countcheck);


                            if (countcheck2>0)
                            {

                                this.count=countcheck2;

                            }
                            else
                            {
                                Console.WriteLine("Zehmet olmasa 0 den boyuk bir miqdar daxil edin");
                                continue;
                            }
                        }
                        countstatus=false;
                    }




                    Allstatus=false;


                }





            }
        }




    