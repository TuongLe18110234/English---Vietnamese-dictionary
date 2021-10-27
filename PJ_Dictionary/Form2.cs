using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PJ_Dictionary
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1(); // Tạo một form mới
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_updateTree_Click(object sender, EventArgs e)
        {
            upDate(Form1.node1);
            MessageBox.Show("Cập nhật từ thành công!", "Thông báo!");
        }
        public void showWord(Node node1)
        {
            tbx_word.Enabled = false;
            tbx_word.Text = node1.data.word;
            tbx_pronunciation.Text = node1.data.pronunciation;
            tbx_wordType.Text = node1.data.wordType;

            string tempMean = node1.data.mean;
            string[] listMean = tempMean.Split('/'); // Hàm cắt chuỗi khi gặp '/'

            int size = listMean.Length;

            if (size >= 1)
                tbx_mean1.Text = listMean[0];
            if (size >= 2)
                tbx_mean2.Text = listMean[1];
            if (size >= 3)
                tbx_mean3.Text = listMean[2];
            if (size >= 4)
                tbx_mean4.Text = listMean[3];
            if (size >= 5)
                tbx_mean5.Text = listMean[4];
        }
        public void upDate(Node node1)
        {
            node1.data.word = tbx_word.Text;
            node1.data.pronunciation = tbx_pronunciation.Text;
            node1.data.wordType = tbx_wordType.Text;

            string temp = "";
            if (tbx_mean1.Text != "")
                temp = tbx_mean1.Text;

            if (tbx_mean2.Text != "")
                temp = temp + "/" + tbx_mean2.Text;

            if (tbx_mean3.Text != "")
                temp = temp + "/" + tbx_mean3.Text;

            if (tbx_mean4.Text != "")
                temp = temp + "/" + tbx_mean4.Text;

            if (tbx_mean5.Text != "")
                temp = temp + "/" + tbx_mean5.Text;
            node1.data.mean = temp;
        }

        private void Btn_updateFile_Click(object sender, EventArgs e)
        {
            Form1.tree.writeToFile(Form1.tree.root);
            MessageBox.Show("Cập nhật vào file thành công", "Thông báo");
        }
    }
}
