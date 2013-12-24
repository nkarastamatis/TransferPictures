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
        private TransferMedia transfer = new TransferMedia();

        private Thread refreshthread;
        private Thread runningthread;
        private Thread progressthread;

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

        private void RefreshStorage()
        {
            while (true)
            {
                if (transfer.Refresh())
                    this.treeListView.SetObjects(transfer.MediaStorage);

                Thread.Sleep(5000);
            }
        }

        private void btn_TransferMedia_MouseClick(object sender, MouseEventArgs e)
        {
            btn_TransferMedia.Enabled = false;

            runningthread = new Thread(
                new ThreadStart(transfer.transfer));
           
            runningthread.Start();

            progressthread = new Thread(
                new ParameterizedThreadStart(ReportProgress));

            progressthread.Start(runningthread);
            
        }

        private void ReportProgress(object thread)
        {
            while (((Thread)thread).IsAlive)
            {
                Thread.Sleep(1000);
                this.Invoke((MethodInvoker)delegate
                {
                    progressBar.Value = transfer.Progress.Current; // runs on UI thread
                });
            }

            this.Invoke((MethodInvoker)delegate
            {
                btn_TransferMedia.Enabled = true;
                progressBar.Value = transfer.Progress.Current; // runs on UI thread
            });
        }

        private void TransferPicturesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TransferPicturesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshthread.Abort();
            
            if (progressthread.IsAlive)
                progressthread.Abort();

            if (runningthread.IsAlive)
                runningthread.Abort();
            

        }

        private void TransferPicturesForm_Shown(object sender, EventArgs e)
        {
            // start the refresh thread    
            refreshthread = new Thread(
                new ThreadStart(RefreshStorage));

            refreshthread.Start();
        }
     
    }
}
