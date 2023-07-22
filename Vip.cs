
using WinFormsApp1;

public partial class Vip : Form
{
    private Label Vipname;
    private Button Button_;
    private Button AddPoint;
    private Label HowPoint;
    public static int VipPoint = 0;
    public Vip()
    {
        InitializeComponent();
        Vipname = new Label();
        Button_ = new Button();
        AddPoint = new Button();
        HowPoint = new Label();
        
        this.HowPoint.Text = "您当前点券为:"+VipPoint.ToString();//设置Text属性
        HowPoint.Location = new Point(50,30);//设置布局位置 Point(x,y)
        HowPoint.Size = new Size(100,40);//设置尺寸大小 Size(width,height)
        this.Controls.Add(this.HowPoint);//注册控件到窗体
        
        this.Vipname.Text = "高级会员：999点数/月";//设置Text属性
        this.Vipname.Location = new Point(50,80);//设置布局位置 Point(x,y)
        this.Vipname.Size = new Size(100,40);//设置尺寸大小 Size(width,height)
        this.Controls.Add(this.Vipname);//注册控件到窗体

        this.Button_.Location = new System.Drawing.Point(50, 130);
        this.Button_.Size = new System.Drawing.Size(100, 40);
        this.Button_.Text = "购买";
        this.Button_.Click += new System.EventHandler(this.Button_Click);
        
        this.AddPoint.Location = new System.Drawing.Point(50, 180);
        this.AddPoint.Size = new System.Drawing.Size(100, 40);
        this.AddPoint.Text = "购买点数";
        this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);

        Controls.Add(this.Button_);
        Controls.Add(AddPoint);
    }

    private void Button_Click(object sender, System.EventArgs e)
    {
        MessageBox.Show("购买成功!购买后请重新打开此窗");
        VipPoint -= 999;
        Form1.IsVip = true;
    }

    private void AddPoint_Click(object sender, System.EventArgs e)
    {
        VipPointWindows vippointwindows = new VipPointWindows();
        vippointwindows.Show();
    }
    
}