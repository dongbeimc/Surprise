using System.Windows.Forms;

namespace WinFormsApp1;

public partial class VipPointWindows : Form
{
    private Label Point1000;
    private Button PointButton;
    public VipPointWindows()
    {
        InitializeComponent();
        Point1000 = new Label();
        PointButton = new Button(); 
        
        this.Point1000.Text = "1000点数";//设置Text属性
        this.Point1000.Location = new Point(50,80);//设置布局位置 Point(x,y)
        this.Point1000.Size = new Size(100,40);//设置尺寸大小 Size(width,height)
        this.Controls.Add(this.Point1000);//注册控件到窗体
        
        this.PointButton.Location = new System.Drawing.Point(50, 130);
        this.PointButton.Size = new System.Drawing.Size(100, 40);
        this.PointButton.Text = "购买";
        this.PointButton.Click += new System.EventHandler(this.PointButton_Click);

        Controls.Add(this.Point1000);
        Controls.Add(this.PointButton);
    }

    private void PointButton_Click(object sender, System.EventArgs e)
    {
        Vip.VipPoint += 1000;
        MessageBox.Show("购买成功！购买后请重新打开此窗口");
    }
}