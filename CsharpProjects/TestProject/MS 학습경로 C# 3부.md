### 조건문에서 중괄호 생략

```csharp
string name = "steve";

// 가독성이 좋아지도록 개행하는 것이 좋다.
if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
```

### switch-case 멀티레이블 할당

```csharp
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
```

### if문 switch-case로 변경

```csharp
// 변경 전
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
```

```csharp
// 변경 후
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
  case "01":
    type = "Sweat shirt";
    break;
  case "02":
    type = "T-Shirt";
    break;
  case "03":
    type = "Sweat pants";
    break;
  default:
    type = "Other";
    break;
}

switch (product[1])
{
  case "BL":
    color = "Black";
    break;
  case "MN":
    color = "Maroon";
    break;
  default:
    color = "White";
    break;
}

switch (product[2])
{
  case "S":
    size = "Small";
    break;
  case "M":
    size = "Medium";
    break;
  case "L":
    size = "Large";
    break;
  default:
    size = "One Size Fits All";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
```

### for 문을 사용하여 foreach 문의 제한 사항 극복하기

```csharp
// 에러 발생 코드
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}

// Cannot assign to name because it is a 'foreach iteration variable'
// name은 foreach 반복의 내부 구현에 포함되어 있으므로 값을 다시 할당할 수 없음
```

```csharp
// for문을 사용해 반복 코드 블록 내의 배열 내용 수정
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
```

### FizzBuzz 과제

```csharp
for (int i = 1; i < 101; i++)
{
  if (i % 3 == 0 && i % 5 == 0){
    Console.WriteLine($"{i} - FizzBuzz");
  } else if (i % 3 == 0){
    Console.WriteLine($"{i} - Fizz");
  } else if (i % 5 == 0){
    Console.WriteLine($"{i} - Buzz");
  } else {
    Console.WriteLine(i);
  }
}
```

### 롤 플레잉 게임 배틀 과제

```csharp
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
```

### 반복문 정리

```
for 문: 지정된 부울 식('조건')이 true로 평가되는 동안 본문을 실행합니다.
foreach 문: 컬렉션의 요소를 열거하고 컬렉션의 각 요소에 대한 본문을 실행합니다.
do-while 문: 조건부로 본문을 한 번 이상 실행합니다.
while 문: 조건부로 본문을 0번 이상 실행합니다.
```