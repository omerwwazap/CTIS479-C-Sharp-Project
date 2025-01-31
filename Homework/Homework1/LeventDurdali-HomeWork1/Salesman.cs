﻿//1.Create at least 3 classes Buyer,Salesman,RetailSalesPerson,Re-helper
//2.Add is -a relation between the classes, there has to be at least 3 level of inheritance
//4.Create at least one abstract class.
namespace LeventDurdali_HomeWork1
{
    public abstract class Salesman
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int age { get; set; }


        public string Fullname
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
        }
        public string getAge
        {
            get
            {
                return string.Format("{0}", this.age);
            }
        }

        public Salesman(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Salesman(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }


        public void Sell()
        {
            this.Talk();
            this.Tell_about_car();
            this.Close();
        }

        protected abstract void Talk();
        protected abstract void Tell_about_car();
        protected abstract void Close();
    }
}
