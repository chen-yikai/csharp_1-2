namespace _1_2
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
            this.showDate = new System.Windows.Forms.Button();
            this.showText = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.center = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.greenbg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showDate
            // 
            this.showDate.Font = new System.Drawing.Font("新細明體", 15F);
            this.showDate.Location = new System.Drawing.Point(42, 188);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(162, 49);
            this.showDate.TabIndex = 0;
            this.showDate.Text = "顯示日期時間";
            this.showDate.UseVisualStyleBackColor = true;
            this.showDate.Click += new System.EventHandler(this.button1_Click);
            // 
            // showText
            // 
            this.showText.Font = new System.Drawing.Font("新細明體", 15F);
            this.showText.Location = new System.Drawing.Point(210, 188);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(116, 49);
            this.showText.TabIndex = 1;
            this.showText.Text = "顯示文字";
            this.showText.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("新細明體", 15F);
            this.left.Location = new System.Drawing.Point(332, 188);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(101, 49);
            this.left.TabIndex = 2;
            this.left.Text = "靠左";
            this.left.UseVisualStyleBackColor = true;
            // 
            // center
            // 
            this.center.Font = new System.Drawing.Font("新細明體", 15F);
            this.center.Location = new System.Drawing.Point(439, 188);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(101, 49);
            this.center.TabIndex = 3;
            this.center.Text = "置中";
            this.center.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("新細明體", 15F);
            this.right.Location = new System.Drawing.Point(546, 188);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(101, 49);
            this.right.TabIndex = 4;
            this.right.Text = "靠右";
            this.right.UseVisualStyleBackColor = true;
            // 
            // greenbg
            // 
            this.greenbg.Font = new System.Drawing.Font("新細明體", 15F);
            this.greenbg.Location = new System.Drawing.Point(42, 243);
            this.greenbg.Name = "greenbg";
            this.greenbg.Size = new System.Drawing.Size(162, 49);
            this.greenbg.TabIndex = 5;
            this.greenbg.Text = "綠色標籤背景";
            this.greenbg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greenbg);
            this.Controls.Add(this.right);
            this.Controls.Add(this.center);
            this.Controls.Add(this.left);
            this.Controls.Add(this.showText);
            this.Controls.Add(this.showDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showDate;
        private System.Windows.Forms.Button showText;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button center;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button greenbg;
    }
}

