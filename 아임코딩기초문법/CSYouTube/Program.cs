namespace CSYouTube
{
    internal class Program
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


        }

    }
}
