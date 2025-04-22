using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabinCryptosystem
{
    public partial class RabinCryptosystem : Form
    {
        uint bytesToWrite = 1;
        private const uint numsToWrite = 30;
        private RabinCipher rabinCipher;
        public RabinCryptosystem()
        {
            InitializeComponent();
            rabinCipher = new RabinCipher();
        }

        private string GetBytesRepresentation(byte[] bytes,uint ind,uint count,uint numsToWrite)
        {
            
            
            StringBuilder sb = new StringBuilder();
            byte[] numInBytes = new byte[4];
            for (uint i = 0; i < count - 1 ; i++)
            {
                for (uint j = 0; j < numsToWrite; j++)
                {
                    numInBytes[j] = bytes[ind + i * (numsToWrite) + numsToWrite - j - 1];
                }
                sb.Append(BitConverter.ToUInt32(numInBytes,0));
                sb.Append(' ');
            }
            for (uint j = 0; j < numsToWrite; j++)
            {
                numInBytes[j] = bytes[count*numsToWrite-1-j];
            }
            sb.Append(BitConverter.ToUInt32(numInBytes, 0));
            return sb.ToString();
        }

        // получение имени файла и сохранение его в текстовое поля
        private void SaveFileToOpen_Click(object sender, EventArgs e)
        {
            if (ofdChooseAnyFile.ShowDialog() == DialogResult.OK)
            {
               if ((Button)sender == btInputFile)
               {
                   tbInputFileName.Text = ofdChooseAnyFile.FileName;
               }
               else
               {
                   tbOutputFileName.Text = ofdChooseAnyFile.FileName;
               }
            }
        }

        // подпрограмма для проверки введенных числовых значений
        public bool CheckOpenValuesForCorrect(out uint resultP, out uint resultQ, out uint resultB, out uint N)
        {
            string p = tbFirstSimple.Text;
            string q = tbSecondSimple.Text;
            string b = tbEncryptLessN.Text;

            resultP = 0;
            resultQ = 0;
            resultB = 0;
            N = 0;

            // переменная для проверки вводимых чисел
            bool flag = true;
            if (!uint.TryParse(new string(p.Where(char.IsDigit).ToArray()), out resultP))
            {
                flag = false;
                MessageBox.Show($"Проверьте строку с числом p на наличие цифр,произведение p*q должно иметь максимальное значение - {uint.MaxValue} , повторите ввод", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }
            if (!uint.TryParse(new string(q.Where(char.IsDigit).ToArray()), out resultQ))
            {
                flag = false;
                MessageBox.Show($"Проверьте строку с числом q на наличие цифр,произведение p*q должно иметь максимальное значение - {uint.MaxValue}", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }
            try
            {
                checked
                {
                    uint checkN = resultP * resultQ;
                }
            }
            catch(OverflowException)
            {
                flag = false;
                MessageBox.Show($"Произведение p*q слишком большое, оно должно иметь максимальное значение - {uint.MaxValue}", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }
           
            if (resultP <= 3)
            {
                flag = false;
                MessageBox.Show("p должно быть больше 3, повторите ввод", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }
            
            if (flag)
            {
                if (resultQ < 3511)
                {
                    flag = false;
                    MessageBox.Show("q должно быть больше 3511, повторите ввод", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return flag;
                }
            }

            // проверка чисел на простоту
            if (!TheoryOfNumbers.IsSimpleNumber(resultP))
            {
                flag = false;
                MessageBox.Show($"Число p не является простым", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }

            if (!TheoryOfNumbers.IsSimpleNumber(resultQ))
            {
                flag = false;
                MessageBox.Show($"Число q не является простым", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }

            
            // проверка на остаток от деления на 4, он должен равняться 3
            uint modP = resultP % 4;
            uint modQ = resultQ % 4;
            if (modP != 3)
            {
                flag = false;
                MessageBox.Show($"Число p при делении на 4 дает остаток {modP},а не 3", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }
            if (modQ != 3)
            {
                flag = false;
                MessageBox.Show($"Число q при делении на 4 дает остаток {modQ},а не 3", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }
            
            N = resultP * resultQ;
            tbMultTwoSimple.Text = N.ToString();
            if (!uint.TryParse(new string(b.Where(char.IsDigit).ToArray()), out resultB))
            {
                flag = false;
                MessageBox.Show("Строка с числом b не содержит цифр, повторите ввод", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return flag;
            }

            // проверка числа B для шифрования
            if (flag)
            {
                if (resultB >= N || !(resultB >= 1 && resultB <= 10532))
                {
                    flag = false;
                    MessageBox.Show($"b должно быть меньше n и лежать в диапазоне от 1 до 10532, повторите ввод", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return flag;

                }
            }
            return flag;
        }

        // функция для вывода результата на экран
        private void ShowResult(TextBox text, byte[] bytes,uint bytesToNumber)
        {
            string res = "";
            if (bytes.Length > text.MaxLength)
            {
                res += "First: ";
                res += GetBytesRepresentation(bytes, 0, RabinCryptosystem.numsToWrite,bytesToNumber);
                res += "\r\n";
                res += "Last: ";
                res += GetBytesRepresentation(bytes, (uint)(bytes.Length - RabinCryptosystem.numsToWrite*bytesToNumber), RabinCryptosystem.numsToWrite,bytesToNumber);
            }
            else
            {
                res = GetBytesRepresentation(bytes, 0, (uint)bytes.Length/bytesToNumber,bytesToNumber);
            }
            text.Text = res;
        }
        private void btEncryptOrDecrypt_Click(object sender, EventArgs e)
        {
            bool flag = false;  

            // массив байтов исходного текста
            byte[] textToWork;

            // массив байтов конечного текста
            byte[] endText;
            if (!CheckOpenValuesForCorrect(out uint resultP, out uint resultQ, out uint resultB, out uint N))
                return;
            if (tbInputFileName.Text == "" || tbOutputFileName.Text == "")
            {
                MessageBox.Show($"Выберите исходный и конечный файлы", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rabinCipher.P = resultP;
            rabinCipher.Q = resultQ;
            rabinCipher.B = resultB;
            rabinCipher.N = rabinCipher.P * rabinCipher.Q;
            // дополнительные коэффициенты для подсчета корней по модулю N
            (rabinCipher.yP, rabinCipher.yQ) = TheoryOfNumbers.ExtendedEuclid(rabinCipher.P, rabinCipher.Q);

            using (FileStream fs = new FileStream(tbInputFileName.Text, FileMode.Open,FileAccess.Read))
            {
                textToWork = new byte[fs.Length];
                fs.Read(textToWork, 0, textToWork.Length);
            }
            ShowResult(tbInput,textToWork,bytesToWrite);
            if ((ToolStripButton)sender == btEncrypt)
            {
                endText = rabinCipher.Encrypt(textToWork);
                bytesToWrite = RabinCipher.bytesToCipher;
            }
            else
            {
                endText = rabinCipher.Decrypt(textToWork);
                flag = true;
                
            }
            using (FileStream fs = new FileStream(tbOutputFileName.Text, FileMode.Create, FileAccess.Write))
            {
                fs.Write(endText,0,endText.Length);
            }
            if (flag)
            {
                bytesToWrite = 1;
                flag = false;
            }
            ShowResult(tbOutput,endText,bytesToWrite);
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbFirstSimple.Text = "";
            tbSecondSimple.Text = "";
            tbEncryptLessN.Text = "";
            tbMultTwoSimple.Text = "";
            tbInputFileName.Text = "";
            tbOutputFileName.Text = "";
            tbInput.Text = "";
            tbOutput.Text = "";
        }
    }

    public class RabinCipher
    {
        public uint P {  get; set; }

        public uint Q { get; set; }

        public uint B { get; set; }

        public int yP { get; set; }
        public int yQ { get; set; }

        private uint pq;
        public uint N { get { return pq; } set { 
                pq = value; uint i = 0; byte[] bytes = BitConverter.GetBytes(value); while (i < sizeof(uint) && bytes[i] != 0) i++; if (i == 0) i++; bytesToCipher = i; } 
        }
        internal static uint bytesToCipher;

        // подпрограмма для шифрования 
        public byte[] Encrypt(byte[] plainText)
        {
            
            uint encodeValue;
            byte[] encode = new byte[bytesToCipher * plainText.Length];
            for (uint i = 0; i < plainText.Length; i++)
            {
                encodeValue = (plainText[i] * (plainText[i] + B)) % N;

                // берем для шифрования n байт от результата
                byte[] encodeBytes = BitConverter.GetBytes(encodeValue);
                for (uint j = 0; j < bytesToCipher; j++)
                {
                    encode[i * bytesToCipher + j] = encodeBytes[bytesToCipher - j - 1];
                }
            }
            
            return encode;
        }

        // подпрограмма для расшифровки
        public byte[] Decrypt(byte[] cipherText)
         {
            
            uint rootPPositive, rootPInverse;
            uint rootQPositive, rootQInverse;
            byte[] decodeValue = new byte[4];
            uint D;
            byte[] decode = new byte[cipherText.Length/bytesToCipher];
            

            for (uint i = 0; i < decode.Length; i++)
            {
                for (uint j = 0; j < bytesToCipher; j++)
                {
                    decodeValue[bytesToCipher - j - 1] = cipherText[i * bytesToCipher+j];
                }

                // получаем дискриминант и корни по модулю p и q для нахождения 4 квадратных корней по модулю N
                D = GetDiscriminant(N, B, BitConverter.ToUInt32(decodeValue, 0));
                (rootPPositive,rootPInverse) = GetRootsByModule(D, P);
                (rootQPositive,rootQInverse) = GetRootsByModule(D, Q);

                
                // получаем однозначное значение исходного текста - должно получиться 1 значение в 1 байт
                decode[i] = GetDecipherByte(GetSummaryRootsByModule(rootPPositive,rootPInverse,rootQPositive,rootQInverse,yP,yQ));
            }
            return decode;
        }

        // получение однозначного однобайтового корня
        private byte GetDecipherByte(uint[] roots)
        {
            bool flag = false;
            int m = 0;
            for (uint i = 0; i < roots.Length && !flag; i++)
            {
                if ((roots[i] - B) % 2 == 0)
                {
                    m = (int)(((-B + roots[i]) / 2) % N);
                }
                else
                    m = (int)(((-B + roots[i] + N) / 2) % N);
                if (m < 0)
                {
                    m = (int)(m + N);
                }
                // нахождение корня,если он в пределах одного байта, остановка
                if (m < 256)
                {
                    flag = true;
                }
            }
            return (byte)m;
        }

        // получение корней по общему модулю
        private uint[] GetSummaryRootsByModule(uint positiveP, uint inverseP,uint positiveQ,uint inverseQ,int yP, int yQ)
        {
            uint positiveD1, inverseD1;
            uint negativeD2, inverseD2;
            long term1 = positiveQ * yP * P + positiveP * yQ * Q;
            long term2 = inverseQ * yP * P + inverseP * yQ * Q;
            long term3 = positiveQ * yP * P - positiveP * yQ * Q;
            long term4 = inverseQ * yP * P - inverseP * yQ * Q;
            positiveD1 = (uint)(((term1 % N) + N) % N);
            inverseD1 = (uint)(((term2 % N) + N) % N);
            negativeD2 = (uint)(((term3 % N) + N)% N);
            inverseD2 = (uint)(((term4 % N) + N) % N);
            uint[] roots = new uint[] { positiveD1, inverseD1, negativeD2, inverseD2 };
            return new uint[] { positiveD1,inverseD1,negativeD2,inverseD2};
        }


        // получение корней по модулям составного модуля, основываясь на алгоритме Рабина с числами, остаток которых 3
        private (uint,uint) GetRootsByModule(uint x,uint module)
        {
            x = x % module;
            // степень для подсчета корней
            uint degree = (module + 1) / 4;

            // первый прямой корень
            uint positiveRoot = TheoryOfNumbers.FastExp(x, degree, module);

            // второй корень, обратный прямому
            uint inverseRoot = module - positiveRoot;

            return (positiveRoot, inverseRoot);
        }

        // подсчет дискриминанта по модулю N
        private uint GetDiscriminant(uint N, uint B, uint decodeValue)
        {
            return (B * B + 4 * decodeValue) % N;
        }
    }
    public static class TheoryOfNumbers
    {
        // алгоритм быстрого возведения в степень
        public static uint FastExp(uint a, uint z, uint n)
        {
            UInt64 tempRes;
            // результат
            uint x = 1;

            // проверка степени
            while (z != 0)
            {
                while (z % 2 == 0)
                {
                    z = z / 2;
                    tempRes = a * a;
                    a = (uint)(tempRes % n);
                }
                z -= 1;
                tempRes = x * a;
                x = (uint)(tempRes % n);
            }
            return x;
        }

        // расширенный алгоритм Евклида
        public static (int,int) ExtendedEuclid(uint a,uint b)
        {
            uint q,d2;
            uint d0 = a, d1 = b;
            int x0 = 1, y0 = 0;
            int y1 = 1, x1 = 0;
            int x2, y2;
            while (d1 > 1)
            {
                q = d0 / d1;
                d2 = d0 % d1;
                y2 = (int)(y0 - q * y1);
                x2 = (int)(x0 - q * x1);

                // старые коэффициенты для b становятся коэффициентами для нового a
                x0 = x1;
                y0 = y1;
                y1 = y2;
                x1 = x2;

                // d0 в d1,т к a становится b
                d0 = d1;

                // d1 в d2 т к становится r
                d1 = d2; 
            }
            return (x1,y1);
        }

        // решето Эратосфена для проверки числа на простоту 
        public static bool IsSimpleNumber(uint number)
        {
            bool[] resheto = new bool[number+1];
            resheto[1] = false;
            resheto[0] = false;
            

            for (uint i = 2; i < number+1; i++)
            {
                resheto[i] = true;
            }
            for (uint i = 2; i < number; i++)
            {
                while (i <= number && resheto[i] != true)
                {
                    i++;
                }
                uint ind = i * i;
                while (ind <= number)
                {
                    resheto[ind] = false;
                    ind += i;
                }
            }
            return resheto[number];
        }
    }
}
