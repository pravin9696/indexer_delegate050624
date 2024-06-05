using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace indexer_delegate050624
{
    public delegate int myDelegate(int x, int y);
    public delegate void strDelegate(string ss1,string ss2);
    class calculator
    {
        public int sum(int a,int b)
        {
            return a + b;
        }
        public void stringConcat(string s1,string s2)
        {
            Console.WriteLine(s1+s2);
        }
    }
    
    class student
    {
        public int roll { get; set; }// property
        public String name { get; set; }
        public int[] sub { get; set; }
        public int [] aaa { get; set; }
        public string[] subNames { get; set; }
        public student()
        {
            sub = new int[5];
            for (int i = 0; i < sub.Length; i++)
            {
                sub[i] = 0;
            }
            subNames = new string[5];
            for (int i = 0; i < subNames.Length; i++)
            {
                subNames[i] = "Empty";
            }
            aaa= new int[5];
            for (int i = 0; i < sub.Length; i++)
            {
                aaa[i] = -1;
            }
        }
        public void show(int x)
        {

        }
        public void show(char b)
        {
            

        }

        public string this[int i,int temp]
        {
            set
            {
                subNames[i] = value;
            }
            get
            {
                return subNames[i];
            }
        }
        public int this[int i, int j,int k]
        {
            set
            {
                aaa[i] = value;
            }
            get
            {
                return aaa[i];
            }
        }

        public int this[int index]
        {
            set
            {
                sub[index] = value;
            }
            get
            {
                return sub[index];
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region indexer demo
            /*
              student s1 = new student();// single object of student type
              s1[0] = 89;//sub
              s1[0, 0, 0] = 11111;
              s1[0,0] = "C programming";
              s1[4] = 99;
              s1[4, 0] = "JAVA";
              s1.roll = 12345;
              s1.name = "rajesh";
              Console.WriteLine("roll="+s1.roll);
              Console.WriteLine("Name="+s1.name);
              Console.WriteLine("5 subject marks:");
              for (int i = 0; i < 5; i++)
              {
                  Console.WriteLine(s1[i]);
              }
              Console.WriteLine("Subject Names:");

              for (int i = 0; i < 5; i++)
              {
                  Console.WriteLine(s1[i,0]);
              }
              Console.WriteLine(s1[0,1,2]);
            */
            #endregion

            #region delegate Example
            calculator c1 = new calculator();
            myDelegate md = new myDelegate(c1.sum);
            //int ans=c1.sum(100, 200);
            int ans = md(100, 200);
            Console.WriteLine(ans);

            strDelegate del2 = new strDelegate(c1.stringConcat);
            del2("pune", "Maharashtra");
            #endregion
        }

    }
}
