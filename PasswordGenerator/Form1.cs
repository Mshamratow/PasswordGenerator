using System.IO;
using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public int minlen = 6, maxlen = 30;
        string alphabet = "abcdefghijklmnopqrstuvwxyz1234567890";
        string special_symbols = "{}()[]/\\'\"`-~,.;:<>";
        string group1 = "i1lL";
        string group2 = "o0O";
        public string[] often_used_passwords = new string[10000];
        public int rowsAmount;

        public void fillArray()
        {
            using (var f = new StreamReader("../../../../rockyou.txt"))
            {
                string s;
                int i = 0;
                while (i < 10000 && (s = f.ReadLine()) != null)
                {
                    often_used_passwords[i] = s;ж
                    i++;
                }
                rowsAmount = i;
            }
        }

        public Form1()
        {
            InitializeComponent();

            DirectoryInfo di = new DirectoryInfo("./");
            foreach (FileInfo fi in di.GetFiles())
            {
                if (!fi.Name.EndsWith(".txt"))
                    continue;
                comboBox4.Items.Add(fi.Name);
            }

            fillArray(); ;

            for (int i = minlen; i <= maxlen; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
            comboBox3.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool Filter(string password)
        {
            for (int i = 0; i < rowsAmount; i++)
            {
                if (password == often_used_passwords[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void generate()
        {
            int length = int.Parse(comboBox3.SelectedItem.ToString());
            string password = "";
            Random rnd = new Random();
            string abc = alphabet;
            if (comboBox2.SelectedItem.ToString() == "да")
                abc += special_symbols;
            for (int i = 0; i < length; i++)
            {
                char symbol;
                do
                {
                    if (comboBox1.SelectedItem.ToString() == "да")
                    {
                        int l = password.Length;
                        if (l > 0)
                        {
                            char sym;
                            do
                            {
                                sym = abc[rnd.Next(0, abc.Length)];
                            } while (sym != password[l - 1] && (group1.Contains(sym) && group1.Contains(password[l - 1]) ||
                            group2.Contains(sym) && group2.Contains(password[l - 1])));
                            symbol = sym;
                        }
                        else symbol = abc[rnd.Next(0, abc.Length)];
                    }
                    else
                        symbol = abc[rnd.Next(0, abc.Length)];
                } while (!Filter(password + symbol));
                password += symbol;
            }
            textBox1.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void update()
        {
            comboBox4.Items.Clear();
            DirectoryInfo di = new DirectoryInfo("./");
            foreach (FileInfo fi in di.GetFiles())
            {
                if (!fi.Name.EndsWith(".txt"))
                    continue;
                comboBox4.Items.Add(fi.Name);
            }
        }

        private void update_file_list(object sender, EventArgs e)
        {
            update();
        }

        public void Write()
        {
            if (textBox1.Text == "" || !File.Exists(comboBox4.SelectedItem.ToString()))
                return;
            using (var f = new StreamWriter(comboBox4.SelectedItem.ToString(), true))
            {
                f.WriteLine(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Write();
        }
    }
}