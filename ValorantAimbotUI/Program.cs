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
			MessageBox.Show("Detection Status: Unknown (No reported Ban so far)." + "\n" + "Use this Cheat at your own risk!" + "\n" + "\n" + "This Update has some Visual Features in it." + "\n" + "Most of these Visuals are bad coded and slow." + "\n" + "I will improve them in the next Update." + "\n" + "Please disable them if your Aimbot stutters because of it." +"\n" + "\n" + "Default Settings are adjusted for:" + "\n" + "Screen Resolution: 2560 x 1440." + "\n" + "Ingame Mouse Sensitivity: 1", "Information - Patch 0.49");

		   Application.Run(new Form1());
		   Application.Run(new FormOverlay());


		}
	}
}
