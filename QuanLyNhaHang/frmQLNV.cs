using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmQLNV : Form
    {
        Image closeImage, closeImageAct;
        public frmQLNV()
        {
           
            InitializeComponent();

            
        }

        private void AddTabPage(Form frm)
        {
            int t = KTFormTonTai(frm);
            if (t >= 0) 
            {
                
                if (tabControl1.SelectedTab == tabControl1.TabPages[t])
                    MessageBox.Show("Tap \"" + frm.Text.Trim() + "\" dang mo!");
                else
                    tabControl1.SelectedTab = tabControl1.TabPages[t];
            }
            else 
            {
                TabPage newTab = new TabPage(frm.Text.Trim());
                tabControl1.TabPages.Add(newTab);
                frm.TopLevel = false;
                frm.Parent = newTab;
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabCount - 1];
                frm.Show();
                frm.Dock = DockStyle.Fill;

            }
        }

        private int KTFormTonTai(Form frm)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
                if (tabControl1.TabPages[i].Text == frm.Text.Trim())
                    return i;
            return -1;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

            
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
                rect.Top + (rect.Height - closeImage.Height) / 2,
                closeImage.Width, closeImage.Height);
          
            rect.Size = new Size(rect.Width + 20, 38);

            Font f;
            Brush br = Brushes.Black;
            StringFormat strF = new StringFormat(StringFormat.GenericDefault);
           
            if (tabControl1.SelectedTab == tabControl1.TabPages[e.Index])
            {
                
                e.Graphics.DrawImage(closeImageAct, imageRec);
                f = new Font("Arial", 10, FontStyle.Bold);
              
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    f, br, rect, strF);
            }
            else
            {
                
                e.Graphics.DrawImage(closeImage, imageRec);
                f = new Font("Arial", 9, FontStyle.Regular);
              
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    f, br, rect, strF);
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
               
                Rectangle rect = tabControl1.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,rect.Top + (rect.Height - closeImage.Height) / 2,closeImage.Width, closeImage.Height);

                if (imageRec.Contains(e.Location))
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTabPage(new frmQLNhanVien());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTabPage(new frmCaLam());
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            Size mysize = new System.Drawing.Size(20, 20); 
            Bitmap bt = new Bitmap(Properties.Resources.close);
           
            Bitmap btm = new Bitmap(bt, mysize);
            closeImageAct = btm;
         
            Bitmap bt2 = new Bitmap(Properties.Resources.closeBlack);
      
            Bitmap btm2 = new Bitmap(bt2, mysize);
            closeImage = btm2;
            tabControl1.Padding = new Point(30);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddTabPage(new frmLuong());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddTabPage(new frmChamCong());
        }






    }
}
