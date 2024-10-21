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
		hoursLabel.Location = new Point(12, 15);
		hoursLabel.Name = "hoursLabel";
		hoursLabel.Size = new Size(48, 20);
		hoursLabel.TabIndex = 0;
		hoursLabel.Text = "&Hours";
		// 
		// hoursTextBox
		// 
		hoursTextBox.Location = new Point(66, 12);
		hoursTextBox.Name = "hoursTextBox";
		hoursTextBox.Size = new Size(58, 27);
		hoursTextBox.TabIndex = 1;
		hoursTextBox.KeyDown += TextBox_KeyDown;
		hoursTextBox.KeyPress += TextBox_KeyPress;
		// 
		// minutesLabel
		// 
		minutesLabel.AutoSize = true;
		minutesLabel.Location = new Point(130, 15);
		minutesLabel.Name = "minutesLabel";
		minutesLabel.Size = new Size(61, 20);
		minutesLabel.TabIndex = 2;
		minutesLabel.Text = "&Minutes";
		// 
		// minutesTextBox
		// 
		minutesTextBox.Location = new Point(197, 12);
		minutesTextBox.Name = "minutesTextBox";
		minutesTextBox.Size = new Size(58, 27);
		minutesTextBox.TabIndex = 3;
		minutesTextBox.KeyDown += TextBox_KeyDown;
		minutesTextBox.KeyPress += TextBox_KeyPress;
		// 
		// secondsLabel
		// 
		secondsLabel.AutoSize = true;
		secondsLabel.Location = new Point(261, 15);
		secondsLabel.Name = "secondsLabel";
		secondsLabel.Size = new Size(64, 20);
		secondsLabel.TabIndex = 4;
		secondsLabel.Text = "Se&conds";
		// 
		// secondsTextBox
		// 
		secondsTextBox.Location = new Point(331, 12);
		secondsTextBox.Name = "secondsTextBox";
		secondsTextBox.Size = new Size(58, 27);
		secondsTextBox.TabIndex = 5;
		secondsTextBox.KeyDown += TextBox_KeyDown;
		secondsTextBox.KeyPress += TextBox_KeyPress;
		// 
		// startButton
		// 
		startButton.Location = new Point(12, 45);
		startButton.Name = "startButton";
		startButton.Size = new Size(377, 29);
		startButton.TabIndex = 6;
		startButton.Text = "Start";
		startButton.UseVisualStyleBackColor = true;
		startButton.Click += StartButton_Click;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(402, 87);
		Controls.Add(startButton);
		Controls.Add(secondsTextBox);
		Controls.Add(secondsLabel);
		Controls.Add(minutesTextBox);
		Controls.Add(minutesLabel);
		Controls.Add(hoursTextBox);
		Controls.Add(hoursLabel);
		MaximizeBox = false;
		MaximumSize = new Size(420, 134);
		MinimumSize = new Size(420, 134);
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
