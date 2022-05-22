using System
using System.Text
using System.Collection.Generic

namespace ConsoleApp1 
{ 
    class Text 
    { 
        public string tema; 
        public string text; 
 
 
        public Text(string tema, string text) => (this.tema, this.text) = (tema, text); 
 
        public int charLength() 
        { 
            int length = 0; 
            for(int i = 0; i < text.Length; i++) 
            { 
                if(text[i] >= 65 && text[i] <= 90 || 
                   text[i] >= 97 && text[i] <= 122) 
                { 
                    length++; 
                } 
            } 
            return length; 
        } 
 
        public int numberSpaces() 
        { 
            int count = 0; 
            for (int i = 0; i < text.Length; i++) 
            { 
                if (text[i] == ' ') 
                { 
                    count++; 
                } 
            } 
            return count; 
        } 
 
        public void f3(char a, char b) 
        { 
            string res = ""; 
            for (int i = 0; i < text.Length; i++) 
            { 
                if (text[i].Equals(a)) 
                { 
                    res += b; 
                } 
                else res += text[i]; 
            } 
            text = res; 
        } 
 
        public void f4(int b) 
        { 
            int k = 1; 
            string res = ""; 
            for (int i = 0; i < text.Length; i++) 
            { 
                if (text[i] == ' ' && i + 1 < text.Length && text[i + 1] != '-') 
                { 
                    k += 1; 
                } 
                if(k == b) 
                { 
                    int y = i + 1; 
                    while (y < text.Length && text[y] != ' ') y++; 
                    i = y - 1; 
                    continue; 
                } 
                res += text[i];  
            } 
            text = res.Trim(); 
        } 
 
    } 
 
 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Text a = new Text("a", "a b c d eee"); 
            Console.WriteLine(a.text); 
            Console.WriteLine(a.charLength()); 
            Console.WriteLine(a.numberSpaces()); 
            a.f3('a', 'b'); 
            Console.WriteLine(a.text); 
 
            a.f4(1);  
            Console.WriteLine(a.text); 
 
        } 
    } 
}