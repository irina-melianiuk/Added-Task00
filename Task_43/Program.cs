// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLine(lineData1, lineData2))
{
  double[] coord = FindCoord(lineData1, lineData2);
  Console.WriteLine($"Точка пересечения двух прямых ({coord[X_COORD]}, {coord[Y_COORD]})");
}

double Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  double result = Convert.ToDouble(readInput);
  return result;
}

double[] InputLineData (int numberOfLine)
{
  double[] lineData = new double[2];
  lineData[COEFFICIENT] = Promt($"Введите коэффициент для {numberOfLine}: ");
  lineData[CONSTANT] = Promt($"Введите константу для {numberOfLine}: ");
  return lineData;
}
 
double[] FindCoord(double[] lineData1, double[] lineData2)
{
  double[] coord = new double[2];
  coord[X_COORD] = (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]) / (lineData1[CONSTANT] - lineData2[CONSTANT]);
  coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[COEFFICIENT];
  return coord;
}

bool ValidateLine(double[] lineData1, double[] lineData2)
{
  if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
  {
    if (lineData1[CONSTANT] == lineData2[CONSTANT])
    {
      Console.WriteLine("Прямые совпадают");
      return false;
    }
    else
    {
      Console.WriteLine("Прямые параллельны");
      return false;
    }
  }
  return true;
}





