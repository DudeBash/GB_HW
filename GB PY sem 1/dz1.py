##Задача 1. Напишите программу, которая принимает на вход цифру,
##обозначающую день недели, и выводит название этого дня недели.
import math
num = int(input("введите номер дня недели"))

week = ({1:'понедельник',2:'вторник',3:'среда',4:'четверг',5:'пятница',6:'субота',7:'воскресение'})
if num>7 or num<1:
    print('Нет такого дня')
else:
    print(week[num])
##Задача 2. Напишите программу, которая принимает на вход координаты двух точек
## и находит расстояние между ними в 2D пространстве.
x1 = int(input("введите x1"))
y1 = int(input("введите y1"))
x2 = int(input("введите x2"))
y2 = int(input("введите y2"))
dist = 0
dist = math.sqrt((x1-x2)**2+(y1-y2)**2)
print(f"растояние между двумя точками:{dist}")
##Задача 3. Напишите программу, которая по заданному номеру четверти,
##показывает диапазон возможных координат точек в этой четверти (x и y).
x3 = int(input("введите x"))
y3 = int(input("введите y"))
if x3>0 and y3>0:
    print("четверть первая")
elif x3<0 and y3>0:
    print("четверть вторая")
elif x3<0 and y3<0:
    print("четверть третья")
elif x3>0 and y3<0:
    print("четверть четвертая")
else:
    print("кординаты равны нулю")
##Задача 4. Напишите программу, которая на вход принимает число (N),
## а на выходе показывает все чётные числа от 1 до N.
N = int(input("введите n"))
c = 0 
while c<=N:
    if c % 2 == 0:
        print(c)
    c+=1