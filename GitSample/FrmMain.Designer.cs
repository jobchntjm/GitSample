﻿namespace GitSample
{
    partial class FrmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.txtExpression1 = new System.Windows.Forms.TextBox();
            this.txtExpression2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label1.Location = new System.Drawing.Point(26, 18);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 43);
            label1.TabIndex = 0;
            label1.Text = "値１";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label2.Location = new System.Drawing.Point(436, 18);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 43);
            label2.TabIndex = 2;
            label2.Text = "値２";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label3.Location = new System.Drawing.Point(26, 304);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 43);
            label3.TabIndex = 4;
            label3.Text = "結果";
            // 
            // txtExpression1
            // 
            this.txtExpression1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtExpression1.Location = new System.Drawing.Point(35, 86);
            this.txtExpression1.Margin = new System.Windows.Forms.Padding(6);
            this.txtExpression1.Name = "txtExpression1";
            this.txtExpression1.Size = new System.Drawing.Size(346, 50);
            this.txtExpression1.TabIndex = 1;
            // 
            // txtExpression2
            // 
            this.txtExpression2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtExpression2.Location = new System.Drawing.Point(445, 86);
            this.txtExpression2.Margin = new System.Windows.Forms.Padding(6);
            this.txtExpression2.Name = "txtExpression2";
            this.txtExpression2.Size = new System.Drawing.Size(346, 50);
            this.txtExpression2.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(35, 372);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(756, 50);
            this.txtResult.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(61, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "＋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(216, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "ー";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(383, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 65);
            this.button3.TabIndex = 8;
            this.button3.Text = "×";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 482);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtExpression2);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtExpression1);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpression1;
        private System.Windows.Forms.TextBox txtExpression2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

