using System;

namespace PAIPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Polmorphism




            //Bird bird = new Bird();
            //bird.Sound();

            //Dog dog = new Dog();
            //dog.Sound();
            #endregion

            #region Abstract


            //Bird bird = new Bird();
            //bird.Sound();
            //bird.Eat();

            //Dog dog = new Dog();
            //dog.Sound();
            //dog.Eat();
            #endregion

            #region Test



            //Test test = new Test();
            //test.Id = 6; 
            #endregion

            #region Interface


            //Person person = new Person();
            //person.Speak();
            #endregion

            #region Interface 2
            Person person = new Person();
            person.Speak();
            person.Eating(DateTime.Now);
            #endregion

        }
    }
}
