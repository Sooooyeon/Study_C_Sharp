namespace CSYouTube
{
    internal class 기초문법
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, World!");
            Console.WriteLine("Hello, World!"); //Line이 추가되면 개행

            string input;

            input = Console.ReadLine(); // 사용자 입력을 받음
            // 사용자가 입력한 값은 함수의 반환값으로 설정됨
            Console.WriteLine("입력받은 문자열" + input);



            // 자료형
            // 정수 자료형
            // s가 붙으면 signed로 부호가 있는것을 의미함
            sbyte sbyteNum; // 8비트 저장공간 -128 ~ 127
            byte byteNum; // 8비트 0 ~255

            short shorNum; // 16비트 -32,786 ~ 32,7567 
            ushort ushortNum; // 16비트 0 ~ 65,535

            int intNum; // 부호 있는 32비트(+,-) -2,147,483,648 ~ 약 21억 
            uint uintNum; // 부호 없는 32비트 0 ~ 약 42억

            long longNum; // 부호 있는 64비트 정수
            ulong ulongNum; // 부호 없는 64비트 정수

            // byteNum = 300; // 오류 발생 - 범위에 따라 저장할 수 있는 값이 다름 
            shorNum = 300;

            Console.WriteLine(shorNum);




            // 문자 자료형
            char ch; // char - 단일 문자 '' 홑따옴표 사용
            ch = 'a';
            Console.WriteLine(ch);

            string str = "안녕"; // string - 문자열 "" 쌍따옴표 사용
            Console.WriteLine(str);

            // 이스케이프 문자 - \를 사용
            // \' == '
            // \" == "
            // \n == enter (개행)
            // \t == tab

            string str1 = "\"안녕하세요\" \n 라고 말했\t습니다.";
            Console.WriteLine(str1);



            // 실수 자료형
            // float 4바이트 6~9개 자리수 저장 가능
            // double 8바이트 15~17개 자리수 저장 가능
            // decimal 16바이트 28~29개 자리수 저장 가능 
            // 저장공간이 클수록 더 정밀한 소수 계산이 가능

            float floatNum = 12.12f;
            // 자료형을 더블로 인식해 저장안됨 f붙여줘야함

            double doubleNum = 33.444d;
            // 그냥 사용해도 되지만 보통 뒤에 d를 붙여줌

            decimal decimalNum = 11.223m;
            // 뒤에 m을 붙여줌



            // bool 자료형
            bool t = true;
            bool f = false;

            Console.WriteLine(t);
            Console.WriteLine(f);

            // 논리 연산자
            // AND 연산자
            // true and true == true
            // true and false == false
            // false and true == false
            // false and false == false
            Console.WriteLine(t && t);
            Console.WriteLine(t && f);
            Console.WriteLine(f && t);
            Console.WriteLine(f && f);


            // OR 연산자
            // true or true == true
            // true or false == true
            // false or true == true
            // false or false == false
            Console.WriteLine(t || t);
            Console.WriteLine(t || f);
            Console.WriteLine(f || t);
            Console.WriteLine(f || f);


            // XOR 연산자 ^ 두 연산자가 다를 때 참
            // true XOR true == false
            // true XOR false == true
            // false XOR true == true
            // false XOR false == false
            Console.WriteLine(t ^ t);
            Console.WriteLine(t ^ f);
            Console.WriteLine(f ^ t);
            Console.WriteLine(f ^ f);


            // NOT 연산자
            // true -> false
            // false -> true
            Console.WriteLine(!t);
            Console.WriteLine(!f);


            // 산술 연산자
            // +   양변을 더합니다.
            // -   좌변에서 우변을 뺍니다.
            // *   양변을 곱합니다.
            // /   좌변을 우변으로 나눈 몫
            // %   좌변을 우변으로 나눈 나머지
            // ++  피연산자를 1만큼 증가
            // --  피연산자를 1만큼 감소

            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // 먼저 증가하고 대입
            int c;
            c = ++a;
            Console.WriteLine(a);
            Console.WriteLine(c);

            // 먼저 대입하고 증가
            int d;
            d = a++;
            Console.WriteLine(a);
            Console.WriteLine(d);


            // 비교연산자
            // 반환 자료형이 bool 타입인 것을 기억하기
            // 기호     이름                        반환 자료형
            // ==       같음 연산자                 bool
            // !=       같지 않음 연산자            bool
            // <        보다 작음 연산자            bool
            // <=       보다 작거나 같은 연산자     bool
            // >        보다 큼 연산자              bool
            // >=       보다 크거나 같은 연산자     bool

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);

            string str2 = "hello";
            string str3 = "world";
            string str4 = "hello";

            Console.WriteLine(str2 == str3);
            Console.WriteLine(str2 != str3);
            Console.WriteLine(str2 == str4);

            // Console.WriteLine(str2 < str3);  
            // < 대소 비교 연산은 string 형식의 피연산자에 적용 불가능하다.



            // 조건문
            // if(조건식)
            // {조건식이 참일 때 실행될 코드들}

            int i = 10;
            if (i < 5)
            {
                Console.WriteLine("i는 10입니다!");
            }


            // if(조건식)
            // {조건식이 참일 때 실행될 코드들}
            // else(조건식)
            // {조건식이 거짓일 때 실행될 코드들}
            if (i < 5)
            {
                Console.WriteLine("i는 5보다 작습니다!");
            }
            else
            {
                Console.WriteLine("i는 5보다 크거나 같습니다!");
            }


            // if(조건식1)
            // {조건식이 참일 때 실행될 코드들}
            // else(조건식2)
            // {조건식 1이 거짓일 때 실행될 코드들}
            // else(조건식)
            // {모든 조건식이 거짓일 때 실행될 코드들}
            if (i < 5)
            {
                Console.WriteLine("i는 5보다 작습니다!");
            }
            else if (i > 5)
            {
                Console.WriteLine("i는 5보다 큽니다!");
            }
            else
            {
                Console.WriteLine("i는 5입니다!");
            }


            // switch-case조건문
            // switch(변수)
            // {
            //  case value1:
            //      변수 == value1 일때 실행될 코드들  
            //      break;             
            //  case value2:
            //      변수 == value2 일때 실행될 코드들  
            //      break;
            //  defalut:
            //      모든 케이스가 아닐 때 실행될 코드들  
            //      break;
            // }

            switch (i)
            {
                case 0:
                    Console.WriteLine("i는 0입니다.");
                    break;
                case 1:
                    Console.WriteLine("i는 1입니다.");
                    break;
                case 2:
                    Console.WriteLine("i는 2입니다.");
                    break;
                default:
                    Console.WriteLine("위의 모든 경우가 거짓입니다.");
                    break;
            }


            switch (i)
            {
                case 'a':
                    Console.WriteLine("i는 문자 a입니다.");
                    break;
                case 'b':
                    Console.WriteLine("i는  문자 b입니다.");
                    break;
                case 'c':
                    Console.WriteLine("i는  문자 c입니다.");
                    break;
                default:
                    Console.WriteLine("위의 모든 경우가 거짓입니다.");
                    break;
            }




            // 반복문
            /* for - 반복할 횟수가 정해져 있을 때 사용
             for(초기식; 조건식; 증감식){
                반복할 코드들을 중괄호 안에 작성합니다.
            }
             */

            int j;
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Hello");
                Console.WriteLine("World");
                Console.WriteLine(j);
            }

            // 구구단 2단을 화면에 출력해보세요.
            for (j = 1; j < 10; j++)
            {
                Console.WriteLine("2 * " + j + " = " + 2 * j);
            }



            /* while, do-while
             while - 반복할 조건이 정해져 있을 때 사용(조건을 만족하지 않을때까지 반복)
             while(조건식){
                조건식이 참일 때 반복할 코드들
            }
             */

            int h = 1;

            while (h <= 10)
            {
                Console.WriteLine(h);
                h++;
            }

            do
            {    Console.WriteLine(h);
                h++;
            } while (h <= 10);



            // 배열
            // 동일한 데이터 형식의 자료를 한번에 저장하는 구조

            //(자료형)[](배열이름);

            // 배열을 초기화 하는 방법
            // 1. new int[]
            int[] numbers = new int[10];
            // 2. 중괄호 사용
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            // 3. new int[]{}
            int[] numbers2 = new int[]{ 1, 2, 3, 4, 5, };

            // 인덱스 - 데이터의 순서, 0부터 시작

            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers2[2]);
            Console.WriteLine(numbers2.Length);


            // 반복문과 배열을 조합하면 배열의 원소에 쉽게 접근이 가능하다.
            for(int k=0; k < numbers2.Length; k++)
            {
                Console.WriteLine(numbers2[k]);
            }

        }

    }
}
