using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Diagnostics;

namespace _4_5
{
    public partial class Form1 : Form
    {
        private Calculater _calk;
        private double[,] _arr;

        private int _n;
        private double _a;
        private double _tau;
        private double _t1;
        private double _t2;
        private double _t3;
        private double _t4;
        private double _time;
        private double _size;
        private double _h;
        private double _k = 0;

//        private bool END = false;
        private bool _draw = false;
  //      private bool STATE = true;

        public Form1()
        {
            InitializeComponent();
            _calk = new Calculater();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           panel1, new object[] { true });
        }

        // Сброс данных
        private void DoReset()
        {
            _n = 0;
            _a = 0;
            _tau = 0;
            _t1 = 0;
            _t2 = 0;
            _t3 = 0;
            _t4 = 0;
            _time = 0;
            _size = 0;
            _k = 0;
            _draw = false;
         //   END = false;
         //   panelEND.Invalidate();
            timer1.Enabled = false;
            Cursor = Cursors.Default;
        }

        // считываем начальные значения
        private void PrepareData()
        {
            _a = Convert.ToDouble(tbA.Text);
            _n = Convert.ToInt32(nudN.Value); // количество разбиений
            _tau = Convert.ToDouble(tbTay.Text);
            _t1 = Convert.ToDouble(tbLeft.Text);
            _t2 = Convert.ToDouble(tbDown.Text);
            _t3 = Convert.ToDouble(tbRight.Text);
            _t4 = Convert.ToDouble(tbUp.Text);
            _time = Convert.ToDouble(tbTime.Text);
            _size = Convert.ToDouble(tbSize.Text); // размер

            _h = _size / _n;

            // Создание и определение массива
            _arr = new double[_n, _n];
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _arr[i, j] = 0;
                    //  Левая граница
                    if (i == 0)
                    {
                        _arr[i, j] = _t1;
                    }
                    // Правая граница
                    if (i == (_n - 1))
                    {
                        _arr[i, j] = _t3;
                    }
                    // Нижняя граница
                    if (j == (_n - 1))
                    {
                        _arr[i, j] = _t2;
                    }
                    // Верхняя граница
                    if (j == (_n - 1))
                    {
                        _arr[i, j] = _t4;
                    }
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            _draw = true;
            timer1.Enabled = true;
        //    END = false;
            StartReadingData();
            panel1.Invalidate();
            //  panelEND.Invalidate();
            rtb.AppendText("Расчёт запущен" + Environment.NewLine);
            Cursor = Cursors.WaitCursor;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            _calk.PrintFile();
            DoReset();
        }

        private double Normalaze(double x, double xmin, double xmax, double d1, double d2)
        {
            return ((x - xmin) * (d2 - d1)) / (xmax - xmin) + d1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!_draw) return;

            double sizepixel = 500 / _n;

            Graphics g = e.Graphics;

            double max = _arr.Cast<double>().Max();
            double min = _arr.Cast<double>().Min();

            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    int rc = Convert.ToInt32(Normalaze(_arr[i, j], min, max, 0, 255));
                    int gc = Convert.ToInt32(Normalaze(_arr[i, j], min, max, 0, 255));
                    int bc = 255 - Convert.ToInt32(Normalaze(_arr[i, j], min, max, 0, 255));
                    Color c = Color.FromArgb(rc, gc, bc);

                    Brush brush = new SolidBrush(c);
                    g.FillRectangle(brush, Convert.ToInt32(i * sizepixel), Convert.ToInt32(j * sizepixel), Convert.ToInt32(sizepixel), Convert.ToInt32(sizepixel));
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (_k < _time && _calk.State() == true)
            {
                    _calk.CalculateOne(false);
                    _k += _tau;
                    panel1.Invalidate();
                }
            
            else
            {
                if (_calk.State() == false)
                {/* rtb.AppendText("Уравнение не устойчиво" + Environment.NewLine);*/ DoReset(); }
                //  END = true;
                //  panelEND.Invalidate();
                rtb.AppendText("Расчёт окончен" + Environment.NewLine);
                Cursor = Cursors.Default;
                _calk.PrintFile();
                timer1.Enabled = false;
            }
              
        }

        private void panelEND_Paint(object sender, PaintEventArgs e)
        {
           /* double sizepixel = 50;
            int rc;
            int gc;
            int bc;

            if (END == false)
            {
                rc = 255;
                gc = 255;
                bc = 255;
            }
            else
            {
                rc = 255;
                gc = 0;
                bc = 0;
            }

            Graphics g = e.Graphics;
            Color c = Color.FromArgb(rc, gc, bc);
            Brush brush = new SolidBrush(c);
            g.FillRectangle(brush, 0, 0, Convert.ToInt32(sizepixel), Convert.ToInt32(sizepixel));
            */
        }

        private void Test(bool p)
        {
            Cursor = Cursors.WaitCursor;

            Stopwatch sw = new Stopwatch();
            sw.Start();            

            if (_k < _time && p == false)
            {
                while (_k < _time)
                {
                    _calk.CalculateOne(false);
                    _k += _tau;
                }
                _calk.PrintFile(Convert.ToString(p));
                DoReset();
            }

            if (_k < _time && p == true)
            {
                while (_k < _time)
                {
                    _calk.CalculateOne(true);
                    _k += _tau;
                }
                _calk.PrintFile(Convert.ToString(p));
                DoReset();
            }

            sw.Stop();
            rtb.AppendText(Convert.ToString(Convert.ToDouble(sw.ElapsedMilliseconds)/1000) + "     Параллелизм = " + Convert.ToString(p) + Environment.NewLine);
            Cursor = Cursors.Default;
        }

        private void StartReadingData()
        {
            PrepareData();
            _calk.SetData(_n, _a, _tau, _arr, _h, _time, _t1, _t2, _t3, _t4);

            if (!_calk.State())
            {
                MessageBox.Show("Условие устойчивости нарушенo");
                return;
            }
            else rtb.AppendText( "Уравнение устойчиво" + Environment.NewLine);

        }

        private void btTest_Click(object sender, EventArgs e)
        {
            rtb.AppendText("Расчёт запущен" + Environment.NewLine);
            StartReadingData();
            if (_calk.State()) Test(true);
            rtb.AppendText("Расчёт окончен" + Environment.NewLine);
            rtb.AppendText("Расчёт запущен" + Environment.NewLine);
            StartReadingData();
            if (_calk.State()) Test(false);
            rtb.AppendText("Расчёт окончен" + Environment.NewLine);
        }

        private void btfast_Click(object sender, EventArgs e)
        {
            StartReadingData();
            rtb.AppendText("Расчёт запущен" + Environment.NewLine);
            if (_calk.State())   Test(true);
            rtb.AppendText("Расчёт закончен" + Environment.NewLine);
            _calk.PrintFile();
        }
    }
}
