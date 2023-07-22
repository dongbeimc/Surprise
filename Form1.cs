
using System.Security.Cryptography;
using WinFormsApp1;

public partial class Form1 : Form
{

    public const int Default = 9999;
    private Button buttonRegister;
    public Button FuckingButton;
    public static bool IsNewAccount=false;
    public Button HelloButton;
    public Button Vips;
    private Button LoginButton;
    public static bool IsVip=false;
    
    public  static  string[] Password = new String[] {"114514dongbei","1919810iloveyou"};
    
    public Form1()
    {
        InitializeComponent();
        ClientSize = new Size(200, 300);
        this.HelloButton = new Button();
        Vips = new Button();
        LoginButton = new Button();

        this.FuckingButton = new System.Windows.Forms.Button();//定义控件
        this.FuckingButton.Text = "打开大礼包";//设置Text属性
        this.FuckingButton.Location = new Point(50,80);//设置布局位置 Point(x,y)
        this.FuckingButton.Size = new Size(100,40);//设置尺寸大小 Size(width,height)
        this.Controls.Add(this.FuckingButton);//注册控件到窗体
        this.FuckingButton.Click += new EventHandler(this.FuckingButton_Click);
        
        this.HelloButton.Location = new System.Drawing.Point(50, 30);
        this.HelloButton.Size = new System.Drawing.Size(100, 40);
        this.HelloButton.Text = "Hello";
        this.HelloButton.Click += new System.EventHandler(this.hellobutton_Click);
        Controls.Add(HelloButton);
        
        this.Vips.Location = new System.Drawing.Point(50, 180);
        this.Vips.Size = new System.Drawing.Size(100, 40);
        this.Vips.Text = "充值Vip";
        this.Vips.Click += new System.EventHandler(this.Vip_Click);
        Controls.Add(Vips);
        
        LoginButton.Location = new System.Drawing.Point(50, 230);
        LoginButton.Size = new System.Drawing.Size(100, 40);
        LoginButton.Text = "登录";
        LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
        Controls.Add(LoginButton);
    }
    private void InitializeComponent()
    {
        this.buttonRegister = new Button();
        
        this.buttonRegister.Location = new System.Drawing.Point(50, 130);
        this.buttonRegister.Size = new System.Drawing.Size(100, 40);
        this.buttonRegister.Text = "Register";
        this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
        
        this.Controls.Add(this.buttonRegister);
        this.Text = "MainForm";
    }

    private void buttonRegister_Click(object sender, EventArgs e)
    {
        if (!IsNewAccount)
        {
            Account registerForm = new Account();
            registerForm.Show();
        }
        else
        {
            MessageBox.Show("你已登录");
        }
        
    }

    private void Vip_Click(object sender, EventArgs e)
    {
        
        if (IsNewAccount)
        {
            Vip vis = new Vip();
            vis.Show();
        }else
        {
            MessageBox.Show("请先注册", "注册");
        }
        
    }
    private void hellobutton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("本软件由东北开发，购买邀请码+q:1253342588", "Message");
    }
    public void MessageBoxFuck()
    {
        
        if (IsNewAccount)
        {
            if (!IsVip)
            {
                MessageBox.Show("Fuck you!", "Surprise");
            }
            else
            {
                MessageBox.Show("你好啊!感谢你下载本软件！赠送您100点券", "Surprise");
                Vip.VipPoint += 100;
            }
            
        }
        else
        {
            MessageBox.Show("请先注册", "注册");
        }
    }

    private void FuckingButton_Click(object sender, EventArgs e)
    {
        MessageBoxFuck();
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        LoginWindows loginWindows = new LoginWindows();
        loginWindows.Show();
    }
}