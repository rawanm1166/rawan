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

namespace hw
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void main_menu_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }

        }


        private void main_menu_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedfiles=(string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in droppedfiles) {
                pictureBox1.Image = Image.FromFile(file); 

            
            }
        }
        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

     
    }
}
