using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {

            IndexedNames names = new IndexedNames();
            names[0] = "Modi";
            names[1] = "Trump";
            names[2] = "May";
            names[3] = "Tradeau";
            names[4] = "Khan";
            names[5] = "Sirisena";
            names[6] = "Turnbull";

            for(int i = 0; i<IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }



            foreach(string str in names)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }

    internal class IndexedNames : IEnumerable
    {
        public static int size = 7;
        private String[] nameList = new string[size];

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        public IEnumerator GetEnumerator()
        {
            return nameList.GetEnumerator();
        }

        

        public IndexedNames()
        {
            nameList.GetEnumerator();

          //for(int i =0;i<size;i++)
          //  {
          //      nameList[i] = "Nothing";
          //  }
       
        }
        

        
        public string this[int index]
        {
            get
            {
                string tmp;


               
                if(index >= 0 && index <=size-1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }

                return tmp;
            }
            set
            {
                if(index >=0 && index <=size-1)
                {
                    nameList[index] = value;
                }
            }
        }



    }
    }
