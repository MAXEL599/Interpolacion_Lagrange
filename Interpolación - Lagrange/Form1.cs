using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interpolación___Lagrange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos de entrada
            x1.Clear();
            x2.Clear();
            x3.Clear();
            x4.Clear();

            Y1.Clear();
            Y2.Clear();
            Y3.Clear();
            Y4.Clear();
            txtResultado.Clear();
            panelG.Invalidate(); // Limpiar el panel de gráficos
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var interpolacion = new InterpolacionLagrange();

                // Agregar puntos desde los TextBox
                interpolacion.AgregarPunto(double.Parse(x1.Text), double.Parse(Y1.Text));
                interpolacion.AgregarPunto(double.Parse(x2.Text), double.Parse(Y2.Text));
                interpolacion.AgregarPunto(double.Parse(x3.Text), double.Parse(Y3.Text));
                interpolacion.AgregarPunto(double.Parse(x4.Text), double.Parse(Y4.Text));

                // Mostrar opciones de interpolación
                string opcion = Microsoft.VisualBasic.Interaction.InputBox(
                    "Seleccione el tipo de interpolación:\n1. Interpolación Lagrange (calcular Y dado X).\n2. Interpolación Inversa (calcular X dado Y).",
                    "Tipo de Interpolación",
                    "1");

                if (opcion == "1")
                {
                    // Interpolación Lagrange
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de X para calcular Y:", "Valor de X", "0");
                    if (double.TryParse(input, out double x))
                    {
                        string formula;
                        double valorInterpoladoY = interpolacion.CalcularValorInterpolado(x, out formula);
                        txtResultado.Text = $"El valor interpolado en X = {x} es Y = {valorInterpoladoY:F4}\n\nFórmula:\n{formula}";
                        DibujarGrafica(interpolacion.ObtenerPuntos(), x, valorInterpoladoY);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor numérico válido para X.", "Error");
                    }
                }
                else if (opcion == "2")
                {
                    // Interpolación Inversa
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de Y para calcular X:", "Valor de Y", "0");
                    if (double.TryParse(input, out double y))
                    {
                        string formula;
                        double valorInterpoladoX = interpolacion.CalcularValorInterpoladoInverso(y, out formula);
                        txtResultado.Text = $"El valor interpolado en Y = {y} es X = {valorInterpoladoX:F4}\n\nFórmula:\n{formula}";
                        DibujarGrafica(interpolacion.ObtenerPuntos(), valorInterpoladoX, y);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor numérico válido para Y.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una opción válida (1 o 2).", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
        }

        private void DibujarGrafica(IEnumerable<(double x, double y)> puntos, double x, double y)
        {
            var g = panelG.CreateGraphics();
            g.Clear(panelG.BackColor);

            // Dibujar puntos
            foreach (var punto in puntos)
            {
                g.FillEllipse(Brushes.Blue, (float)punto.x * 10, (float)punto.y * 10, 5, 5);
            }

            // Dibujar punto interpolado
            g.FillEllipse(Brushes.Red, (float)x * 10, (float)y * 10, 5, 5);
        }
    }

    public interface IInterpolacionLagrange
    {
        void AgregarPunto(double x, double y);
        double CalcularValorInterpolado(double x, out string formula);
        double CalcularValorInterpoladoInverso(double y, out string formula);
        IEnumerable<(double x, double y)> ObtenerPuntos();
    }

    public class InterpolacionLagrange : IInterpolacionLagrange
    {
        private readonly List<(double x, double y)> puntos = new List<(double x, double y)>();

        public void AgregarPunto(double x, double y)
        {
            puntos.Add((x, y));
        }

        public double CalcularValorInterpolado(double x, out string formula)
        {
            if (puntos.Count < 2)
                throw new InvalidOperationException("Se necesitan al menos dos puntos para realizar la interpolación.");

            double resultado = 0.0;
            int n = puntos.Count;
            formula = "y = ";

            for (int i = 0; i < n; i++)
            {
                double termino = puntos[i].y;
                string terminoFormula = $"({puntos[i].y})";

                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        termino *= (x - puntos[j].x) / (puntos[i].x - puntos[j].x);
                        terminoFormula += $"(x - {puntos[j].x}) / ({puntos[i].x} - {puntos[j].x})";
                    }
                }

                resultado += termino;
                formula += terminoFormula + (i < n - 1 ? " + " : "");
            }

            return resultado;
        }

        public double CalcularValorInterpoladoInverso(double y, out string formula)
        {
            if (puntos.Count < 2)
                throw new InvalidOperationException("Se necesitan al menos dos puntos para realizar la interpolación.");

            double resultado = 0.0;
            int n = puntos.Count;
            formula = "x = ";

            for (int i = 0; i < n; i++)
            {
                double termino = puntos[i].x;
                string terminoFormula = $"({puntos[i].x})";

                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        termino *= (y - puntos[j].y) / (puntos[i].y - puntos[j].y);
                        terminoFormula += $"(y - {puntos[j].y}) / ({puntos[i].y} - {puntos[j].y})";
                    }
                }

                resultado += termino;
                formula += terminoFormula + (i < n - 1 ? " + " : "");
            }

            return resultado;
        }

        public IEnumerable<(double x, double y)> ObtenerPuntos()
        {
            return puntos;
        }
    }
}
