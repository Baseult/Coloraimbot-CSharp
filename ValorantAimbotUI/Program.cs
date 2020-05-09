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

namespace iBaseult
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{

            Form1.CheckForIllegalCrossThreadCalls = false;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MessageBox.Show("Detection Status: Unknown (No reported Ban so far)." + "\n" + "\n" + "Use this Cheat at your own risk!" + "\n" + "\n" +  "For increased Security change iBaseult.exe to another Name!");
			Application.Run(new Form2());
			Application.Run(new Form1());
		}
	}
}
