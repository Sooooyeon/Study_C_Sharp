### .NET 프로젝트 생성 명령어

```
dotnet new console -o ./CsharpProjects/TestProject

```

CLI 명령의 구조는 다음 세 부분으로 구성

- 드라이버: 이 예제의 `dotnet`
- 명령: 이 예제의 `new console`
- 명령 인수: 이 예제의 `o ./CsharpProjects/TestProject`

### 상태 저장 메서드, 상태 비저장 메서드

```csharp
/*
  상태 저장 메서드, 상태 비저장 메서드
  상태 비저장 메서드 - 메모리에 저장된 값을 참조하거나 변경하지 않고 작동할 수 있도록 구현. 정적 메서드라고도 함.
  상태 저장 메서드 - 이미 실행된 이전 코드 줄에서 메모리에 저장된 값을 사용하는 방식으로 빌드. 인스턴스 메서드라고도 함.
*/ 

// 클래스 인스턴스 만들기 - new 연산자 사용
/*
new 연산자가 수행하는 작업
1. 새 개체를 저장하기에 충분한 크기의 컴퓨터 메모리 주소를 요청
2. 새 개체를 만들어 메모리 주소에 저장
3. 변수에 저장할 수 있도록 메모리 주소를 반환
*/

Random dice = new Random();
Random dice2 = new();
// 최신 버전의 .NET 런타임을 사용하면 형식 이름을 반복하지 않고도 개체 인스턴스화 가능

int roll = dice.Next(1, 7);
// dice 변수가 참조되면 .NET 런타임에서 내부적으로 조회를 수행하여 개체 자체를 직접 작업하는 것처럼 보이게 함

Console.WriteLine(roll); 
```

### 오버로드 된 메서드

```csharp
Random dice = new Random();

int roll1 = dice.Next(1, 7);
// dice 변수가 참조되면 .NET 런타임에서 내부적으로 조회를 수행하여 개체 자체를 직접 작업하는 것처럼 보이게 함

int roll2 = dice.Next();
// 상한 및 하한을 결정하지 않아 메서드는 0에서 int에 저장할 수 있는 최댓값인 2,147,483,647 사이의 값을 반환

int roll3 = dice.Next(101);
// 최댓값을 상한으로 지정. 이 경우 0에서 100 사이의 임의 값을 반환

int roll4 = dice.Next(50, 101);
// 최솟값과 최댓값을 모두 지정. 이 경우 50에서 100 사이의 임의 값을 반환

Console.WriteLine($"roll1 : {roll1}"); 
Console.WriteLine($"roll2 : {roll2}");
Console.WriteLine($"roll3 : {roll3}");
Console.WriteLine($"roll4 : {roll4}");
```

### if else 주사위 게임

```csharp
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
  if ((roll1 == roll2) && (roll2 == roll3))
  {
    Console.WriteLine("트리플! 보너스 6점을 얻었습니다!");
    total += 6;
  }
  else
  {
    Console.WriteLine("더블! 보너스 2점을 얻었습니다!");
    total += 2;
  }
}

if (total >= 16)
{
  Console.WriteLine("자동차를 획득했습니다!");
}
else if(total>=10)
{
  Console.WriteLine("노트북을 획득했습니다!");
}
else if (total == 7)
{
  Console.WriteLine("여행 상품을 획득했습니다!");
}
else
{
  Console.WriteLine("라면을 획득했습니다!");
}
```

### if else 구독 안내

```csharp
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("구독이 만료되었습니다.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"구독이 하루 안에 만료됩니다.");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"구독 만료까지 {daysUntilExpiration}일 남았습니다.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("구독이 곧 만료됩니다! 재구독 해 주세요!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"{discountPercentage}% 할인 받은 가격으로 재구독 하세요!");
}
```

### 배열 생성 및 초기화

```csharp
// 세 개의 문자열 값을 포함할 수 있는 배열의 새 인스턴스를 메모리에 생성
// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// 선언과 동시에 초기화
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
```

## foreach

```csharp
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
  Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
  sum += item;
  bin++;
  Console.WriteLine($"Bin{bin} : {item} (요소 합 : {sum})");
}
Console.WriteLine($"요소의 총 합은 {sum}");

string[] arr = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(string item in arr){
  if (item.StartsWith("B"))
  {
    Console.WriteLine(item);
  }
}
```

### 변수 이름 규칙

```csharp
/*
변수 이름 규칙
1. 카멜케이스
2. 설명과 의미 제공
3. 단어 축약하지 않기
4. 변수 이름에 데이터 형식을 포함하지 않기
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;
foreach (char i in message)
{
  if (i == 'o')
  {
    letterCount++;
  }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
```

### 성적 계산

```csharp
// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
  string currentStudent = name;

  if (currentStudent == "Sophia")
    studentScores = sophiaScores;

  else if (currentStudent == "Andrew")
    studentScores = andrewScores;

  else if (currentStudent == "Emma")
    studentScores = emmaScores;

  else if (currentStudent == "Logan")
    studentScores = loganScores;

  // initialize/reset the sum of scored assignments
  int sumAssignmentScores = 0;

  // initialize/reset the calculated average of exam + extra credit scores
  decimal currentStudentGrade = 0;

  // initialize/reset a counter for the number of assignment 
  int gradedAssignments = 0;

  // loop through the scores array and complete calculations for currentStudent
  foreach (int score in studentScores)
  {
    // increment the assignment counter
    gradedAssignments += 1;

    if (gradedAssignments <= examAssignments)
      // add the exam score to the sum
      sumAssignmentScores += score;

    else
      // add the extra credit points to the sum - bonus points equal to 10% of an exam score
      sumAssignmentScores += score / 10;
  }

  currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

  if (currentStudentGrade >= 97)
    currentStudentLetterGrade = "A+";

  else if (currentStudentGrade >= 93)
    currentStudentLetterGrade = "A";

  else if (currentStudentGrade >= 90)
    currentStudentLetterGrade = "A-";

  else if (currentStudentGrade >= 87)
    currentStudentLetterGrade = "B+";

  else if (currentStudentGrade >= 83)
    currentStudentLetterGrade = "B";

  else if (currentStudentGrade >= 80)
    currentStudentLetterGrade = "B-";

  else if (currentStudentGrade >= 77)
    currentStudentLetterGrade = "C+";

  else if (currentStudentGrade >= 73)
    currentStudentLetterGrade = "C";

  else if (currentStudentGrade >= 70)
    currentStudentLetterGrade = "C-";

  else if (currentStudentGrade >= 67)
    currentStudentLetterGrade = "D+";

  else if (currentStudentGrade >= 63)
    currentStudentLetterGrade = "D";

  else if (currentStudentGrade >= 60)
    currentStudentLetterGrade = "D-";

  else
    currentStudentLetterGrade = "F";

  //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
  Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
```