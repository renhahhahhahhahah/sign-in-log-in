/*
 * Created by SharpDevelop.
 * User: ME
 * Date: 4/15/2024
 * Time: 2:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WinForm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.ConfirmPass = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.LoginPanel = new System.Windows.Forms.GroupBox();
			this.LogLbl = new System.Windows.Forms.Label();
			this.Log = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LogPass = new System.Windows.Forms.TextBox();
			this.LogName = new System.Windows.Forms.TextBox();
			this.LabelError = new System.Windows.Forms.Label();
			this.LoginPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.AccessibleName = "BtnLogin";
			this.button1.Location = new System.Drawing.Point(571, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Login);
			// 
			// textBox1
			// 
			this.textBox1.AccessibleName = "TxtBxName";
			this.textBox1.Location = new System.Drawing.Point(251, 85);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(281, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.AccessibleName = "TxtBxPass";
			this.textBox2.Location = new System.Drawing.Point(251, 124);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '•';
			this.textBox2.Size = new System.Drawing.Size(281, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Azure;
			this.label1.Location = new System.Drawing.Point(251, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Password
			// 
			this.Password.BackColor = System.Drawing.Color.Azure;
			this.Password.Location = new System.Drawing.Point(251, 108);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(100, 16);
			this.Password.TabIndex = 4;
			this.Password.Text = "Password";
			// 
			// button2
			// 
			this.button2.AccessibleName = "BtnSignUp";
			this.button2.Location = new System.Drawing.Point(357, 196);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Sign up";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.SignUp);
			// 
			// ConfirmPass
			// 
			this.ConfirmPass.AccessibleName = "ConfirmPass";
			this.ConfirmPass.Location = new System.Drawing.Point(251, 160);
			this.ConfirmPass.Name = "ConfirmPass";
			this.ConfirmPass.PasswordChar = '•';
			this.ConfirmPass.Size = new System.Drawing.Size(281, 20);
			this.ConfirmPass.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Azure;
			this.label5.Location = new System.Drawing.Point(251, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Confirm Password";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Azure;
			this.label6.Location = new System.Drawing.Point(357, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Sign Up";
			// 
			// LoginPanel
			// 
			this.LoginPanel.AccessibleName = "LogInPanel";
			this.LoginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPanel.BackgroundImage")));
			this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.LoginPanel.Controls.Add(this.LogLbl);
			this.LoginPanel.Controls.Add(this.Log);
			this.LoginPanel.Controls.Add(this.label4);
			this.LoginPanel.Controls.Add(this.label3);
			this.LoginPanel.Controls.Add(this.LogPass);
			this.LoginPanel.Controls.Add(this.LogName);
			this.LoginPanel.Location = new System.Drawing.Point(184, 12);
			this.LoginPanel.Name = "LoginPanel";
			this.LoginPanel.Size = new System.Drawing.Size(462, 226);
			this.LoginPanel.TabIndex = 11;
			this.LoginPanel.TabStop = false;
			this.LoginPanel.Text = "Log In";
			this.LoginPanel.Visible = false;
			this.LoginPanel.Enter += new System.EventHandler(this.LoginPanelEnter);
			// 
			// LogLbl
			// 
			this.LogLbl.AccessibleName = "LogLbl";
			this.LogLbl.BackColor = System.Drawing.Color.Azure;
			this.LogLbl.Location = new System.Drawing.Point(163, 171);
			this.LogLbl.Name = "LogLbl";
			this.LogLbl.Size = new System.Drawing.Size(166, 23);
			this.LogLbl.TabIndex = 5;
			this.LogLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Log
			// 
			this.Log.AccessibleName = "Log";
			this.Log.Location = new System.Drawing.Point(198, 146);
			this.Log.Name = "Log";
			this.Log.Size = new System.Drawing.Size(101, 23);
			this.Log.TabIndex = 4;
			this.Log.Text = "Login";
			this.Log.UseVisualStyleBackColor = true;
			this.Log.Click += new System.EventHandler(this.LogClick);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Azure;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(123, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Azure;
			this.label3.Location = new System.Drawing.Point(123, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// LogPass
			// 
			this.LogPass.AccessibleName = "LogPass";
			this.LogPass.Location = new System.Drawing.Point(123, 112);
			this.LogPass.Name = "LogPass";
			this.LogPass.PasswordChar = '•';
			this.LogPass.Size = new System.Drawing.Size(251, 20);
			this.LogPass.TabIndex = 1;
			// 
			// LogName
			// 
			this.LogName.AccessibleName = "LoginName";
			this.LogName.Location = new System.Drawing.Point(123, 73);
			this.LogName.Name = "LogName";
			this.LogName.Size = new System.Drawing.Size(251, 20);
			this.LogName.TabIndex = 0;
			// 
			// LabelError
			// 
			this.LabelError.AccessibleName = "LabelError";
			this.LabelError.BackColor = System.Drawing.Color.MintCream;
			this.LabelError.Location = new System.Drawing.Point(316, 241);
			this.LabelError.Name = "LabelError";
			this.LabelError.Size = new System.Drawing.Size(197, 17);
			this.LabelError.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AccessibleName = "InterFace";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(773, 260);
			this.Controls.Add(this.LabelError);
			this.Controls.Add(this.LoginPanel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ConfirmPass);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "WinForm";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.LoginPanel.ResumeLayout(false);
			this.LoginPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label LogLbl;
		private System.Windows.Forms.Button Log;
		private System.Windows.Forms.Label LabelError;
		private System.Windows.Forms.TextBox LogName;
		private System.Windows.Forms.TextBox LogPass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox LoginPanel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ConfirmPass;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		
	}
}
