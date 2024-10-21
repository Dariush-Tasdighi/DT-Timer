namespace MyApplication;

partial class TimerForm
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
		components = new System.ComponentModel.Container();
		myTimer = new System.Windows.Forms.Timer(components);
		myLabel = new Label();
		SuspendLayout();
		// 
		// myTimer
		// 
		myTimer.Interval = 1000;
		myTimer.Tick += myTimer_Tick;
		// 
		// myLabel
		// 
		myLabel.BackColor = Color.Black;
		myLabel.Dock = DockStyle.Fill;
		myLabel.Font = new Font("Verdana", 100.200005F, FontStyle.Bold, GraphicsUnit.Point, 0);
		myLabel.ForeColor = Color.White;
		myLabel.Location = new Point(0, 0);
		myLabel.Name = "myLabel";
		myLabel.Size = new Size(982, 453);
		myLabel.TabIndex = 0;
		myLabel.Text = "00:00:00";
		myLabel.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// TimerForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(982, 453);
		Controls.Add(myLabel);
		Name = "TimerForm";
		StartPosition = FormStartPosition.CenterScreen;
		Load += TimerForm_Load;
		ResumeLayout(false);
	}

	#endregion

	private System.Windows.Forms.Timer myTimer;
	private Label myLabel;
}
