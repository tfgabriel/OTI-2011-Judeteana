namespace oti2011_judeteana
{
    partial class messengerForm
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
            ionelBtn = new Button();
            mariaBtn = new Button();
            deleteBtn = new Button();
            saveBtn = new Button();
            loadBtn = new Button();
            displaymsgRtb = new RichTextBox();
            entermsgRtb = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // ionelBtn
            // 
            ionelBtn.Location = new Point(50, 292);
            ionelBtn.Name = "ionelBtn";
            ionelBtn.Size = new Size(112, 72);
            ionelBtn.TabIndex = 0;
            ionelBtn.Text = "Ionel";
            ionelBtn.UseVisualStyleBackColor = true;
            ionelBtn.Click += ionelBtn_Click;
            // 
            // mariaBtn
            // 
            mariaBtn.Location = new Point(767, 292);
            mariaBtn.Name = "mariaBtn";
            mariaBtn.Size = new Size(112, 72);
            mariaBtn.TabIndex = 1;
            mariaBtn.Text = "Maria";
            mariaBtn.UseVisualStyleBackColor = true;
            mariaBtn.Click += mariaBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(351, 424);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(230, 35);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Sterge fereastra mesaje";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(50, 424);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(230, 35);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Salveaza mesaje";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(649, 424);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(230, 35);
            loadBtn.TabIndex = 4;
            loadBtn.Text = "Incarcare mesaje";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // displaymsgRtb
            // 
            displaymsgRtb.Location = new Point(50, 12);
            displaymsgRtb.Name = "displaymsgRtb";
            displaymsgRtb.Size = new Size(829, 249);
            displaymsgRtb.TabIndex = 5;
            displaymsgRtb.Text = "";
            // 
            // entermsgRtb
            // 
            entermsgRtb.Location = new Point(187, 294);
            entermsgRtb.Name = "entermsgRtb";
            entermsgRtb.Size = new Size(542, 70);
            entermsgRtb.TabIndex = 6;
            entermsgRtb.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Rich Text Format|*.rtf";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Rich Text Format|*.rtf";
            // 
            // messengerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 522);
            Controls.Add(entermsgRtb);
            Controls.Add(displaymsgRtb);
            Controls.Add(loadBtn);
            Controls.Add(saveBtn);
            Controls.Add(deleteBtn);
            Controls.Add(mariaBtn);
            Controls.Add(ionelBtn);
            Name = "messengerForm";
            Text = "MESSENGER";
            ResumeLayout(false);
        }

        #endregion

        private Button ionelBtn;
        private Button mariaBtn;
        private Button deleteBtn;
        private Button saveBtn;
        private Button loadBtn;
        private RichTextBox displaymsgRtb;
        private RichTextBox entermsgRtb;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
