
namespace Calculator
{
    partial class JCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.importSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.secondNumber_txtBox = new System.Windows.Forms.TextBox();
            this.memoryClear_btn = new System.Windows.Forms.Button();
            this.memoryRecall_btn = new System.Windows.Forms.Button();
            this.memoryAdd_btn = new System.Windows.Forms.Button();
            this.memorySubtract_btn = new System.Windows.Forms.Button();
            this.memoryStore_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.changeSign_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.decimalPoint_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.equals_btn = new System.Windows.Forms.Button();
            this.operator_cb = new System.Windows.Forms.ComboBox();
            this.firstNumber_txtBox = new System.Windows.Forms.TextBox();
            this.history_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memory_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.historyMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSubMenu,
            this.exitSubMenu});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // clearSubMenu
            // 
            this.clearSubMenu.Name = "clearSubMenu";
            this.clearSubMenu.Size = new System.Drawing.Size(101, 22);
            this.clearSubMenu.Tag = "clear";
            this.clearSubMenu.Text = "Clear";
            // 
            // exitSubMenu
            // 
            this.exitSubMenu.Name = "exitSubMenu";
            this.exitSubMenu.Size = new System.Drawing.Size(101, 22);
            this.exitSubMenu.Tag = "exit";
            this.exitSubMenu.Text = "Exit";
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySubMenu,
            this.pasteSubMenu});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            // 
            // copySubMenu
            // 
            this.copySubMenu.Name = "copySubMenu";
            this.copySubMenu.Size = new System.Drawing.Size(102, 22);
            this.copySubMenu.Tag = "copy";
            this.copySubMenu.Text = "Copy";
            // 
            // pasteSubMenu
            // 
            this.pasteSubMenu.Name = "pasteSubMenu";
            this.pasteSubMenu.Size = new System.Drawing.Size(102, 22);
            this.pasteSubMenu.Tag = "paste";
            this.pasteSubMenu.Text = "Paste";
            // 
            // historyMenuItem
            // 
            this.historyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSubMenu,
            this.importSubMenu});
            this.historyMenuItem.Name = "historyMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyMenuItem.Text = "History";
            // 
            // exportSubMenu
            // 
            this.exportSubMenu.Name = "exportSubMenu";
            this.exportSubMenu.Size = new System.Drawing.Size(149, 22);
            this.exportSubMenu.Tag = "export";
            this.exportSubMenu.Text = "Export To Text";
            // 
            // importSubMenu
            // 
            this.importSubMenu.Name = "importSubMenu";
            this.importSubMenu.Size = new System.Drawing.Size(165, 22);
            this.importSubMenu.Tag = "import";
            this.importSubMenu.Text = "Import From Text";
            // 
            // secondNumber_txtBox
            // 
            this.secondNumber_txtBox.Enabled = false;
            this.secondNumber_txtBox.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondNumber_txtBox.Location = new System.Drawing.Point(12, 56);
            this.secondNumber_txtBox.Name = "secondNumber_txtBox";
            this.secondNumber_txtBox.Size = new System.Drawing.Size(324, 38);
            this.secondNumber_txtBox.TabIndex = 2;
            this.secondNumber_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // memoryClear_btn
            // 
            this.memoryClear_btn.Location = new System.Drawing.Point(12, 100);
            this.memoryClear_btn.Name = "memoryClear_btn";
            this.memoryClear_btn.Size = new System.Drawing.Size(60, 23);
            this.memoryClear_btn.TabIndex = 3;
            this.memoryClear_btn.Tag = "mc";
            this.memoryClear_btn.Text = "MC";
            this.memoryClear_btn.UseVisualStyleBackColor = true;
            this.memoryClear_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // memoryRecall_btn
            // 
            this.memoryRecall_btn.Location = new System.Drawing.Point(78, 100);
            this.memoryRecall_btn.Name = "memoryRecall_btn";
            this.memoryRecall_btn.Size = new System.Drawing.Size(60, 23);
            this.memoryRecall_btn.TabIndex = 3;
            this.memoryRecall_btn.Tag = "mr";
            this.memoryRecall_btn.Text = "MR";
            this.memoryRecall_btn.UseVisualStyleBackColor = true;
            this.memoryRecall_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // memoryAdd_btn
            // 
            this.memoryAdd_btn.Location = new System.Drawing.Point(144, 100);
            this.memoryAdd_btn.Name = "memoryAdd_btn";
            this.memoryAdd_btn.Size = new System.Drawing.Size(60, 23);
            this.memoryAdd_btn.TabIndex = 3;
            this.memoryAdd_btn.Tag = "m+";
            this.memoryAdd_btn.Text = "M+";
            this.memoryAdd_btn.UseVisualStyleBackColor = true;
            this.memoryAdd_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // memorySubtract_btn
            // 
            this.memorySubtract_btn.Location = new System.Drawing.Point(210, 100);
            this.memorySubtract_btn.Name = "memorySubtract_btn";
            this.memorySubtract_btn.Size = new System.Drawing.Size(60, 23);
            this.memorySubtract_btn.TabIndex = 3;
            this.memorySubtract_btn.Tag = "m-";
            this.memorySubtract_btn.Text = "M-";
            this.memorySubtract_btn.UseVisualStyleBackColor = true;
            this.memorySubtract_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // memoryStore_btn
            // 
            this.memoryStore_btn.Location = new System.Drawing.Point(276, 100);
            this.memoryStore_btn.Name = "memoryStore_btn";
            this.memoryStore_btn.Size = new System.Drawing.Size(60, 23);
            this.memoryStore_btn.TabIndex = 3;
            this.memoryStore_btn.Tag = "ms";
            this.memoryStore_btn.Text = "MS";
            this.memoryStore_btn.UseVisualStyleBackColor = true;
            this.memoryStore_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(210, 128);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(126, 36);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Tag = "delete";
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // seven_btn
            // 
            this.seven_btn.Location = new System.Drawing.Point(12, 128);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(60, 36);
            this.seven_btn.TabIndex = 3;
            this.seven_btn.Tag = "input";
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = true;
            this.seven_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // eight_btn
            // 
            this.eight_btn.Location = new System.Drawing.Point(78, 128);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(60, 36);
            this.eight_btn.TabIndex = 3;
            this.eight_btn.Tag = "input";
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = true;
            this.eight_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // nine_btn
            // 
            this.nine_btn.Location = new System.Drawing.Point(144, 128);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(60, 36);
            this.nine_btn.TabIndex = 3;
            this.nine_btn.Tag = "input";
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = true;
            this.nine_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // four_btn
            // 
            this.four_btn.Location = new System.Drawing.Point(12, 170);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(60, 36);
            this.four_btn.TabIndex = 3;
            this.four_btn.Tag = "input";
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = true;
            this.four_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // five_btn
            // 
            this.five_btn.Location = new System.Drawing.Point(78, 170);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(60, 36);
            this.five_btn.TabIndex = 3;
            this.five_btn.Tag = "input";
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = true;
            this.five_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // six_btn
            // 
            this.six_btn.Location = new System.Drawing.Point(144, 170);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(60, 36);
            this.six_btn.TabIndex = 3;
            this.six_btn.Tag = "input";
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = true;
            this.six_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // one_btn
            // 
            this.one_btn.Location = new System.Drawing.Point(12, 212);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(60, 36);
            this.one_btn.TabIndex = 3;
            this.one_btn.Tag = "input";
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = true;
            this.one_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // two_btn
            // 
            this.two_btn.Location = new System.Drawing.Point(78, 212);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(60, 36);
            this.two_btn.TabIndex = 3;
            this.two_btn.Tag = "input";
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = true;
            this.two_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // three_btn
            // 
            this.three_btn.Location = new System.Drawing.Point(144, 212);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(60, 36);
            this.three_btn.TabIndex = 3;
            this.three_btn.Tag = "input";
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = true;
            this.three_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // changeSign_btn
            // 
            this.changeSign_btn.Location = new System.Drawing.Point(12, 254);
            this.changeSign_btn.Name = "changeSign_btn";
            this.changeSign_btn.Size = new System.Drawing.Size(60, 36);
            this.changeSign_btn.TabIndex = 3;
            this.changeSign_btn.Tag = "+-";
            this.changeSign_btn.Text = "+/-";
            this.changeSign_btn.UseVisualStyleBackColor = true;
            this.changeSign_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // zero_btn
            // 
            this.zero_btn.Location = new System.Drawing.Point(78, 254);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(60, 36);
            this.zero_btn.TabIndex = 3;
            this.zero_btn.Tag = "input";
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = true;
            this.zero_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // decimalPoint_btn
            // 
            this.decimalPoint_btn.Location = new System.Drawing.Point(144, 254);
            this.decimalPoint_btn.Name = "decimalPoint_btn";
            this.decimalPoint_btn.Size = new System.Drawing.Size(60, 36);
            this.decimalPoint_btn.TabIndex = 3;
            this.decimalPoint_btn.Tag = "input";
            this.decimalPoint_btn.Text = ".";
            this.decimalPoint_btn.UseVisualStyleBackColor = true;
            this.decimalPoint_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(210, 170);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(126, 36);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Tag = "clear";
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // equals_btn
            // 
            this.equals_btn.Location = new System.Drawing.Point(210, 254);
            this.equals_btn.Name = "equals_btn";
            this.equals_btn.Size = new System.Drawing.Size(126, 36);
            this.equals_btn.TabIndex = 3;
            this.equals_btn.Tag = "=";
            this.equals_btn.Text = "=";
            this.equals_btn.UseVisualStyleBackColor = true;
            this.equals_btn.Click += new System.EventHandler(this.buttonActions);
            // 
            // operator_cb
            // 
            this.operator_cb.DropDownHeight = 110;
            this.operator_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operator_cb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operator_cb.FormattingEnabled = true;
            this.operator_cb.IntegralHeight = false;
            this.operator_cb.Items.AddRange(new object[] {
            " + Add",
            " - Subtract",
            " * Multiply",
            " / Divide"});
            this.operator_cb.Location = new System.Drawing.Point(210, 212);
            this.operator_cb.Name = "operator_cb";
            this.operator_cb.Size = new System.Drawing.Size(126, 36);
            this.operator_cb.TabIndex = 5;
            this.operator_cb.SelectedIndexChanged += new System.EventHandler(this.operator_cb_SelectedIndexChanged);
            // 
            // firstNumber_txtBox
            // 
            this.firstNumber_txtBox.Enabled = false;
            this.firstNumber_txtBox.Location = new System.Drawing.Point(12, 27);
            this.firstNumber_txtBox.Name = "firstNumber_txtBox";
            this.firstNumber_txtBox.Size = new System.Drawing.Size(324, 23);
            this.firstNumber_txtBox.TabIndex = 6;
            this.firstNumber_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // history_listbox
            // 
            this.history_listbox.FormattingEnabled = true;
            this.history_listbox.ItemHeight = 15;
            this.history_listbox.Location = new System.Drawing.Point(353, 57);
            this.history_listbox.Name = "history_listbox";
            this.history_listbox.Size = new System.Drawing.Size(164, 229);
            this.history_listbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "History List";
            // 
            // memory_listbox
            // 
            this.memory_listbox.FormattingEnabled = true;
            this.memory_listbox.ItemHeight = 15;
            this.memory_listbox.Location = new System.Drawing.Point(529, 57);
            this.memory_listbox.Name = "memory_listbox";
            this.memory_listbox.Size = new System.Drawing.Size(164, 229);
            this.memory_listbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Memory Trail";
            // 
            // JCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memory_listbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.history_listbox);
            this.Controls.Add(this.firstNumber_txtBox);
            this.Controls.Add(this.operator_cb);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.memoryStore_btn);
            this.Controls.Add(this.memorySubtract_btn);
            this.Controls.Add(this.memoryAdd_btn);
            this.Controls.Add(this.memoryRecall_btn);
            this.Controls.Add(this.nine_btn);
            this.Controls.Add(this.eight_btn);
            this.Controls.Add(this.equals_btn);
            this.Controls.Add(this.decimalPoint_btn);
            this.Controls.Add(this.three_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.six_btn);
            this.Controls.Add(this.zero_btn);
            this.Controls.Add(this.two_btn);
            this.Controls.Add(this.five_btn);
            this.Controls.Add(this.changeSign_btn);
            this.Controls.Add(this.one_btn);
            this.Controls.Add(this.four_btn);
            this.Controls.Add(this.seven_btn);
            this.Controls.Add(this.memoryClear_btn);
            this.Controls.Add(this.secondNumber_txtBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 344);
            this.MinimumSize = new System.Drawing.Size(723, 344);
            this.Name = "JCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCalculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSubMenu;
        private System.Windows.Forms.ToolStripMenuItem exitSubMenu;
        private System.Windows.Forms.ToolStripMenuItem copySubMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteSubMenu;
        private System.Windows.Forms.ToolStripMenuItem exportSubMenu;
        private System.Windows.Forms.ToolStripMenuItem importSubMenu;
        private System.Windows.Forms.TextBox secondNumber_txtBox;
        private System.Windows.Forms.Button memoryClear_btn;
        private System.Windows.Forms.Button memoryRecall_btn;
        private System.Windows.Forms.Button memoryAdd_btn;
        private System.Windows.Forms.Button memorySubtract_btn;
        private System.Windows.Forms.Button memoryStore_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button changeSign_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button decimalPoint_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button equals_btn;
        private System.Windows.Forms.ComboBox operator_cb;
        private System.Windows.Forms.TextBox firstNumber_txtBox;
        private System.Windows.Forms.ListBox history_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox memory_listbox;
        private System.Windows.Forms.Label label2;
    }
}

