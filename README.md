# Решение задачи для итоговой контрольной работы по основному блоку

### 1. Для решения задачи на первом этапе была создана схема решения в draw.io с целью наглядности и разбиение задачи на блоки.
![Схема решения задачи](Scheme.jpg)

### 2. Написание программы на языке C#
- Создаем первый метод (функцию) для создания массива, состоящего из строк, введенных с клавиатуры пользователем. Количество строк также вводит пользователь.
```C#
string [] CreateNewMassive(string [] str)
```
- Пишем вторую функцию для создания нового массива, объем которого определяется количеством строк в предыдущем массиве, длина которых меньше, либо равна 3 символам.

*(В этом же методе заполняем конечный массив строками из первого, длина которых меньше, либо равна 3 символам.)*

```C#
string [] ResultMassive(string [] str2)
```
- Создаем третий метод print для выведения на экран содержимого конечного массива:
```C#
void PrintResultMassive(string [] str2)
```
- На последнем этапе добавляем пользовательский ввод количества строк в массиве, создаем массив с определенным объемом и пошагово вызываем созданные ранее методы.
```C#
Console.WriteLine("Введите количество строк в массиве ");

int count = Convert.ToInt32(Console.ReadLine());

string [] str = new string[count];

CreateNewMassive(str);

string [] str2 = ResultMassive(str);

PrintResultMassive(str2);
```
### 3. Добавление созданной программы и схемы на удаленный репозиторий
```
echo "# My_main_repo" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/OlegZavorotniy/Final_test.git
git push -u origin main
```
# Конец!
![Смешной котик!](https://kartinki.pics/pics/uploads/posts/2022-09/1662894222_1-kartinkin-net-p-samii-smeshnoi-kot-v-mire-pinterest-1.jpg)