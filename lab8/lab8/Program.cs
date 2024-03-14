//int[] arrs = { 19, 20, 23, 24, 25 };
//Console.WriteLine("Yashinizi yazin: ");
//input:
//if(int.TryParse(Console.ReadLine(),out int TelebeYash))
//{
//    bool checkYash = false;
//    foreach(int i in arrs)
//    {
//        if(i == TelebeYash)
//        {
//            checkYash = true;
//            break;
//        }
//    }
//    Console.WriteLine(checkYash);
//}
//else
//{
//    Console.WriteLine("Yashinizi reqemle yazin:");
//    goto input;
//}

//Task2
string[] names = { "Pasha", "Nicat", "Ali","Miragha" };
l1:
Console.WriteLine("Ad daxil edin");
string input = Console.ReadLine();
int count = 0;
foreach (var item in names)
{
    if (input == item)
    {
        count++;
    }
}
    if (count >= 1)
    {
        Console.WriteLine("Telebenin adi:"+input);
    }
    else
    {
        Console.WriteLine("Telebe yoxdur");
        goto l1;
    }

