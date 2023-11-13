using System.Globalization;
using System.Runtime.Serialization;

int mes = Convert.ToInt32(Console.ReadLine());

DateTimeFormatInfo month = new DateTimeFormatInfo();
Console.WriteLine(month.GetMonthName(mes));


