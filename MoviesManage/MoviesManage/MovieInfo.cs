using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesManage
{
    public partial class MovieInfo : Form
    {
        public MovieInfo()
        {
            InitializeComponent();
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {
            
        }

        private void MovieInfo_Load(object sender, EventArgs e)
        {
            //名字
            Lname.BackColor = Color.Transparent;
            Lname.Parent = pictureBox2;
            Lname.Location = new Point(499, 98);
            //类型
            Ltype.BackColor = Color.Transparent;
            Ltype.Parent = pictureBox2;
            Ltype.Location = new Point(506, 230);
            //地区
            Larea.BackColor = Color.Transparent;
            Larea.Parent = pictureBox2;
            Larea.Location = new Point(506, 273);
            //时长
            Ltime.BackColor = Color.Transparent;
            Ltime.Parent = pictureBox2;
            Ltime.Location = new Point(577, 273);
            //上映日期
            Lontime.BackColor = Color.Transparent;
            Lontime.Parent = pictureBox2;
            Lontime.Location = new Point(506, 316);
            //评分
            Lfenshu.BackColor = Color.Transparent;
            Lfenshu.Parent = pictureBox2;
            Lfenshu.Location = new Point(901, 364);

            //内容补充
            string strSql = "select * from Movie where 1=1";
            SqlDataReader dr = DBHelper.GetDataReader(strSql);
            string im = ImageName.imageName;

            pictureBox1.ImageLocation = im ;
            MessageBox.Show(pictureBox1.ImageLocation);


        }
    }
}
