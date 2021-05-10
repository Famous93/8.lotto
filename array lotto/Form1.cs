using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_lotto
{
    public partial class Form1 : Form
    {
		
		Random m_random = new Random();

		int[] selectedNumbers = new int[9];
		
		public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			// random number
			for (int numberCount = 0; numberCount < selectedNumbers.Length; numberCount++)
			{

				int newNumber = m_random.Next(1, 40);

				for (int i = 0; i < numberCount; i++)
				{
					if (newNumber == selectedNumbers[i])
					{
						// jos numero toistu
						newNumber = m_random.Next(1, 40); 
						continue; // Test again
					}
				}

				selectedNumbers[numberCount] = newNumber;

			}
			Array.Sort(selectedNumbers);
			num1.Text = string.Join(", ", selectedNumbers.Select(x => x.ToString()).ToArray());

			


		}








			private void button2_Click(object sender, EventArgs e)
			{
				int oikeidenmaara = 0;
				var veikkaus = new List<int>();
				veikkaus.Add(Int32.Parse(mynum1.Text));
				veikkaus.Add(Int32.Parse(mynum2.Text));
				veikkaus.Add(Int32.Parse(mynum3.Text));
				veikkaus.Add(Int32.Parse(mynum4.Text));
				veikkaus.Add(Int32.Parse(mynum5.Text));
				veikkaus.Add(Int32.Parse(mynum6.Text));
				veikkaus.Add(Int32.Parse(mynum7.Text));
				veikkaus.Add(Int32.Parse(mynum8.Text));
				veikkaus.Add(Int32.Parse(mynum9.Text));

				for (int i = 0; i < selectedNumbers.Length; i++)
				{
					for (int j = 0; j < veikkaus.Count; j++)
					{
						if (selectedNumbers[i] == veikkaus[j])
						{
							oikeidenmaara = oikeidenmaara + 1;
						}
					}

				}

				label1.Text = oikeidenmaara.ToString();

				}
	}

}
