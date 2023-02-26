Console.WriteLine("أهلا بك في برنامج اصدار رخصة القيادة. اضغط على أي مفتاح على لوحة المفاتيح للبدأ");
Console.ReadKey();
Console.WriteLine("كم عمرك؟");
int x = Convert.ToInt32(Console.ReadLine());
if (x >= 18)
{
    Console.WriteLine("تهانينا أنت مؤهل لِ اصدار رخصة القيادة");
}
else if (x == 17)
{
    Console.WriteLine("أنت حاليا مؤهل لِ اصدار رخصة قيادة مؤقتة عمرها سنة واحدة");
}
else if (x < 18)
{
    Console.WriteLine("نأسف أنت غير مؤهل لِ اصدار رخصة القيادة لأنك لم تتجاوز السن القانوني.");
}