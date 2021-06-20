 public string DecodeString(string s) {
        
        Stack<int>    numstack = new Stack<int>();
        Stack<string> strstack = new Stack<string>();
        //parse the string;
        int i = 0;
        string str = "";
        while(i < s.Length)
        {
           if (Char.IsDigit(s[i]))
           {  
               int num = 0;
               while(i < s.Length && Char.IsDigit(s[i]))
               {
                   num = num*10 + (s[i]-'0');
                   i++;
               }
               numstack.Push(num);
               strstack.Push(str);
               str = "";
           }
           else if(Char.IsLetter(s[i]))
           { 
               while(i < s.Length && Char.IsLetter(s[i]))
               {
                   str += s[i];
                   i++;
               }
           }
           else if (s[i]==']')
           {
               //take the string from the stack out,
               StringBuilder temp = new StringBuilder(strstack.Pop());
               int multipler = numstack.Pop();
               //str has the current string for the multiplier
               for(int j = 0; j < multipler; j++)
               {
                   temp.Append(str);
               }
               //switch the str with temp;
               str = temp.ToString();
               i++;
           }
           else
              i++;
           
        }
        return str; //it has the full string;
    }