using System;
using System.Collections.Generic;
using System.Text;

namespace roman_numerals_csharp
{
    public class Converter
    {
        public static string Multiply(string source, int multiplier)
        {
            StringBuilder sb = new StringBuilder(multiplier * source.Length);
            for (int i = 0; i < multiplier; i++)
            {
                sb.Append(source);
            }

            return sb.ToString();
        }

        public string calc(string n, string baze, string middle, string peak)
        {
            int number;
            bool isParsable = Int32.TryParse(n, out number);

            if(isParsable)
            {
                if(number<5 && number!=4) return Multiply(baze, number);
                else if(number==4) return baze + middle;
                else if(number==5) return middle;
                else if(number>5 && number<9) return middle + Multiply(baze, number-5);
                else if(number==9) return baze+peak;
                else return "";
            }

            else return "error";
    
        }

        public void convert( string num)
        {
            List<string> roman = new List<string>();

            switch (num)
            {
                case var d when d.Length == 4:
                    roman.Add(Multiply("M", Int32.Parse(d[0].ToString())));
                    roman.Add(calc(d[1].ToString(),"C","D","M"));
                    roman.Add(calc(d[2].ToString(),"X","L","C"));
                    roman.Add(calc(d[3].ToString(),"I","V","X"));
                break;

                case var d when d.Length == 3:
                    roman.Add(calc(d[0].ToString(),"C","D","M"));
                    roman.Add(calc(d[1].ToString(),"X","L","C"));
                    roman.Add(calc(d[2].ToString(),"I","V","X"));
                break;

                case var d when d.Length == 2:
                    roman.Add(calc(d[0].ToString(),"X","L","C"));
                    roman.Add(calc(d[1].ToString(),"I","V","X"));
                break;

                case var d when d.Length == 1:
                    roman.Add(calc(d.ToString(),"I","V","X"));
                break;

            }
            Console.WriteLine(String.Join("", roman));
        }
        
    }
}
