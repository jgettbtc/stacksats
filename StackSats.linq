<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
</Query>

void Main()
{
	var form = new System.Windows.Forms.Form();
	form.Text = "Currency Upgrade";
	form.Width = 400;
	form.Height = 165;
	
	var label = new System.Windows.Forms.Label();
	label.Text = "Upgrading fiat to bitcoin...";
	label.Left = 10;
	label.Top = 15;
	label.Width = 200;
	form.Controls.Add(label);
	
	var prog = new System.Windows.Forms.ProgressBar();
	prog.Value = 13;
	prog.Left = 10;
	prog.Top = 40;
	prog.Width = 360;
	prog.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
	form.Controls.Add(prog);
	
	var btn = new System.Windows.Forms.Button();
	btn.Text = "StackSats";
	btn.Left = 10;
	btn.Top = 75;
	btn.Height = 30;
	
	btn.Click += (sender, e) =>
	{
		if (prog.Value == 100)
			prog.Value = 0;
			
		prog.Value += 1;
	};
	
	form.Controls.Add(btn);
	
	form.Show();
}
