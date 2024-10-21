using System.Media;

namespace MyApplication;

public partial class TimerForm : Form
{
	public TimerForm()
	{
		InitializeComponent();
	}

	public TimeSpan MyTimeSpan { get; set; }
	public TimeSpan MyOneSecondTimeSpan { get; set; }
	public TimeSpan MyLastThresholdTimeSpan { get; set; }
	public TimeSpan MyFirstThresholdTimeSpan { get; set; }

	private void TimerForm_Load(object sender, EventArgs e)
	{
		Text = MyTimeSpan.ToString(format: "c");

		MyOneSecondTimeSpan =
			new TimeSpan(hours: 0, minutes: 0, seconds: 1);

		MyFirstThresholdTimeSpan =
			new TimeSpan(hours: 0, minutes: 0, seconds: 5);

		MyLastThresholdTimeSpan =
			new TimeSpan(hours: 0, minutes: 0, seconds: 5);

		if (MyFirstThresholdTimeSpan.Ticks == 0)
		{
			myLabel.ForeColor = Color.White;
			DisplayTimeSpan(timeSpan: MyTimeSpan);
		}
		else
		{
			myLabel.ForeColor = Color.Yellow;
			MyTimeSpan += MyOneSecondTimeSpan;
			DisplayTimeSpan(timeSpan: MyFirstThresholdTimeSpan);
		}

		myTimer.Enabled = true;
	}

	private void myTimer_Tick(object sender, EventArgs e)
	{
		if (MyFirstThresholdTimeSpan.Ticks > 0)
		{
			myLabel.ForeColor = Color.Yellow;
			MyFirstThresholdTimeSpan -= MyOneSecondTimeSpan;
			DisplayTimeSpan(timeSpan: MyFirstThresholdTimeSpan);

			if (MyFirstThresholdTimeSpan < MyOneSecondTimeSpan)
			{
				SystemSounds.Beep.Play();
			}

			return;
		}

		myLabel.ForeColor = Color.White;
		MyTimeSpan -= MyOneSecondTimeSpan;

		if (MyTimeSpan.Ticks < 0)
		{
			myLabel.ForeColor = Color.Red;
			myTimer.Enabled = false;
			return;
		}

		if (MyTimeSpan < MyLastThresholdTimeSpan)
		{
			SystemSounds.Hand.Play();
			myLabel.ForeColor = Color.Red;

			//SystemSounds.Beep.Play();
			//SystemSounds.Question.Play();
			//SystemSounds.Asterisk.Play();
			//SystemSounds.Exclamation.Play();
		}

		DisplayTimeSpan(timeSpan: MyTimeSpan);
	}

	private void DisplayTimeSpan(TimeSpan timeSpan)
	{
		var text =
			timeSpan.ToString(format: "c");

		myLabel.Text = text;
	}
}
