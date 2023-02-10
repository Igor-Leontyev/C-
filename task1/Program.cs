
Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
int buf = num - 1 ;
buf = buf - (num * 2);

while (buf < num)
{
    buf++;
    Console.Write(buf+"\t");
   
}
Console.WriteLine("\n");


Console.WriteLine("input num");
int numb = Convert.ToInt32(Console.ReadLine());
int su = numb % 10;
Console.WriteLine(su);
