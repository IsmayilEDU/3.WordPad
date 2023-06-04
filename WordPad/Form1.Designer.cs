namespace WordPad
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 349);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonFont
            // 
            this.buttonFont.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFont.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFont.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFont.Location = new System.Drawing.Point(30, 55);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(129, 38);
            this.buttonFont.TabIndex = 1;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = false;
            this.buttonFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFont_MouseClick);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonColor.Location = new System.Drawing.Point(218, 55);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(129, 38);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseClick);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(485, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 27);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSave_MouseClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Location = new System.Drawing.Point(673, 55);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(91, 27);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLoad_MouseClick);
            // 
            // labelFont
            // 
            this.labelFont.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFont.Location = new System.Drawing.Point(49, 19);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(125, 33);
            this.labelFont.TabIndex = 7;
            this.labelFont.Text = "Change font";
            // 
            // labelColor
            // 
            this.labelColor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelColor.Location = new System.Drawing.Point(231, 19);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(125, 33);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "Change color";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(497, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Save file";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(685, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Load file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Wordpad";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonFont;
        private Button buttonColor;
        private Button buttonSave;
        private Button buttonLoad;
        private Label labelFont;
        private Label labelColor;
        private Label label1;
        private Label label2;
    }
}