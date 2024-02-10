using System.Runtime.CompilerServices;

namespace oti2011_judeteana
{
    public partial class messengerForm : Form
    {
        public messengerForm()
        {
            InitializeComponent();
        }

        private void ionelBtn_Click(object sender, EventArgs e)
        {
            string text = entermsgRtb.Text;
            string name = "Ionel: ";
            DisplayText(text, name, Color.Blue);
        }

        private void mariaBtn_Click(object sender, EventArgs e)
        {
            string text = entermsgRtb.Text;
            string name = "Maria: ";
            DisplayText(text, name, Color.Red);
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            displaymsgRtb.Text = string.Empty;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                displaymsgRtb.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                displaymsgRtb.LoadFile(openFileDialog1.FileName);
            }
        }

        private void AppendLine(RichTextBox box, string text, Color color)
        {
            box.SelectionColor = color;
            box.AppendText(text);
        }

        private void DisplayText(string text, string name, Color color)
        {
            if (text != string.Empty)
            {
                string ionelText = name + text + "\n";
                AppendLine(displaymsgRtb, ionelText, color);
                entermsgRtb.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Nu ai introdus niciun mesaj.");
            }
        }
    }
}
