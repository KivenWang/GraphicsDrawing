using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GraphicalCS
{
	/// <summary>
	/// newForm 的摘要说明。
	/// </summary>
	public class NewForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancle;
		private string OutPut;
		private bool boolvalue;
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.Button btnFont;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		public string outText
		{
			get
			{
				return OutPut;
			}
		}

		public Size txtSize
		{
			get
			{
				return new Size(this.txtBox.Font.Height*2*this.txtBox.Text.Length, this.txtBox.Font.Height);
			}
		}

		public Font TxtFont
		{
			get
			{
				return this.txtBox.Font;
			}
		}

		public bool cancle
		{
			get
			{
				return boolvalue;
			}
		}

		public NewForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
			this.txtBox.Focus();
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtBox = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.btnFont = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtBox
			// 
			this.txtBox.Location = new System.Drawing.Point(32, 32);
			this.txtBox.Name = "txtBox";
			this.txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtBox.Size = new System.Drawing.Size(160, 21);
			this.txtBox.TabIndex = 0;
			this.txtBox.Text = "";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(208, 32);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(56, 23);
			this.btnSubmit.TabIndex = 0;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(280, 32);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(56, 23);
			this.btnCancle.TabIndex = 1;
			this.btnCancle.Text = "Cancle";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// btnFont
			// 
			this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnFont.Location = new System.Drawing.Point(208, 64);
			this.btnFont.Name = "btnFont";
			this.btnFont.TabIndex = 2;
			this.btnFont.Text = "Font";
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// NewForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(344, 102);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtBox);
			this.Name = "NewForm";
			this.Text = "InputText";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			boolvalue = false;
			OutPut = this.txtBox.Text;
			this.Hide();
		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			boolvalue = true;
			this.Hide();
		}

		private void btnFont_Click(object sender, System.EventArgs e)
		{
			if(fontDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtBox.Font = fontDialog.Font;
			}
		}
	}
}
