using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlagajnaProjekt
{
    public partial class Form2 : Form
    {
      
        public Form2()
        {
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                var song = context.Songs.FirstOrDefault();
                label1.Text = song.Artist;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

