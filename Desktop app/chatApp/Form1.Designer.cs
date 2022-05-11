namespace chatApp
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
            this.txt_mess = new System.Windows.Forms.TextBox();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_sendgroup = new System.Windows.Forms.Button();
            this.lb_mess = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_mess
            // 
            this.txt_mess.Location = new System.Drawing.Point(70, 50);
            this.txt_mess.Name = "txt_mess";
            this.txt_mess.Size = new System.Drawing.Size(100, 23);
            this.txt_mess.TabIndex = 0;
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(71, 87);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(100, 23);
            this.txt_group.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(184, 49);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(184, 88);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(75, 23);
            this.btn_join.TabIndex = 3;
            this.btn_join.Text = "join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_sendgroup
            // 
            this.btn_sendgroup.Location = new System.Drawing.Point(156, 127);
            this.btn_sendgroup.Name = "btn_sendgroup";
            this.btn_sendgroup.Size = new System.Drawing.Size(75, 23);
            this.btn_sendgroup.TabIndex = 4;
            this.btn_sendgroup.Text = "send to group";
            this.btn_sendgroup.UseVisualStyleBackColor = true;
            this.btn_sendgroup.Click += new System.EventHandler(this.btn_sendgroup_Click);
            // 
            // lb_mess
            // 
            this.lb_mess.FormattingEnabled = true;
            this.lb_mess.ItemHeight = 15;
            this.lb_mess.Location = new System.Drawing.Point(44, 207);
            this.lb_mess.Name = "lb_mess";
            this.lb_mess.Size = new System.Drawing.Size(509, 199);
            this.lb_mess.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.lb_mess);
            this.Controls.Add(this.btn_sendgroup);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.txt_mess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_mess;
        private TextBox txt_group;
        private Button btn_send;
        private Button btn_join;
        private Button btn_sendgroup;
        private ListBox lb_mess;
    }
}