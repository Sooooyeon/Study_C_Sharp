using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSYouTube
{
    internal class 캡슐화
    {
        public class Person 
        {
            // 데이터 필드
            // private를 사용하면 데이터 필드에 접근 불가
            private int age;

            public void SetAge(int age)
            {
                // this는 외부에서 클래스에 접근했을때 자기자신객체를 의미
                this.age = age;
            }

            public int GetAge() // 직접 접근을 할 수 없기때문에 return 역할을 해주는 메서드를 정의
            {
                return age;
            }
        }


        static void Main(string[] args)
        {

            // 캡슐화
            // 데이터와 데이터를 다루는 메서드를 하나로 묶은것
            // C#에서는 class를 사용해 데이터와 메서드를 하나로 묶음
            // class를 사용해 객체를 정의하고, class 내부에 필드와 메서드를 정의
            // 객체 필드(데이터)들은 외부에서 접근할 수 없게 만듭니다.
            // 메서드는 외부에서 접근할 수 있게 만듭니다.
            // private 접근제한자를 필드에 적용

            Person p = new Person();
            //p3.age = 17; // 접근불가
            p.SetAge(17);
            //Console.WriteLine(p3.age); // 접근불가
            //Console.WriteLine(p3.SetAge(17)); // 접근불가
            Console.WriteLine(p.GetAge()); // get 역할을 하는 메서드를 사용해 접근


        }



    }
}
