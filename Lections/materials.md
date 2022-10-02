# 1 лекция


**Последовательность действий:**
1. Создаем новый folder (папку) и открываем его в VSC.
2. Создаем локальный репозиторий для этого фолдера git init.
3. Создаем внутри фолдера с репозиторием новую папку, где будет храниться проект
4. Открываем внутри новой папки терминал
5. dotnet new console (создание проекта: конфигурационные файлы и т д)
6. Переходим в program.cs
```
#Пишем программу
console - помогает работать с терминалом
writeline - вывод в окно терминала
console.writeLine("Hello, world");
```

7. dotnet run (запускает написанную программу)
8. Для того, чтобы запушить изменения и добавить commit:
- переходим в основной фолдер
- добавляем папку с программой git add (папка2)
- git coomit -a 
- git push (в репозиторий на gitHub)

************************************************************
write (); - вывод в однустроку
WriteLine (); - в конце перейти на новую строку;
ReadLine (); Считать строку из терминала
string - тип данных
int - целые числа
double – вещественные (не целые)
bool – true or false

new Random().Next(min,max) – случайные числа
.ToLower() - фиксация проблем с нижним регистром
************************************************************


!!!    ПРИМЕРЫ :

**Пример приветствия пользователя:**

- Создаем новую папку внутри фолдера test1
- Открываем терминал 
```
dotnet new console 
- Переходим в program.cs
console.writeline("Введите Ваше имя");
string username = console.readLine();
console.writeline("Hello");
console.writeline(username);
dotnet run
```

Открываем терминал основной:
- git add test1
- git coomit -a 
- git push (Для пуша в репозиторий на gitHub)


**Пример складывания двух чисел.** 

//Программа должна быть написана для Windows, macOS,

в которую пользователь вводит два целых числа, 

в которой записаны два целых числа, 

два целых числа генерируются случайным образом.

Создаем новую папку внутри фолдера test2
//Открываем терминал

<>
dotnet new console
- Переходим в program.cs
int numberA = new Random().Next(1,10); // 1 2 3 4 5…9
console.writeLine(numberA);
int numberB = new Random().Next(1,10); // 1 2 3 4 5…9
console.writeLine(numberA);
int result = numberA + numberB
console.writeline(result);
dotnet run
<>

Открываем терминал основной:
- git add test1
- git coomit -a 
- git push (Для пуша в репозиторий на gitHub)

                                               Пример частного двух чисел
 
#Программа должна быть написана для Windows, macOS,
# в которую пользователь вводит два целых числа, 
# в которой записаны два целых числа, 
# два целых числа генерируются случайным образом.

Создаем новую папку внутри фолдера test2
Открываем терминал 
<>
dotnet new console
- Возвращаемся в основной фолдер
- git add название папки в фолдере
- Переходим в program.cs

double numberA = 10;
double numberB = 5;
console.writeline(numberA / numberB);
dotnet run
<>
Открываем терминал основной:
- git coomit -a 
- git push (Для пуша в репозиторий на gitHub)

                                               Приветствие особенного пользователя (if else)

Создаем новый фолдер hello
Открываем его терминал
dotnet new console
Переходим в program.cs
<>
Console.WriteLine("Введите имя пользователя");
string username = console.ReadLine();

if (username.ToLower() == маша)
{
Console.WriteLine("Ура, это же МАША!")
}
Console.Write("Привет, ");
Console.WriteLine(username);
<>
Переходим в главный фолдер
git add hello
git commit -a 
git push

                                               Цикл While (треугольник с точками)

Создаем фолдер
открываем терминал
dotnet new console
programs.cs
<>
Console.Clear ();
//Console.SetCursorPosition(10, 4);
//console.writeLine("+");

int xa = 1; ya = 1; 
int xb = 1; yb = 30;
int xc = 40; yc = 30;

console.setCursonPosition(xa, ya);
Console.WriteLine ("+");

console.setCursonPosition(xb, yb);
Console.WriteLine ("+");

console.setCursonPosition(xc, yc);
Console.WriteLine ("+");

int x = xa, y = xb;

int count = 0;

while (count < 10)
{
int what = new Random().Next(0,3); // 0 1 2

if (what == 0)
{
x = (x+xa)/2
y = (y+ya)/2
}

if (what == 1)
{
x = (x+xa)/2
y = (y+ya)/2
}

}
<>
