using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NazyrikNET
{
    public partial class Register : Form
    {
        const int KEY = 4;
        private Autorization autorization_;
        public Register(Autorization autorization)
        {
            InitializeComponent();
            autorization_ = autorization;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void panel_BackToAuto_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(panel_BackToAuto.Parent.BackColor);
            Control control = panel_BackToAuto;
            int radius = 30;
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddLine(radius, 0, control.Width - radius, 0);
                path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                path.AddLine(control.Width, radius, control.Width, control.Height - radius);
                path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                path.AddLine(control.Width - radius, control.Height, radius, control.Height);
                path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
                path.AddLine(0, control.Height - radius, 0, radius);
                path.AddArc(0, 0, radius, radius, 180, 90);
                using (SolidBrush brush = new SolidBrush(control.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
        private void panel_Register_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(panel_Register.Parent.BackColor);
            Control control = panel_Register;
            int radius = 30;
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddLine(radius, 0, control.Width - radius, 0);
                path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                path.AddLine(control.Width, radius, control.Width, control.Height - radius);
                path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                path.AddLine(control.Width - radius, control.Height, radius, control.Height);
                path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
                path.AddLine(0, control.Height - radius, 0, radius);
                path.AddArc(0, 0, radius, radius, 180, 90);
                using (SolidBrush brush = new SolidBrush(control.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("При регистрации, каждом доступе и/или фактическом использовании любого из Сервисов,\n Пользователь соглашается с условиями настоящего Соглашения, Общей политикой конфиденциальности Сервисов NazyrikNET,\n а также с условиями соглашений, положений и правил используемых им Сервисов,\n которые размещены на страницах (в разделах) соответствующих Сервисов, в редакциях,\n которые действовали на момент фактического использования таких Сервисов. ", "Пользовательское соглашение");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (autorization_ == null || autorization_.IsDisposed) 
            { Autorization autorization = new Autorization(); autorization.Show(); }
            else 
            {autorization_.Show();this.Close();}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Появление надписи "Обязательное поле"
            bool warning = false;
            if (textBoxName == null || textBoxName.Text == "") { labelImpField1.Visible = true; warning = true; } 
            else { labelImpField1.Visible = false; }
            if (textBoxSurname == null || textBoxSurname.Text == "") { labelImpField2.Visible = true; warning = true; } 
            else { labelImpField2.Visible = false; }
            if (textBoxDate == null || textBoxDate.Text == "") { labelImpField3.Visible = true; warning = true; } 
            else { labelImpField3.Visible = false; }
            if (textBoxMail == null || textBoxMail.Text == "") { labelImpField4.Visible = true; warning = true; } 
            else { labelImpField4.Visible = false; }
            if (textBoxPassword == null || textBoxPassword.Text == "") { labelImpField5.Visible = true; warning = true; } 
            else { labelImpField5.Visible = false; }
            if( labelImpField1.Visible == false & 
                labelImpField2.Visible == false & 
                labelImpField3.Visible == false & 
                labelImpField4.Visible == false & 
                labelImpField5.Visible == false )
                warning = false;
            //Проверка для запуска
            if (checkBox1.Checked == true)
            {
                labelImpField6.Visible = false;
                if(warning == false)
                    try
                    {
                        //GET VALUE FROM TEXTBOXS
                        string path = System.IO.Directory.GetCurrentDirectory() + @"\bin.txt";
                        string sex = "";
                        if (radioButton2.Checked == true) 
                            sex = radioButton2.Text; else sex = radioButton1.Text;
                        string longLine = $"NewPol {textBoxName.Text} {textBoxSurname.Text} {sex} {textBoxDate.Text} {textBoxMail.Text} {textBoxPassword.Text} {Environment.NewLine}"; //Line for work with mass
                                     
                        //FILE ENCRYPTION 
                        FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                        cryptoServiceProvider.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                        cryptoServiceProvider.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                        CryptoStream cryptoStream = new CryptoStream(stream, cryptoServiceProvider.CreateEncryptor(),CryptoStreamMode.Write);
                        byte[] cryptoData = ASCIIEncoding.ASCII.GetBytes(longLine);
                        cryptoStream.Write(cryptoData, 0, cryptoData.Length);
                        cryptoStream.Close();
                        stream.Close();

                                        //byte[] buf = Encoding.Unicode.GetBytes(longLine);
                                        //for (int i = 0; i < buf.Length; i++) 
                                        //    buf[i] = (byte)(buf[i] ^ KEY);
                                        //longLine = Encoding.Unicode.GetString(buf);
                                        //File.AppendAllText(path, longLine);

                                        //File.AppendAllLines(path, DATA_Pol);

                        //SUCCESFULLY
                        MessageBox.Show("Пользователь зарегистрирован!", "Регистрация");
                        if (autorization_ == null || autorization_.IsDisposed)
                        { Autorization autorization = new Autorization(); autorization.Show(); }
                        else
                        { autorization_.Show(); this.Close(); }
                    }
                    catch (Exception ex) { MessageBox.Show(Text, ex.Message); };
            }
            else labelImpField6.Visible = true;
        }
    }
}
