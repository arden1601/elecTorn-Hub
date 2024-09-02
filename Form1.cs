namespace elecTorn_Hub;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        CreateButton();

    }
    private void CreateButton()
{
    // Instantiate the button
    Button button1 = new Button();

    // Set button properties
    button1.Text = "Click Me";
    button1.Location = new System.Drawing.Point(50, 50); // Set the location on the form
    button1.Size = new System.Drawing.Size(100, 50); // Set the size of the button

    // Add the button to the form's controls
    this.Controls.Add(button1);

    // Optionally, add an event handler for the button click event
    button1.Click += new EventHandler(Button1_Click);
}

private void Button1_Click(object sender, EventArgs e)
{
    MessageBox.Show("Button clicked!");
}
}



