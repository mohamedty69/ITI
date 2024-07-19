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
        #region Day9
        public class HTMLElement
        {
            public string type;
            public string value;
            public HTMLElement(string type, string value)
            {
                this.type = type;
                this.value = value;
            }
            public virtual void render()
            {
                Console.WriteLine($"<{type}>{value}</{type}>");
            }
        }
          public class ImageElement : HTMLElement
      {
          public string src;
          public ImageElement(string type, string value, string src ) : base(type, value)
          {
              this.src = src;
          }
          public override void render()
          {
              Console.WriteLine($"<{type} src={src}>{value}</{type}>");
          }
      }
      public class TextElement : HTMLElement
    {
       public string fontsize;
       public string fontcolor;
        public TextElement(string type, string value ,string fontsize, string fontcolor) : base(type, value)
        {
            this.fontsize = fontsize;
            this.fontcolor = fontcolor;
        }
        public override void render()
        {
            Console.WriteLine($"<{type}>{value}</{type}>");
        }
    
    }
      public class H1Element : TextElement
      {
          string text;
          public H1Element(string type ,string value , string fontsize , string fontcolor,string text) : base(type , value ,fontsize,fontcolor )
          {
              this.text = text;
          }
          public override void render()
          {
              Console.WriteLine($"<{type} fontsize={fontsize} color={fontcolor}>{value}</{type}>");
          }
        
      }
      public class H2Element : TextElement
    {
        string text;
        public H2Element(string type, string value, string fontsize, string fontcolor, string text) : base(type, value, fontsize, fontcolor)
        {
            this.text = text;
        }
        public override void render()
        {
            Console.WriteLine($"<{type} fontsize={fontsize} color={fontcolor}>{value}</{type}>");
        }
    }
    #endregion

        #region DAY11
    public class BMIinput<T>
    {
        public T heghit { get; set; }
        public T width { get; set; }

        public BMIinput(T heghit, T width)
        {
            this.heghit = heghit;
            this.width = width;
        }
    }
    #endregion

    
    #region DAY11
    public class BMIcalc : BMIinput <double>
    {
        public double BMI { get; set; }
        public BMIcalc(double height, double weight) : base(height, weight)
        { 
        }
        public void CalculateBMI()
        {
            BMI = width / (heghit * heghit);
        }
        public void printBMI()
        {
            Console.WriteLine($"Height: {heghit} ");
            Console.WriteLine($"Weight: {width} ");
            Console.WriteLine($"BMI: {BMI}");
        }
        public void range()
        {
            if (BMI < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (BMI >= 25 && BMI < 29.9)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
           
        }
    }
#endregion
#region DAY11
public class Calculator <T>
{
    
    public T x;
    public T y;
    public Calculator(T x, T y)
    {
        this.x = x;
        this.y = y;
    }
    public delegate T Operation(T x, T y);
    public T Add(T x, T y)
    {
        dynamic a = x;
        dynamic b = y;
        return (a + b);
    }
    public T Sub(T x, T y)
    {
        dynamic a = x;
        dynamic b = y;
        return (a - b);
    }
    public  T Mul(T x, T y)
    {
        dynamic a = x;
        dynamic b = y;
        return (a * b);
    }
    public T Div(T x, T y)
    {
        dynamic a = x;
        dynamic b = y;
        return (a / b);
    }
    public void Calculate(Operation operation,T x,T y)
    {
        Console.WriteLine("The Result Is :" + operation(x, y));
    }
}
#endregion

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
                              
            #region Day8
             int x;
            int y;
            Console.WriteLine("Enter a number :");
            x = int.Parse(Console.ReadLine());
            int [] age;
            string[] name;
            age = new int[x];
            name = new string[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter the name of the student :");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter the age of the student :");
                age[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the number :");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("The name is " + name[y-1] + " and the age is " + age[y-1]);
            #endregion
                              
            #region Day8 P2
             Console.WriteLine("Enter the arr of string :");
            string input = Console.ReadLine();
            string [] arr1 = input.Split(",");
            int[] num = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                num[i] = int.Parse(arr1[i]);
            }
            int[] arr = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                int mul = 1;
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (num[j] == num[i])
                    {
                        continue;
                    }
                   
                  
                        mul = mul * num[j];
                    
                }
                arr[i] = mul;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            #endregion
                              
            #region Day9
            List<HTMLElement> elements = new List<HTMLElement>();
            elements.Add(new H2Element("H2", "Text", "20pt", "#665", "H2"));
            elements.Add(new ImageElement("img", "Image", "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png"));
            elements.Add(new TextElement("text","text","15pt", "#558"));
            elements.Add(new H1Element("H1", "Heading 1", "25pt", "#655", "H1"));
            foreach (var element in elements)
            {
                element.render();
            }
            #endregion
                              
            #region Day11
            Stack<BMIcalc> bMIinputs = new Stack<BMIcalc>();
            bMIinputs.Push(new BMIcalc(1.5, 70));
            bMIinputs.Push(new BMIcalc(1.1, 10));
            bMIinputs.Push(new BMIcalc(1.15, 90));
            bMIinputs.Push(new BMIcalc(1.90, 100));
            bMIinputs.Push(new BMIcalc(1.01, 110));
            foreach (var bMIinput in bMIinputs)
            {
                bMIinput.CalculateBMI();
                bMIinput.printBMI();
                bMIinput.range();
            }
            #endregion
            #region DAY11
         Calculator<int> calculator1 = new Calculator<int>(10, 5);
         calculator1.Calculate(calculator1.Add, 10, 5);
        
         Calculator<double> calculator2 = new Calculator<double>(10.5, 5.5);
         calculator2.Calculate(calculator2.Sub, 10.5, 5.5);
        
         Calculator<float> calculator3 = new Calculator<float>(10.4f, 80.3f);
         calculator3.Calculate(calculator3.Div, 10.45f, 80.2f);
        
         Calculator<long> calculate4 = new Calculator<long>(1000, 500000);
         calculate4.Calculate(calculate4.Mul, 1000, 500000);
         #endregion
        }
    }
}
