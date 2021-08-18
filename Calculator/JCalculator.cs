using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class JCalculator : Form
    {

        private KeyValuePair<string, string> firstInputPair = new KeyValuePair<string, string>();
        private bool operatorIsClicked = false;
        private bool textChanged = false;
        private string copyValue = "";

        private List<History> historyList = new List<History>();
        private List<string> memoryList = new List<string>();
       
        public JCalculator()
        {
            InitializeComponent();

            RefreshHistoryList();

            RefreshMemoryList();

            LoadDefaults();
        }

        private void operator_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var action = (sender as ComboBox);

            switch (action.SelectedItem.ToString())
            {
                case " + Add":
                    {
                        OperatorClicked("+");
                    }
                    break;
                case " - Subtract":
                    {
                        OperatorClicked("-");
                    }
                    break;
                case " * Multiply":
                    {
                        OperatorClicked("*");
                    }
                    break;
                case " / Divide":
                    {
                        OperatorClicked("/");
                    }
                    break;
                default:
                    { }
                    break;
            }
        }

        private void buttonActions(object sender, EventArgs e)
        {
            var actionType = sender.GetType();

            if (actionType == typeof(ToolStripMenuItem))
            {
                ToolStripMenuItem menuItemPressed = (sender as ToolStripMenuItem);

                switch (menuItemPressed.Tag.ToString())
                {
                    case "clear":
                        {
                            ClearTextBox();
                        }
                        break;
                    case "exit":
                        {
                            Environment.Exit(1);
                        }
                        break;
                    case "copy":
                        {
                            copyValue = secondNumber_txtBox.Text;
                        }
                        break;
                    case "paste":
                        {
                            secondNumber_txtBox.Text = copyValue;
                        }
                        break;
                    case "export":
                        {
                            Export();
                        }
                        break;
                    case "import":
                        {
                            Import();
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }
            }
            else if (actionType == typeof(Button))
            {
                Button buttonPressed = (sender as Button);

                switch (buttonPressed.Tag.ToString())
                {
                    case "clear":
                        {
                            ClearTextBox();
                        }
                        break;
                    case "delete":
                        {
                            Delete();
                        }
                        break;
                    case "=":
                        {
                            OperatorClicked("=");
                        }
                        break;
                    case "+-":
                        {
                            ChangeSign();
                        }
                        break;
                    case "input":
                        {
                            InsertCharacter(buttonPressed.Text);
                        }
                        break;
                    case "ms":
                        {
                            memoryList.Add(secondNumber_txtBox.Text);
                            RefreshMemoryList();
                            operatorIsClicked = true;
                        }
                        break;
                    case "mc":
                        {
                            memoryList.Clear();
                            RefreshMemoryList();
                        }
                        break;
                    case "mr":
                        {
                            if (memoryList.Count != 0)
                                secondNumber_txtBox.Text = memoryList.Last();
                        }
                        break;
                    case "m+":
                        {
                            if (memoryList.Count != 0)
                            {
                                string newLast = GetResult(Convert.ToDecimal(memoryList.Last()), "+", Convert.ToDecimal(secondNumber_txtBox.Text)).ToString();
                                memoryList.RemoveAt(memoryList.Count - 1);
                                memoryList.Add(newLast);
                                RefreshMemoryList();
                                operatorIsClicked = true;
                            }
                            else
                            {
                                memoryList.Add(secondNumber_txtBox.Text);
                                RefreshMemoryList();
                                operatorIsClicked = true;
                            }
                        }
                        break;
                    case "m-":
                        {
                            if (memoryList.Count != 0)
                            {
                                string newLast = GetResult(Convert.ToDecimal(memoryList.Last()), "-", Convert.ToDecimal(secondNumber_txtBox.Text)).ToString();
                                memoryList.RemoveAt(memoryList.Count - 1);
                                memoryList.Add(newLast);
                                RefreshMemoryList();
                                operatorIsClicked = true;
                            }
                            else
                            {
                                memoryList.Add("-" + secondNumber_txtBox.Text);
                                RefreshMemoryList();
                                operatorIsClicked = true;
                            }
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }
            }
        }
        
        private void OperatorClicked(string op)
        {
            operatorIsClicked = op != "=";

            try
            {
                if (firstNumber_txtBox.Text == "")
                {
                    firstNumber_txtBox.Text = secondNumber_txtBox.Text + " " + op;
                    firstInputPair = new KeyValuePair<string, string>(secondNumber_txtBox.Text, op);
                }
                else if (firstNumber_txtBox.Text != "")
                {
                    if (op == "=")
                    {
                        if (firstInputPair.Value == "=")
                        {
                            //add to memory
                        }
                        else
                        {
                            decimal firstInput = Convert.ToDecimal(firstInputPair.Key);
                            decimal secondInput = Convert.ToDecimal(secondNumber_txtBox.Text);

                            decimal result = GetResult(firstInput, op, secondInput);

                            AddToHistory("Equals", result.ToString());

                            secondNumber_txtBox.Text = result.ToString();
                        }


                        firstInputPair = new KeyValuePair<string, string>(secondNumber_txtBox.Text, op);
                        firstNumber_txtBox.Text = secondNumber_txtBox.Text + " " + op;

                        textChanged = false;
                    }
                    else
                    {
                        if (!textChanged)
                        {
                            firstInputPair = new KeyValuePair<string, string>(secondNumber_txtBox.Text, op);
                            firstNumber_txtBox.Text = secondNumber_txtBox.Text + " " + op;
                        }
                        else if (textChanged)
                        {
                            decimal firstInput = Convert.ToDecimal(firstInputPair.Key);
                            decimal secondInput = Convert.ToDecimal(secondNumber_txtBox.Text);

                            decimal result = GetResult(firstInput, firstInputPair.Value, secondInput);

                            AddToHistory(GetHistoryAction(firstInputPair.Value), secondInput.ToString());

                            secondNumber_txtBox.Text = result.ToString();

                            firstInputPair = new KeyValuePair<string, string>(secondNumber_txtBox.Text, op);
                            firstNumber_txtBox.Text = secondNumber_txtBox.Text + " " + op;

                            textChanged = false;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException occurred. Resetting..", "Error");

                LoadDefaults();
            }
        }

        private void AddToHistory(string action, string value)
        {
            History history = new History();

            history.Hist_ID = GetHistoryId();
            history.Hist_Action = action;
            history.Hist_Value = value;

            historyList.Add(history);

            RefreshHistoryList();

        }

        private string GetHistoryAction(string op)
        {
            string action = "";

            switch (op)
            {
                case "+":
                    action = "Add";
                    break;
                case "-":
                    action = "Subtract";
                    break;
                case "*":
                    action = "Multiply";
                    break;
                case "/":
                    action = "Divide";
                    break;
                default:
                    break;
            }

            return action;
        }

        private int GetHistoryId()
        {
            int id = 0;

            id = historyList.Count + 1;

            return id;
        }

        private void InsertCharacter(string input)
        {
            string currentText = secondNumber_txtBox.Text;

            if (input == "." && currentText.Contains('.') && !operatorIsClicked)
                return;


            if (secondNumber_txtBox.Text == "0")
                secondNumber_txtBox.Text = input;
            else
            {
                if (operatorIsClicked)
                {
                    secondNumber_txtBox.Text = input;
                    textChanged = true;
                }
                else
                {
                    secondNumber_txtBox.Text += input;
                }

                operatorIsClicked = false;
            }
        }

        private void Delete()
        {
            string currentText = secondNumber_txtBox.Text;
            if (currentText.Length == 1)
                secondNumber_txtBox.Text = "0";
            else
            {
                if(currentText.Contains("-") && currentText.Length == 2)
                    secondNumber_txtBox.Text = "0";
                else
                    secondNumber_txtBox.Text = currentText.Remove(currentText.Length - 1, 1);
            }
        }

        private void ChangeSign()
        {
            string currentText = secondNumber_txtBox.Text;

            if (currentText != "0")
            {
                if (currentText[0] == '-')
                    secondNumber_txtBox.Text = currentText.Remove(0, 1);
                else
                    secondNumber_txtBox.Text = "-" + currentText;
            }
        }

        private decimal GetResult(decimal firstInput, string op, decimal secondInput)
        {
            decimal result = 0;
            try
            {

                switch (op)
                {
                    case "+":
                        {
                            result = Math.Round(firstInput + secondInput, 6, MidpointRounding.AwayFromZero);
                        }
                        break;
                    case "-":
                        {
                            result = Math.Round(firstInput - secondInput, 6, MidpointRounding.AwayFromZero);
                        }
                        break;
                    case "*":
                        {
                            result = Math.Round(firstInput * secondInput, 6, MidpointRounding.AwayFromZero);
                        }
                        break;
                    case "/":
                        {
                            result = Math.Round(firstInput / secondInput, 6, MidpointRounding.AwayFromZero);
                        }
                        break;
                    case "=":
                        {
                            result = GetResult(Convert.ToDecimal(firstInputPair.Key), firstInputPair.Value.ToString(), secondInput);
                        }
                        break;
                    default:
                        { }
                        break;

                }

            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow expection occured. Resetting..", "Error");

                LoadDefaults();

            }


            return result;
        }

        private void Export()
        {
            StreamWriter sw;
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Txt files (*.txt)|*.txt";

            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (sw = new StreamWriter(sfd.FileName, false))
                    {
                        foreach (var history in historyList)
                        {
                            sw.WriteLine(history.Hist_ID + "    " + history.Hist_Action + "    " + history.Hist_Value);
                        }

                        sw.Flush();
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("An error regarding the file occurred. Please try again.", "Error");

            }
        }

        private void Import()
        {
            historyList.Clear();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Txt files (*.txt)|*.txt";

            try
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] histories = File.ReadAllLines(ofd.FileName);

                    foreach (var history in histories)
                    {
                        var historySplit = history.Split("    ");
                        History newHistory = new History();
                        newHistory.Hist_ID = Convert.ToInt32(historySplit[0]);
                        newHistory.Hist_Action = historySplit[1];
                        newHistory.Hist_Value = historySplit[2];

                        historyList.Add(newHistory);
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The file is invalid. Please make sure its an exported history file or of the same format.", "Error");

            }

            RefreshHistoryList();
        }

        private void ClearTextBox()
        {  
            firstNumber_txtBox.Text = "";
            secondNumber_txtBox.Text = "0";
        }

        private void RefreshHistoryList()
        {
            history_listbox.Items.Clear();

            foreach (var history in historyList)
            {
                history_listbox.Items.Add(history.Hist_ID + "    " + history.Hist_Action + "    " + history.Hist_Value);
            }

            history_listbox.Refresh();

        }

        private void RefreshMemoryList()
        {
            memory_listbox.Items.Clear();

            memoryList.Reverse();
            foreach (var memory in memoryList)
            {
                memory_listbox.Items.Add(memory);
            }

            memory_listbox.Refresh();

            memoryList.Reverse();
        }

        private void LoadDefaults()
        {
            secondNumber_txtBox.Text = "0";
            firstNumber_txtBox.Text = "";

            clearSubMenu.Click += buttonActions;
            copySubMenu.Click += buttonActions;
            pasteSubMenu.Click += buttonActions;
            exitSubMenu.Click += buttonActions;
            exportSubMenu.Click += buttonActions;
            importSubMenu.Click += buttonActions;

            historyList.Clear();
            memoryList.Clear();
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    {
                        InsertCharacter("0");
                    }
                    break;
                case '1':
                    {
                        InsertCharacter("1");
                    }
                    break;
                case '2':
                    {
                        InsertCharacter("2");
                    }
                    break;
                case '3':
                    {
                        InsertCharacter("3");
                    }
                    break;
                case '4':
                    {
                        InsertCharacter("4");
                    }
                    break;
                case '5':
                    {
                        InsertCharacter("5");
                    }
                    break;
                case '6':
                    {
                        InsertCharacter("6");
                    }
                    break;
                case '7':
                    {
                        InsertCharacter("7");
                    }
                    break;
                case '8':
                    {
                        InsertCharacter("8");
                    }
                    break;
                case '9':
                    {
                        InsertCharacter("9");
                    }
                    break;
                case '+':
                    {
                        OperatorClicked("+");
                    }
                    break;
                case '-':
                    {
                        OperatorClicked("-");
                    }
                    break;
                case '*':
                    {
                        OperatorClicked("*");
                    }
                    break;
                case '/':
                    {
                        OperatorClicked("/");
                    }
                    break;
                case '\b':
                    {
                        Delete();
                    }
                    break;
                case '.':
                    {
                        InsertCharacter(".");
                    }
                    break;
                default:
                    { }
                    break;

            }
        }

    }
}
