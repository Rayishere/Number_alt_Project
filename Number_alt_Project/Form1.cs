using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace Number_alt_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double reqest_to_know = Math.Pow(2, 32);
            double que = reqest_to_know - 1;
           
            for (double i = 2; i < que; i++)
            {
                if (que % i == 0)
                {
                    lbl_q1_output.Text = "No!";
                    MessageBox.Show("This is not a prime nubmer " + que.ToString(),
                        "Question 1",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                else if(que % i != 0)
                {
                    lbl_q1_output.Text = "Yes!";
                    MessageBox.Show("This is a prime nubmer " + que.ToString(),
                        "Question 1",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                }
            }
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            txt_q2_out.Clear();
            txt_q2_result.Clear();
            if (txt_input.Text == null)
            {
                MessageBox.Show("Please input some text.", "Note",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                string input = txt_input.Text;
                string output = string.Empty;
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                BitArray bits = new BitArray(bytes);

                try
                {
                    txt_q2_out.Text += bittostr(bits) + Environment.NewLine;
                    txt_q2_out.Text += BitConverter.ToString(bytes) +
                        Environment.NewLine + "Input Text: " +
                        Encoding.UTF8.GetString(bytes) + Environment.NewLine +
                        "Total Binary Count:" + bits.Count.ToString();

                    //Start to perform exchange
                    //The number of blocks we required
                    int bits_count_loop = 1;
                    int temp_cout = 0;

                    //temporary bitaray
                    BitArray temp_bitarray = new BitArray(16);
                    BitArray swaped_bitarrray = new BitArray(16);
                    //Empty bitarray
                    BitArray bits_result;

                    if (bits.Length % 16 == 0)
                    {
                        bits_result = new BitArray(bits.Length);
                    }
                    else
                    {
                        bits_result = new BitArray(bits.Length + 8);
                    }

                    //Swap position
                    for (int i = 0; i < bits.Length; i++)
                    {
                        Console.Write(temp_cout.ToString());
                        temp_bitarray[temp_cout] = bits[i];
                        temp_cout++;

                        if (bits_count_loop == 16)
                        {
                            swaped_bitarrray = p16(temp_bitarray);
                            
                            int cc = 0;
                            for(int s = 0; s < bits.Length; s++)
                            {
                                bits_result[s] = swaped_bitarrray[cc];
                                cc++;
                                if (cc == 15)
                                {
                                    cc = 0;
                                }
                            }
                            temp_bitarray = new BitArray(16);
                            temp_cout = 0;
                            bits_count_loop = 1;
                        }
                        bits_count_loop++;
                    }

                    //----print theresult-----//
                    txt_q2_result.Text += bittostr(bits_result);

                    byte[] print_byte = new byte[bits_result.Length / 8];
                    bits_result.CopyTo(print_byte, 0);

                    txt_q2_result.Text += Environment.NewLine + BitConverter.ToString(print_byte) +
                        Environment.NewLine + "Result Text: " + Encoding.UTF8.GetString(print_byte) + 
                        Environment.NewLine + "Total Binary Count:" + bits_result.Count.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.ToString());
                }
            }
            
        }

        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2.Focus();
                button2_Click(sender, e);
                txt_input.Focus();
            }
            
        }

        //change position
        public static BitArray p16 (BitArray text_in)
        {
           // Console.WriteLine(bittostr(text_in));
            BitArray decoder = new BitArray(16);

            decoder[0] = text_in[0];
            decoder[1] = text_in[4];
            decoder[2] = text_in[13];
            decoder[3] = text_in[1];
            decoder[4] = text_in[2];
            decoder[5] = text_in[15];
            decoder[6] = text_in[11];
            decoder[7] = text_in[8];
            decoder[8] = text_in[3];
            decoder[9] = text_in[10];
            decoder[10] = text_in[6];
            decoder[11] = text_in[12];
            decoder[12] = text_in[5];
            decoder[13] = text_in[9];
            decoder[14] = text_in[0];
            decoder[15] = text_in[7];

           // Console.WriteLine("-----------------");
           // Console.WriteLine(bittostr(decoder));

            return decoder;

        }

        public static string bittostr(BitArray ba)
        {
            string[] str_array = new string[ba.Length];
            string complete_str = "";
            int count_loop = 1;
            StringBuilder sb = new StringBuilder();
            
            for (int x = 0; x < ba.Length; x++)
            {
                bool res_bit_display = ba.Get(x);

                if (res_bit_display == true)
                {
                    str_array[x] = "1";
                }
                else
                {
                    str_array[x] = "0";
                }
                
                //string segmentation
                if ( count_loop < 8)
                {
                    sb.Append(str_array[x]);
                    count_loop++;
                }
                else if (count_loop == 8)
                {
                    sb.Append(str_array[x]);
                    sb.AppendLine();
                    count_loop = 1;
                }
            }
            return complete_str = sb.ToString();
        }
    }
}
