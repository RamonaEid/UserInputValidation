namespace UIV.WinForms
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValidate = new System.Windows.Forms.Button();
            this.TextBoxInputString = new System.Windows.Forms.TextBox();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(24, 254);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(87, 23);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // TextBoxInputString
            // 
            this.TextBoxInputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInputString.Location = new System.Drawing.Point(24, 84);
            this.TextBoxInputString.Multiline = true;
            this.TextBoxInputString.Name = "TextBoxInputString";
            this.TextBoxInputString.Size = new System.Drawing.Size(116, 95);
            this.TextBoxInputString.TabIndex = 1;
            this.TextBoxInputString.Enter += new System.EventHandler(this.TextBoxInputString_Enter);
            // 
            // ResultListView
            // 
            this.ResultListView.BackColor = System.Drawing.Color.Bisque;
            this.ResultListView.Location = new System.Drawing.Point(269, 79);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(304, 221);
            this.ResultListView.TabIndex = 2;
            this.ResultListView.TileSize = new System.Drawing.Size(1, 1);
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.List;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(8, 197);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 26);
            this.ResultLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. Length: From 5 to 12 Alphanumeric characters\r\n2. At least one number and one l" +
    "etter\r\n3. No consecutive seqential repeating chracters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.TextBoxInputString);
            this.Controls.Add(this.btnValidate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(604, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(604, 350);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Input Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox TextBoxInputString;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label1;
    }
}

