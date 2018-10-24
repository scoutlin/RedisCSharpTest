namespace RedisTest
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.button_CreateRedis = new System.Windows.Forms.Button();
            this.button_StartWrite = new System.Windows.Forms.Button();
            this.button_StartRead = new System.Windows.Forms.Button();
            this.button_StartDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Start_SET = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CreateRedis
            // 
            this.button_CreateRedis.Location = new System.Drawing.Point(177, 21);
            this.button_CreateRedis.Name = "button_CreateRedis";
            this.button_CreateRedis.Size = new System.Drawing.Size(75, 75);
            this.button_CreateRedis.TabIndex = 0;
            this.button_CreateRedis.Text = "CreateRedis";
            this.button_CreateRedis.UseVisualStyleBackColor = true;
            this.button_CreateRedis.Click += new System.EventHandler(this.button_CreateRedis_Click);
            // 
            // button_StartWrite
            // 
            this.button_StartWrite.Enabled = false;
            this.button_StartWrite.Location = new System.Drawing.Point(258, 21);
            this.button_StartWrite.Name = "button_StartWrite";
            this.button_StartWrite.Size = new System.Drawing.Size(75, 75);
            this.button_StartWrite.TabIndex = 0;
            this.button_StartWrite.Text = "Start Write";
            this.button_StartWrite.UseVisualStyleBackColor = true;
            this.button_StartWrite.Click += new System.EventHandler(this.button_StartWrite_Click);
            // 
            // button_StartRead
            // 
            this.button_StartRead.Enabled = false;
            this.button_StartRead.Location = new System.Drawing.Point(339, 21);
            this.button_StartRead.Name = "button_StartRead";
            this.button_StartRead.Size = new System.Drawing.Size(75, 75);
            this.button_StartRead.TabIndex = 0;
            this.button_StartRead.Text = "Start Read";
            this.button_StartRead.UseVisualStyleBackColor = true;
            this.button_StartRead.Click += new System.EventHandler(this.button_StartRead_Click);
            // 
            // button_StartDelete
            // 
            this.button_StartDelete.Enabled = false;
            this.button_StartDelete.Location = new System.Drawing.Point(420, 21);
            this.button_StartDelete.Name = "button_StartDelete";
            this.button_StartDelete.Size = new System.Drawing.Size(75, 75);
            this.button_StartDelete.TabIndex = 1;
            this.button_StartDelete.Text = "Start Delete";
            this.button_StartDelete.UseVisualStyleBackColor = true;
            this.button_StartDelete.Click += new System.EventHandler(this.button_StartDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button_CreateRedis);
            this.groupBox1.Controls.Add(this.button_StartDelete);
            this.groupBox1.Controls.Add(this.button_StartWrite);
            this.groupBox1.Controls.Add(this.button_StartRead);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StackExchange.Redis_String";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuck Times";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ServerStack.Redis";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "CreateRedis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(249, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_StartDelete_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(87, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 0;
            this.button3.Text = "Start Write";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_StartWrite_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(168, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 0;
            this.button4.Text = "Start Read";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_StartRead_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "TestSet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test Set Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button_Start_SET);
            this.groupBox3.Location = new System.Drawing.Point(12, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 108);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "StackExchange.Redis_Set";
            // 
            // button_Start_SET
            // 
            this.button_Start_SET.Location = new System.Drawing.Point(177, 21);
            this.button_Start_SET.Name = "button_Start_SET";
            this.button_Start_SET.Size = new System.Drawing.Size(75, 75);
            this.button_Start_SET.TabIndex = 0;
            this.button_Start_SET.Text = "Start";
            this.button_Start_SET.UseVisualStyleBackColor = true;
            this.button_Start_SET.Click += new System.EventHandler(this.button_Start_SET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CreateRedis;
        private System.Windows.Forms.Button button_StartWrite;
        private System.Windows.Forms.Button button_StartRead;
        private System.Windows.Forms.Button button_StartDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Start_SET;
    }
}

