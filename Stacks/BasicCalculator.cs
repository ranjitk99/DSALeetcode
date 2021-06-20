public int Calculate(string s) {
        int result = 0;
        bool minusLastSeen = false;
        bool evenNumberOfMinusesOnStack = true;
        int currentNum = 0;
        Stack<bool> signStack = new Stack<bool>();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == ' ')
                continue;
            
            if (char.IsDigit(c))
            {
                currentNum *= 10;
                currentNum += (currentNum < 0 ? -1 : 1) * (c - '0');
                
                if (minusLastSeen)
                {
                    currentNum *= -1;
                    minusLastSeen = false;
                }                
            }
            else
            {
                result += (evenNumberOfMinusesOnStack ? 1 : -1) * currentNum;
                currentNum = 0;
                if (c == '-')
                {
                    minusLastSeen = true;
                }
                else
                {
                    if (c == '(')
                    {
                        if (minusLastSeen)
                        {
                            evenNumberOfMinusesOnStack = !evenNumberOfMinusesOnStack;
                            signStack.Push(false);
                        }
                        else
                        {
                            signStack.Push(true);                            
                        }
                    }
                    else if (c == ')')
                    {
                        if (!signStack.Pop())
                        {
                            evenNumberOfMinusesOnStack = !evenNumberOfMinusesOnStack;                            
                        }
                    }
                    
                    minusLastSeen = false;
                }
            }
        }
        
        result += currentNum;
        return result;
    }