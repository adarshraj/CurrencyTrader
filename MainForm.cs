/*
 * Created by SharpDevelop.
 * User: Ads
 * Date: 5/10/2008
 * Time: 8:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CurrencyTrader
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
		
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
			double exchangeRate = Convert.ToDouble(textBox1.Text);
			//double fromCurrency = Convert.ToDouble(textBox2.Text);
			string fromCurrency = textBox2.Text;
			string toCurrency = textBox3.Text;

			ActiveCurrencyTrader act = new ActiveCurrencyTrader(exchangeRate,fromCurrency,toCurrency);

            if (textBox3.ReadOnly == true)
				textBox3.Text = Convert.ToString(act.ConvertTo(Convert.ToDouble(textBox2.Text)));
			else
				textBox2.Text = Convert.ToString(act.ConvertFrom(Convert.ToDouble(textBox3.Text)));
			}
			catch(Exception)
			{
				MessageBox.Show("Enter Proper Details");
			}	
		}
		
		
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				textBox2.ReadOnly = true;
				textBox3.ReadOnly = false;
			}
			else
			{
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = true;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			textBox3.ReadOnly = true;
		}
	}
}
