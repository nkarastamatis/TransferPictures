using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaLib;
using Limilabs.Client.IMAP;

namespace TransferPictures
{
    public partial class LoginDialog : Form
    {
        private Dictionary<string, string> ImapServers = new Dictionary<string, string>
        {
            {"Gmail", "imap.gmail.com"},
            {"Yahoo Mail", "imap.mail.yahoo.com"}
        };

        public Imap NewConnection { get; set; }
        public string NewUser { get; set; }

        public LoginDialog()
        {
            InitializeComponent();
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            label_Invalid.Text = String.Empty;

            cb_AccountType.DataSource = new BindingSource(ImapServers, null);
            cb_AccountType.DisplayMember = "Key";
            cb_AccountType.ValueMember = "Value";

            tb_Email.SelectionStart = 0;  //This keeps the text
            tb_Email.SelectionLength = 0; //from being highlighted
            tb_Email.Text = "Email";
            tb_Email.ForeColor = Color.Gray;            

            tb_Password.SelectionStart = 0;  //This keeps the text
            tb_Password.SelectionLength = 0; //from being highlighted
            tb_Password.Text = "Password";
            tb_Password.ForeColor = Color.Gray;
        }

        private void tb_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (tb_Email.Text.Equals("Email") == true)
            {
                tb_Email.Text = "";
                tb_Email.ForeColor = Color.Black;
            }
        }

        private void tb_Email_KeyUp(object sender, KeyEventArgs e)
        {
            if (tb_Email.Text.Equals(null) == true || tb_Email.Text.Equals("") == true)
            {
                tb_Email.Text = "Email";
                tb_Email.ForeColor = Color.Gray;
            }
        }

        private void tb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (tb_Password.Text.Equals("Password") == true)
            {
                this.tb_Password.PasswordChar = '•';
                tb_Password.Text = "";
                tb_Password.ForeColor = Color.Black;
                
            }

            label_Invalid.Text = String.Empty;
        }

        private void tb_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (tb_Password.Text.Equals(null) == true || tb_Password.Text.Equals("") == true)
            {                
                
            }
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            MailCredentials credentials = 
                new MailCredentials((string)cb_AccountType.SelectedValue, tb_Email.Text, tb_Password.Text);

            tb_Password.Text = String.Empty;

            Imap imap = credentials.Imap();

            if (imap != null)
            {
                NewConnection = imap;
                NewUser = tb_Email.Text;
                this.Close();
            }
            else
            {
                label_Invalid.Text = "Invalid Credentials";
            }

            Cursor.Current = Cursors.Default;
        }
    }

    class ColorSelector : ComboBox
    {
        public ColorSelector()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Draws the items into the ColorSelector object
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            DropDownItem item = (DropDownItem)Items[e.Index];
            // Draw the colored 16 x 16 square
            e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);
            // Draw the value (in this case, the color name)
            e.Graphics.DrawString(item.Value, e.Font, new
                    SolidBrush(e.ForeColor), e.Bounds.Left + item.Image.Width, e.Bounds.Top + 2);

            base.OnDrawItem(e);
        }
    }

    public class DropDownItem
    {
        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }
        private string value;

        public Image Image
        {
            get { return img; }
            set { img = value; }
        }
        private Image img;

        public DropDownItem()
            : this("")
        { }

        public DropDownItem(string val)
        {
            value = val;
            this.img = new Bitmap(16, 16);
            Graphics g = Graphics.FromImage(img);
            Brush b = new SolidBrush(Color.FromName(val));
            g.DrawRectangle(Pens.White, 0, 0, img.Width, img.Height);
            g.FillRectangle(b, 1, 1, img.Width - 1, img.Height - 1);
        }

        public override string ToString()
        {
            return value;
        }
    }
}
