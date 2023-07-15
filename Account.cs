// RegistrationForm.cs
using System;
using System.Windows.Forms;

public partial class Account : Form
{
    public TextBox textBoxUsername;
    public TextBox textBoxPassword;
    public TextBox YaoQingPassword;
    public Button button;
    public Label Username;
    public Label Password;
    public Label PasswordConfirmation;
    Form1 form1 = new Form1();

    public Account()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.textBoxUsername = new TextBox();
        this.textBoxPassword = new TextBox();
        this.YaoQingPassword = new TextBox();
        this.Username = new Label();
        this.Password = new Label();
        this.PasswordConfirmation = new Label();

        this.textBoxUsername.Location = new System.Drawing.Point(50, 30);
        this.textBoxUsername.Size = new System.Drawing.Size(200, 20);
        this.textBoxUsername.Text = "限10字以内";
        this.Username.Location = new Point(10, 33);
        this.Username.Size = new Size(60, 20);
        this.Username.Text = "用户名";


        this.textBoxPassword.Location = new System.Drawing.Point(50, 70);
        this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
        this.textBoxPassword.PasswordChar = '*';
        this.Password.Location = new Point(10, 73);
        this.Password.Size = new Size(50, 20);
        this.Password.Text = "密码";

        this.YaoQingPassword.Location = new Point(50, 110);
        this.YaoQingPassword.Size = new Size(200, 20);
        this.YaoQingPassword.Text = "";
        this.PasswordConfirmation.Location = new Point(10, 113);
        this.PasswordConfirmation.Size = new Size(50, 20);
        this.PasswordConfirmation.Text = "邀请码";

        this.Controls.Add(this.textBoxUsername);
        this.Controls.Add(this.textBoxPassword);
        this.Controls.Add(this.YaoQingPassword);
        this.Controls.Add(this.Password);
        this.Controls.Add(this.Username);
        this.Controls.Add(this.PasswordConfirmation);

        this.button = new Button(); //定义控件
        this.button.Text = "注册"; //设置Text属性
        this.button.Location = new Point(50, 140); //设置布局位置 Point(x,y)
        this.button.Size = new Size(200, 40); //设置尺寸大小 Size(width,height)
        this.Controls.Add(this.button); //注册控件到窗体
        this.button.Click += new EventHandler(this.button_Click);

        this.Text = "RegistrationForm";
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (YaoQingPassword.Text == "114514dongbei")
        {
            MessageBox.Show("注册成功");

            Form1.IsNewAccount = true;
        }
        else
        {
            MessageBox.Show("邀请码错误");
            
            Form1.IsNewAccount = false;
        }
    }
}