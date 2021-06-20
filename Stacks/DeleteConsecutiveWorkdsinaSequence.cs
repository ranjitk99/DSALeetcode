public static int removeConsecutiveSame(List<string> words)
{
    Stack<string> stackwords = new Stack<string>();
  
    
    for (int i = 0; i < words.Count; i++)
    {
        
        if (stackwords.Count == 0)
        {
            stackwords.Push(words[i]);
        }
        else
        {
            string str = stackwords.Peek();  
           
            if (str.Equals(words[i]))
            {
                stackwords.Pop();
            }  
           
            else
            {
                stackwords.Push(words[i]);
            }
        }
    }
  
   
    return stackwords.Count;
}
  