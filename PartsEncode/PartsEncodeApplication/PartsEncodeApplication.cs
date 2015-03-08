using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;

namespace PartsEncode
{
    public partial class PartsEncodeApplication : Form
    {
        string Part = "P";

        public PartsEncodeApplication()
        {
            InitializeComponent(); ;

            timer1.Enabled = true;

            XmlDocument doc = new XmlDocument();
            doc.Load("App.xml");
            string xmlcontents = doc.InnerXml;
            
            textBoxDate.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            textBoxUser.Text = "K";

            buttonPart.Click += new EventHandler(Button_Click);
            buttonAssembly.Click += new EventHandler(Button_Click);

            LoadFields(xmlcontents);

            UpdatePart();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            switch (bt.Text)
            {
                case "Part" :
                    Part = "P";
                    break;
                case "Assembly":
                    Part = "A";
                    break;
            }
            UpdatePart();

        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            UpdatePart();
        }

        private void textBoxProject_TextChanged(object sender, EventArgs e)
        {
            UpdatePart();
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            UpdatePart();
        }

        public String Encode(long input)
        {
            string CharList = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (input < 0) throw new ArgumentOutOfRangeException("input", input, "input cannot be negative");

            char[] clistarr = CharList.ToCharArray();
            var result = new Stack<char>();
            while (input != 0)
            {
                result.Push(clistarr[input % 36]);
                input /= 36;
            }
            return new string(result.ToArray());
        }

        public void UpdatePart()
        {
            
            DateTime date = DateTime.Parse(textBoxDate.Text);
            string year = date.Year.ToString().Substring(2);
            string month = date.Month.ToString();
            int MMYY = Int32.Parse(month + year);
            string base36MMYY = Encode(MMYY);
            string day = date.Day.ToString() + date.Hour.ToString() + date.Minute.ToString();
            string base36DDhhmm = Encode(long.Parse(day));
            string project = textBoxProject.Text;

            switch (textBoxProject.Text)
            {
                case "POL":
                    project = "PO";
                    break;
            }

            textBoxPart.Text = project + "-" + textBoxUser.Text + base36MMYY + "-" + base36DDhhmm + "-" + Part;

            Clipboard.SetText(textBoxPart.Text);
        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            UpdatePart();
        }

        private void LoadFields(string xmlString)
        {

            textBoxUser.Text = GetFieldValue(xmlString, "User");
            textBoxProject.Text = GetFieldValue(xmlString, "Project");
        }

        private string GetFieldValue(string xmlString, string fieldName)
        {
            XDocument xdoc = XDocument.Parse(xmlString);
            return (string)(
                from el in xdoc.Descendants("Field")
                where (string)el.Element("Name") == fieldName
                select el.Element("Value")).FirstOrDefault();
        }

    }
}
