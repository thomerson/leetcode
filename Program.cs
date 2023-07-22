// See https://aka.ms/new-console-template for more information
using leetcode.Sort;
using System.Text;

var arr = new int[10] { 2, 5, 3, 15, 7, 12, 52, 64, 1, 8 };

//BubbleSort.Sort(arr);
SelectionSort.Sort(arr);

foreach (var item in arr)
{
    Console.WriteLine(item);
}




Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

string str = "a1某某某";
//string str = "abc123中文汉字";
//string str = "中文汉字";
//byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
//for (int j = 0; j < bytes.Length; j++)
//{
//    Console.WriteLine(bytes[j]);
//}


//var str = "a1某某某";

var code = Encoding.Default;

Console.WriteLine(System.Text.Encoding.Default.EncodingName);

//Encoding.

//Console.WriteLine(Encoding.Default.GetBytes(str).Length);
Console.WriteLine("GB2312:" + Encoding.GetEncoding("GB2312").GetBytes(str).Length);
Console.WriteLine("Unicode:" + Encoding.Unicode.GetBytes(str).Length);
Console.WriteLine("UTF8:" + Encoding.UTF8.GetBytes(str).Length);
Console.WriteLine("UTF32:" + Encoding.UTF32.GetBytes(str).Length);
Console.WriteLine("ASCII:" + Encoding.ASCII.GetBytes(str).Length);

Console.WriteLine(str.Length);

string strTmp = "a1某某某";
var aa = System.Text.Encoding.Default.GetBytes(strTmp);

foreach (var item in aa)
{
    Console.WriteLine(item);
}

int bb = strTmp.Length;


string strTm11p = "abcdefg某某某";

int i = System.Text.Encoding.Default.GetBytes(strTm11p).Length;

byte by = 255;

by += 5;

Console.WriteLine(byte.MinValue);
Console.WriteLine(byte.MaxValue);

Console.WriteLine(by);

Console.WriteLine("Hello, World!");

//Console.WriteLine($"a:{ReadonlyConstDemo.a},b:{ReadonlyConstDemo.b},c:{ReadonlyConstDemo.c},d:{ReadonlyConstDemo.d}");
//A a = new B();
//A c = new C();

//a.Test();
//c.Test();


Console.WriteLine($"test:{Test()}");

Console.WriteLine("Hello, World!");

//int[] arr = new int[10] { 4, 6, 10, 55, 33, 14, 1, 8, 40, 5 };
////arr = QuickSort.quickSort(arr, 0, arr.Length - 1);
// QuickSort.quickSort(arr, 0, arr.Length - 1);

//foreach (var item in arr)
//{
//    Console.Write($"{item}  ");
//}
//Console.ReadLine();

Int64 a = 0;

long b = 0;

StringBuilder stringBuilder = new StringBuilder();

Console.WriteLine(a == b);

static int Test()
{
    var a = 1;
    try
    {
        return a;
    }
    catch (Exception)
    {

        throw;
    }
    finally
    {
        Console.WriteLine($"finally before:{a}");
        a++;
        Console.WriteLine($"finally end:{a}");
    }
}
class ReadonlyConstDemo
{
    static ReadonlyConstDemo()
    {
        c = d * 5;
    }

    public const int a = b * 5;
    public const int b = 5;

    public static readonly int c = 1;
    public static readonly int d = 5;

}

abstract class A
{
    public virtual void Test()
    {
        Console.WriteLine("a");
    }

    public void Fun()
    {
        Console.WriteLine("fun");
    }
}

class B : A
{
    public override void Test()
    {
        Console.WriteLine("b");
    }
}


class C : A
{
    public new void Test()
    {
        Console.WriteLine("c");
    }

    public new void Fun()
    {
        Console.WriteLine("new fun");
    }
}




