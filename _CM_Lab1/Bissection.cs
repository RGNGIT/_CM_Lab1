using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CM_Lab1
{
    public class Bissection
    {

        App app;
        int iter = 1;
        double a, b, epsilon, Fraction;

        public Bissection(App app)
        {
            this.app = app;
            a = int.Parse(app.textBoxA.Text);
            b = int.Parse(app.textBoxB.Text);
            epsilon = double.Parse(app.comboBoxEpsilon.Text.ToString());
            app.chart.Series.Add("Метод Биссекций");
            app.chart.Series["Метод Биссекций"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            DoFraction();
        }

        void DoFraction()
        {
            Fraction = (a + b) / 2;
            DoCalc();
        }

        void DoCalc()
        {
            if(Func(Fraction) == 0)
            {
                app.listBoxBis.Items.Add($"Итерация: {iter}. Значение: {Fraction}");
                app.chart.Series["Метод Биссекций"].Points.AddXY(iter, Fraction);
                ConfirmResult(Fraction);
            }
            else
            {
                if((double)Math.Abs(b - a) <= epsilon)
                {
                    app.listBoxBis.Items.Add($"Итерация: {iter}. Значение: {Fraction}");
                    app.chart.Series["Метод Биссекций"].Points.AddXY(iter, Fraction);
                    ConfirmResult(Fraction);
                }
                else 
                {
                    iter++;
                    if(Func(a) * Func(Fraction) < 0)
                    {
                        app.listBoxBis.Items.Add($"Итерация: {iter}. Значение: {Fraction}");
                        app.chart.Series["Метод Биссекций"].Points.AddXY(iter, Fraction);
                        b = Fraction;
                        DoFraction();
                    }
                    else
                    {
                        app.listBoxBis.Items.Add($"Итерация: {iter}. Значение: {Fraction}");
                        app.chart.Series["Метод Биссекций"].Points.AddXY(iter, Fraction);
                        a = Fraction;
                        DoFraction();
                    }
                }
            }
        }

        void ConfirmResult(double Res)
        {
            app.listBoxBis.Items.Add($"Финальный результат: {Res}. Итераций: {iter}");
            app.chart.Series["Метод Биссекций"].Points.AddXY(iter, Res);
        }

        double Func(double x) => 2 * x - Math.Log10(x) - 7;

    }
}
