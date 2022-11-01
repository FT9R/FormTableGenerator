using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTableGenerator
{
    public partial class Form1 : Form
    {
        public const double PI = 3.1415926535897932384626433832795;
        private UInt64[] DacValArr;
        private string DacValString;
        private UInt64 Item_cnt;
        public Form1()
        {
            InitializeComponent();
        }

        private double Deg2Rad(double Deg) { return Deg * PI / 180; }
        private double Triangle(double Deg)
        {
            if ((Deg < 0) && (Deg >= 360)) return double.NaN;
            else if (Deg <= 180) return 1.0 / 180 * Deg;
            else return (-1.0 / 180 * Deg) + 2;
        }
        private double Saw(double Deg)
        {
            if ((Deg < 0) && (Deg >= 360)) return double.NaN;
            else return 1.0 / 360 * Deg;
        }
        private int Noize(double Seed, int MaxVal)
        {
            var rand1 = new Random();
            var seed = rand1.Next();
            var rand2 = new Random(seed + Convert.ToInt32(Seed));
            return rand2.Next(MaxVal);
        }

        private void Start_BT_Click(object sender, EventArgs e)
        {
            bool InputDataStat = true;
            UInt16 Resolution = 12;
            UInt16 Samples = 128;
            UInt16 Rows = 8;
            string FileName = Path.Combine(Environment.CurrentDirectory, "OUT.csv");

            try
            {
                Resolution = Convert.ToUInt16(Resolution_TB.Text);
                Samples = Convert.ToUInt16(Samples_TB.Text);
                Rows = Convert.ToUInt16(Rows_TB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format");
                InputDataStat = false;
            }
            finally
            {
                DacValArr = new UInt64[Samples];
                if ((Resolution_TB.Text == "0") || (Samples_TB.Text == "0") || (Rows_TB.Text == "0"))
                {
                    MessageBox.Show("Insignificant value");
                    InputDataStat = false;
                }
                if ((Samples % Rows) != 0)
                {
                    MessageBox.Show("Make sure that Samples/Rows = integer value");
                    InputDataStat = false;
                }
            }

            if (InputDataStat)
            {
                UInt16 DAC_Amp = (UInt16)(Math.Pow(2, Resolution) - 1);
                UInt16 ValuesPerRow = (UInt16)(Samples / Rows);
                UInt16 Values_cnt = 0;
                try
                {
                    StreamWriter OUT = new StreamWriter(FileName);

                    /* Check for desired waveform */
                    if (Sin_RB.Checked)
                    {
                        for (double d = 0; d < 360;)    // filling values array by Sin values
                        {
                            DacValArr[Values_cnt++] = Convert.ToUInt64((DAC_Amp / 2) * Math.Sin(Deg2Rad(d)) + (DAC_Amp / 2));
                            d += 360.0 / Samples;
                        }
                    }
                    else if (Triangle_RB.Checked)
                    {
                        for (double d = 0; d < 360;)    // filling values array by Triangle values
                        {
                            DacValArr[Values_cnt++] = Convert.ToUInt64(DAC_Amp * Triangle(d));
                            d += 360.0 / Samples;
                        }
                    }
                    else if (Saw_RB.Checked)
                    {
                        for (double d = 0; d < 360;)    // filling values array by Saw values
                        {
                            DacValArr[Values_cnt++] = Convert.ToUInt64(DAC_Amp * Saw(d));
                            d += 360.0 / Samples;
                        }
                    }
                    else if (Noize_RB.Checked)
                    {
                        for (double d = 0; d < 360;)    // filling values array by Random values
                        {
                            DacValArr[Values_cnt++] = Convert.ToUInt64(Noize(d, DAC_Amp));
                            d += 360.0 / Samples;
                        }
                    }

                    /* forming output file */
                    foreach (var item in DacValArr)
                    {
                        if (((Item_cnt % ValuesPerRow) == 0) && (Item_cnt != 0))
                        {
                            OUT.Write("\r\n");
                        }
                        if (++Item_cnt < Samples)
                        {
                            OUT.Write(Convert.ToString(item) + ',');
                        }
                        else { OUT.Write(Convert.ToString(item)); Item_cnt = 0; }
                    }
                    OUT.Close();
                }
                catch (IOException) { MessageBox.Show("File is already in use", "Failed to access file", MessageBoxButtons.OK, MessageBoxIcon.Hand); this.Close(); }
                catch (Exception) { MessageBox.Show("Global exception", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand); this.Close(); }
                MessageBox.Show("Completed.\n" + "Pull content from clipboard\n" + "Or check 'OUT.csv' in the directory");

                /* copying to clipboard */
                foreach (var item in DacValArr)
                {
                    if (((Item_cnt % ValuesPerRow) == 0) && (Item_cnt != 0))
                    {
                        DacValString += ("\r\n");
                    }
                    if (++Item_cnt < Samples)
                    {
                        DacValString += Convert.ToString(item);
                        DacValString += ',';
                    }
                    else { DacValString += (Convert.ToString(item)); Item_cnt = 0; }
                }
                Clipboard.SetData(DataFormats.Text, DacValString);
                this.Close();
            }
        }
    }
}