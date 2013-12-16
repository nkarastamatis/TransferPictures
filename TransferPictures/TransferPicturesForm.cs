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
using MediaLib;

namespace TransferPictures
{
    public partial class TransferPicturesForm : Form
    {
        public TransferPicturesForm()
        {
            InitializeComponent();
        }

        private void btn_Browse_MouseClick(object sender, MouseEventArgs e)
        {
            TransferMedia.transfer();


            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var fileInfo = dlg.FileName;
                string filename = dlg.FileName;
                var file = dlg.OpenFile();
                System.IO.Stream steam = System.IO.Stream.Null;
                file.CopyTo(steam);
            }
        }
    }
}
