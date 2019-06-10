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
    public partial class FilmInformationBackForm : Form
    {
        public FilmInformationBackForm()
        {
            InitializeComponent();
        }
        //刷新
        private void Up()
        {
            string sql = "select * from Movie";
            DataTable dt = DBHelper.GetDataTable(sql);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        private void 影片信息_Enter(object sender, EventArgs e)
        {

        }
        //加载
        private void Form1_Load(object sender, EventArgs e)
        {
            Up();
            //pictureBox2.ImageLocation  = "D:\\2019皇家工程\\作业\\zero\\影片图片\\八尺·一声一世.jpg";
        }

        //图片索引
        private int currentIndex = 0;


        //数据显示
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtMnames.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtMZY.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cmbMDq.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cmbMtype.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtTime.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtJ.Text= dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtState.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                if (string.IsNullOrEmpty(txtMnames.Text.Trim()) )
                {
                    currentIndex = 0;
                    //图片的显示到框中
                    //用 ImageLocation 来存放本地图片路径
                    pictureBox2.ImageLocation = "D:\\2019皇家工程\\作业\\zero\\影片图片\\0无法01.jpg";
                    //currentIndex 用来记录图片的编号 使用有bug
                    //this.pictureBox2.Image = this.imageList1.Images[currentIndex];
                    pictureBox1.ImageLocation = "D:\\2019皇家工程\\作业\\zero\\影片图片\\0无法01.jpg";
                    //this.pictureBox1.Image = this.imageList2.Images[currentIndex];
                }
                else
                {
                    //图片的变换
                    currentIndex = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    //图片的显示到框中
                    pictureBox2.ImageLocation = "D:\\2019皇家工程\\作业\\zero\\影片图片\\" + txtMnames.Text.ToString() + ".jpg";
                    //MessageBox.Show(pictureBox2.ImageLocation);
                    //this.pictureBox2.Image = this.imageList1.Images[currentIndex];
                    pictureBox1.ImageLocation = "D:\\2019皇家工程\\作业\\zero\\影片图片\\" + txtMnames.Text.ToString() + ".jpg";
                    //this.pictureBox1.Image = this.imageList2.Images[currentIndex];
                }
                
            }

        }


        //新增
        private void btnTJ_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (string.IsNullOrEmpty(txtMnames.Text.Trim()) || string.IsNullOrEmpty(txtMZY.Text.Trim()) || string.IsNullOrEmpty(cmbMDq.Text.Trim()) || string.IsNullOrEmpty(cmbMtype.Text.Trim()) || string.IsNullOrEmpty(txtTime.Text.Trim()) || string.IsNullOrEmpty(txtState.Text.Trim()))
            {
                MessageBox.Show("内容不完全，请检查！！！", "提示");
                return;
            }
            else
            {
                //判断时长是否在1-300之间
                if (int.Parse(txtTime.Text.ToString()) < 0 || int.Parse(txtTime.Text.ToString()) > 300)
                {
                    MessageBox.Show("请输入正确的时间：1-300！！！","提示");
                }
                DateTime dtime = DateTime.Parse(dateTimePicker1.Text);
                string sql = string.Format("insert into Movie(MovieName,MainPerformer,MovieTypeId,Area,TimeLength,OnTime,MovieState,Synopsis) values ('{0}','{1}','{3}','{2}','{4}','{5}','{6}','{7}')", txtMnames.Text, txtMZY.Text, cmbMDq.Text, cmbMtype.Text, txtTime.Text, dtime,txtState.Text,txtJ.Text);         
                if (DBHelper.ExecuteNonQuery(sql))
                {                   
                    MessageBox.Show("添加成功！！！");
                    Up();
                    return;                  
                }
                else
                {
                    MessageBox.Show("添加失败！！！");
                    Up();
                    return;
                }

            }
            
        }

        //当前时间
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           
        }

        //修改
        private void btnXG_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (string.IsNullOrEmpty(txtMnames.Text.Trim()) || string.IsNullOrEmpty(txtMZY.Text.Trim()) || string.IsNullOrEmpty(cmbMDq.Text.Trim()) || string.IsNullOrEmpty(cmbMtype.Text.Trim()) || string.IsNullOrEmpty(txtTime.Text.Trim()) || string.IsNullOrEmpty(txtState.Text.Trim()))
            {
                MessageBox.Show("内容不完全，请检查！！！", "提示");
                return;
            }
            else
            {
                //判断时长是否在1-300之间
                if (int.Parse(txtTime.Text.ToString()) < 0 || int.Parse(txtTime.Text.ToString()) > 300)
                {
                    MessageBox.Show("请输入正确的时间：1-300！！！", "提示");
                }
                DateTime dtime = DateTime.Parse(dateTimePicker1.Text);
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string sql = string.Format("update Movie set MovieName='{0}',MainPerformer='{1}',MovieTypeId='{3}',Area='{2}',TimeLength='{4}',OnTime='{5}',MovieState='{6}',Synopsis='{7}' where MID='{8}'", txtMnames.Text, txtMZY.Text, cmbMDq.Text, cmbMtype.Text, txtTime.Text, dtime, txtState.Text, txtJ.Text,id);
                if (DBHelper.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("修改成功！！！");
                    Up();
                    return;
                }
                else
                {
                    MessageBox.Show("修改失败！！！");
                    Up();
                  
                }

            }
        }

        //删除
        private void btnSC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1 || string.IsNullOrEmpty(txtMnames.Text.Trim()))
            {
                MessageBox.Show("请选择要删除的行！");
            }
            else
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string sql = string.Format("delete from Movie where MID='{0}'",id);
                if (DBHelper.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("删除成功！");
                    Up();
                    return;
                }
                else
                {
                    MessageBox.Show("删除失败！");
                    return;
                }
            }
        }
        //用于模糊查询的小查询
        private void update(string sqlcon)
        {
            DataTable dt = DBHelper.GetDataTable(sqlcon);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
             if (dt.Rows.Count < 1)
            {
                MessageBox.Show("暂无，请等候添加。");
                return;
            }

        }
        //检索 模糊查询
        
        private void btnSerch_Click(object sender, EventArgs e)
        {
            //定义string 类型的 sql 用来存放SQL语句
            string sqlSerch;
            //判断下拉列表里面的数值为“（无）”则赋值null
            //判断地区
            if (cmdSArae.Text.ToString()=="（无）")
            {
                cmdSArae.Text = null;
                return;
            }
            //判断类型
            if (cmbSType.Text.ToString() == "（无）")
            {
                cmbSType.Text = null;
                return;
            }

            if (string.IsNullOrEmpty(txtSName.Text.Trim()) && string.IsNullOrEmpty(cmbSType.Text.Trim()) && string.IsNullOrEmpty(cmdSArae.Text.Trim()))
            {
                Up();
                return;
            }
            else
            {
                //名字
                if (!string.IsNullOrEmpty(txtSName.Text.Trim()) && (string.IsNullOrEmpty(cmbSType.Text.Trim()) || cmbSType.Text == "（无）") && string.IsNullOrEmpty(cmdSArae.Text.Trim()))
                {
                    sqlSerch = string.Format("select * from Movie where 1=1 and MovieName like '%{0}%'", txtSName.Text.ToString());
                    update(sqlSerch);
                    return;
                }
                //类型
                else if (string.IsNullOrEmpty(txtSName.Text.Trim()) && !(string.IsNullOrEmpty(cmbSType.Text.Trim()) || cmbSType.Text == "（无）") && string.IsNullOrEmpty(cmdSArae.Text.Trim()))
                {
                    sqlSerch = string.Format("select * from Movie where 1=1 and MovieTypeId like '%{0}%'", cmbSType.Text.ToString());
                    update(sqlSerch);
                    return;
                }
                //地区
                else if(string.IsNullOrEmpty(txtSName.Text.Trim()) && string.IsNullOrEmpty(cmbSType.Text.Trim()) && !string.IsNullOrEmpty(cmdSArae.Text.Trim()))
                {
                    sqlSerch = string.Format("select * from Movie where 1=1 and Area like '%{0}%'", cmdSArae.Text.ToString());
                    update(sqlSerch);
                    return;
                }
                //名字类型
                else if (!string.IsNullOrEmpty(txtSName.Text.Trim()) && !string.IsNullOrEmpty(cmbSType.Text.Trim()) && string.IsNullOrEmpty(cmdSArae.Text.Trim()))
                {
                    sqlSerch = string.Format("select * from Movie where 1=1 and MovieName like '%{0}%' and MovieTypeId like '%{1}%'", txtSName.Text.ToString(), cmbSType.Text.ToString());
                    update(sqlSerch);
                    return;
                }
                //名字地区
                else if (!string.IsNullOrEmpty(txtSName.Text.Trim()) && string.IsNullOrEmpty(cmbSType.Text.Trim()) && !string.IsNullOrEmpty(cmdSArae.Text.Trim()))
                {
                    sqlSerch = string.Format("select * from Movie where 1=1 and MovieName like '%{0}%' and Area like '%{1}%'", txtSName.Text.ToString(), cmdSArae.Text.ToString());
                    update(sqlSerch);
                    return;
                }
                //类型地区
                else if (string.IsNullOrEmpty(txtSName.Text.Trim()) && !string.IsNullOrEmpty(cmbSType.Text.Trim()) && !string.IsNullOrEmpty(cmdSArae.Text.Trim()))
                {
                    sqlSerch = string.Format("select * from Movie where 1=1 and Area like '%{0}%' and MovieTypeId like '%{1}%'", cmdSArae.Text.ToString(), cmbSType.Text.ToString());
                    update(sqlSerch);
                    return;
                }
                //三合在一起
                else if (!string.IsNullOrEmpty(txtSName.Text.Trim()) && !string.IsNullOrEmpty(cmbSType.Text.Trim()) && !string.IsNullOrEmpty(cmdSArae.Text.Trim()))
                {
                    sqlSerch = string.Format("select * from Movie where 1=1 and Area like '%{0}%' and MovieTypeId like '%{1}%' and MovieName like '%{2}%'", cmdSArae.Text.ToString(), cmbSType.Text.ToString(),txtSName.Text.ToString());
                    update(sqlSerch);
                    return;
                }
            }
        }

       
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 前后端切换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //前端
            FilmInformation UM = new FilmInformation();
            UM.ShowDialog();
            this.Hide();
        }
        //菜单栏 退出
        private void 关闭当前窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
