using System;
using System.Windows.Forms;

namespace UHotel9
{
    public partial class AnotherForm : Form
    {
        private FormStack formStack;

        public AnotherForm(FormStack formStack)
        {
          
            InitializeCustomComponents();

            this.formStack = formStack;
        }

        private void InitializeCustomComponents()
        {
           
        }

        private void AnotherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            formStack.Pop();
        }
    }
}
