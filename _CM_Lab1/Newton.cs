using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CM_Lab1
{
    public class Newton
    {

        App app;
        double a, b, epsilon, X, XPast;
        int iter = 1;

        public Newton(App app)
        {
            this.app = app;
            a = int.Parse(app.textBoxA.Text);
            b = int.Parse(app.textBoxB.Text);
            epsilon = double.Parse(app.comboBoxEpsilon.Text.ToString());
            app.chart.Series.Add("Метод Ньютона");
            app.chart.Series["Метод Ньютона"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            DoX();
        }

        void DoDerivativeCheck(double x)
        {
            if(dFunc(x) == 0 || ddFunc(x) == 0)
            {
                app.listBoxNewton.Items.Add("dFunc(x) == 0 или ddFunc(x) == 0. Метод неприменим.");
            } 
            else 
            {
                return;
            }
        }

        void DoX()
        {
            if(Func(a) * ddFunc(a) > 0)
            {
                X = a;
            }
            else
            {
                X = b;
            }
            Console.WriteLine($"X:{X}");
            DoCalc();
        }

        void DoCalc()
        {
            XPast = X;
            X = XPast - (Func(XPast) / dFunc(XPast));
            app.listBoxBis.Items.Add($"Итерация: {iter}. Значение: {X}");
            app.chart.Series["Метод Ньютона"].Points.AddXY(iter, X);
            DoDerivativeCheck(X);
            Console.WriteLine(X);
            if((double)Math.Abs(X - XPast) <= epsilon)
            {
                ConfirmResult(X);
            }
            else
            {
                iter++;
                DoCalc();
            }
        }

        void ConfirmResult(double Res)
        {
            app.listBoxNewton.Items.Add($"Финальный результат: {Res}. Итераций: {iter}");
            app.chart.Series["Метод Ньютона"].Points.AddXY(iter, Res);
        }

        double Func(double x) => 2 * x - Math.Log10(x) - 7;
        double dFunc(double x) => 2 - (1 / (x * Math.Log10(10)));
        double ddFunc(double x) => 1 / (Math.Pow(x, 2) * Math.Log10(10));

    }
}
