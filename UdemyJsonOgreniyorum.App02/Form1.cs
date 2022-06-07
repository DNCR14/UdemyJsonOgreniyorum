using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyJsonOgreniyorum.App02
{
    public partial class Form1 : Form
    {
        Repositories.WebSiteRepository webSiteRepository;
        public Form1()
        {
            InitializeComponent();
            webSiteRepository = new Repositories.WebSiteRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
