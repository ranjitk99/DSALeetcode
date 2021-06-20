public class Solution {
    public string MinRemoveToMakeValid(string s)
    {

        StringBuilder sb = new StringBuilder(s);
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == '(')
            {
                st.Push(i);
            }

            if (sb[i] == ')')
            {
                if (st.Count > 0)
                {
                    st.Pop();
                }
                else
                {
                    sb.Replace(')', '*', i, 1);
                }
            }
        }

        while (st.Count > 0)
        {
            sb.Remove(st.Pop(), 1);
        }

        sb.Replace("*", "");
        return sb.ToString();
    }
}