using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema_4_acasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////1.
            int[] lista = new int[6] { 4, 8, 15, 16, 23, 42};
            int poz = -1;
            for (int i = 0; i < lista.Length; i++)
                if (lista[i] == 15)
                    poz = i;
            if (poz != -1)
                Console.WriteLine("Numarul 15 se afla pe pozitia " + (poz+1));
            else
                Console.WriteLine("Nu exista numarul 15");


            ////2.
            int[] v=new int[7] { 42,8,4,16,23,15,16};
            bool ok = true;
            int pozi = -1;
            for (int i = 0; i < v.Length; i++)
                if (v[i] == 16 && ok == true)
                {
                    pozi = i;
                    ok = false;
                }
            Console.WriteLine("Numarul 16 este pe pozitia " + (pozi+1));
            
            
            for (int i = 0; i < v.Length; i++)
                if (v[i] == 16)
                    Console.WriteLine("Numarul 16 se afla pe pozitia " + (i + 1));
        }
    }
}
