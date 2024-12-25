using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SosninFM.Sprint7.Project.V3
{
	public partial class FormAbout_SFM : Form
	{
		public FormAbout_SFM()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAbout_SFM));
			textBoxAboutMe_SFM = new TextBox();
			buttonAboutMe_SFM = new Button();
			pictureBoxAboutMe_SFM = new PictureBox();
			((ISupportInitialize)pictureBoxAboutMe_SFM).BeginInit();
			SuspendLayout();
			// 
			// textBoxAboutMe_SFM
			// 
			textBoxAboutMe_SFM.BackColor = SystemColors.GradientInactiveCaption;
			textBoxAboutMe_SFM.Location = new Point(245, 26);
			textBoxAboutMe_SFM.Multiline = true;
			textBoxAboutMe_SFM.Name = "textBoxAboutMe_SFM";
			textBoxAboutMe_SFM.Size = new Size(399, 283);
			textBoxAboutMe_SFM.TabIndex = 0;
			textBoxAboutMe_SFM.Text = resources.GetString("textBoxAboutMe_SFM.Text");
			// 
			// buttonAboutMe_SFM
			// 
			buttonAboutMe_SFM.BackColor = SystemColors.GradientActiveCaption;
			buttonAboutMe_SFM.Location = new Point(563, 327);
			buttonAboutMe_SFM.Name = "buttonAboutMe_SFM";
			buttonAboutMe_SFM.Size = new Size(81, 34);
			buttonAboutMe_SFM.TabIndex = 1;
			buttonAboutMe_SFM.Text = "О К";
			buttonAboutMe_SFM.UseVisualStyleBackColor = false;
			buttonAboutMe_SFM.Click += buttonAboutMe_SFM_Click;
			// 
			// pictureBoxAboutMe_SFM
			// 
			pictureBoxAboutMe_SFM.Image = (Image)resources.GetObject("pictureBoxAboutMe_SFM.Image");
			pictureBoxAboutMe_SFM.Location = new Point(25, 36);
			pictureBoxAboutMe_SFM.Name = "pictureBoxAboutMe_SFM";
			pictureBoxAboutMe_SFM.Size = new Size(196, 257);
			pictureBoxAboutMe_SFM.TabIndex = 2;
			pictureBoxAboutMe_SFM.TabStop = false;
			pictureBoxAboutMe_SFM.Click += pictureBox1_Click;
			// 
			// FormAbout_SFM
			// 
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(667, 373);
			Controls.Add(pictureBoxAboutMe_SFM);
			Controls.Add(buttonAboutMe_SFM);
			Controls.Add(textBoxAboutMe_SFM);
			Name = "FormAbout_SFM";
			Text = "О программе";
			((ISupportInitialize)pictureBoxAboutMe_SFM).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void buttonAboutMe_SFM_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
