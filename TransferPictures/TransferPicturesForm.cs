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
using Limilabs.Client.IMAP;

using BrightIdeasSoftware;

namespace TransferPictures
{
    public partial class TransferPicturesForm : Form
    {
        private TransferMedia transfer;

        private Thread refreshthread;
        private Thread runningthread;
        private Thread progressthread;
        private Thread statusthread;

        public TransferPicturesForm()
        {
            InitializeComponent();

            this.toolStripStatusLabel1.Text = String.Empty;
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
            if (transfer == null)
                transfer = new TransferMedia();

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

        private void CheckStatus()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (transfer == null)
                    continue;

                this.Invoke((MethodInvoker)delegate
                {
                    toolStripStatusLabel1.Text = transfer.Progress.Status;                    
                });
            }
        }

        private void ReportProgress(object thread)
        {
            while (((Thread)thread).IsAlive)
            {
                Thread.Sleep(1000);
                this.Invoke((MethodInvoker)delegate
                {
                    toolStripStatusLabel1.Text = transfer.Progress.Status;
                    progressBar.Value = transfer.Progress.Percent; // runs on UI thread
                });
            }

            this.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = transfer.Progress.Status;
                btn_TransferMedia.Enabled = true;
                progressBar.Value = transfer.Progress.Percent; // runs on UI thread
            });
        }

        private void TransferPicturesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TransferPicturesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshthread.Abort();
            
            if (progressthread != null && progressthread.IsAlive)
                progressthread.Abort();

            if (statusthread != null && statusthread.IsAlive)
                statusthread.Abort();

            if (runningthread != null && runningthread.IsAlive)
                runningthread.Abort();
            

        }

        private void TransferPicturesForm_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;

            // start the refresh thread    
            refreshthread = new Thread(
                new ThreadStart(RefreshStorage));

            refreshthread.Start();

            statusthread = new Thread(
                new ThreadStart(CheckStatus));

            statusthread.Start();

        }

        private void ts_btn_EmailAccount_Click(object sender, EventArgs e)
        {
            LoginDialog login = new LoginDialog();
            login.ShowDialog();

            if (login.NewConnection != null)
            {
                transfer.AddMailConnection(login.NewUser, login.NewConnection);
            }
        }

        private void ts_btn_DeleteStorage_Click(object sender, EventArgs e)
        {
            transfer.delete();
        }
     
    }
}
