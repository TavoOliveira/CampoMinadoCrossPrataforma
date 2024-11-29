using Avalonia.Controls.Shapes;
using Avalonia.Controls;
using Avalonia.Media;

namespace CampoMinadoCrossPrataforma;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        var campoComMinas = this.FindControl<Canvas>("CampoComMinas");
        FillCanvas(campoComMinas, 8, 8); // Exemplo: 8x8 tabuleiro de xadrez
    }

    private void FillCanvas(Canvas canvas, int rows, int cols)
    {
        canvas.Children.Clear();
        
        // Tamanho do canvas
        double canvasWidth = canvas.Width;
        double canvasHeight = canvas.Height;

        // Dimensões de cada célula
        double cellWidth = canvasWidth / cols;
        double cellHeight = canvasHeight / rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Alterna a cor entre preto e branco
                bool isDark = (i + j) % 2 == 0;
                var className = isDark ? "lightGreen" : "darkGreen";

                // Cria o retângulo
                var rect = new Rectangle
                {
                    Width = cellWidth,
                    Height = cellHeight,
                };
                
                rect.Classes.Add(className);

                // Define a posição do retângulo
                Canvas.SetLeft(rect, j * cellWidth);
                Canvas.SetTop(rect, i * cellHeight);

                // Adiciona ao Canvas
                canvas.Children.Add(rect);
            }
        }
    }
}