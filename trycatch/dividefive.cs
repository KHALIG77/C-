
int count = 0;

for (int i = 0; i<=100;)            //i++ da olar i=i+5 de 
{
    if (i%5==0&&i!=0)
    {
        count++;
    }
    i=i+5;

}
Console.WriteLine(count);
