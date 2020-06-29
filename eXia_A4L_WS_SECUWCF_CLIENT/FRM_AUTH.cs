using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;

namespace eXia_A4L_WS_SECUWCF_CLIENT
{

    public partial class frm_auth : Form
    {
        private delegate void SafeCallDelegate(string text);

        private MSG msg;
        private M1_CUT.CUT_AUTH cutAuth;
        private Dictionary<string, string> fileList;
        public frm_auth()
        {
            InitializeComponent();
        }

        private void frm_auth_Load(object sender, EventArgs e)
        {
            this.cutAuth = new M1_CUT.CUT_AUTH();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            this.msg.data = new object[2];

            this.txt_information.Clear();
            if ((this.txt_login.Text != "") && (this.txt_password.Text != ""))
            {
                if (this.txt_service.Text == "Login")
                {
                    this.msg.data[0] = this.txt_login.Text.ToLower();
                    this.msg.data[1] = this.txt_password.Text;
                    this.msg.operationName = this.txt_service.Text;
                }
                else if (this.txt_service.Text == "Decrypt")
                {
                    this.msg.operationName = this.txt_service.Text;
                    this.msg.data = new object[fileList.Count * 2];
                    int i = 0;

                    foreach (var item in fileList)
                    {
                        this.msg.data[i++] = (item.Key);
                        this.msg.data[i++] = (item.Value);
                    }
                }
                else if (this.txt_service.Text == "Decrypted")
                {
                    this.msg.operationName = this.txt_service.Text;
                    this.msg.data = new object[fileList.Count * 2];
                    int i = 0;

                    foreach (var item in fileList)
                    {
                        this.msg.data[i++] = (item.Key);
                        this.msg.data[i++] = (item.Value);
                    }
                }



                Thread t = new Thread(() => ContactServer(this.msg));
                t.Start();

                //this.msg = this.cutAuth.m_auhentifier(this.msg);

                //if (this.msg.statusOp == true)
                //{
                //    this.txt_information.Text = msg.info;
                //}
                //else
                //{
                //    this.txt_information.Text = msg.info;
                //}
            }
            else
            {
                this.txt_information.Text = "Veuillez renseigner tous les champs";
            }

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_go_Click(sender, e);
        }

        public void ContactServer(MSG message)
        {
            message = this.cutAuth.m_auhentifier(message);

            DisplayInformation(message.info);

        }

        private void DisplayInformation(string info)
        {
            if (this.txt_information.InvokeRequired)
            {
                var deleg = new SafeCallDelegate(DisplayInformation);
                txt_information.Invoke(deleg, new object[] { info });
            }
            else
                txt_information.Text = info;
        }

        public void btn_addFileClick(object sender, EventArgs e)
        {
            if (checkBox_resestFile.CheckState == CheckState.Checked || fileList == null)
            {
                checkBox_resestFile.CheckState = CheckState.Unchecked;
                fileList = new Dictionary<string, string>();
            }

            try
            {
                fileList.Add(txt_fileName.Text, txt_fileContent.Text);
                DisplayInformation("File added.");
                txt_fileName.Text = "";
                txt_fileContent.Text = "";
            }
            catch (ArgumentException)
            {
                DisplayInformation("Filename is already used.");
            }
        }
    }
}
