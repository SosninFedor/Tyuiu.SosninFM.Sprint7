namespace Tyuiu.SosninFM.Sprint7.Project.V3
{
	partial class FormMain_SFM
	{
		private System.ComponentModel.IContainer components = null;	
		private ToolTip toolTipHelp;
		private ListBox listBoxResult_SFM;
		private Button buttonSearch_SFM;
		private Button buttonHelp_SFM; // Добавлена кнопка "Справка"
		private TextBox textBoxInput_SFM;
		private TextBox textBoxNameProject_SFM;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Chart chartStatistics; // Добавлен элемент Chart

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			buttonHelp_SFM = new Button();
			toolTipHelp = new ToolTip(components);
			listBoxResult_SFM = new ListBox();
			buttonSearch_SFM = new Button();
			buttonHelp_SFM = new Button(); // Инициализация кнопки "Справка"
			textBoxInput_SFM = new TextBox();
			textBoxNameProject_SFM = new TextBox();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			chartStatistics = new Chart(); // Инициализация Chart
			((System.ComponentModel.ISupportInitialize)chartStatistics).BeginInit();
			SuspendLayout();

			// buttonHelp_SFM
			buttonHelp_SFM.BackColor = System.Drawing.Color.White;
			buttonHelp_SFM.Location = new System.Drawing.Point(1521, 8);
				buttonHelp_SFM.Margin = new Padding(3, 2, 3, 2);
			buttonHelp_SFM.Name = "buttonHelp_SFM";
			buttonHelp_SFM.Size = new System.Drawing.Size(70, 59);
			buttonHelp_SFM.TabIndex = 0;
			buttonHelp_SFM.Text = "Справка";
			buttonHelp_SFM.TextImageRelation = TextImageRelation.ImageAboveText;
			buttonHelp_SFM.UseVisualStyleBackColor = false;
			buttonHelp_SFM.Click += buttonMain_SFM_Click;

			// toolTipHelp
			toolTipHelp.ToolTipIcon = ToolTipIcon.Info;
			toolTipHelp.ToolTipTitle = "Сведение о программе";

			// listBoxResult_SFM
			listBoxResult_SFM.BorderStyle = BorderStyle.None;
			listBoxResult_SFM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			listBoxResult_SFM.ForeColor = SystemColors.InactiveCaptionText;
			listBoxResult_SFM.FormattingEnabled = true;
			listBoxResult_SFM.ItemHeight = 21;
			listBoxResult_SFM.Location = new System.Drawing.Point(10, 230);
			listBoxResult_SFM.Margin = new Padding(3, 2, 3, 2);
			listBoxResult_SFM.Name = "listBoxResult_SFM";
			listBoxResult_SFM.Size = new System.Drawing.Size(1580, 42);
			listBoxResult_SFM.TabIndex = 3;
			listBoxResult_SFM.SelectedIndexChanged += listBoxResult_SFM_SelectedIndexChanged;

			// buttonSearch_SFM
			buttonSearch_SFM.Location = new System.Drawing.Point(590, 144);
			buttonSearch_SFM.Margin = new Padding(3, 2, 3, 2);
			buttonSearch_SFM.Name = "buttonSearch_SFM";
			buttonSearch_SFM.Size = new System.Drawing.Size(100, 36);
			buttonSearch_SFM.TabIndex = 4;
			buttonSearch_SFM.Text = "Поиск";
			buttonSearch_SFM.UseVisualStyleBackColor = true;
			buttonSearch_SFM.Click += buttonSearch_SFM_Click;
			// buttonHelp_SFM
			buttonHelp_SFM.Location = new System.Drawing.Point(700, 144); // Расположение кнопки "Справка"
			buttonHelp_SFM.Margin = new Padding(3, 2, 3, 2);
			buttonHelp_SFM.Name = "buttonHelp_SFM";
			buttonHelp_SFM.Size = new System.Drawing.Size(100, 36);
			buttonHelp_SFM.TabIndex = 5;
			buttonHelp_SFM.Text = "Справка";
			buttonHelp_SFM.UseVisualStyleBackColor = true;
			buttonHelp_SFM.Click += buttonHelp_SFM_Click;

			// textBoxInput_SFM
			textBoxInput_SFM.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxInput_SFM.Location = new System.Drawing.Point(10, 144);
			textBoxInput_SFM.Margin = new Padding(3, 2, 3, 2);
			textBoxInput_SFM.Multiline = true;
			textBoxInput_SFM.Name = "textBoxInput_SFM";
			textBoxInput_SFM.Size = new System.Drawing.Size(474, 36);
			textBoxInput_SFM.TabIndex = 6;

			// textBoxNameProject_SFM
			textBoxNameProject_SFM.BackColor = SystemColors.InactiveBorder;
			textBoxNameProject_SFM.BorderStyle = BorderStyle.FixedSingle;
			textBoxNameProject_SFM.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBoxNameProject_SFM.ForeColor = System.Drawing.Color.DarkSlateGray;
			textBoxNameProject_SFM.Location = new System.Drawing.Point(10, 9);
			textBoxNameProject_SFM.Margin = new Padding(3, 2, 3, 2);
			textBoxNameProject_SFM.Multiline = true;
			textBoxNameProject_SFM.Name = "textBoxNameProject_SFM";
			textBoxNameProject_SFM.Size = new System.Drawing.Size(1505, 59);
			textBoxNameProject_SFM.TabIndex = 7;
			textBoxNameProject_SFM.Text = "Университет";

			// chartStatistics
			chartStatistics.Location = new System.Drawing.Point(10, 277);
			chartStatistics.Name = "chartStatistics";
			chartStatistics.Size = new System.Drawing.Size(807, 303);
			chartStatistics.TabIndex = 8;
			chartStatistics.Text = "chart1";

			// FormMain_SFM
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new System.Drawing.Size(1370, 700);
			Controls.Add(chartStatistics);
			Controls.Add(textBoxNameProject_SFM);
			Controls.Add(textBoxInput_SFM);
			Controls.Add(buttonSearch_SFM);
			Controls.Add(buttonHelp_SFM); // Добавление кнопки "Справка" на форму
			Controls.Add(listBoxResult_SFM);
			Controls.Add(buttonHelp_SFM);
			Margin = new Padding(3, 2, 3, 2);
			Name = "FormMain_SFM";
			Text = "Главная";
			((System.ComponentModel.ISupportInitialize)chartStatistics).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}