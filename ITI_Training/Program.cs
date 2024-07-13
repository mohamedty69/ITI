using System.Runtime.ExceptionServices;
using System.Timers;

namespace ITI_Training
{
    class student
    {
        int id;
        string name;
        int age;
        public void Print()
        {
            Console.WriteLine($"id : {id} - name : {name} - age : {age}");
        }
            #region Day7

    #region p2
    // class book 
    // id , name, price, type 
    // createdon ==> date time
    // isDeleted ==> bool    ====> true ==> deleted  , false ==> not deleted
    // 4ctor ===> id , ===> id, name ===> id, name, price ===> id, name, price, type
    // how many books buy
    // method 
    // getDataBook
    class Book
    {
       int id;
       string name;
       string type;
       string price;
       static DateTime createdon;
       bool isdeleted;
       static int count = 0;
       public void setId(int id)
        {
            this.id = id;
        }
        public void setNameAndId(string name,int id)
        {
            this.name = name;
            this.id = id;
        }
        public void setNameAndIdAndPrice(string name, int id, string price)
        {
            this.name = name;
            this.id = id;
            this.price = price;
        }
        public void setData(string name, int id, string price, string type, bool isdeleted)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.type = type;
            this.isdeleted = isdeleted;
            createdon = DateTime.Now;
            count++;
        }
        public string isDeleted()
        {
            if (isdeleted == true)
            {
                return "Deleted";
            }
            else
            {
                return "Not Deleted";
            }
        }
        public void getdataBook()
        {
            Console.WriteLine($"{id} - {name} - {price} - {type} - {isDeleted()} - {createdon} ");
        }
        public void howManyBooks()
        {
            Console.WriteLine($"Number of books is {count}");
        }
    }
    #endregion
    #region p1
class student(int id, string name, int age)
    {
       
        public void getdata()
        {
            Console.WriteLine($"{id} - {name} - {age}");
        }
        static student()
        {
            Console.WriteLine("Student data");
        }
    }
    #endregion
    #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region proplem 1
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
            #endregion
            #region proplem 2
            int id;
            int salary;
            int age;
            Console.Write("Enter the id : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter the salary : ");
            salary = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Write("Enter the age ");
                age = int.Parse(Console.ReadLine());
                if (age > 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"""
                    {"Your id :"} {id}

                    {"Your salary :"} {salary}
                    
                    {"Your age :"} {age}
                    """);
            #endregion

            #region proplem 3
            student s = new student();
            s.Print();
            #endregion

            #region Day 7

            #region S for p1
            student s1 = new student(1, "Ahmed", 20);
            s1.getdata(); 
            student s2 = new student(2, "Ali", 21);
            s2.getdata();
            student s3 = new student(3, "Mohamed", 22);
            s3.getdata(); 
            student s4 = new student(4, "Omar", 23); 
            s4.getdata();
            #endregion



            #region S for p2
            Book b1 = new Book();
            b1.setData("Book1", 1, "100", "Type1", false);
            b1.getdataBook();
            Book b2 = new Book();
            b2.setData("Book2", 2, "200", "Type2", false);
            b2.getdataBook();
            Book b3 = new Book();
            b3.setData("Book3", 3, "300", "Type3", false);
            b3.getdataBook();
            Book b4 = new Book();
            b4.setData("Book4", 4, "400", "Type4", true);
            b4.getdataBook();
            Book b5 = new Book();
            b5.setData("Book5", 4, "550", "Type5", true);
            b5.getdataBook();
            b5.howManyBooks();
            #endregion

            #endregion
        }
    }
}
