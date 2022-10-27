namespace Exec2_Fee
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.InputAgeTextBox = new System.Windows.Forms.TextBox();
			this.CalButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.MaleRadioButton = new System.Windows.Forms.RadioButton();
			this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ResultFeeLabel = new System.Windows.Forms.Label();
			this.ResultReasonLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.FemaleRadioButton);
			this.groupBox1.Controls.Add(this.MaleRadioButton);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.CalButton);
			this.groupBox1.Controls.Add(this.InputAgeTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(59, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(410, 157);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "客戶資訊";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ResultReasonLabel);
			this.groupBox2.Controls.Add(this.ResultFeeLabel);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(59, 223);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(411, 137);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "計算結果";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(26, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "年齡";
			// 
			// InputAgeTextBox
			// 
			this.InputAgeTextBox.Location = new System.Drawing.Point(71, 28);
			this.InputAgeTextBox.Name = "InputAgeTextBox";
			this.InputAgeTextBox.Size = new System.Drawing.Size(100, 22);
			this.InputAgeTextBox.TabIndex = 1;
			// 
			// CalButton
			// 
			this.CalButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.CalButton.Location = new System.Drawing.Point(61, 78);
			this.CalButton.Name = "CalButton";
			this.CalButton.Size = new System.Drawing.Size(93, 27);
			this.CalButton.TabIndex = 2;
			this.CalButton.Text = "計算";
			this.CalButton.UseVisualStyleBackColor = true;
			this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(213, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "性別";
			// 
			// MaleRadioButton
			// 
			this.MaleRadioButton.AutoSize = true;
			this.MaleRadioButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.MaleRadioButton.Location = new System.Drawing.Point(256, 30);
			this.MaleRadioButton.Name = "MaleRadioButton";
			this.MaleRadioButton.Size = new System.Drawing.Size(41, 20);
			this.MaleRadioButton.TabIndex = 4;
			this.MaleRadioButton.Tag = "1";
			this.MaleRadioButton.Text = "男";
			this.MaleRadioButton.UseVisualStyleBackColor = true;
			// 
			// FemaleRadioButton
			// 
			this.FemaleRadioButton.AutoSize = true;
			this.FemaleRadioButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FemaleRadioButton.Location = new System.Drawing.Point(303, 30);
			this.FemaleRadioButton.Name = "FemaleRadioButton";
			this.FemaleRadioButton.Size = new System.Drawing.Size(41, 20);
			this.FemaleRadioButton.TabIndex = 6;
			this.FemaleRadioButton.Tag = "2";
			this.FemaleRadioButton.Text = "女";
			this.FemaleRadioButton.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(28, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "車資";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(28, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "原因";
			// 
			// ResultFeeLabel
			// 
			this.ResultFeeLabel.AutoSize = true;
			this.ResultFeeLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ResultFeeLabel.Location = new System.Drawing.Point(83, 40);
			this.ResultFeeLabel.Name = "ResultFeeLabel";
			this.ResultFeeLabel.Size = new System.Drawing.Size(71, 16);
			this.ResultFeeLabel.TabIndex = 2;
			this.ResultFeeLabel.Text = "顯示車資";
			// 
			// ResultReasonLabel
			// 
			this.ResultReasonLabel.AutoSize = true;
			this.ResultReasonLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ResultReasonLabel.Location = new System.Drawing.Point(85, 88);
			this.ResultReasonLabel.Name = "ResultReasonLabel";
			this.ResultReasonLabel.Size = new System.Drawing.Size(71, 16);
			this.ResultReasonLabel.TabIndex = 3;
			this.ResultReasonLabel.Text = "顯示原因";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 386);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "計算車資";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton FemaleRadioButton;
		private System.Windows.Forms.RadioButton MaleRadioButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button CalButton;
		private System.Windows.Forms.TextBox InputAgeTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label ResultReasonLabel;
		private System.Windows.Forms.Label ResultFeeLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
	}
}

