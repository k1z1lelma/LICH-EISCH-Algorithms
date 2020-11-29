using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace file_organization
{
    public partial class eisch_lich_algorithms : Form
    {
        public int valueNumber;
        public int generatedRange;
        public int[] array;
        public int key;
        public int notStandartKey;
        


        public eisch_lich_algorithms()
        {
            InitializeComponent();
            txt_array_size.Text = "15";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LICH_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EICH_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void probCom_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EISCH_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void generateNumberButton_Click(object sender, EventArgs e)
        {

            valueNumber = Int32.Parse(txt_array_size.Text);
            generatedRange= Int32.Parse(txt_number_range.Text);
            generateArray(valueNumber);

            Setkey();
            
            createTableRows(grid_LICHdata);
            createTableRows(grid_EISCHdata);
                
            LICH();
            EISCH();
            
           setProbsTable();
           setProbsStatistics();

        }
   
        

        //LICH Algorithm Table
        private void LICH()
        {
            Setkey();
            int totalLineCount = key;
            notStandartKey = smallerkey(key);
            int primaryIndex;


            for (int i = 0; i < valueNumber; i++)
            {
                primaryIndex = array[i] % notStandartKey;

                if (grid_LICHdata.Rows[primaryIndex].Cells[1].Value == null)
                {
                    grid_LICHdata.Rows[primaryIndex].Cells[1].Value = array[i];
                }

                else
                {
                    int line = totalLineCount - 1;

                    while (grid_LICHdata.Rows[line].Cells[1].Value != null && line>0)
                        line--;

                    grid_LICHdata.Rows[line].Cells[1].Value = array[i];


                
                    while (grid_LICHdata.Rows[primaryIndex].Cells[2].Value != null)
                    {
                        int linkValue = Convert.ToInt32(grid_LICHdata.Rows[primaryIndex].Cells[2].Value);
                        primaryIndex = Convert.ToInt32(grid_LICHdata.Rows[linkValue].Cells[0].Value);
                    }

                    grid_LICHdata.Rows[primaryIndex].Cells[2].Value = line;
                }
            }

            LICH_textBox.Text = "Overflow Area Starts From : " + notStandartKey;
        }



        //LAYOUT OF EISCH TABLE
        private void EISCH()
        {
            Setkey();
            int primaryIndex;

            for (int i = 0; i < valueNumber; i++)
            {
                primaryIndex = array[i] % key;

                if (grid_EISCHdata.Rows[primaryIndex].Cells[1].Value == null)
                {
                    grid_EISCHdata.Rows[primaryIndex].Cells[1].Value = array[i];
                }

                else
                {
                    int line = key - 1;

                    while (grid_EISCHdata.Rows[line].Cells[1].Value != null)
                        line--;

                    grid_EISCHdata.Rows[line].Cells[1].Value = array[i];   
                 
                    grid_EISCHdata.Rows[line].Cells[2].Value = grid_EISCHdata.Rows[primaryIndex].Cells[2].Value;
                    grid_EISCHdata.Rows[primaryIndex].Cells[2].Value = grid_EISCHdata.Rows[line].Cells[0].Value;

                }
            }


        }



        //Placing the Probe Comperison Table
        private void setProbsTable()
        {
            grid_probCom.RowCount = valueNumber;

            for (int i = 0 ; i < valueNumber; i++)
            {
               grid_probCom.Rows[i].Cells[0].Value= array[i];
                
               
               grid_probCom.Rows[i].Cells[1].Value = probCounts_UNStandart(grid_LICHdata,array[i]);
               grid_probCom.Rows[i].Cells[2].Value = probCounts_Standart(grid_EISCHdata,array[i]);
               
            }
        }

        private int probCounts_Standart(DataGridView table,int i)
        {
            int probCounter = 1;
            int lookingIndex = i % key;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
                probCounter++;  
                if (probCounter > valueNumber)
                {
                    return -1;
                }
                 
           
            }
         
                return probCounter;
           
        }
      
        private int probCounts_UNStandart(DataGridView table, int i)
        {
            int probCounter = 1;
            int lookingIndex = i % notStandartKey;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
                probCounter++;
                if (probCounter > valueNumber)
                    return -1;
            }

                return probCounter;
        }

        public int totalProb(int column)
        {
            int sum=0;

            for (int i = 0; i < valueNumber; i++)

                sum += Convert.ToInt32(grid_probCom.Rows[i].Cells[column].Value);

            return sum;
        }
        //ProbCom' da verilen columdaki toplam prob sayısı
        public float avarageProb(int column)
        {
            return (float)totalProb(column) / valueNumber;
        }

        //Total istatistics Alanının doldurulması
        public void setProbsStatistics()
        {
            txt_ProbsStatistics.Text = "LICH -> totalProb= " + totalProb(1) + "    avarageProb = " + avarageProb(1) + Environment.NewLine
                + "EISCH -> totalProb= " + totalProb(2) + "    avarageProb = " + avarageProb(2) + Environment.NewLine
                + Environment.NewLine+ Environment.NewLine+ Environment.NewLine 
                + "PACKING FACTOR IS " +Math.Round(((double)valueNumber/key)*100) + "%";
        }

        void createTableRows(DataGridView table)
        {
            table.RowCount = key;

            for (int i= 0;i<key;i++)
            {
                table.Rows[i].Cells[0].Value = i;
                table.Rows[i].Cells[1].Value = null;
                table.Rows[i].Cells[2].Value = null;
            }
        }

        //Finding the prime number of the hashing function so that the packing factor is approximately 90%
        private void Setkey()
        {
            int number = (valueNumber + valueNumber /11 )+1;

            while (!isPrimeNumber(number))
            {
                number++;
            }

            key = number;

        }

        //Check the number is it a prime number or not
        public static bool isPrimeNumber (int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        //OWERFLOW area kullanan fonksiyonlar için bi küçük Hash Asal sayısını bulma. Adress faktörü %85 oranında tutmaya çalışıyoruz.
        public int smallerkey(int number)
        {
            number-= Convert.ToInt32((double)number*0.20); // adress faktörün  yalaşık %85 çıkması için gerekli hesaplama
            while (!isPrimeNumber(number))
                number--;     
            return number;
        }


        // find packing factor
        private double PackingFactor()
        {
            return (double)valueNumber / (double)key;
        }

        private void generateArray(int valueNumber)
        {
            Random rastgele = new Random();
            int value;
            array = new int[valueNumber];

            for (int i = 0; i < valueNumber; i++)
            {
                value = rastgele.Next(0, generatedRange);
                array[i] = value;
            }

        }


        private int probStandart(DataGridView table, int i)
        {
            int lookingIndex = i % key;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
            }
            return lookingIndex;
        }

        private int probUnStandart(DataGridView table, int i)
        {
            int lookingIndex = i % notStandartKey;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);

            }
            return lookingIndex;

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(txt_search_value.Text);
            
                txt_search_result.Text = "The key you are looking for has been FOUND !" + Environment.NewLine

                    + "LICH    Table index  => " + probUnStandart(grid_LICHdata, deger) + Environment.NewLine
                    + "EISCH  Table index  => " + probStandart(grid_EISCHdata, deger) + Environment.NewLine;
            
        }

        private void txt_number_range_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_array_size_Click(object sender, EventArgs e)
        {

        }
    }
}
