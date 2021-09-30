using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CM_Lab1
{
    public class Chord
    {

        App app;
        double a, b, x0, x1, epsilon, X, XNext;
        int iter = 1;

        public Chord(App app)
        {
            this.app = app;
            a = int.Parse(app.textBoxA.Text);
            b = int.Parse(app.textBoxB.Text);
            epsilon = double.Parse(app.comboBoxEpsilon.Text.ToString());
            x0 = a;
            x1 = b;
            X = b;
            XNext = b;
            app.chart.Series.Add("Метод Хорд");
            app.chart.Series["Метод Хорд"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            DoCalc();
        }

        void DoCalc()
        {
            X = XNext;
            XNext = b - (b - a)/(Func(b) - Func(a)) * Func(b);
            app.listBoxChord.Items.Add($"Итерация: {iter}. Значение: {XNext}");
            app.chart.Series["Метод Хорд"].Points.AddXY(iter, XNext);
            if ((double)Math.Abs(XNext - X) <= epsilon)
            {
                ConfirmResult(XNext);
            }
            else
            {
                if(Func(a) * Func(XNext) < 0)
                {
                    b = XNext;
                }
                else
                {
                    a = XNext;
                }
                iter++;
                DoCalc();
            }
        }

        void ConfirmResult(double Res)
        {
            app.listBoxChord.Items.Add($"Финальный результат: {Res}. Итераций: {iter}");
            app.chart.Series["Метод Хорд"].Points.AddXY(iter, Res);
        }

        double Func(double x) => 2 * x - Math.Log10(x) - 7;

    }
}
