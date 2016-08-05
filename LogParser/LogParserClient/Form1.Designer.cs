namespace LogParserClient {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.tbStringToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEnvironment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File Path";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(118, 26);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(282, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(30, 110);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // tbStringToFind
            // 
            this.tbStringToFind.Location = new System.Drawing.Point(118, 52);
            this.tbStringToFind.Name = "tbStringToFind";
            this.tbStringToFind.Size = new System.Drawing.Size(282, 20);
            this.tbStringToFind.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "String to Find";
            // 
            // tbEnvironment
            // 
            this.tbEnvironment.Location = new System.Drawing.Point(118, 82);
            this.tbEnvironment.Name = "tbEnvironment";
            this.tbEnvironment.Size = new System.Drawing.Size(282, 20);
            this.tbEnvironment.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Environment";
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(30, 140);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(417, 235);
            this.rtbResults.TabIndex = 7;
            this.rtbResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 387);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.tbEnvironment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStringToFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(495, 426);
            this.MinimumSize = new System.Drawing.Size(495, 426);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox tbStringToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEnvironment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbResults;
    }
}

