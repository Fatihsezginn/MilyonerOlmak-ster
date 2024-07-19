using System.ComponentModel.Design;

int dogruCevap = 0;

Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?");
Console.WriteLine("a) Lama");
Console.WriteLine("b) Deve");
string cevap1 = Console.ReadLine().ToLower().Trim();


if (cevap1 == "a")
{
    dogruCevap++;
    Console.WriteLine("Tebrikler doğru cevap verdiniz");
}
else
{
    Console.WriteLine("Maalesef yanlış cevap verdiniz");

}
Console.WriteLine("2-> Dünya'ya en yakın gezegen hangisidir?");
Console.WriteLine("a) Venüs");
Console.WriteLine("b) Mars");
string cevap2 = Console.ReadLine().ToLower().Trim();


if (cevap2 == "a")
{
    dogruCevap++;
    Console.WriteLine("Tebrikler doğru cevap verdiniz");
}
else
{
    Console.WriteLine("Maalesef yanlış cevap verdiniz");
    
}   if (dogruCevap >= 1)
{

    Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
    Console.WriteLine("A) 7");
    Console.WriteLine("B) 12");
    string cevap3 = Console.ReadLine().Trim().ToLower();


    if (cevap3 == "b")

    {
        dogruCevap++;
        Console.WriteLine("Tebrikler doğru cevap verdiniz");
    }
    else
    {
        Console.WriteLine("Maalesef yanlış cevap verdiniz");
    }
}
    if (dogruCevap >= 2)
    {
        Console.WriteLine("Tebrikler! Büyük ödülü kazandınız!");
    }
    else
    {
        Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");

    }





