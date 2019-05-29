using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5
{
    public class Calculater
    {
        private double[,] _arr;
        public double[,] Arr    // оставляем доступ для внешних классов
        {
            get
            {
                return _arr;
            }
        }

        private int _n;
        private double _a;
        private double _tau;
        private double _h;
        private bool _state = true;
        private double _time;
        private double _t1;
        private double _t2;
        private double _t3;
        private double _t4;


        public void SetData(int n, double a, double tau, double[,] U, double h, double time, double d1, double d2, double d3, double d4)
        {
            _a = a;
            _n = n;
            _tau = tau;
            _arr = U;
            _h = h;
            _time = time;
            _t1 = d1;
            _t2 = d2;
            _t3 = d3;
            _t4 = d4;
        }

        // Проверка на устойчивость
        public bool State()
        {
            if ((_a * _a * _tau / _h / _h) > (0.25))
            {
                return false;
            }
            return true;
        }

        public void Difrent(bool p)
        {

            
            if (p == true)
            {
                Parallel.For(0, _n, i =>
                {
                    for (int j = 0; j < _n; j++)
                    {
                        if (i == 0)
                        {
                            Arr[i, j] = _t1;
                        }
                        if (i == _n - 1)
                        {
                            Arr[i, j] = _t3;
                        }
                        if (j == 0)
                        {
                            Arr[i, j] = _t4;
                        }
                        if (j == _n - 1)
                        {
                            Arr[i, j] = _t2;
                        }
                        if (i != 0 && i != _n - 1 && j != 0 && j != _n - 1)
                        {
                            Arr[i, j] = _arr[i, j] + (_a * _a * _tau / _h / _h) * (_arr[i - 1, j] + _arr[i + 1, j] + _arr[i, j - 1] + _arr[i, j + 1] - 4 * _arr[i, j]);
                        }
                    }
                });
            }

            else
            {
                for (int i = 0; i < _n; i++)
                {
                    for (int j = 0; j < _n; j++)
                    {
                        if (i == 0)
                        {
                            Arr[i, j] = _t1;
                        }
                        if (i == _n - 1)
                        {
                            Arr[i, j] = _t3;
                        }
                        if (j == 0)
                        {
                            Arr[i, j] = _t4;
                        }
                        if (j == _n - 1)
                        {
                            Arr[i, j] = _t2;
                        }
                        if (i != 0 && i != _n - 1 && j != 0 && j != _n - 1)
                        {
                            Arr[i, j] = _arr[i, j] + (_a * _a * _tau / _h / _h) * (_arr[i - 1, j] + _arr[i + 1, j] + _arr[i, j - 1] + _arr[i, j + 1] - 4 * _arr[i, j]);
                        }
                    }
                }

            }

        //    PrintFile(Convert.ToString(p));
        }

        public void SetSave()

        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _arr[i, j] = Arr[i, j];
                }
            }
        }

        public void PrintFile(string p = "true")
        {
            StreamWriter sw = File.CreateText("Data" + p + ".csv");

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    sw.Write(Convert.ToString(_arr[i, j]));
                    sw.Write(";");
                }
                sw.WriteLine("");
            }
            sw.Write("END\n");
            sw.Close();
        }



        public void CalculateOne(bool p)
        {
            Difrent(p);
           
            // Пересчёт
            SetSave();  // Сохраняем результаты перед следующей итерацией
           // PrintFile(Convert.ToString(p)); // Сохраняем в фаил
        }
    }
}
