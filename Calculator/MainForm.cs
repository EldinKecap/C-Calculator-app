/*
 * Created by SharpDevelop.
 * User: Korisnik
 * Date: 6/24/2022
 * Time: 9:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{		
		Double resultValue = 0;
		String operationPerformed = "";
		bool isOperationPerformed = false;
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
		
	
		void Button1Click(object sender, EventArgs e)
		{	
			if((textbox_result.Text=="0")||(isOperationPerformed))textbox_result.Clear();
			Button button = (Button) sender;
			isOperationPerformed = false;
			if(button.Text == "."){
				if(!textbox_result.Text.Contains("."))textbox_result.Text = textbox_result.Text + button.Text;
			}else{
				textbox_result.Text = textbox_result.Text + button.Text;
			}
			
		}
		
		
		void operatorClilck(object sender, EventArgs e)
		{
			Button button =(Button) sender;
			if(resultValue != 0){
				button18.PerformClick();
				operationPerformed = button.Text;
			resultValue = Double.Parse(textbox_result.Text);
			labelCurrentOperation.Text = resultValue + " " + operationPerformed;
			isOperationPerformed = true;
			}else{
			operationPerformed = button.Text;
			resultValue = Double.Parse(textbox_result.Text);
			isOperationPerformed = true;
			labelCurrentOperation.Text = resultValue + " " + operationPerformed;
			}
			
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			textbox_result.Text = "0";
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			textbox_result.Text = "0";
			resultValue = 0;
		}
		
		void Button18Click(object sender, EventArgs e)
		{
			switch(operationPerformed){
				case "+":
					textbox_result.Text = (resultValue + Double.Parse(textbox_result.Text)).ToString();;
				break;
				case "-":
					textbox_result.Text = (resultValue - Double.Parse(textbox_result.Text)).ToString();;
				break;
				case "x":
					textbox_result.Text = (resultValue * Double.Parse(textbox_result.Text)).ToString();;
				break;
				case "/":
					textbox_result.Text = (resultValue / Double.Parse(textbox_result.Text)).ToString();;
				break;
			}
			resultValue = Double.Parse(textbox_result.Text);
			labelCurrentOperation.Text = "";
		}
	}
}
