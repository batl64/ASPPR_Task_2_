using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text.RegularExpressions;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<double[]> MatrixCalc(List<double[]> array, out int count)
        {
            List<double[]> arrayMatrixA = array;
            double val = 0;
            int countCalc = 0;

            string infoReport = "Знаходження оберненої матриці:\r\n";
            infoReport += "Вхідна матриця:\r\n";

            for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
            {

                for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                {
                    infoReport += arrayMatrixA[elX][el];
                    if (el != arrayMatrixA[elX].Length - 1) infoReport += " ";
                }
                if (elX != arrayMatrixA.Count() - 1) infoReport += "\r\n";

            }
            infoReport += "\r\nПротокол обчислення:\r\n";
            for (int x = 0; x < arrayMatrixA.Count(); x++)
            {
                if (x >= arrayMatrixA[0].Length) break;
                val = arrayMatrixA[x][x];
                if (Math.Abs(val) < Math.Pow(10, -10))
                {
                    val = 0;
                    for (int el = 0; el < arrayMatrixA[x].Length; el++)
                    {
                        if (el > x && arrayMatrixA[x][el] != 0)
                        {
                            val = arrayMatrixA[x][el];

                            arrayMatrixA[x][el] = 1 / val;
                            break;

                        }

                    }

                    if (val == 0)
                    {
                        continue;
                    }
                }
                else
                {
                    arrayMatrixA[x][x] = 1 / val;
                }
                countCalc++;
                

                for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
                {
                    if (elX == x) continue;

                    for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                    {
                        if (el == x) continue;

                        arrayMatrixA[elX][el] = (arrayMatrixA[elX][el] * val - arrayMatrixA[x][el] * arrayMatrixA[elX][x]) / val;
                    }
                }
                int size = arrayMatrixA.Count() > arrayMatrixA[0].Length ? arrayMatrixA.Count() : arrayMatrixA[0].Length;
                for (int elX = 0; elX < size; elX++)
                {
                    if (elX == x) continue;

                    if (elX < arrayMatrixA[0].Length) { arrayMatrixA[x][elX] = -arrayMatrixA[x][elX] / val; }
                    if (elX < arrayMatrixA.Count()) { arrayMatrixA[elX][x] = arrayMatrixA[elX][x] / val; }
                }

                infoReport += $"\r\n\r\nКрок #{x + 1}:\r\n";
                infoReport += $"Розв’язувальний елемент: A[{x}, {x}] = {Math.Round(val, 4)}:\r\n";
                infoReport += "Матриця після виконання ЗЖВ:\r\n";
                for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
                {

                    for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                    {
                        infoReport += Math.Round(arrayMatrixA[elX][el], 4);
                        if (el != arrayMatrixA[elX].Length - 1) infoReport += " ";
                    }
                    if (elX != arrayMatrixA.Count() - 1) infoReport += "\r\n";

                }

            }
            count = countCalc;
            textBoxReport.Text = infoReport;

            return arrayMatrixA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!valid(InputMatrixA.Text))
            {
                TextBoxResultatMatrixA.Text = "Не валідна матриця";
                return;
            }
            string b = InputMatrixA.Text;
            int count = 0;
            List<double[]> arrayMatrixA = b.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
            if (!check(arrayMatrixA))
            {
                TextBoxResultatMatrixA.Text = "Не коректна матриця";
                return;
            }
            arrayMatrixA = MatrixCalc(arrayMatrixA, out count);

            if (arrayMatrixA == null) { TextBoxResultatMatrixA.Text = "Вироджена матриця"; return; }
            if (arrayMatrixA.Count != arrayMatrixA[0].Length)
            {
                TextBoxResultatMatrixA.Text = "Ця матриця не квадратна";

            }
            else
            {
                TextBoxResultatMatrixA.Text = string.Join("\r\n", arrayMatrixA.Select(row => string.Join("   ", row.Select(num => Math.Round(num, 4)))));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!valid(InputMatrixA.Text))
            {
                LabelMatrixRange.Text = "Не валідна матриця";
                return;
            }
            string b = InputMatrixA.Text;
            int count = 0;
            List<double[]> arrayMatrixA = b.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
            if (!check(arrayMatrixA))
            {
                LabelMatrixRange.Text = "Не коректна матриця";
                return;
            }
            arrayMatrixA = MatrixCalc(arrayMatrixA, out count);
            LabelMatrixRange.Text = count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!valid(InputMatrixA.Text))
            {
                TextBoxResultatMatrix.Text = "Не валідна матриця A";
                return;
            }
            if (!validMatrixB(InputMatrixB.Text))
            {
                TextBoxResultatMatrix.Text = "Не валідна матриця B";
                return;
            }

            string textInputA = InputMatrixA.Text;
            string textInputB = InputMatrixB.Text;

            if (textInputB == null || textInputB == "")
            {
                TextBoxResultatMatrix.Text = "Матриця B не валідна";
                return;
            }
            int count = 0;
            List<double[]> arrayMatrixA = textInputA.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
            List<double[]> arrayMatrixB = textInputB.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
            if (arrayMatrixA.Count != arrayMatrixB.Count)
            {
                TextBoxResultatMatrix.Text = "Кількість рядків в матриці B не співпадає з кількість рядків матриці A";
                return;
            }

            if (!check(arrayMatrixA))
            {
                TextBoxResultatMatrix.Text = "Не коректна матриця";
                return;
            }
            arrayMatrixA = MatrixCalc(arrayMatrixA, out count);
            if (arrayMatrixA == null) { TextBoxResultatMatrix.Text = "Вироджена матриця"; return; }
            if (arrayMatrixA.Count != arrayMatrixA[0].Length)
            {
                TextBoxResultatMatrix.Text = "Ця матриця не квадратна";

            }
            else
            {
                textBoxReport.Text += "\r\n\r\nВхідна матриця В:\r\n";
                for (int elX = 0; elX < arrayMatrixB.Count(); elX++)
                {

                    for (int el = 0; el < arrayMatrixB[elX].Length; el++)
                    {
                        textBoxReport.Text += Math.Round(arrayMatrixB[elX][el], 4);
                    }
                    if (elX != arrayMatrixB.Count() - 1) textBoxReport.Text += "\r\n";

                }
                textBoxReport.Text += "\r\n\r\nОбчислення розв’язків:\r\n";
                int x = 0;
                List<double[]> resultatMatrix = arrayMatrixA.Select(row =>
                {

                    double[] res = new double[1];

                    textBoxReport.Text += $"\r\nx[{++x}] = ";
                    for (int index = 0; index < row.Length; index++)
                    {
                        textBoxReport.Text += $"{Math.Round(row[index], 4)} * {Math.Round(arrayMatrixB[index][0], 4)}";
                        if (index != row.Length - 1) textBoxReport.Text += " + ";
                        res[0] += row[index] * arrayMatrixB[index][0];
                    }
                    textBoxReport.Text += $" = {Math.Round(res[0], 4)} \r\n";
                    return res;
                }).ToList();


                TextBoxResultatMatrix.Text = string.Join("\r\n", resultatMatrix.Select(row => string.Join(" ", row.Select(num => Math.Round(num, 4)))));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal rows = InputNumGenMatrix1.Value, colums = InputNumGenMatrix2.Value;


            genMatrixA(rows, colums);
            genMatrixB(rows);
        }

        private void genMatrixA(decimal row, decimal col)
        {
            int n = 0;
            List<double[]> arrayMatrixA;
            string f = "";
            do
            {
                string textInput = "";
                Random rand = new Random();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        textInput += rand.Next(-20, 20);
                        if (j != col - 1) textInput += " ";
                    }
                    if (i != row - 1) textInput += "\r\n";
                }
                arrayMatrixA = textInput.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
                f = textInput;
            } while (row == col && MatrixCalc(arrayMatrixA, out n) == null);
            InputMatrixA.Text = f;
        }

        private void genMatrixB(decimal size)
        {
            string textInput = "";
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                textInput += rand.Next(-20, 20);
                if (i != size - 1) textInput += "\r\n";
            }
            InputMatrixB.Text = textInput;
        }

        private bool valid(string input)
        {
            string pattern = @"^((-?\d+\s+)+(-?\d+))(\r?\n((-?\d+\s+)+(-?\d+)))*$";

            return Regex.IsMatch(input, pattern);
        }

        private bool check(List<double[]> input)
        {
            int row = input.Count;
            int col = input[0].Length;

            foreach (var el in input)
            {
                if (el.Length != col)
                {
                    return false;
                }
            }

            return true;
        }

        private bool validMatrixB(string input)
        {
            string pattern = @"^(-?\d+)(\r\n(-?\d+))*$";

            return Regex.IsMatch(input, pattern);
        }

        private List<double[]> MatrixCalc2(List<double[]> array, int indexX, int indexY)
        {
            List<double[]> arrayMatrixA = array;
            double val = arrayMatrixA[indexY][indexX];
            arrayMatrixA[indexY][indexX] = 1 / val;

                for (int elY = 0; elY < arrayMatrixA.Count(); elY++)
                {
                    if (elY == indexY) continue;

                    for (int el = 0; el < arrayMatrixA[elY].Length; el++)
                    {
                        if (el == indexX) continue;

                    arrayMatrixA[elY][el] = (arrayMatrixA[elY][el] * val - arrayMatrixA[indexY][el] * arrayMatrixA[elY][indexX]) / val;
                    }
                }

            for (int elY = 0; elY < arrayMatrixA.Count(); elY++)
            {
                if (elY == indexY) continue;
                arrayMatrixA[elY][indexX] = -arrayMatrixA[elY][indexX] / val;
            }
            for (int el = 0; el < arrayMatrixA[indexY].Length; el++)
                {
                if (el == indexX) continue;
                    arrayMatrixA[indexY][el] = arrayMatrixA[indexY][el] / val; 
                    
            }
                              


            return arrayMatrixA;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(CountVal.Value);
            int cofMaxCheck = radioButton1.Checked ? -1 : 1; 
            List<double[]> arrayMatrixB = new();
            string [] Input = textBox3.Text.Split("\r\n");
            ReportTextBox.Text = "Постановка Задачі:\r\n\r\n" +"Z = "+ textBox2.Text +"->" + (radioButton1.Checked ? "max":"min") + 
                "\r\n\r\n" + textBox3.Text + "\r\n\r\n";
            foreach (string s in Input)
            {
                
                MatchCollection matches = Regex.Matches(s, @"([-+]?\d*)x(\d+)");
                Match constraintMatch = Regex.Match(s, @"[<>]=?\s*(-?\d+)");
                double[] array = new double[val+1];

                int cofSignValue = constraintMatch.Value.Substring(0,2) == "<=" ? 1 : -1;
                int cofSignRes = constraintMatch.Value.Substring(0, 2) == "<=" ? 1 : -1;

                foreach (Match matc in matches)
                {
                    int index = int.Parse(matc.Groups[2].Value)-1;
                    string cof = matc.Groups[1].Value;
                    array[index] = (cof == "+" || cof == "" ? 1 : cof == "-" ?- 1 : int.Parse(cof)) * cofSignValue;
                }
                array[val] = constraintMatch.Success ? int.Parse(constraintMatch.Groups[1].Value) * cofSignRes : 0;
                arrayMatrixB.Add(array);
            }
            MatchCollection matches2 = Regex.Matches(textBox2.Text, @"([-+]?\d*)x(\d+)");

            double[] arrayRes = new double[val+1];
            foreach (Match matc in matches2)
            {
                int index = int.Parse(matc.Groups[2].Value) - 1;
                string cof = matc.Groups[1].Value;
                arrayRes[index] = (cof == "+" || cof == "" ? 1 : cof == "-" ? -1 : int.Parse(cof)) * cofMaxCheck;
            }
            arrayMatrixB.Add(arrayRes);

            string[][] Head = new string[2][];
            string[] row = new string[val+1];
            for(int i=0;i<val;i++)
            {
                row[i] = "x" + (i+1);
            }
            row[val] = "1";
            Head[1] = row;

            row = new string[Input.Length+1];
            for (int i = 0; i < Input.Length; i++)
            {
                row[i] = "y" + (i+1);
            }
            row[Input.Length]="Z";
            Head[0] = row;

            string infoReport = "Вхідна симплексна таблиця:\r\n";
            infoReport += string.Format("{0,-20}", "");
            foreach (var el in Head[1])
            {
                infoReport += string.Format("{0,-20}", el);
            }
            infoReport += "\r\n";
            for (int elX = 0; elX < arrayMatrixB.Count(); elX++)
            {
                infoReport += string.Format("{0,-20}", Head[0][elX]);
                for (int el = 0; el < arrayMatrixB[elX].Length; el++)
                {
                    infoReport += string.Format("{0,-20}", Math.Round(arrayMatrixB[elX][el], 2).ToString());
                }
                if (elX != arrayMatrixB.Count() - 1) infoReport += "\r\n";

            }
            ReportTextBox.Text += infoReport;
            SupportingElement(arrayMatrixB, Head);
            OptimalRes(arrayMatrixB, Head);

        }
        private void SupportingElement(List<double[]> array, string[][] _Head)
        {
            List<double[]> arrayMatrixA = array;
            string[][] Head = _Head;
            string infoReport = "\r\nПошук опорного елементу:\r\n", varC;
            int indexX = 0, indexY = -1;
            bool exit = false;
            do
            {
                double valA = 0;
                for (int i = 0; i < arrayMatrixA.Count-1; i++)
                {

                    if (arrayMatrixA[i][arrayMatrixA[i].Length-1] < 0)
                    {

                        for (int e = 0; e < arrayMatrixA[i].Length; e++)
                        {
                            if (arrayMatrixA[i][e] < 0)
                            {
                                valA = arrayMatrixA[i][e];
                                indexX = e;
                                break;
                            }

                        }
                        if (valA != 0) break;
                        ReportTextBox.Text = "Система обмежень є суперечливою";
                        return;
                    }
                }
                if (valA == 0) {
                    exit = true;
                    break; 

                }

                double valB = 0;
                valA = -1;
                for (int i = 0; i < arrayMatrixA.Count-1; i++)
                {
                    valB = arrayMatrixA[i][arrayMatrixA[i].Length - 1] / arrayMatrixA[i][indexX];
                    if ((valB < valA || indexY == -1) && valB >= 0)
                    {
                        valA = valB;
                        indexY = i;
                    }
                }
                varC = Head[0][indexY];
                string varD = Head[1][indexX];
                infoReport += "\r\n\r\n" + "Розв'язувальний рядок:" + varC + "\r\n Розв'язувальний стовпець: -" + varD + "\r\n";
                Head[0][indexY] = Head[1][indexX];
                Head[1][indexX] = varC;
                arrayMatrixA = MatrixCalc2(arrayMatrixA, indexX, indexY);
            } while (!exit);

            infoReport += "\r\n";
            infoReport += string.Format("{0,-20}", "");
            foreach (var el in Head[1])
            {
                infoReport += string.Format("{0,-20}", el);
            }
            infoReport += "\r\n";
            for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
            {
                infoReport += string.Format("{0,-20}", Head[0][elX]);
                for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                {
                    infoReport += string.Format("{0,-20}", Math.Round(arrayMatrixA[elX][el], 2).ToString());
                }
                if (elX != arrayMatrixA.Count() - 1) infoReport += "\r\n";

            }
            double[] res = new double[arrayMatrixA[0].Length - 1];
            int index = 0;
            for (int elX = 0; elX < arrayMatrixA.Count() - 1; elX++)
            {
                if (Head[0][elX].Contains("x"))
                {
                    index = int.Parse(Head[0][elX].Substring(1)) - 1;
                    res[index] += arrayMatrixA[elX][arrayMatrixA[elX].Length - 1];
                }

            }

            infoReport += "\r\nОпорний розв'язок(" + string.Join(";", res.Select(x => x.ToString())) + ")\r\n";
            ReportTextBox.Text += infoReport;

        }

        private void OptimalRes(List<double[]> array, string[][] _Head)
        {
            List<double[]> arrayMatrixA = array;
            string[][] Head = _Head;
            string infoReport = "\r\n\r\nПошук оптимального розв'язання", varC;
            int indexX = 0, indexY = -1;
            bool exit = false;
            do
            {
                double valA = 0;
                for (int i = 0; i < arrayMatrixA[arrayMatrixA.Count - 1].Length-1; i++)
                {

                    if (arrayMatrixA[arrayMatrixA.Count-1][i] < 0)
                    {

                        for (int e = 0; e < arrayMatrixA.Count; e++)
                        {
                            if (arrayMatrixA[e][i] < 0)
                            {
                                valA = arrayMatrixA[e][i];
                                indexX = i;
                                break;
                            }

                        }
                        if (valA != 0) break;
                        ReportTextBox.Text = "Система обмежень є суперечливою";
                        return;
                    }
                }
                if (valA == 0)
                {
                    exit = true;
                    break;

                }

                double valB = 0;
                indexY = -1;
                valA = -1;
                for (int i = 0; i < arrayMatrixA.Count - 1; i++)
                {
                    valB = arrayMatrixA[i][arrayMatrixA[i].Length - 1] / arrayMatrixA[i][indexX];
                    double a  = arrayMatrixA[i][arrayMatrixA[i].Length - 1];
                    double b = arrayMatrixA[i][indexX];
                    if ((valB < valA || indexY == -1) && valB > 0 || 
                        valB == 0 && (
                            (arrayMatrixA[i][arrayMatrixA[i].Length - 1] == 0 && arrayMatrixA[i][indexX] >= 0)
                            || (arrayMatrixA[i][indexX] == 0 && arrayMatrixA[i][arrayMatrixA[i].Length - 1] >= 0)))
                    {
                        valA = valB;
                        indexY = i;
                    }
                }
                if (indexY == -1)
                {
                    ReportTextBox.Text = "Система обмежень є суперечливою";
                    return;
                }
                
                
                
                varC = Head[0][indexY];
                string varD = Head[1][indexX];
                infoReport += "\r\n\r\n" + "Розв'язувальний рядок:" + varC + "\r\n Розв'язувальний стовпець: -" + varD + "\r\n";
                Head[0][indexY] = Head[1][indexX];
                Head[1][indexX] = varC;
                arrayMatrixA = MatrixCalc2(arrayMatrixA, indexX, indexY);

                infoReport += "\r\n";
                infoReport += string.Format("{0,-20}", "");
                foreach (var el in Head[1])
                {
                    infoReport += string.Format("{0,-20}", el);
                }
                infoReport += "\r\n";
                for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
                {
                    infoReport += string.Format("{0,-20}", Head[0][elX]);
                    for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                    {
                        infoReport += string.Format("{0,-20}", Math.Round(arrayMatrixA[elX][el], 2).ToString());
                    }
                    if (elX != arrayMatrixA.Count() - 1) infoReport += "\r\n";

                }

            } while (!exit);
            double[] res = new double[arrayMatrixA[0].Length-1];
            int index = 0;
            for (int elX = 0; elX < arrayMatrixA.Count()-1; elX++)
            {
                if (Head[0][elX].Contains("x")) {
                    index = int.Parse(Head[0][elX].Substring(1))-1;
                    res[index] += arrayMatrixA[elX][arrayMatrixA[elX].Length-1];
                }

            }
            infoReport += "\r\n Оптимальний розв'язок:(" + string.Join(";", res.Select(x => x.ToString())) + ")";
            textBox4.Text = "("+ string.Join(";",res.Select(x=>x.ToString())) + ")";
            textBox5.Text = (!radioButton1.Checked ? "-":"")+  arrayMatrixA[arrayMatrixA.Count()-1][arrayMatrixA[arrayMatrixA.Count-1].Length-1]+ " ";
            ReportTextBox.Text += infoReport;

        }

    }
}