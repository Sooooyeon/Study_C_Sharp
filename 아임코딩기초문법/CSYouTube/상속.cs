using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSYouTube
{
    internal class 상속
    {

        public class Parent
        {
            private int num;

            public void PrintNum()
            {
                Console.WriteLine("num: " + num);
            }

            public void setNum(int num)
            {
                this.num = num;
            }

            public int getNum() { 
                return num; 
            }

        }

        public class Child : Parent {
            public void Print()
            {
                Console.WriteLine("자식 클래스의 메서드 입니다.");
            }
        }



        static void Main(string[] args)
        {

            // 상속
            // 객체지향 프로그래밍 언어 특성중에 하나로 기존 클래스를 재사용해 새로운 클래스를 만들 수 있는 기능
            // 상속하는 클래스를 부모 클래스, 상속받는 클래스를 자식 클래스라고 함
            // 부모의 메서드를 그대로 물려받음

            Child child = new Child();
            child.setNum(10);
            Console.WriteLine(child.getNum());

            child.Print();

        }



    }
}
