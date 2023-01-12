Console.Clear();
Console.Write("Введите расстояние между друзьями (м): ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Скорость первого друга (км/ч): ");
double firstFrendSpeed = Convert.ToDouble(Console.ReadLine());

Console.Write("Скорость второго друга (км/ч): ");
double secondFrendSpeed = Convert.ToDouble(Console.ReadLine());

Console.Write("Скорость собаки (км/ч): ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());

// double dogSpeed = 5;
// Console.WriteLine($"Скорость собаки: {dogSpeed} км/ч.");

// double distance = 10000, 
//    firstFriendSpeed = 1,
//    secondFriendSpeed = 2;

firstFrendSpeed = firstFrendSpeed * 1000/3600;     // перевод скоростей из км/ч в м/с
secondFrendSpeed = secondFrendSpeed * 1000/3600;
dogSpeed = dogSpeed * 1000/3600;
double distConst = distance;

int count = 0,
    friend = 2;
double 
    time = 0, 
    dogDistance = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFrendSpeed + dogSpeed);
        friend = 2;
        // Console.WriteLine(time);
    }
    else
    {
        time = distance / (secondFrendSpeed + dogSpeed);
        friend = 1;
        // Console.WriteLine(time);
    }

    distance = (distance - (firstFrendSpeed + secondFrendSpeed) * time);
    // Console.WriteLine($"{distance} м");

    dogDistance = (dogDistance + time * dogSpeed);
    count = count + 1;
    Console.Write(".");
}

Console.WriteLine(".");

double hour = Math.Round((distConst/(firstFrendSpeed+secondFrendSpeed)/3600), 1); // расчет часов 
int minute = (int)((hour - (int)hour) * 60); // расчет минут

Console.WriteLine($"До встречи друзей пройдет {(int)hour} часа(ов) {minute} минут(ы).");
Console.WriteLine($"Собака пробежит между друзьями до их встречи {count} раз и преодолеет дистанцию {String.Format("{0:.##}", dogDistance)} метров.");
