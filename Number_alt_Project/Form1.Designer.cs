namespace Number_alt_Project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_q1 = new System.Windows.Forms.GroupBox();
            this.lbl_q1_output = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBox_q2 = new System.Windows.Forms.GroupBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_q2_result = new System.Windows.Forms.TextBox();
            this.txt_q2_out = new System.Windows.Forms.TextBox();
            this.lbl_q2_input = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_q2_out = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lbl_q2_details = new System.Windows.Forms.Label();
            this.lbl_q2_discription = new System.Windows.Forms.Label();
            this.grpBox_q1.SuspendLayout();
            this.grpBox_q2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Is 2^32 - 1 a prime number?";
            // 
            // grpBox_q1
            // 
            this.grpBox_q1.Controls.Add(this.lbl_q1_output);
            this.grpBox_q1.Controls.Add(this.button1);
            this.grpBox_q1.Controls.Add(this.label1);
            this.grpBox_q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_q1.Location = new System.Drawing.Point(12, 24);
            this.grpBox_q1.Name = "grpBox_q1";
            this.grpBox_q1.Size = new System.Drawing.Size(482, 94);
            this.grpBox_q1.TabIndex = 1;
            this.grpBox_q1.TabStop = false;
            this.grpBox_q1.Text = "Question 1";
            // 
            // lbl_q1_output
            // 
            this.lbl_q1_output.AutoSize = true;
            this.lbl_q1_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_q1_output.Location = new System.Drawing.Point(381, 37);
            this.lbl_q1_output.Name = "lbl_q1_output";
            this.lbl_q1_output.Size = new System.Drawing.Size(0, 20);
            this.lbl_q1_output.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(225, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBox_q2
            // 
            this.grpBox_q2.Controls.Add(this.lbl_result);
            this.grpBox_q2.Controls.Add(this.txt_q2_result);
            this.grpBox_q2.Controls.Add(this.txt_q2_out);
            this.grpBox_q2.Controls.Add(this.lbl_q2_input);
            this.grpBox_q2.Controls.Add(this.button2);
            this.grpBox_q2.Controls.Add(this.lbl_q2_out);
            this.grpBox_q2.Controls.Add(this.txt_input);
            this.grpBox_q2.Controls.Add(this.lbl_q2_details);
            this.grpBox_q2.Controls.Add(this.lbl_q2_discription);
            this.grpBox_q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBox_q2.Location = new System.Drawing.Point(12, 133);
            this.grpBox_q2.Name = "grpBox_q2";
            this.grpBox_q2.Size = new System.Drawing.Size(482, 367);
            this.grpBox_q2.TabIndex = 2;
            this.grpBox_q2.TabStop = false;
            this.grpBox_q2.Text = "Question 2";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(241, 137);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(111, 16);
            this.lbl_result.TabIndex = 8;
            this.lbl_result.Text = "Converted Result";
            // 
            // txt_q2_result
            // 
            this.txt_q2_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_q2_result.Location = new System.Drawing.Point(244, 159);
            this.txt_q2_result.Multiline = true;
            this.txt_q2_result.Name = "txt_q2_result";
            this.txt_q2_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_q2_result.Size = new System.Drawing.Size(232, 202);
            this.txt_q2_result.TabIndex = 7;
            // 
            // txt_q2_out
            // 
            this.txt_q2_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_q2_out.Location = new System.Drawing.Point(10, 159);
            this.txt_q2_out.Multiline = true;
            this.txt_q2_out.Name = "txt_q2_out";
            this.txt_q2_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_q2_out.Size = new System.Drawing.Size(228, 202);
            this.txt_q2_out.TabIndex = 6;
            // 
            // lbl_q2_input
            // 
            this.lbl_q2_input.AutoSize = true;
            this.lbl_q2_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_q2_input.Location = new System.Drawing.Point(27, 82);
            this.lbl_q2_input.Name = "lbl_q2_input";
            this.lbl_q2_input.Size = new System.Drawing.Size(130, 16);
            this.lbl_q2_input.TabIndex = 2;
            this.lbl_q2_input.Text = "Enter your text below";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(363, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_q2_out
            // 
            this.lbl_q2_out.AutoSize = true;
            this.lbl_q2_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_q2_out.Location = new System.Drawing.Point(27, 140);
            this.lbl_q2_out.Name = "lbl_q2_out";
            this.lbl_q2_out.Size = new System.Drawing.Size(85, 16);
            this.lbl_q2_out.TabIndex = 5;
            this.lbl_q2_out.Text = "Original Input";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(30, 108);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(273, 26);
            this.txt_input.TabIndex = 3;
            this.txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_KeyDown);
            // 
            // lbl_q2_details
            // 
            this.lbl_q2_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_q2_details.Location = new System.Drawing.Point(98, 45);
            this.lbl_q2_details.Name = "lbl_q2_details";
            this.lbl_q2_details.Size = new System.Drawing.Size(283, 37);
            this.lbl_q2_details.TabIndex = 1;
            this.lbl_q2_details.Text = "Enter some text and we will convert it to bits. Demo the n-bit ot n-bit block sub" +
    "stution";
            // 
            // lbl_q2_discription
            // 
            this.lbl_q2_discription.AutoSize = true;
            this.lbl_q2_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_q2_discription.Location = new System.Drawing.Point(97, 25);
            this.lbl_q2_discription.Name = "lbl_q2_discription";
            this.lbl_q2_discription.Size = new System.Drawing.Size(284, 20);
            this.lbl_q2_discription.TabIndex = 0;
            this.lbl_q2_discription.Text = "n-bit to n-bit Block Substitution Chipher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 512);
            this.Controls.Add(this.grpBox_q2);
            this.Controls.Add(this.grpBox_q1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions & Answers";
            this.grpBox_q1.ResumeLayout(false);
            this.grpBox_q1.PerformLayout();
            this.grpBox_q2.ResumeLayout(false);
            this.grpBox_q2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox_q1;
        private System.Windows.Forms.Label lbl_q1_output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpBox_q2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_q2_out;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lbl_q2_details;
        private System.Windows.Forms.Label lbl_q2_discription;
        private System.Windows.Forms.Label lbl_q2_input;
        private System.Windows.Forms.TextBox txt_q2_out;
        private System.Windows.Forms.TextBox txt_q2_result;
        private System.Windows.Forms.Label lbl_result;
    }
}

