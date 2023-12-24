using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class FormStack
{
    private Stack<Form> stack = new Stack<Form>();

    public void Push(Form form)
    {
        stack.Push(form);
    }

    public Form Pop()
    {
        if (stack.Count > 1)
        {
            stack.Pop(); // Pop the current form
            return stack.Pop(); // Return the previous form
        }
        return null; // Only one form in the stack; cannot go back further
    }
}
