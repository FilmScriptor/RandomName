using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomName
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//ListBox nameAvailable = new ListBox();

		private void random_Click(object sender, EventArgs e)
		{
			int hi = 400;
			int lo = 4;
			int[] counts = new int[10];

			LinearCongruential lincon = new LinearCongruential(0);
			for (int i = 0; i < 1000; ++i)
			{
				double x = lincon.Next();
				int ri = (int)((hi - lo) * x + lo);

				++counts[ri];
				textBox1.Text = ri.ToString();
			}

			


		}

		// x0=seed; a=multiplier; b=increment; m=modulus; n=desired array length; 
		//	const linearRandomGenerator = (x0, a, b, m, n) => {
		//		const results = []
	
		//	for (let i = 0; i < n; i++)
		//		{
		//			x0 = (a * x0 + b) % m

		//		results.push(x0)

		//	}
		//		return results
	
		//}
	}
}
