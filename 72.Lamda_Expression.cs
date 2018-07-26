﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;         // 스레드를 사용하려면 추가해야 한다.

namespace CPPPP
{
    class Lamda_Expression
    {
        public static void Main()
        {
            Thread th1 = new Thread(                // 익명 메소드를
                delegate (object obj)               // 더 짧게 사용할
                {
                    Console.WriteLine("바보");      // 수 있다.
                });

            th1.Start();

            Thread th2 = new Thread(
                (obj) =>                        // 원래 매개변수의 자료형을 명시해야 하지만
                {                               // 이 축약 익명 메소드는 매개변수의 자료형도 안써도 된다.
                    Console.WriteLine("바보");  // 이 식을 람다 식이라고 한다.
                });                             // 람다 식은 익명 메소드를 극도로 간략화한 형태다.

            th2.Start();

            th1.Join();     // th1에게 다른 스레드를 기다리라고 한다.
            th2.Join();     // th2에게 다른 스레드를 기다리라고 한다.
        }
    }
}