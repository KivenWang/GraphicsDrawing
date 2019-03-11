using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GraphicalCS
{
	/// <summary>
	/// About 的摘要说明。
	/// </summary>
	public class About : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label NAME;
		private System.Windows.Forms.Label CopyRight;
		private System.Windows.Forms.LinkLabel EMail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label Athur;
		private System.Windows.Forms.PictureBox pictureBox;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public About()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(About));
			this.NAME = new System.Windows.Forms.Label();
			this.CopyRight = new System.Windows.Forms.Label();
			this.EMail = new System.Windows.Forms.LinkLabel();
			this.lblEmail = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.Athur = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// NAME
			// 
			this.NAME.Location = new System.Drawing.Point(88, 24);
			this.NAME.Name = "NAME";
			this.NAME.Size = new System.Drawing.Size(136, 16);
			this.NAME.TabIndex = 0;
			this.NAME.Text = "myPGS v1.0";
			// 
			// CopyRight
			// 
			this.CopyRight.Location = new System.Drawing.Point(88, 48);
			this.CopyRight.Name = "CopyRight";
			this.CopyRight.Size = new System.Drawing.Size(160, 16);
			this.CopyRight.TabIndex = 1;
			this.CopyRight.Text = "Copyright (C) 2004 PCH";
			// 
			// EMail
			// 
			this.EMail.Location = new System.Drawing.Point(80, 104);
			this.EMail.Name = "EMail";
			this.EMail.Size = new System.Drawing.Size(144, 23);
			this.EMail.TabIndex = 2;
			this.EMail.TabStop = true;
			this.EMail.Text = "tcpch@sohu.com";
			this.EMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EMail_LinkClicked);
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(32, 104);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(48, 23);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "E-Mail:";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(208, 136);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(64, 24);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// Athur
			// 
			this.Athur.Location = new System.Drawing.Point(88, 72);
			this.Athur.Name = "Athur";
			this.Athur.Size = new System.Drawing.Size(144, 23);
			this.Athur.TabIndex = 5;
			this.Athur.Text = "010678 庞池海";
			// 
			// pictureBox
			// 
			this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
			this.pictureBox.Location = new System.Drawing.Point(16, 24);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(48, 48);
			this.pictureBox.TabIndex = 6;
			this.pictureBox.TabStop = false;
			// 
			// About
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 174);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.Athur);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.EMail);
			this.Controls.Add(this.CopyRight);
			this.Controls.Add(this.NAME);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "About";
			this.Text = "About myPGS";
			this.ResumeLayout(false);

		}
		#endregion

		private void EMail_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:tcpch@sohu.com");
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
