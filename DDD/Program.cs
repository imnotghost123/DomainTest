using DDD.ValueObjects;



var initialMoney = new Money(100m, "USD");
var newMoney = initialMoney.Add(50m);

Console.WriteLine(initialMoney.Amount); // 输出: 100
Console.WriteLine(newMoney.Amount); // 输出: 150

Console.WriteLine(initialMoney == newMoney); // 输出: False，因为它们的值不相等