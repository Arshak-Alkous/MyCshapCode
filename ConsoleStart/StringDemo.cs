using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStart
{
    public class StringDemo
    {
        public static void ExplainStaticVersusInstance() 
        {
            // string demo = string.Join();
            // string demo2 = "Demo of instance".ToLower();
            // demo2.EndsWith('r');
        }
        public string[] SplitTextToArray()
        {
            string textToTransform =
                "As you can see, the period characters (.) are included in two of the         substrings. If you want to exclude the period characters, you can add the period character as an additional delimiting character. The next example shows how to do this.";
            string[] textArray = new string[4];
            //string[] textToTransformed = textToTransform.Split("per");
            //for (int i = 0; i < textToTransformed.Length; i++)
           // {
            //    Console.WriteLine(textToTransformed[i]);
           // }
            //Console.WriteLine("________________________________________");

            string[] textToTransformed1 = textToTransform.Split(new char[] {' ','.',',','(',')'},StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(textToTransformed1);
            //for (int i = 0; i < textToTransformed1.Length; i++)
            //{
            //    Console.Write(textToTransformed1[i]);
           // }
           // Console.WriteLine();
           // Console.WriteLine("________________________________________");
            //string[] textToTransformed2 = textToTransform.Split(new char[] {'.',' '});
            //for (int i = 0; i < textToTransformed2.Length; i++)
            //{
            //    Console.Write(textToTransformed2[i]);
            //}
            return textToTransformed1;
        }
        public string spitTextToParagraph(string text)
        {
            string paragraph = "";
            string newText = "";
            string[] textArray = text.Split('.', StringSplitOptions.RemoveEmptyEntries);  
            for (int i = 0; i < textArray.Length; i++)
            {
                if ((paragraph + textArray[i]).Length<=400)
                    paragraph += textArray[i].Trim() + ". ";
                else
                {
                    newText += paragraph + "\n\n";
                    paragraph=textArray[i].Trim()+". ";
                }
            }
            //add the last paragraph becuae if last paragraph is less than 400 it will not add to newText because adding within else statment 
            newText += paragraph+"\n";
            return newText;
        }


    }
}
