using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistinctBlocoNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fileResult = openFileDialog1.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            else
            {
                textBox1.Text = "";
                return;
            }

            var file = File.ReadAllLines(textBox1.Text).Where(x => !string.IsNullOrWhiteSpace(x)).ToList().Distinct().ToList();

            var novalista = file.Select(item => item.Replace("\"", "").Trim()).Distinct().ToList();

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = openFileDialog1.FileName;
            var fileSave = saveFileDialog1.ShowDialog();
            if (fileSave == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, novalista);
            }
            MessageBox.Show("Sucesso!!");
        }
    }
}
