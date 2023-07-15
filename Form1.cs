using System.Security.Principal;
using System;
using System.Windows.Forms;


public partial class Form1 : Form
{
    
    private Button buttonRegister;
    public Button FuckingButton;
    public static bool IsNewAccount=false;
    
    public Form1()
    {
        InitializeComponent();
        this.FuckingButton = new System.Windows.Forms.Button();//定义控件
        this.FuckingButton.Text = "打开大礼包";//设置Text属性
        this.FuckingButton.Location = new Point(50,80);//设置布局位置 Point(x,y)
        this.FuckingButton.Size = new Size(100,40);//设置尺寸大小 Size(width,height)
        this.Controls.Add(this.FuckingButton);//注册控件到窗体
        this.FuckingButton.Click += new EventHandler(this.FuckingButton_Click);
        
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
        Account registerForm = new Account();
        registerForm.Show();
    }
    
    public void MessageBoxFuck()
    {
        if (IsNewAccount)
        {
            MessageBox.Show("Fuck you!", "Surprise");
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
    
    
}