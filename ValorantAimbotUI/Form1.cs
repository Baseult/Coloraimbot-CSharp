
//﻿
//   _______             _             _    _               ______                              _         
//  (_______)           | |           | |  | |             (____  \                            | |    _   
//   _         ___    __| | _____   __| |  | |__   _   _    ____)  ) _____   ___  _____  _   _ | |  _| |_ 
//  | |       / _ \  / _  || ___ | / _  |  |  _ \ | | | |  |  __  ( (____ | /___)| ___ || | | || | (_   _)
//  | |_____ | |_| |( (_| || ____|( (_| |  | |_) )| |_| |  | |__)  )/ ___ ||___ || ____|| |_| || |   | |_ 
//   \______) \___/  \____||_____) \____|  |____/  \__  |  |______/ \_____|(___/ |_____)|____/  \_)   \__)
//                                                 (____/                                                  


//Recode of https://www.unknowncheats.me/forum/valorant/389766-valorant-color-aimbot-ui-source.html


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValorantAimbotUI.Properties;

namespace ValorantAimbotUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
			this.isTriggerbot = this.GetKey<bool>("isTriggerbot");
			this.isAimbot = this.GetKey<bool>("isAimbot");
			this.speed = this.GetKey<decimal>("speed");
			this.Bhop = this.GetKey<decimal>("Bhop");
			this.fovX = this.GetKey<int>("fovX");
			this.fovY = this.GetKey<int>("fovY");
			this.color = (Form1.ColorType)this.GetKey<int>("color");
			this.mainAimKey = (Form1.AimKey)this.GetKey<int>("mainAimKey");
			this.Bhopxkey = (Form1.Bhopkey)this.GetKey<int>("Bhopxkey");
			this.isAimKey = this.GetKey<bool>("isAimKey");
			this.isHold = this.GetKey<bool>("isHold");
			this.monitor = this.GetKey<int>("monitor");
			this.isTriggerbot = this.GetKey<bool>("isTriggerbot");
			this.offsetY = this.GetKey<int>("offsetY");
			this.msShootTime = this.GetKey<int>("msShootTime");
			this.isRecoil = this.GetKey<bool>("isRecoil");
			this.isBhop = this.GetKey<bool>("isBhop");
			Form1.ColorType colorType = this.color;



			if (colorType != Form1.ColorType.Red)
			{
				if (colorType == Form1.ColorType.Purple)
				{
					this.PurpleRadio.Checked = true;
				}
			}
			else
			{
				this.RedRadio.Checked = true;
			}
			this.UpdateUI();
			this.IsHoldToggle.Checked = this.isHold;
			this.AimbotBtt.Checked = this.isAimbot;
			this.RecoilBtt.Checked = this.isRecoil;
			this.Bhopbox.Checked = this.isBhop;
			this.AimKeyToggle.Checked = this.isAimKey;
			this.AimKeyToggle.Checked = this.isBhop;
			this.Speed.Value = this.speed;
			this.Bhopinput.Value = this.Bhop;
			this.FovXNum.Value = this.fovX;
			this.FovYNum.Value = this.fovY;
			this.TriggerbotBtt.Checked = this.isTriggerbot;
			this.offsetNum.Value = this.offsetY;
			this.FireRateNum.Value = this.msShootTime;
			foreach (string text in Enum.GetNames(typeof(Form1.AimKey)))
			{
				this.contextMenuStrip1.Items.Add(text);
			}
			this.contextMenuStrip1.ItemClicked += delegate (object o, ToolStripItemClickedEventArgs e)
			{
				this.mainAimKey = (Form1.AimKey)Enum.Parse(typeof(Form1.AimKey), e.ClickedItem.ToString());
				this.SetKey("mainAimKey", (int)this.mainAimKey);
				this.UpdateUI();
			};
			foreach (string text in Enum.GetNames(typeof(Form1.Bhopkey)))
			{
				this.contextMenuStrip2.Items.Add(text);
			}
			this.contextMenuStrip2.ItemClicked += delegate (object o, ToolStripItemClickedEventArgs e)
			{
				this.Bhopxkey = (Form1.Bhopkey)Enum.Parse(typeof(Form1.Bhopkey), e.ClickedItem.ToString());
				this.SetKey("Bhopxkey", (int)this.Bhopxkey);
				this.UpdateUI();
			};

			this.AutoSize = false;
			base.AutoScaleMode = AutoScaleMode.Font;
			this.Font = new Font("Trebuchet MS", 10f, FontStyle.Regular, GraphicsUnit.Point, 204);
		}

		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

		private static float GetScalingFactor()
		{
			IntPtr hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
			int deviceCaps = Form1.GetDeviceCaps(hdc, 10);
			return (float)Form1.GetDeviceCaps(hdc, 117) / (float)deviceCaps;
		}


		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(int vKey);

		[DllImport("USER32.dll")]
		private static extern short GetKeyState(int nVirtKey);

		private async void Update3()
		{
			for (; ; )
			{
				News:

				if (!this.isRunning || !this.isBhop)
				{
					await Task.Delay(1000).ConfigureAwait(true);
					goto News;
				}
				else
				{
					int xx = int.Parse(Bhopinput.Text);
					int keyState = (int)Form1.GetKeyState(xx);

					if (keyState >= 0)
					{
						await Task.Delay(10).ConfigureAwait(true);
						goto News;
					}
					else
					{
						Thread.Sleep(25);
						SendKeys.SendWait(" ");
						Thread.Sleep(25);
					}

				}
			}
		}




		private async void Update2()
		{

			for (; ; )
			{

				New:

				if (!this.isRunning)
				{
					await Task.Delay(1000).ConfigureAwait(true);
				}
				else
				{
					if (this.isRecoil)
					{
						int keyState = (int)Form1.GetKeyState((int)this.mainAimKey);
						int keyState2 = (int)Form1.GetKeyState(1);
						if (keyState >= 0 && keyState2 >= 0)
						{
								await Task.Delay(1).ConfigureAwait(true);
								goto New;
							}
							else
							{

							for (int o = 0; o < 2; o++)
							{
								int keyStatex = (int)Form1.GetKeyState((int)this.mainAimKey);
								int keyStatex2 = (int)Form1.GetKeyState(1);
								if (keyStatex >= 0 && keyStatex2 >= 0)
								{
									await Task.Delay(1).ConfigureAwait(true);
									goto New;
								}
								else
								{

									await Task.Delay(15).ConfigureAwait(true);
									Move(0, 1);
								}
							}
						}

					}

					if (this.isRecoil)
					{
						int keyState = (int)Form1.GetKeyState((int)this.mainAimKey);
						int keyState2 = (int)Form1.GetKeyState(1);
						if (keyState >= 0 && keyState2 >= 0)
						{
							await Task.Delay(1).ConfigureAwait(true);
							goto New;
						}
						else
						{

							for (int f = 0; f < 3; f++)
							{
								int keyStatex = (int)Form1.GetKeyState((int)this.mainAimKey);
								int keyStatex2 = (int)Form1.GetKeyState(1);
								if (keyStatex >= 0 && keyStatex2 >= 0)
								{
									await Task.Delay(1).ConfigureAwait(true);
									goto New;
								}
								else
								{

									await Task.Delay(20).ConfigureAwait(true);
									Move(0, 2);
								}
							}
						}
					}

					if (this.isRecoil)
					{
						int keyState = (int)Form1.GetKeyState((int)this.mainAimKey);
						int keyState2 = (int)Form1.GetKeyState(1);
						if (keyState >= 0 && keyState2 >= 0)
						{
							await Task.Delay(1).ConfigureAwait(true);
							goto New;
						}
						else
						{
							for (int f = 0; f < 1; f++)
							{
								int keyStatex = (int)Form1.GetKeyState((int)this.mainAimKey);
								int keyStatex2 = (int)Form1.GetKeyState(1);
								if (keyStatex >= 0 && keyStatex2 >= 0)
								{
									await Task.Delay(1).ConfigureAwait(true);
									goto New;
								}
								else
								{
									await Task.Delay(30).ConfigureAwait(true);
									Move(0, 8);
								}
							}
						}
					}

					if (this.isRecoil)
					{
						int keyState = (int)Form1.GetKeyState((int)this.mainAimKey);
						int keyState2 = (int)Form1.GetKeyState(1);
						if (keyState >= 0 && keyState2 >= 0)
						{
							await Task.Delay(1).ConfigureAwait(true);
							goto New;
						}
						else
						{
							for (int f = 0; f < 1; f++)
							{
								int keyStatex = (int)Form1.GetKeyState((int)this.mainAimKey);
								int keyStatex2 = (int)Form1.GetKeyState(1);
								if (keyStatex >= 0 && keyStatex2 >= 0)
								{
									await Task.Delay(1).ConfigureAwait(true);
									goto New;
								}
								else
								{
									await Task.Delay(30).ConfigureAwait(true);
									Move(0, 9);
								}
							}
						}
					}

					if (this.isRecoil)
					{
						int keyState = (int)Form1.GetKeyState((int)this.mainAimKey);
						int keyState2 = (int)Form1.GetKeyState(1);
						if (keyState >= 0 && keyState2 >= 0)
						{
							await Task.Delay(1).ConfigureAwait(true);
							goto New;
						}
						else
						{

							for (int f = 0; f < 15; f++)
							{
								int keyStatex = (int)Form1.GetKeyState((int)this.mainAimKey);
								int keyStatex2 = (int)Form1.GetKeyState(1);
								if (keyStatex >= 0 && keyStatex2 >= 0)
								{
									await Task.Delay(1).ConfigureAwait(true);
									goto New;
								}
								else
								{
									await Task.Delay(25).ConfigureAwait(true);
									Move(0, 4);
								}
							}
						}
					}

					if (this.isRecoil)
					{
						int keyState = (int)Form1.GetKeyState((int)this.mainAimKey);
						int keyState2 = (int)Form1.GetKeyState(1);
						if (keyState >= 0 && keyState2 >= 0)
						{
							await Task.Delay(1).ConfigureAwait(true);
							goto New;
						}
						else
						{
							for (int f = 0; f < 22; f++)
							{
								int keyStatex = (int)Form1.GetKeyState((int)this.mainAimKey);
								int keyStatex2 = (int)Form1.GetKeyState(1);
								if (keyStatex >= 0 && keyStatex2 >= 0)
								{
									await Task.Delay(1).ConfigureAwait(true);
									goto New;
								}
								else
								{
									await Task.Delay(100).ConfigureAwait(true);
								}
							}
						}
					}


					if (this.isRecoil)
					{
						int keyState = (int)Form1.GetKeyState((int)this.mainAimKey);
						int keyState2 = (int)Form1.GetKeyState(1);
						if (keyState >= 0 && keyState2 >= 0)
						{
							await Task.Delay(1).ConfigureAwait(true);
							goto New;
						}
						else
						{
							for (int f = 0; f < 2; f++)
							{
								int keyStatex = (int)Form1.GetKeyState((int)this.mainAimKey);
								int keyStatex2 = (int)Form1.GetKeyState(1);
								if (keyStatex >= 0 && keyStatex2 >= 0)
								{
									await Task.Delay(1).ConfigureAwait(true);
									goto New;
								}
								else
								{
									Move(0, -82);
								}
							}
						}
					}

						
					
				}
			}
		}


		private async void Update4()
		{

			for (; ; )
			{

				if (!this.isRunning)
				{
					await Task.Delay(1000).ConfigureAwait(true);
				}
				else
				{
					if (this.isAimKey)
					{
						int keyState = (int)Form1.GetKeyState((int)this.Bhopxkey);
						if (this.isHold)
						{
							if (keyState >= 0)
							{
								await Task.Delay(1).ConfigureAwait(true);
								continue;
							}
						}
						else if (keyState != 0)
						{
							await Task.Delay(1).ConfigureAwait(true);
							continue;
						}
					}


					Color PixelColor;

					if (Customcolor.Checked == true)
					{
						int r = int.Parse(Redinput.Text);
						int g = int.Parse(Greeninput.Text);
						int b = int.Parse(Blueinput.Text);
						PixelColor = Color.FromArgb(r, g, b);
					}
					else
					{
						PixelColor = Color.FromArgb(GetColor(this.color));
					}

					int pixelx;
					int pixely;

					if (this.isTriggerbot)
					{
						if (checkBox1.Checked == true)
						{
							pixelx = int.Parse(PixelX.Text);
							pixely = int.Parse(PixelY.Text);
						}
						else
						{
							pixelx = 10;
							pixely = 10;
						}

						if (this.PixelSearch(new Rectangle((this.xSize - pixelx) / 2, (this.ySize - pixely) / 2, pixelx, pixely), PixelColor, this.colorVariation).Length != 0)
						{
							this.Move(0, 0, true);
						}
					}
					
				}



			}
		}
		

		private new async void Update()
		{

				for (; ; )
				{

				if (!this.isRunning)
				{
					await Task.Delay(1000).ConfigureAwait(true);
				}
				else
				{
					if (this.isAimKey)
					{
						int keyState = (int)Form1.GetKeyState((int)this.mainAimKey);
						if (this.isHold)
						{
							if (keyState >= 0)
							{
								await Task.Delay(1).ConfigureAwait(true);
								continue;
							}
						}
						else if (keyState != 0)
						{
							await Task.Delay(1).ConfigureAwait(true);
							continue;
						}
					}


					Color PixelColor;

					if (Customcolor.Checked == true)
					{
						int r = int.Parse(Redinput.Text);
						int g = int.Parse(Greeninput.Text);
						int b = int.Parse(Blueinput.Text);
						PixelColor = Color.FromArgb(r, g, b);
					}
					else
					{
						PixelColor = Color.FromArgb(GetColor(this.color));
					}

					
					if (this.isAimbot)
					{
						Point[] array = this.PixelSearch(new Rectangle((this.xSize - this.fovX) / 2, (this.ySize - this.fovY) / 2, this.fovX, this.fovY), PixelColor, this.colorVariation);
						if (array.Length != 0)
						{
							try
							{
								bool pressDown = false;
								
								Point[] array2 = (from t in array
												  orderby t.Y
												  select t).ToArray<Point>();
								List<Vector2> list = new List<Vector2>();
								for (int j = 0; j < array2.Length; j++)
								{
									Vector2 current = new Vector2((float)array2[j].X, (float)array2[j].Y);
									if (!(from t in list
										  where (t - current).Length() < 60f || Math.Abs(t.X - current.X) < 60f
										  select t).Any())
									{
										list.Add(current);
										if (list.Count > 5)
										{
											break;
										}
									}
								}
								Vector2 vector = (from t in list
												  select t - new Vector2((float)(this.xSize / 2), (float)(this.ySize / 2)) into t
												  orderby t.Length()
												  select t).ElementAt(0) + new Vector2(1f, (float)this.offsetY);
								this.Move((int)(vector.X * (float)this.speed), (int)(vector.Y * (float)this.speed), pressDown);
								continue;
							}
							catch (Exception ex)
							{
								Console.WriteLine("Main Ex." + ex?.ToString());
								continue;
							}
						}

					}
				}
			

						
			}
		}

		private static int GetColor(Form1.ColorType color)
		{
			if (color == Form1.ColorType.Red)
			{
				return 0x9A0000;
			}
			if (color != Form1.ColorType.Purple)
			{
				return 0xA224A2;
			}

			return 11480751;
		}

		private void UpdateDisplayInformation()
		{
			if (CustomScreen.Checked == true)
			{

				int x =  int.Parse(ScreenX2.Text);
				int y = int.Parse(ScreenY2.Text);

				this.xSize = x;
				this.ySize = y;
			}
			else
			{
				this.zoom = GetScalingFactor();
				Screen screen = this.CurrentScreen();
				bool primary = screen.Primary;
				this.xSize = (int)((float)screen.Bounds.Width * (primary ? this.zoom : 1f));
				this.ySize = (int)((float)screen.Bounds.Height * (primary ? this.zoom : 1f));
			}
		}

		[DllImport("user32.dll")]
		private static extern void Mouse_event(int dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

		public new void Move(int xDelta, int yDelta, bool pressDown = false)
		{
			if (pressDown)
			{
				if (DateTime.Now.Subtract(this.lastShot).TotalMilliseconds < (double)this.msShootTime)
				{
					pressDown = false;
				}
				else
				{
					this.lastShot = DateTime.Now;
				}
			}
			Form1.Mouse_event(pressDown ? 6:1 , xDelta, yDelta, 0U, UIntPtr.Zero);
			
		}

		public Screen CurrentScreen()
		{
			return Screen.AllScreens[this.monitor];
		}

		public unsafe Point[] PixelSearch(Rectangle rect, Color PixelColor, int ShadeVariation)
		{
			ArrayList arrayList = new ArrayList();
			Bitmap bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
			if (this.monitor >= Screen.AllScreens.Length)
			{
				this.monitor = 0;
				this.UpdateUI();
			}
			int left = Screen.AllScreens[this.monitor].Bounds.Left;
			int top = Screen.AllScreens[this.monitor].Bounds.Top;
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(rect.X + left, rect.Y + top, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
			}
			BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			int[] array = new int[]
			{
				(int)PixelColor.B,
				(int)PixelColor.G,
				(int)PixelColor.R
			};
			for (int i = 0; i < bitmapData.Height; i++)
			{
				byte* ptr = (byte*)((void*)bitmapData.Scan0) + i * bitmapData.Stride;
				for (int j = 0; j < bitmapData.Width; j++)
				{
					if (((int)ptr[j * 3] >= array[0] - ShadeVariation & (int)ptr[j * 3] <= array[0] + ShadeVariation) && ((int)ptr[j * 3 + 1] >= array[1] - ShadeVariation & (int)ptr[j * 3 + 1] <= array[1] + ShadeVariation) && ((int)ptr[j * 3 + 2] >= array[2] - ShadeVariation & (int)ptr[j * 3 + 2] <= array[2] + ShadeVariation))
					{
						arrayList.Add(new Point(j + rect.X, i + rect.Y));
					}
				}
			}
			bitmap.Dispose();
			return (Point[])arrayList.ToArray(typeof(Point));
		}

		private void Red_changed(object sender, EventArgs e)
		{
			this.color = Form1.ColorType.Red;
			this.SetKey("color", (int)this.color);
		}

		private void Purple_changed(object sender, EventArgs e)
		{
			this.color = Form1.ColorType.Purple;
			this.SetKey("color", (int)this.color);
		}

		private void Speed_changed(object sender, EventArgs e)
		{
			this.speed = this.Speed.Value;
			this.SetKey("speed", this.speed);
		}

		private void FovX_changed(object sender, EventArgs e)
		{
			this.fovX = (int)this.FovXNum.Value;
			this.SetKey("fovX", this.fovX);
		}

		private void FovY_changed(object sender, EventArgs e)
		{
			this.fovY = (int)this.FovYNum.Value;
			this.SetKey("fovY", this.fovY);
		}

		private void IsAimbot_changed(object sender, EventArgs e)
		{
			this.isAimbot = this.AimbotBtt.Checked;
			this.SetKey("isAimbot", this.isAimbot);
		}

		private void IsTriggerbot_changed(object sender, EventArgs e)
		{
			this.isTriggerbot = this.TriggerbotBtt.Checked;
			this.SetKey("isTriggerbot", this.isTriggerbot);
		}

		private void Main_load(object sender, EventArgs e)
		{
			this.mainThread = new Thread(delegate()
			{
				this.Update();
				this.Update2();
				this.Update3();
				this.Update4();
			});
			this.mainThread.Start();
		}

		private void SetKey(string key, bool o)
		{
			Settings.Default[key] = o;
			Settings.Default.Save();
		}

		private void SetKey(string key, int o)
		{
			Settings.Default[key] = o;
			Settings.Default.Save();
		}

		private void SetKey(string key, decimal o)
		{
			Settings.Default[key] = o;
			Settings.Default.Save();
		}

		private T GetKey<T>(string key)
		{
			return (T)((object)Settings.Default[key]);
		}

		protected override void OnHandleDestroyed(EventArgs e)
		{
			this.mainThread.Abort();
			Settings.Default.Save();
			base.OnHandleDestroyed(e);
		}

		private void Start_click(object sender, EventArgs e)
		{
			this.isRunning = !this.isRunning;
			this.UpdateUI();
		}

		private void UpdateUI()
		{
			this.StartBtt.Text = (this.isRunning ? "Stop" : "Start");
			this.UpdateDisplayInformation();
			this.ChangeMonitorBtt.Text = string.Concat(new string[]
			{
				"Monitor [",
				this.monitor.ToString(),
				"] ",
				this.xSize.ToString(),
				"x",
				this.ySize.ToString()
			});
			this.AimkeyBtt.Text = Enum.GetName(typeof(Form1.AimKey), this.mainAimKey);
			this.TriggerKeyBtt.Text = Enum.GetName(typeof(Form1.Bhopkey), this.Bhopxkey);
		}

		private void MonitorChanged(object sender, EventArgs e)
		{
			this.monitor++;
			if (this.monitor >= Screen.AllScreens.Length)
			{
				this.monitor = 0;
			}
			this.SetKey("monitor", this.monitor);
			this.UpdateUI();
		}

		private void IsAimKeyChanged(object sender, EventArgs e)
		{
			this.isAimKey = this.AimKeyToggle.Checked;
			this.SetKey("isAimKey", this.isAimKey);
		}

		private void IsHold_changed(object sender, EventArgs e)
		{
			this.isHold = this.IsHoldToggle.Checked;
			this.SetKey("isHold", this.isHold);
		}

		private void AimKeyDrop(object sender, EventArgs e)
		{
			if (this.AimkeyBtt.PointToScreen(new Point(this.AimkeyBtt.Left, this.AimkeyBtt.Bottom)).Y + this.contextMenuStrip1.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
			{
				this.contextMenuStrip1.Show(this.AimkeyBtt, new Point(0, -this.contextMenuStrip1.Size.Height));
				return;
			}
			this.contextMenuStrip1.Show(this.AimkeyBtt, new Point(0, this.AimkeyBtt.Height));

		}

		private void TriggerKeyDrop(object sender, EventArgs e)
		{

			if (this.TriggerKeyBtt.PointToScreen(new Point(this.TriggerKeyBtt.Left, this.TriggerKeyBtt.Bottom)).Y + this.contextMenuStrip2.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
			{
				this.contextMenuStrip2.Show(this.TriggerKeyBtt, new Point(0, -this.contextMenuStrip2.Size.Height));
				return;
			}
			this.contextMenuStrip2.Show(this.TriggerKeyBtt, new Point(0, this.TriggerKeyBtt.Height));

		}


		private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
		}

		private void ContextMenuStrip2_Opening(object sender, CancelEventArgs e)
		{
		}

		private void OffsetY_changed(object sender, EventArgs e)
		{
			this.offsetY = (int)this.offsetNum.Value;
			this.SetKey("offsetY", this.offsetY);
		}

		private void Label5_Click(object sender, EventArgs e)
		{
		}

		private void FireRate_changed(object sender, EventArgs e)
		{
			this.msShootTime = (int)this.FireRateNum.Value;
			this.SetKey("msShootTime", this.msShootTime);
		}

		private int xSize;

		private int ySize;

		private int msShootTime = 225;

		private DateTime lastShot = DateTime.Now;

		private int offsetY = 10;

		private bool isTriggerbot;

		private bool isAimbot;

		private bool isRecoil;

		private bool isBhop;

		private decimal speed = 1m;

		private decimal Bhop = 4;

		private int fovX = 100;

		private int fovY = 100;

		private bool isAimKey;


		private bool isHold = true;

		private int monitor;

		private readonly int colorVariation = 25;

		private Form1.AimKey mainAimKey = Form1.AimKey.Alt;

		private Form1.Bhopkey Bhopxkey = Form1.Bhopkey.Alt;

		private Form1.ColorType color = Form1.ColorType.Purple;

		private float zoom = 1f;

		private Thread mainThread;

		private bool isRunning;

		private enum AimKey
		{
			LeftMouse = 1,
			RightMouse,
			X1Mouse = 5,
			X2Button,
			Shift = 160,
			Ctrl = 162,
			Alt = 164,
			Capslock = 20,
			Numpad0 = 96,
			Numlock = 144
		}

		private enum Bhopkey
		{
			LeftMouse = 1,
			RightMouse,
			X1Mouse = 5,
			X2Button,
			Shift = 160,
			Ctrl = 162,
			Alt = 164,
			Capslock = 20,
			Numpad0 = 96,
			Numlock = 144
		}

		public enum DeviceCap
		{
			VERTRES = 10,
			DESKTOPVERTRES = 117
		}

		private enum ColorType
		{
			Red,
			Purple
		}

		private void Label7_Click(object sender, EventArgs e)
		{

		}

		private void ScreenX2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void ScreenY2_ValueChanged(object sender, EventArgs e)
		{

		}


		private void Recoilcheckbox_CheckedChanged_1(object sender, EventArgs e)
		{
			this.isRecoil = this.RecoilBtt.Checked;
			this.SetKey("isRecoil", this.isRecoil);
		}

		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.isBhop = this.Bhopbox.Checked;
			this.SetKey("isBhop", this.isBhop);
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.Bhop = this.Bhopinput.Value;
			this.SetKey("Bhop", this.Bhop);
		}

		private void AimKeyToggle_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void CheckBox2_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
