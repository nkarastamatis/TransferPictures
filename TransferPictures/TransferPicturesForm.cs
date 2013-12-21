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
using System.Threading;

using BrightIdeasSoftware;

namespace TransferPictures
{
    public partial class TransferPicturesForm : Form
    {
        public TransferPicturesForm()
        {
            InitializeComponent();
            //this.treeListView.CanExpandGetter = delegate(IMediaStorage x) { return true; };
            //this.treeListView.ChildrenGetter = delegate(IMediaStorage x) { return ((IMediaStorage)x).Files; };

            this.treeListView.CanExpandGetter = delegate(object x) 
            {
                if (x is IMediaStorage)
                    return true;
                else 
                    return ((MediaInfo)x).IsDirectory(); 
            };
            this.treeListView.ChildrenGetter = delegate(object x)
            {
                if (x is IMediaStorage)
                    return ((IMediaStorage)x).MediaTree;
                else
                    return((MediaInfo)x).Files;
            };
        }

        

        private void btn_Browse_MouseClick(object sender, MouseEventArgs e)
        {
            TransferMedia transfer = new TransferMedia();
            Thread thread = new Thread(
                new ThreadStart(transfer.Initialize));

            thread.Start();

            while (true)
            {
                if (transfer.MediaStorage == null)
                    Thread.Sleep(500);
                else
                    break;

                if (!thread.IsAlive)
                    break;
            }

            if (transfer.MediaStorage.Count != 0)
                this.treeListView.SetObjects(transfer.MediaStorage);
            else
                this.treeListView.SetObjects(null);

            
            
        }

     
    }
}
