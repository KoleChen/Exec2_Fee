using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			ResultFeeLabel.Text=String.Empty;
			ResultReasonLabel.Text=String.Empty;
		}

		private void CalButton_Click(object sender, EventArgs e)
		{
			int age;
			string gender;
			try
			{
				age = GetNumber();
				gender = GetGender();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			Check(gender, age);
		}

		private int GetNumber()
		{
			string input = InputAgeTextBox.Text;
			bool isInt = int.TryParse(input, out int age);
			if (isInt == false)
			{
				throw new Exception("請輸入年齡");
			}
			else if (isInt == true && age < 0)
			{
				throw new Exception("年紀不能為負數");
			}
			return age;
		}
		private string GetGender()
		{
			string gender;
			if (MaleRadioButton.Checked)
			{
				gender = "Male";
				return gender;
			}
			else if (FemaleRadioButton.Checked)
			{
				gender = "Female";
				return gender;
			}
			else 
			{
				throw new Exception("沒有選擇性別");
			}
			
		}
		private string Check(string gender, int age)
		{
			if (gender == "Male")
			{
				if (age<=3)
				{
					Reason("Male", age);
					return ResultFeeLabel.Text = "0";
				}
				else if (3<age && age<70)
				{
					Reason("Male", age);
					return ResultFeeLabel.Text = "15";
				}
				else 
				{
					Reason("Male", age);
					return ResultFeeLabel.Text = "2";
				}
			}
			else
			{
				if (age<=3)
				{
					Reason("Female", age);
					return ResultFeeLabel.Text = "0";
				}
				else if (3<age&&age<60)
				{
					Reason("Female", age);
					return ResultFeeLabel.Text = "15";
				}
				else 
				{
					Reason("Female", age);
					return ResultFeeLabel.Text = "3";
				}
			}
		}
		private string Reason(string gender, int age)
		{
			if (gender == "Male")
			{
				if (age<=3)
				{
					return ResultReasonLabel.Text = "未達3歲不用收費";
				}
				else if (3<age&&age<70)
				{
					return ResultReasonLabel.Text = "男性,全票";
				}
				else 
				{
					return ResultReasonLabel.Text = "超過七十歲男性";
				}
			}
			else 
			{
				if (age<=3)
				{
					return ResultReasonLabel.Text = "未達3歲不用收費";
				}
				else if (3<age&&age<60)
				{
					return ResultReasonLabel.Text = "女性,全票";
				}
				else 
				{
					return ResultReasonLabel.Text = "超過六十歲女性";
				}
			}
		}

	}
}
