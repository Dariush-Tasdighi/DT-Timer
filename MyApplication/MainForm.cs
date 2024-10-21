namespace MyApplication;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	/// <summary>
	/// For Google Meet (1 Hour)
	/// For LinkedIn (15 Minutes)
	/// For Instagram (1 to 10 Minutes)
	/// For YouTube (Less than 20 Minutes)
	/// For Reading Time (Less than 50 Minutes)
	/// For Private / Public Sessions
	/// For Drinking Water!
	/// </summary>
	private void MainForm_Load(object sender, EventArgs e)
	{
		// For Demo:
		//hoursTextBox.Text = "0";
		//minutesTextBox.Text = "0";
		//secondsTextBox.Text = "10";

		// For Production:
		hoursTextBox.Text = "0";
		minutesTextBox.Text = "14";
		secondsTextBox.Text = "50";

		Text = $"DT Timer - Version 1.0";
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		switch (e.KeyChar)
		{
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case '\b':
			{
				break;
			}

			default:
			{
				e.Handled = true; // بی‌خیال شو - شتر دیدی ندیدی
				break;
			}
		}
	}

	private void TextBox_KeyDown(object sender, KeyEventArgs e)
	{
		var currentTextBox = sender as TextBox;

		if (currentTextBox is null)
		{
			return;
		}

		var currentValue = -1;
		var currentTextBoxValue = currentTextBox.Text;

		if ((currentTextBoxValue is not null) && (currentTextBoxValue != string.Empty))
		{
			currentValue =
				Convert.ToInt32(currentTextBoxValue);
		}

		if (e.KeyCode == Keys.Up)
		{
			currentValue++;
			currentTextBox.Text = currentValue.ToString();
			return;
		}

		if (e.KeyCode == Keys.Down)
		{
			if (currentValue == 0)
			{
				return;
			}

			currentValue--;
			currentTextBox.Text = currentValue.ToString();
			return;
		}
	}

	private void StartButton_Click(object sender, EventArgs e)
	{
		hoursTextBox.Text =
			hoursTextBox.Text.Replace(" ", string.Empty);

		minutesTextBox.Text =
			minutesTextBox.Text.Replace(" ", string.Empty);

		secondsTextBox.Text =
			secondsTextBox.Text.Replace(" ", string.Empty);

		if (hoursTextBox.Text == string.Empty)
		{
			hoursTextBox.Text = "0";
		}

		if (minutesTextBox.Text == string.Empty)
		{
			minutesTextBox.Text = "0";
		}

		if (secondsTextBox.Text == string.Empty)
		{
			secondsTextBox.Text = "0";
		}

		var minutes =
			Convert.ToInt32(minutesTextBox.Text);

		var seconds =
			Convert.ToInt32(secondsTextBox.Text);

		if (minutes > 60)
		{
			minutesTextBox.Text = "60";
		}

		if (seconds > 60)
		{
			secondsTextBox.Text = "60";
		}

		var hours =
			Convert.ToInt32(hoursTextBox.Text);

		minutes =
			Convert.ToInt32(minutesTextBox.Text);

		seconds =
			Convert.ToInt32(secondsTextBox.Text);

		var timeSpan =
			new TimeSpan
			(hours: hours, minutes: minutes, seconds: seconds);

		var myTimeForm =
			new TimerForm
			{
				MyTimeSpan = timeSpan,
			};

		myTimeForm.Show();
	}
}
