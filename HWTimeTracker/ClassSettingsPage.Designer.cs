namespace Names
{
    partial class ClassSettingsPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            class1 = new Button();
            delete1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 38);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(162, 65);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(287, 259);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // class1
            // 
            class1.Location = new Point(44, 76);
            class1.Margin = new Padding(3, 2, 3, 2);
            class1.Name = "class1";
            class1.Size = new Size(82, 22);
            class1.TabIndex = 21;
            class1.Text = "Enter";
            class1.UseVisualStyleBackColor = true;
            class1.Click += btnAdd_Click;
            // 
            // delete1
            // 
            delete1.Location = new Point(211, 37);
            delete1.Margin = new Padding(3, 2, 3, 2);
            delete1.Name = "delete1";
            delete1.Size = new Size(82, 22);
            delete1.TabIndex = 31;
            delete1.Text = "Delete";
            delete1.UseVisualStyleBackColor = true;
            delete1.Click += delete1_Click;
            // 
            // ClassSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(class1);
            Controls.Add(listBox1);
            Controls.Add(delete1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClassSettingsPage";
            Size = new Size(1446, 775);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private OpenFileDialog openFileDialog1;
        private Button class1;
        private Button delete1;
    }
}
