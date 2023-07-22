using System.Windows.Forms;

namespace WinFormsApp1;

public partial class LoginWindows : Form
{
    private TextBox textBoxUsername;
    private TextBox textBoxPassword;
    public Label Username;
    public Label Password;
    public Button button;
    private string line;
    public LoginWindows()
    {
        InitializeComponent();
        this.textBoxUsername = new TextBox();
        this.textBoxPassword = new TextBox();
        this.Username = new Label();
        this.Password = new Label();
        
        this.textBoxUsername.Location = new System.Drawing.Point(50, 30);
        this.textBoxUsername.Size = new System.Drawing.Size(200, 20);
        this.Username.Location = new Point(10, 33);
        this.Username.Size = new Size(60, 20);
        this.Username.Text = "用户名";


        this.textBoxPassword.Location = new System.Drawing.Point(50, 70);
        this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
        this.textBoxPassword.PasswordChar = '*';
        this.Password.Location = new Point(10, 73);
        this.Password.Size = new Size(50, 20);
        this.Password.Text = "密码";
        
        this.button = new Button(); //定义控件
        this.button.Text = "登录"; //设置Text属性
        this.button.Location = new Point(50, 100); //设置布局位置 Point(x,y)
        this.button.Size = new Size(200, 40); //设置尺寸大小 Size(width,height)
        this.Controls.Add(this.button); //注册控件到窗体
        this.button.Click += new EventHandler(this.button_Click);

        Controls.Add(this.textBoxUsername);
        Controls.Add(this.textBoxPassword);
        Controls.Add(this.Password);
        Controls.Add(this.Username);
    }

    private void button_Click(object sender, EventArgs e)
    {
        try
        {
            StreamReader sr = new StreamReader("D:\\Passwordtod.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            if (line == textBoxPassword.Text&&sr.ReadLine() == textBoxUsername.Text)
            {
                MessageBox.Show("登录成功");
                Form1.IsNewAccount = true;
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            
                Form1.IsNewAccount = false;
            }
            
            sr.Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("错误:" + exception.Message+"，请注意你是否注册!");
        }
    }
}