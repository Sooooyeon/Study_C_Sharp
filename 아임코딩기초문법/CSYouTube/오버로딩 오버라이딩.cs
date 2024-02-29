using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSYouTube
{
    internal class 오버로딩_오버라이딩
    {
        public class Test // 오버로딩
        {
            public void print()
            {
                Console.WriteLine("hello world");
            }

            public void print(int num) // print 함수에 대한 메서드 오버로딩(같은 함수인데 매개변수가 다름)
            {
                Console.WriteLine(num);
            }

            public void print(string str) // print 함수에 대한 메서드 오버로딩(같은 함수인데 매개변수가 다름)
            {
                Console.WriteLine(str);
            }

            public void print(string str, int num) // print 함수에 대한 메서드 오버로딩(같은 함수인데 매개변수가 다름)
            {
                for(int i = 0; i < num; i++)
                {
                    Console.WriteLine(str);
                }
            }

        }

        public class Parent // 오버라이딩
        {
            public void print()
            {
                Console.WriteLine("부모클래스의 메서드입니다.");
       
            }

        }

        public class Child : Parent // 오버라이딩
        {
            public void print() // 재정의
            {
                Console.WriteLine("자식클래스의 메서드입니다."); 

            }

        }

        static void Main(string[] args)
            {

                // 다형성
                // 하나의 코드가 여러가지 형태로 실행될 수 있도록 하는 것
                // 오버로딩, 오버라이딩이 존재
                // 오버로딩 : 같은 이름의 메서드를 여러개 정의
                // 오버라이딩 : 부모 클래스에서 정의된 메서드를 자식 클래스에서 재정의

                Test test = new Test();

                test.print();
                test.print(10);
                test.print("입력받은 문자열을 출력합니다.");
                test.print("반복",3);
                

                Parent parent = new Parent();
                Child child = new Child();

                parent.print();
                child.print();



            }


    }
}
