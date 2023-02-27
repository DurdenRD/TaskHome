// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите цифру от 1 до 7");
string a = "Понедельник";
string b = "Вторник";
string c = "Среда";
string d = "Четверг";
string e = "Пятница";
string f = "Суббота";
string g = "Воскресенье";

int x = Convert.ToInt32(Console.ReadLine());

if (x==1)
{Console.WriteLine($"вы выбрали {a}");
}

if (x==2)
{Console.WriteLine($"вы выбрали {b}");
}

if (x==3)
{Console.WriteLine($"вы выбрали {c}");
}

if (x==4)
{Console.WriteLine($"вы выбрали {d}");
}
if (x==5)
{Console.WriteLine($"вы выбрали {e}");
}

if (x==6)
{Console.WriteLine($"вы выбрали {f}");
}
if (x==7)
{Console.WriteLine($"вы выбрали {g}");
}