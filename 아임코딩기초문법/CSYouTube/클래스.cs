using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSYouTube
{
    internal class 클래스
    {

    public class Person
    {
        // 데이터들 필드
        public int height;
        public int weight;


        // 데이터를 조작할 메서드(함수)
        // 클래스 안에 접근제한자를 써주고, 반환타입을 명시해 메서드를 생성
        public void PrintHeight()
        {
            Console.WriteLine("키: " + height);
        }
        public void PrintWeight()
        {
            Console.WriteLine("몸무게: " + weight);
        }

    }

    public class Person2
    {
        public void PrintHello() // 반환값과 매개변수가 없는 메서드
        {
            Console.WriteLine("Hello World");
        }
            
        public void HelloSomeone(string name) // 반환값은 없고 매개변수는 있는 메서드
        {
            Console.WriteLine("Hello " + name);
        }


        public int ReturnTen() // 반환값은 있고 매개변수는 없는 메서드
        {
            return 10;
        }

        public int Sum(int a, int b)  // 반환값과 매개변수가 모두 있는 메서드
         {
            return a + b;   
         }
            
    }



        static void Main(string[] args)
        {

            // 클래스
            // 데이터와 메서드를 하나의 단위로 묶어서 캡슐화 하는 것
            // 데이터는 int, float, string등의 자료들을 의미
            // 데이터와 데이터를 조작할 함수들을 묶어놓은것이 클래스
            // 객체지향 언어에서는 클래스로 세상에 있는 사물들을 추상화
            // 데이터 ex) 사람 - 키, 몸무게, 머리카락색상, 발사이즈 등의 특징을 가지며 이는 데이터가 될 수 있다.
            // 메서드 ex) 키를 저장, 키를 변경, 머리카락색상 변경

            // 클래스 = 붕어빵 틀
            // 객체 = 붕어빵
            
            Person p =new Person();
            p.height = 180;
            p.weight = 70;

            p.PrintHeight();
            p.PrintWeight();



            // 메서드
            // 클래스 안의 데이터들을 활용할 용도로 사용
            // 코드들의 집합 (코드들)
            // 메서드 이름, 매개변수, 반환값
            Person2 p2 = new Person2();
            p2.PrintHello();
            p2.HelloSomeone("sooyeon");

            int result;
            result = p2.ReturnTen();
            Console.WriteLine(result);

            int result2;
            result2 = p2.Sum(4,5);
            Console.WriteLine(result2);




            




            // 상속
            // 객체지향 프로그래밍 언어 특성중에 하나로 기존 클래스를 재사용해 새로운 클래스를 만들 수 있는 기능
            // 상속하는 클래스를 부모 클래스, 상속받는 클래스를 자식 클래스라고 함


        }






    }
}
