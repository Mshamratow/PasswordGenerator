using PasswordGenerator;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Form1 form = new Form1();
            Assert.False(form.Filter("qwerty")); //Проверяем, как фильтр реагирует на слово, которое есть в текстовом файле
        }

        [Fact]
        public void Test2()
        {
            Form1 form = new Form1();
            Assert. True(form.Filter("zd/(]j")); //Проверяем, как фильтр реагирует на слово, которого нет в текстовом файле
        }

        [Fact]
        public void Test3()
        {
            string spec_syms = "{}()[]/\\'\"`-~,.;:<>";
            Form1 form = new Form1();
            form.comboBox2.SelectedIndex = 1;
            form.generate();
            string text = form.textBox1.Text;
            for (int i = 0; i < text.Length; i++)
            {
                Assert.False(spec_syms.Contains(text[i])); //Проверяем, действительно ли в пароле нет никаких спецзнаков
            }
        }

        [Fact]
        public void Test4()
        {
            Form1 form = new Form1();
            form.generate();
            Assert.True(form.textBox1.Text.Length == 6); //По умолчанию длина пароля должна быть равна 6
        }

        [Fact]
        public void Test5()
        {
            Form1 form = new Form1();
            form.update();
            for (int i = 0;i < form.comboBox4.Items.Count;i++)
            {
                Assert.True(form.comboBox4.Items[i].ToString().EndsWith(".txt")); //Проверяем, все ли файлы формата TXT
            }
        }

        [Fact]
        public void Test6()
        {
            Form1 form = new Form1();
            form.update();
            for (int i = 0; i < form.comboBox4.Items.Count; i++)
            {
                Assert.True(File.Exists(form.comboBox4.Items[i].ToString())); //Проверяем, все ли файлы существуют
            }
        }

        [Fact]

        public void Test7()
        {
            Form1 form = new Form1();
            string password = form.comboBox4.SelectedItem.ToString();
            StreamReader fstream = new StreamReader(password);
            string s;
            while ((s = fstream.ReadLine()) != null)
            {
                if (s == form.textBox1.Text)
                {
                    return;
                }
            }
            Assert.Fail("Password wasn't written to file");
        }

        [Fact]
        public void Test8()
        {
            Form1 form = new Form1();
            Assert.Equal(form.rowsAmount, 10000);
        }

        [Fact]
        public void Test9()
        {
            Form1 form = new Form1();
            Assert.Equal(form.maxlen - form.minlen + 1, form.comboBox3.Items.Count);
        }

        [Fact]
        public void Test10()
        {
            Form1 form = new Form1();
            form.generate();
            Assert.NotEqual(form.textBox1.Text, "");
        }

        [Fact]
        public void Test11()
        {
            Form1 form = new Form1();
            using (var f = new StreamReader("rockyou.txt"))
            {
                string s = f.ReadLine();
                Assert.Equal(s, form.often_used_passwords[0]);
            }
        }

        [Fact]
        public void Test12()
        {
            Form1 form = new Form1();
            Assert.True(form.comboBox1.SelectedIndex != null);
        }

        [Fact]
        public void Test13()
        {
            Form1 form = new Form1();
            Assert.True(form.comboBox2.SelectedIndex != null);
        }

        [Fact]
        public void Test14()
        {
            Form1 form = new Form1();
            Assert.True(form.comboBox3.SelectedIndex != null);
        }

        [Fact]
        public void Test15()
        {
            Form1 form = new Form1();
            Assert.True(form.comboBox4.SelectedIndex != null);
        }
    }
}