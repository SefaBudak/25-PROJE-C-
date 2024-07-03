using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassaParola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, doğru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "Akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();

                        }
                        break;
                        //cevap1
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            button2.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap2
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 3:
                        if (textBox1.Text == "Cuma")
                        {
                            button8.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap3
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 4:
                        if (textBox1.Text == "Diyarbakır")
                        {
                            button7.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap4
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 5:
                        if (textBox1.Text == "Eski")
                        {
                            button6.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap5
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 6:
                        if (textBox1.Text == "Fenerbahçe")
                        {
                            button5.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap6
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 7:
                        if (textBox1.Text == "Güneş")
                        {
                            button4.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap7
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 8:
                        if (textBox1.Text == "Halı")
                        {
                            button3.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap8
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 9:
                        if (textBox1.Text == "İstanbul")
                        {
                            button21.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap9
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 10:
                        if (textBox1.Text == "Isparta")
                        {
                            button15.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap10
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 11:
                        if (textBox1.Text == "Jandarma")
                        {
                            button14.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap11
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 12:
                        if (textBox1.Text == "Kangal")
                        {
                            button13.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap12
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 13:
                        if (textBox1.Text == "Lale")
                        {
                            button12.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap13
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 14:
                        if (textBox1.Text == "Mersin")
                        {
                            button11.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap14
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 15:
                        if (textBox1.Text == "Ney")
                        {
                            button10.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap15
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 16:
                        if (textBox1.Text == "Ozan")
                        {
                            button9.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap16
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 17:
                        if (textBox1.Text == "Plaka")
                        {
                            button20.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap17
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 18:
                        if (textBox1.Text == "Ramazan")
                        {
                            button19.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap18
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 19:
                        if (textBox1.Text == "Sivas")
                        {
                            button18.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap19
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 20:
                        if (textBox1.Text == "Termos")
                        {
                            button17.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap20
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 21:
                        if (textBox1.Text == "Urfa")
                        {
                            button16.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap21
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 21:
                        if (textBox1.Text == "Van")
                        {
                            button24.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap22
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 22:
                        if (textBox1.Text == "Yaz")
                        {
                            button23.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap23
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 23:
                        if (textBox1.Text == "Zebra")
                        {
                            button22.BackColor = Color.Green;
                            doğru++;
                            label4.Text = doğru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        //cevap24
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Cevapla";
            soruno++;
            this.Text = soruno.ToString();


            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin Güney Kısmındaki Kıyı Bölgesi?";
                button1.BackColor = Color.Yellow;

            }
            if (soruno == 2) 
            {
                richTextBox1.Text = "İskenderi Meşhur Olan İlimiz?";
                button2.BackColor = Color.Yellow;
            }
            if(soruno == 3) 
            {
                richTextBox1.Text = "Müslümanların Kutsal Günü?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla Ünlü İlimiz?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni Kelimesinin Zıt Anlamlısı?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Türkiyenin En Büyük Spor Kulübu?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın Isı Kaynağı?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin Kötü Not Getirdiğinde Bakıştığı Şey?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Türkiyenin En Kalbalık Şehri?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Gülüyle Ünlü İlimiz?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Kırsal Alanlara Bakan Güvenlik Birimi?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Sivasın Meşhur Hayvanı?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her Yıl Festivali Düzenlenen Çiçek Türü?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Tantunisi İle Ünlü Olan Şehir?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli Bir Müzik Aleti?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk Şairi?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Arabaların Ön ve Arka Tamponunda Olan Şey?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayın Sultanı?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Türkiyenin Yüzölçümü En Büyük 2. İli?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "İçecekleri Sıcak Ve Soğuk Tutar?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Balıklıgölün Olduğu Şehir?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Türkiyede Kedisi Meşhur Olan İl?";
                button24.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Havanın Sıcak Olduğu Mevsim?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Siyah Beyaz Bir Hayvan?";
                button22.BackColor = Color.Yellow;
            }
        }
    }
}
