using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSYouTube
{
    internal class 추상화
    {

        public class Parent // 일반클래스 - 객체 생성 가능
        {
            public void print()
            {
                Console.WriteLine("부모 클래스의 메서드입니다.");
            }
        }
        public class Child : Parent // 일반클래스 - 객체 생성 가능
        {
            public void print()
            {
                Console.WriteLine("자식 클래스의 메서드입니다.");
            }
        }

        public abstract class Parent2 // 추상클래스 - 객체 생성이 불가능
        {
            // 추상메서드에는 필드, 일반메서드, 추상메서드가 존재할 수 있음
            private string name = "soo";

            public string getName()
            {
                return name;
            }

            public void print()
            {
                Console.WriteLine("부모 클래스의 메서드입니다.");
            }

            public abstract void printName(); //  추상메서드이기 때문에 구현이 필요하지 않다.

        }
        public class Child2 : Parent2  // 추상메서드는 자식 클래스에서 무조건 재정의가 필요
        {
            public void print()
            {
                Console.WriteLine("자식 클래스의 메서드입니다.");
            }

            // 재정의는 override 키워드를 사용
            public override void printName() // 구현부가 필요
            {
                Console.WriteLine(getName());
            }
        }

        static void Main(string[] args)
        {

            // 추상클래스
            // 일반크래스와는 다르게 상속 전용 클래스 (객체 생성이 되지 않음)

            // 일반클래스
            Parent parent = new Parent();
            Child child = new Child();
            parent.print();
            child.print();

            // 추상클래스는 인스턴스를 만들 수 없다. (객체 생성이 불가능)
            // Parent parent2 = new Parent2(); 인스턴스 생성 불가로 오류 발생
            Child2 child2 = new Child2();
            child2.print();
            child2.printName();

        }



    }
}
