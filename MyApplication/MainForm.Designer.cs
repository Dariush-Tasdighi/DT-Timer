namespace MyApplication;

partial class MainForm
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}

		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
		hoursLabel = new Label();
		hoursTextBox = new TextBox();
		minutesLabel = new Label();
		minutesTextBox = new TextBox();
		secondsLabel = new Label();
		secondsTextBox = new TextBox();
		startButton = new Button();
		SuspendLayout();
		// 
		// hoursLabel
		// 
		hoursLabel.AutoSize = true;
		hoursLabel.Location = new Point(15, 17);
		hoursLabel.Margin = new Padding(6, 0, 6, 0);
		hoursLabel.Name = "hoursLabel";
		hoursLabel.Size = new Size(88, 28);
		hoursLabel.TabIndex = 0;
		hoursLabel.Text = "&Hours";
		// 
		// hoursTextBox
		// 
		hoursTextBox.Location = new Point(115, 13);
		hoursTextBox.Margin = new Padding(6, 4, 6, 4);
		hoursTextBox.Name = "hoursTextBox";
		hoursTextBox.Size = new Size(112, 35);
		hoursTextBox.TabIndex = 1;
		hoursTextBox.KeyDown += TextBox_KeyDown;
		hoursTextBox.KeyPress += TextBox_KeyPress;
		// 
		// minutesLabel
		// 
		minutesLabel.AutoSize = true;
		minutesLabel.Location = new Point(239, 17);
		minutesLabel.Margin = new Padding(6, 0, 6, 0);
		minutesLabel.Name = "minutesLabel";
		minutesLabel.Size = new Size(113, 28);
		minutesLabel.TabIndex = 2;
		minutesLabel.Text = "&Minutes";
		// 
		// minutesTextBox
		// 
		minutesTextBox.Location = new Point(364, 13);
		minutesTextBox.Margin = new Padding(6, 4, 6, 4);
		minutesTextBox.Name = "minutesTextBox";
		minutesTextBox.Size = new Size(112, 35);
		minutesTextBox.TabIndex = 3;
		minutesTextBox.KeyDown += TextBox_KeyDown;
		minutesTextBox.KeyPress += TextBox_KeyPress;
		// 
		// secondsLabel
		// 
		secondsLabel.AutoSize = true;
		secondsLabel.Location = new Point(488, 17);
		secondsLabel.Margin = new Padding(6, 0, 6, 0);
		secondsLabel.Name = "secondsLabel";
		secondsLabel.Size = new Size(119, 28);
		secondsLabel.TabIndex = 4;
		secondsLabel.Text = "Se&conds";
		// 
		// secondsTextBox
		// 
		secondsTextBox.Location = new Point(619, 13);
		secondsTextBox.Margin = new Padding(6, 4, 6, 4);
		secondsTextBox.Name = "secondsTextBox";
		secondsTextBox.Size = new Size(112, 35);
		secondsTextBox.TabIndex = 5;
		secondsTextBox.KeyDown += TextBox_KeyDown;
		secondsTextBox.KeyPress += TextBox_KeyPress;
		// 
		// startButton
		// 
		startButton.BackColor = Color.Khaki;
		startButton.FlatAppearance.BorderSize = 0;
		startButton.FlatStyle = FlatStyle.Flat;
		startButton.Location = new Point(15, 56);
		startButton.Margin = new Padding(6, 4, 6, 4);
		startButton.Name = "startButton";
		startButton.Size = new Size(716, 41);
		startButton.TabIndex = 6;
		startButton.Text = "&Start";
		startButton.UseVisualStyleBackColor = false;
		startButton.Click += StartButton_Click;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(16F, 28F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.SteelBlue;
		ClientSize = new Size(746, 111);
		Controls.Add(startButton);
		Controls.Add(secondsTextBox);
		Controls.Add(secondsLabel);
		Controls.Add(minutesTextBox);
		Controls.Add(minutesLabel);
		Controls.Add(hoursTextBox);
		Controls.Add(hoursLabel);
		Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Margin = new Padding(6, 4, 6, 4);
		MaximizeBox = false;
		MaximumSize = new Size(764, 158);
		MinimumSize = new Size(764, 158);
		Name = "MainForm";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "DT Timer";
		Load += MainForm_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label hoursLabel;
	private TextBox hoursTextBox;
	private Label minutesLabel;
	private TextBox minutesTextBox;
	private Label secondsLabel;
	private TextBox secondsTextBox;
	private Button startButton;
}
