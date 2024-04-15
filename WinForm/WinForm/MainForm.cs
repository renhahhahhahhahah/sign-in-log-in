/*
 * Created by SharpDevelop.
 * User: ME
 * Date: 4/15/2024
 * Time: 2:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace WinForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		public static string UserName;
		public static string Pass;
		void SignUp(object sender, EventArgs e)
		{
			UserName = textBox1.Text;
			Pass = textBox2.Text;
			if (ConfirmPass.Text == Pass) {
				textBox1.Text = "";
			    textBox2.Text = "";
			    ConfirmPass.Text= "";
			}else{
			LabelError.Text = "Invalid Name or Password. Please try again";
			}
		}
		
		void Login(object sender, EventArgs e)
		{
			LoginPanel.Visible = true;
			LabelError.Visible = false;
		}
		
		void LoginPanelEnter(object sender, EventArgs e)
		{
			
		}
		
		void LogClick(object sender, EventArgs e)
		{
			if (LogName.Text == UserName && LogPass.Text == Pass) {
				LogLbl.Text = "Welcome ";
			}else{
				LogLbl.Text = "Incorrect Password or Name";
			}
		}
	}
}
