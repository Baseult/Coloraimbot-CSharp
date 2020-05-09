using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Numerics;

namespace iBaseult
{

	public partial class FormOverlay : Form
	{

		Graphics g;

		public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
		{
			if (IntPtr.Size == 8)
				return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
			else
				return new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
		}

		[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
		private static extern int SetWindowLong32(HandleRef hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
		private static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

		[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
		static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

		public FormOverlay()
		{
			InitializeComponent();
		}



		private void FormOverlay_Load(object sender, EventArgs e)
		{
			try
			{
				this.BackColor = Color.Wheat;
				this.TransparencyKey = Color.Wheat;
				this.TopMost = true;
				this.MaximizeBox = true;
				this.FormBorderStyle = FormBorderStyle.None;


				HandleRef handleRef = new HandleRef(this, this.Handle);
				IntPtr initialStyle = GetWindowLongPtr(this.Handle, -20);
				int test = (int)initialStyle | 0x80000 | 0x20;
				SetWindowLongPtr(handleRef, -20, new IntPtr(test));
				Form1 form1 = new Form1();
			}
			catch
			{
				MessageBox.Show("Failure Code - 10 - There might be an issue with the FovCircle!");
			}
		}

		protected override CreateParams CreateParams
		{
			get
			{
				const int csNoclose = 0x200;

				var cp = base.CreateParams;
				cp.ClassStyle |= csNoclose;
				return cp;
			}
		}


		private void WaitNSeconds(int segundos)
		{
			if (segundos < 1) return;
			DateTime _desired = DateTime.Now.AddSeconds(segundos);
			while (DateTime.Now < _desired)
			{
				System.Windows.Forms.Application.DoEvents();
			}
		}

		public void FormOverlayPaint(object sender, PaintEventArgs e)
		{
		Now:

			for (; ; )
			{
				try
				{

					Form1 form1 = new Form1();
					Top = (form1.ySize - form1.fovY) / 2; Left = (form1.xSize - form1.fovX) / 2;
					Size = new System.Drawing.Size(form1.fovX + 50, form1.fovY + 50);

					if (form1.isCircle == false)
					{
						this.Invalidate();
						this.Close();
					}
					else
					{
						for (; ; )
						{
							try
							{
								Form1 form2 = new Form1();
								g = e.Graphics;
								Color col = Color.FromArgb(form2.FovCircleRed, form2.FovCircleGreen, form2.FovCircleBlue);          //yes it is shit but it works do it better lel
								Pen New = new Pen(col)
								{
									Width = form1.FovCircleWidth
								};
								e.Graphics.Clear(Color.Wheat);
								g.DrawEllipse(New, 0, 0, form2.fovX, form2.fovY);
								WaitNSeconds(5);
								goto Now;
							}
							catch
							{
								MessageBox.Show("Failure Code - 12 - There might be an issue with the FovCircle!");
								this.Close();
							}

						}
					}
				}
				catch
				{
					MessageBox.Show("Failure Code - 13 - There might be an issue with the FovCircle!");
				}

			break;
			}

		}

	}
}