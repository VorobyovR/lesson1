using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "") /*меняем скобки на пусто*/
                .Replace(")", ""); /*меняем скобки на пусто*/
Console.WriteLine(text);    

var data = text.Split(" ")
                .Select(item => item.Split(','))  /*разделяем по ","*/
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))   /*переводим стоки в числовые значения*/
                .Where(e => e.x % 2 == 0)    /*берем только четные значения*/
                .Select(point => (point.x*10, point.y+10))    /*берем значение и делаем с ним математические упражнения*/
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}

