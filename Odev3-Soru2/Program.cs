int toplam = 0;
Console.WriteLine("Bir cümle giriniz");
string cumle = Console.ReadLine();
string[] say = cumle.Split(" ");
foreach (string i in say)
{
    Console.WriteLine(i);
    toplam++;
}
Console.WriteLine("Kelime sayısı:"+toplam);
Console.ReadKey();