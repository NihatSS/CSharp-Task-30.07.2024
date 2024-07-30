////1)  n ededi gelir. N ededi cutdurse ekrana yazilsin cutdur, tekdirse yazilsin tekdir

//int n = 25; 
//if (n%2==0)
//{
//    Console.WriteLine("Cutdur.");
//}
//else
//{
//    Console.WriteLine("tekdir");
//}

////2) m ededi gelir. 1 - den m ededine kimi olan ededleri ekranda gosterin.

//int m = 16;

//for (int i = 1; i < m; i++)
//{
//    Console.WriteLine(i);
//}

////3)  m ededi gelir. 1 - den m ededine kimi olan ededlerin cemini ekranda gostermek.

//int m = 49;
//int sum = 0;

//for (int i = 1; i < m; i++)
//{
//    sum+= i;   
//}
//Console.WriteLine(sum);

////4) m ededi gelir. 1 - den m ededine kimi olan tek ededlerin sayini ekranda gostermek.

//int m = 10;
//int count = 0;
//for (int i = 1; i < m; i++)
//{
//    if (i%2==1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

////5) n ve m ededlerinin arasindaki cut olanlarin cemini tapin.

//int n = 35;
//int m = 98;
//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if (i%2==0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

//6) Gelen ededin faktorialini hesablayin.

int num = 8;
int factorial = 1;

for (int i = 1; i <= num; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);