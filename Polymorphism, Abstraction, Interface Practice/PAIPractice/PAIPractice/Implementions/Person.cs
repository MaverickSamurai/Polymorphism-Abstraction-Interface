using System;
using System.Collections.Generic;
using System.Text;

namespace PAIPractice
{
    #region Interface


    //public  class Person : /*Test,*/ ISpeak, IEating 
    //{
    //    public void Speak()
    //    {
    //        Console.WriteLine("Person speaking");
    //    }

    //    public void Eating(DateTime time)
    //    {
    //        Console.WriteLine("Person eating - " + DateTime.Now);
    //    }
    //}

    //public interface ISpeak
    //{
    //    void Speak();
    //}

    //public interface IEating
    //{
    //    void Eating(DateTime time);
    //}
    #endregion

    #region Interface2
    public class Person : /*Test,*/ ISpeak, IEating
    {
        public void Speak()
        {
            Console.WriteLine("Person speaking");
        }

        public void Eating(DateTime time)
        {
            Console.WriteLine("Person eating - " + time);
        }
    }

    public interface ISpeak
    {
        void Speak();
    }

    public interface IEating
    {
        void Eating(DateTime time);
    }
    #endregion
}
