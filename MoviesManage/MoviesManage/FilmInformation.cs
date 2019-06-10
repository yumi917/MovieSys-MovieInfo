using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesManage
{
    public partial class FilmInformation : Form
    {
        public FilmInformation()
        {
            InitializeComponent();
        }
        //菜单栏
        private void 前后端切换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //后端
            FilmInformationBackForm MM = new FilmInformationBackForm();
            MM.ShowDialog();
            this.Hide();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //关闭 退出
        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关闭当前窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //一个int的全剧变量
        public int MNID =0;

        //新窗口事件
        public void mi(string name)
        {
            MovieInfo mi = new MovieInfo();
            mi.Show();
            ImageName.imageName = name;
            MessageBox.Show(name);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mi(pictureBox1.ImageLocation);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mi(pictureBox2.Name);
        }

        //无用
        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mi(pictureBox3.Name);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mi(pictureBox4.Name);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            mi(pictureBox5.Name);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            mi(pictureBox6.Name);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mi(pictureBox7.Name);
        }

        //if()
    }
}
