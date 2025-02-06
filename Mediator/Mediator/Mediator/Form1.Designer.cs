namespace Mediator
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
            this.cmdSend1 = new System.Windows.Forms.Button();
            this.cmdSend2 = new System.Windows.Forms.Button();
            this.txtMediator = new System.Windows.Forms.TextBox();
            this.txtSend1 = new System.Windows.Forms.TextBox();
            this.txtSend2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSend1
            // 
            this.cmdSend1.Location = new System.Drawing.Point(12, 272);
            this.cmdSend1.Name = "cmdSend1";
            this.cmdSend1.Size = new System.Drawing.Size(75, 23);
            this.cmdSend1.TabIndex = 0;
            this.cmdSend1.Text = "Send ->";
            this.cmdSend1.UseVisualStyleBackColor = true;
            this.cmdSend1.Click += new System.EventHandler(this.cmdSend1_Click);
            // 
            // cmdSend2
            // 
            this.cmdSend2.Location = new System.Drawing.Point(205, 272);
            this.cmdSend2.Name = "cmdSend2";
            this.cmdSend2.Size = new System.Drawing.Size(75, 23);
            this.cmdSend2.TabIndex = 1;
            this.cmdSend2.Text = "<- Send";
            this.cmdSend2.UseVisualStyleBackColor = true;
            this.cmdSend2.Click += new System.EventHandler(this.cmdSend2_Click);
            // 
            // txtMediator
            // 
            this.txtMediator.Location = new System.Drawing.Point(12, 28);
            this.txtMediator.Multiline = true;
            this.txtMediator.Name = "txtMediator";
            this.txtMediator.Size = new System.Drawing.Size(268, 178);
            this.txtMediator.TabIndex = 2;
            // 
            // txtSend1
            // 
            this.txtSend1.Location = new System.Drawing.Point(12, 246);
            this.txtSend1.Name = "txtSend1";
            this.txtSend1.Size = new System.Drawing.Size(130, 20);
            this.txtSend1.TabIndex = 3;
            // 
            // txtSend2
            // 
            this.txtSend2.Location = new System.Drawing.Point(164, 246);
            this.txtSend2.Name = "txtSend2";
            this.txtSend2.Size = new System.Drawing.Size(116, 20);
            this.txtSend2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mediator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Colega2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Colega1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSend2);
            this.Controls.Add(this.txtSend1);
            this.Controls.Add(this.txtMediator);
            this.Controls.Add(this.cmdSend2);
            this.Controls.Add(this.cmdSend1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSend1;
        private System.Windows.Forms.Button cmdSend2;
        private System.Windows.Forms.TextBox txtMediator;
        private System.Windows.Forms.TextBox txtSend1;
        private System.Windows.Forms.TextBox txtSend2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

