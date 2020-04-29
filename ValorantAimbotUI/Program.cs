//﻿
//   _______             _             _    _               ______                              _         
//  (_______)           | |           | |  | |             (____  \                            | |    _   
//   _         ___    __| | _____   __| |  | |__   _   _    ____)  ) _____   ___  _____  _   _ | |  _| |_ 
//  | |       / _ \  / _  || ___ | / _  |  |  _ \ | | | |  |  __  ( (____ | /___)| ___ || | | || | (_   _)
//  | |_____ | |_| |( (_| || ____|( (_| |  | |_) )| |_| |  | |__)  )/ ___ ||___ || ____|| |_| || |   | |_ 
//   \______) \___/  \____||_____) \____|  |____/  \__  |  |______/ \_____|(___/ |_____)|____/  \_)   \__)
//                                                 (____/                                                  

//Some Information stuff..
//Recode of https://www.unknowncheats.me/forum/valorant/389766-valorant-color-aimbot-ui-source.html

//Copyright(c) 2020 Baseult - https://baseult.com - Discord: https://baseult.com/twitchwatcher


using System;
using System.Windows.Forms;

namespace ValorantAimbotUI
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Form1.CheckForIllegalCrossThreadCalls = false;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MessageBox.Show("All mouse_event features using mouse movement have been disabled due to the latest valorant patch making them not usable anymore." + "\n" + "\n" + "Despite that I will try to update the Aimbot and NoRecoil asap." +"\n" + "\n" + "Use this Script at your own risk!", "Information - Patch 0.49");
			Application.Run(new Form1());
		}
	}
}
