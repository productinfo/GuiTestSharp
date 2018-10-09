﻿using System.Windows.Forms;

namespace Codice.Examples.GuiTesting.Windows.Testing
{
    internal class TestHelper
    {
        internal TestHelper(Control control)
        {
            mControl = control;
        }

        internal string GetText(Control control)
        {
            string result = string.Empty;
            control.Invoke((MethodInvoker)delegate
            {
                result = control.Text;
            });

            return result;
        }

        internal void SetText(Control control, string text)
        {
            control.Invoke((MethodInvoker)delegate
            {
                control.Text = text;
            });
        }

        internal void ClickButton(Button button)
        {
            mControl.Invoke((MethodInvoker)delegate
            {
                button.PerformClick();
            });
        }

        internal int GetItemCount(ListBox listBox)
        {
            int result = -1;
            mControl.Invoke((MethodInvoker)delegate
            {
                result = listBox.Items.Count;
            });

            return result;
        }

        internal object GetItemAt(ListBox listBox, int index)
        {
            object result = null;
            mControl.Invoke((MethodInvoker)delegate
            {
                result = listBox.Items[index];
            });

            return result;
        }

        readonly Control mControl;
    }
}