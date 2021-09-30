using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CM_Lab1
{
    public class SimpleIter
    {

        App app;
        double a, b, epsilon;
        int iter = 1;

        public SimpleIter(App app)
        {
            this.app = app;
            a = int.Parse(app.textBoxA.Text);
            b = int.Parse(app.textBoxB.Text);
            epsilon = double.Parse(app.comboBoxEpsilon.Text.ToString());
            app.chart.Series.Add("Метод Прост.Итер.");
            app.chart.Series["Метод Прост.Итер."].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            DoCalc(((a + b) / 2), fi((a + b) / 2));
        }

        void DoCalc(double XPast, double X)
        {
            app.listBoxSimple.Items.Add($"Итерация: {iter}. Значение: {X}");
            app.chart.Series["Метод Прост.Итер."].Points.AddXY(iter, X);
            if (Math.Abs(X - XPast) <= epsilon)
            {
                ConfirmResult(X);
            }
            else
            {
                iter++;
                DoCalc(X, fi(XPast));
            }
        }

        void ConfirmResult(double Res)
        {
            app.listBoxSimple.Items.Add($"Финальный результат: {Res}. Итераций: {iter}");
            app.chart.Series["Метод Прост.Итер."].Points.AddXY(iter, Res);
        }

        double fi(double x) => Math.Pow(10, (2 * x - 7));
    }
}
