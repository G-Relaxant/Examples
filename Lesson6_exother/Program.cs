/*
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ").ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
*/

/*
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .ToArray()
                .Select(item => item.Split(','))
                .ToArray();
///
for (int i = 0; i < data.Length; i++)
{
    //Console.WriteLine(data[i]);
    for (int k = 0; k < data[i].Length; k++)
    {
        Console.WriteLine(data[i][k]);
    }
}
*/


/*
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .ToArray()
                .Select(item => item.Split(','))
                .Select(arr => (x: int.Parse(arr[0]), y: int.Parse(arr[1])))
                .ToArray();
///
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i].x * 10);
    Console.WriteLine();
}
*/


/*
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .ToArray()
                .Select(item => item.Split(','))
                .Select(arr => (x: int.Parse(arr[0]), y: int.Parse(arr[1])))
                .Select(point => (point.x * 10, point.y))
                .ToArray();
///
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}
*/



using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .ToArray()
                .Select(item => item.Split(','))
                .Select(arr => (x: int.Parse(arr[0]), y: int.Parse(arr[1])))
                .Where(arr => arr.x % 2 == 0)
                .Select(point => (point.x * 10, point.y))
                .ToArray();
///
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}