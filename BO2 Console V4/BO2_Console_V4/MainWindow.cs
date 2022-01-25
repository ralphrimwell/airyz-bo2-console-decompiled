using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Airyz;
using ASMdotNET;
using BO2PluginFramework;
using BO2_Console_V4.Classes;
using BO2_Console_V4.Info;
using BO2_Console_V4.XAML;
using ColorWheel.Controls;
using ColorWheel.Core;
using Microsoft.Toolkit.Win32.UI.Controls.WPF;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using WpfAnimatedGif;

namespace BO2_Console_V4
{
	// Token: 0x0200003C RID: 60
	public class MainWindow : Window, IComponentConnector
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0003157D File Offset: 0x0002F77D
		[Obfuscation(Exclude = true)]
		public static Palette Palette
		{
			get
			{
				return Palette.Create(new RGBColorWheel(), Colors.White, 1, 1, 1.0, 0.2, 0.2, 0.9);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000315B4 File Offset: 0x0002F7B4
		public MainWindow()
		{
			this.InitializeComponent();
			base.DataContext = this;
			this.SettingsPanel.Visibility = Visibility.Hidden;
			this.Init();
			this.CheckLogin();
			this.currentSessionName = DateTime.Now.ToString("dd-MM-yy H-mm-ss");
			Task.Run(delegate()
			{
				this.TickLoop();
			});
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000316BC File Offset: 0x0002F8BC
		private string FormatTick(int tick)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(tick - 3000));
			return string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00031708 File Offset: 0x0002F908
		private void TickLoop()
		{
			for (;;)
			{
				if (this.BO2.ReadInt(this.addresses.TheaterBase) != 0)
				{
					int tick = this.BO2.ReadInt(this.addresses.Tick);
					int endTick = this.BO2.ReadInt(this.addresses.EndTick);
					this.TickLabel.Dispatcher.Invoke(delegate()
					{
						this.TickLabel.Content = this.FormatTick(tick);
						this.TheaterProgressBar.Maximum = (double)endTick;
						this.TheaterProgressBar.Value = (double)tick;
					});
				}
				Thread.Sleep(20);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00031799 File Offset: 0x0002F999
		private void BO2_Console_V4_Closing(object sender, CancelEventArgs e)
		{
			this.demoPreviewerWebView.Close();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000317A6 File Offset: 0x0002F9A6
		public bool LoginCallback(bool input)
		{
			return true;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000317A9 File Offset: 0x0002F9A9
		private void CurrentVersionLabel_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.NotifyUpdate();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000317B4 File Offset: 0x0002F9B4
		private void NotifyUpdate()
		{
			if (System.Windows.MessageBox.Show(string.Concat(new string[]
			{
				"An Update is available! Would you like to download?",
				Environment.NewLine,
				Environment.NewLine,
				"Change Log: ",
				Environment.NewLine,
				this.versionInfo.ChangeLog
			}), "Update Available!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			{
				Process.Start("http://airyz.xyz/");
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0003181C File Offset: 0x0002FA1C
		private string GetMapName()
		{
			if (this.BO2 != null)
			{
				int value = this.BO2.ReadInt(this.addresses.UI_MapName);
				return this.BO2.ReadStringASCII((IntPtr)value);
			}
			return "";
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00031860 File Offset: 0x0002FA60
		private void Init()
		{
			this.initialised = false;
			this.writeMemory = false;
			this.globalKeyboardHook.KeyboardPressed += this.GlobalKeyboardHook_KeyboardPressed;
			this.InitialiseCustomSliders();
			this.gen = new UIDGenerator();
			this.AddUidRecursive(this.MainGrid);
			this.AddContextMenus();
			this.WeaponClassSelector.ItemsSource = WeaponIDs.Weapons.Keys;
			this.PluginsPreInit();
			this.RefreshGame();
			DirectoryInfo directoryInfo = new DirectoryInfo("Anims");
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			string[] directories = Directory.GetDirectories("Anims", "*", SearchOption.TopDirectoryOnly);
			for (int i = 0; i < directories.Length; i++)
			{
				string[] array = directories[i].Split(new char[]
				{
					'\\'
				});
				this.AnimCategorySelector.Items.Add(array[array.Length - 1]);
			}
			this.writeMemory = true;
			this.initialised = true;
			BO2Context.GetControlByUID = ((string name) => (System.Windows.Controls.Control)this.controls[name]);
			BO2Context.GetWindow_Internal = (() => this);
			try
			{
				BO2Context.dvars_internal = this.addresses.dvarFinder.returnedDvars;
				BO2Context.SendCommand = delegate(string command)
				{
					this.console.Send(command);
				};
				BO2Context.GetMemoryInstance = (() => this.BO2);
			}
			catch
			{
			}
			this.PluginsPostInit();
			if (File.Exists("waifu.png"))
			{
				BitmapImage bitmapImage = new BitmapImage(new Uri(new FileInfo("waifu.png").FullName));
				this.waifu.Width = bitmapImage.Width / 2.0;
				this.waifu.Height = bitmapImage.Height / 2.0;
				this.waifu.Source = bitmapImage;
			}
			if (File.Exists("waifu2.png"))
			{
				BitmapImage bitmapImage2 = new BitmapImage(new Uri(new FileInfo("waifu2.png").FullName));
				this.waifu2.Width = bitmapImage2.Width / 2.0;
				this.waifu2.Height = bitmapImage2.Height / 2.0;
				this.waifu2.Source = bitmapImage2;
			}
			if (File.Exists("bg.png"))
			{
				this.MainMenuGrid.Background = new SolidColorBrush(Colors.Transparent);
				base.Resources["DefaultBackground"] = new SolidColorBrush(Colors.Transparent);
				this.MainGrid.Background = new ImageBrush(new BitmapImage(new Uri(new FileInfo("bg.png").FullName)))
				{
					Stretch = Stretch.UniformToFill
				};
			}
			WeaponChanger.addresses = this.addresses;
			WeaponChanger.BO2 = this.BO2;
			this.DemoMapSelector.ItemsSource = Demos.foundMaps;
			if (this.cache.demos_folder.Length > 0)
			{
				Demos.LoadDemos(this.cache.demos_folder, this.DemoMapSelector.Dispatcher);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00031B54 File Offset: 0x0002FD54
		private void PluginsPreInit()
		{
			string path = Environment.CurrentDirectory + "\\Plugins";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			this.plugins = PluginLoader.LoadPlugins(path);
			this.PluginListBox.ItemsSource = this.plugins;
			foreach (PluginLoader.Plugin plugin in this.plugins)
			{
				if (this.cache.enabledPlugins.Contains(plugin.hash))
				{
					this.AddPluginDvars(plugin.plugin);
				}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00031BFC File Offset: 0x0002FDFC
		private void PluginsPostInit()
		{
			foreach (PluginLoader.Plugin plugin in this.plugins)
			{
				if (this.cache.enabledPlugins.Contains(plugin.hash))
				{
					this.ExecutePlugin(plugin.plugin);
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00031C68 File Offset: 0x0002FE68
		private void AddPluginDvars(IBO2Plugin plugin)
		{
			foreach (string item in plugin.requestedDvars)
			{
				if (!this.addresses.defaultDvars.Contains(item))
				{
					this.addresses.defaultDvars.Add(item);
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		private void ExecutePlugin(IBO2Plugin plugin)
		{
			System.Windows.Controls.UserControl ui = plugin.UI;
			if (ui != null)
			{
				Grid grid = new Grid();
				System.Windows.Controls.UserControl userControl = ui;
				userControl.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
				userControl.Margin = new Thickness(0.0);
				userControl.VerticalAlignment = VerticalAlignment.Top;
				grid.Children.Add(userControl);
				grid.MinHeight = userControl.MinHeight;
				grid.MinWidth = userControl.MinWidth;
				grid.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
				grid.VerticalAlignment = VerticalAlignment.Top;
				grid.Margin = new Thickness(0.0);
				TabItem tabItem = new TabItem
				{
					Header = plugin.TabName.ToUpper(),
					Content = grid
				};
				((Grid)tabItem.Content).HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
				this.MainTabs.Items.Add(tabItem);
			}
			this.LoadedPlugins.Add(plugin);
			plugin.main();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00031D93 File Offset: 0x0002FF93
		private void EnablePlugin(PluginLoader.Plugin plugin)
		{
			this.cache.enabledPlugins.Add(plugin.hash);
			this.AddPluginDvars(plugin.plugin);
			this.addresses.ReadAllAddresses();
			this.ExecutePlugin(plugin.plugin);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00031DD0 File Offset: 0x0002FFD0
		private void DisablePlugin(PluginLoader.Plugin plugin)
		{
			while (this.cache.enabledPlugins.Contains(plugin.hash))
			{
				this.cache.enabledPlugins.Remove(plugin.hash);
			}
			while (this.LoadedPlugins.Contains(plugin.plugin))
			{
				this.LoadedPlugins.Remove(plugin.plugin);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00031E38 File Offset: 0x00030038
		private void PluginEnabledBox_Checked(object sender, RoutedEventArgs e)
		{
			if (!this.sentViaCode)
			{
				try
				{
					bool? isChecked = this.PluginEnabledBox.IsChecked;
					bool flag = true;
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						this.EnablePlugin((PluginLoader.Plugin)this.PluginListBox.SelectedItem);
						this.SaveCache();
					}
					else
					{
						this.DisablePlugin((PluginLoader.Plugin)this.PluginListBox.SelectedItem);
						this.SaveCache();
						System.Windows.MessageBox.Show("Plugin Disabled. Please restart tool for this to take effect");
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00031ECC File Offset: 0x000300CC
		private void PluginListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			PluginLoader.Plugin plugin = (PluginLoader.Plugin)this.PluginListBox.SelectedItem;
			this.PluginDescBox.Text = plugin.plugin.Description;
			this.PluginAuthorBox.Text = plugin.plugin.Author;
			this.PluginNameBox.Text = plugin.plugin.Name;
			this.PluginHash.Text = plugin.hash;
			this.sentViaCode = true;
			this.PluginEnabledBox.IsChecked = new bool?(this.LoadedPlugins.Contains(plugin.plugin));
			this.sentViaCode = false;
			if (this.versionInfo.VerifiedPlugins.Contains(plugin.hash))
			{
				this.VerifiedPluginLabel.Visibility = Visibility.Visible;
				return;
			}
			this.VerifiedPluginLabel.Visibility = Visibility.Hidden;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00031FA0 File Offset: 0x000301A0
		private void RefreshGame()
		{
			if (Process.GetProcessesByName("t6mp").Length != 0)
			{
				this.BO2 = new AiryzMemory("t6mp");
				base.Title = "BO2 Console V4 - Steam MP";
				this.LoadDemoFromFileButton.IsEnabled = false;
				this.LoadSelectedDemoButton.IsEnabled = false;
				this.SaveCurrentDemoButton.IsEnabled = true;
			}
			else if (Process.GetProcessesByName("t6mpv43").Length != 0)
			{
				this.BO2 = new AiryzMemory("t6mpv43");
				base.Title = "BO2 Console V4 - Redacted MP";
				this.SaveCurrentDemoButton.IsEnabled = false;
			}
			else if (Process.GetProcessesByName("t6zmv41").Length != 0)
			{
				this.BO2 = new AiryzMemory("t6zmv41");
				base.Title = "BO2 Console V4 - Redacted ZM";
				this.SaveCurrentDemoButton.IsEnabled = false;
			}
			else if (Process.GetProcessesByName("t6zm").Length != 0)
			{
				this.BO2 = new AiryzMemory("t6zm");
				base.Title = "BO2 Console V4 - Steam ZM";
			}
			else if (Process.GetProcessesByName("plutonium-bootstrapper-win32").Length != 0)
			{
				this.BO2 = new AiryzMemory("plutonium-bootstrapper-win32");
				base.Title = "BO2 Console V4 - Plutonium";
				this.SaveCurrentDemoButton.IsEnabled = false;
			}
			else
			{
				this.BO2 = new AiryzMemory("NO PROCESS FOUND");
				base.Title = "BO2 Console V4";
			}
			this.console.FindGame();
			int num = this.BO2.ReadInt(this.addresses.SkyboxModel);
			if (num != 0)
			{
				this.model = num;
			}
			this.addresses.ReadAllAddresses();
			this.SetDataContext();
			if (this.persist_settings)
			{
				foreach (object obj in this.controls.Values)
				{
					try
					{
						if (obj.GetType() == typeof(Slider) && (obj as Slider).IsEnabled)
						{
							(obj as Slider).RaiseEvent(new RoutedPropertyChangedEventArgs<double>(0.0, 0.0, RangeBase.ValueChangedEvent));
						}
						if (obj.GetType() == typeof(Dial) && (obj as Slider).IsEnabled)
						{
							(obj as Dial).Value += 0.01;
						}
						if (obj.GetType() == typeof(ColorWheelControl) && (obj as ColorWheelControl).IsEnabled)
						{
							PaletteColor paletteColor = (obj as ColorWheelControl).Palette.Colors[0];
							paletteColor.A += 0.01;
							(obj as ColorWheelControl).Palette.Colors[0] = paletteColor;
						}
					}
					catch
					{
					}
				}
				this.DOFEnable_Checked(null, null);
				this.SsaoToggle_Checked(null, null);
			}
			try
			{
				try
				{
					BO2Context.dvars_internal = this.addresses.dvarFinder.returnedDvars;
					BO2Context.SendCommand = delegate(string command)
					{
						this.console.Send(command);
					};
					BO2Context.GetMemoryInstance = (() => this.BO2);
				}
				catch
				{
				}
				BO2Context.GetControlByUID = ((string name) => (System.Windows.Controls.Control)this.controls[name]);
				BO2Context.GetWindow_Internal = (() => this);
				foreach (IBO2Plugin ibo2Plugin in this.LoadedPlugins)
				{
					ibo2Plugin.refresh();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00032388 File Offset: 0x00030588
		private void GameCheckLoop()
		{
			for (;;)
			{
				this.ReadAndApplyGameSettings();
				Thread.Sleep(10000);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0003239C File Offset: 0x0003059C
		private void InitialiseCustomSliders()
		{
			DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
			DirectoryInfo directoryInfo = new DirectoryInfo(((parent != null) ? parent.ToString() : null) + "\\Sliders");
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			foreach (FileInfo fileInfo in (from f in directoryInfo.GetFiles()
			orderby f.CreationTime
			select f).ToList<FileInfo>())
			{
				string text = File.ReadAllText(fileInfo.FullName);
				CustomSliderAddress customSliderAddress = JsonConvert.DeserializeObject<CustomSliderAddress>(text);
				if (!this.addresses.defaultDvars.Contains(customSliderAddress.name))
				{
					this.addresses.defaultDvars.Add(customSliderAddress.name);
				}
				if (customSliderAddress.type == dvarType_t.FLOAT_3 || customSliderAddress.type == dvarType_t.FLOAT_4)
				{
					CustomSliderAddress customSliderAddress2 = JsonConvert.DeserializeObject<CustomSliderAddress>(text);
					CustomSliderAddress customSliderAddress3 = JsonConvert.DeserializeObject<CustomSliderAddress>(text);
					customSliderAddress2.offset = 4;
					customSliderAddress3.offset = 8;
					CustomSliderAddress customSliderAddress4 = customSliderAddress;
					customSliderAddress4.friendlyName += " - X";
					CustomSliderAddress customSliderAddress5 = customSliderAddress2;
					customSliderAddress5.friendlyName += " - Y";
					CustomSliderAddress customSliderAddress6 = customSliderAddress3;
					customSliderAddress6.friendlyName += " - Z";
					this.CreateSlider(customSliderAddress);
					this.CreateSlider(customSliderAddress2);
					this.CreateSlider(customSliderAddress3);
					if (customSliderAddress.type == dvarType_t.FLOAT_4)
					{
						CustomSliderAddress customSliderAddress7 = JsonConvert.DeserializeObject<CustomSliderAddress>(text);
						customSliderAddress7.offset = 12;
						CustomSliderAddress customSliderAddress8 = customSliderAddress7;
						customSliderAddress8.friendlyName += " - W";
						this.CreateSlider(customSliderAddress7);
					}
				}
				else
				{
					this.CreateSlider(customSliderAddress);
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00032570 File Offset: 0x00030770
		private void SetDataContext()
		{
			try
			{
				this.FogBaseDistanceSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.startDist, 0)
					},
					type = typeof(float)
				};
				this.FogFadeSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fadeDist, 0)
					},
					type = typeof(float)
				};
				this.FogHeightStartSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.startHeight, 0)
					},
					type = typeof(float)
				};
				this.FogHeightFadeSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fadeHeight, 0)
					},
					type = typeof(float)
				};
				this.FogBrightnessSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fogOpacity, 0)
					},
					type = typeof(float)
				};
				this.SunHazeStartRadiusSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.hazeInnerRadius, 0)
					},
					type = typeof(float)
				};
				this.SunHazeEndRadiusSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.hazeOuterRadius, 0)
					},
					type = typeof(float)
				};
				this.SunHazeBrightnessSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.sunHazeOpacity, 0)
					},
					type = typeof(float)
				};
				this.SunXSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.X, 0)
					},
					type = typeof(float)
				};
				this.SunYSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.Y, 0)
					},
					type = typeof(float)
				};
				this.SunZSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.Z, 0)
					},
					type = typeof(float)
				};
				this.ssaoScaleBar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Ssao>(this.addresses.r_ssao, (Structures.Ssao Ssao) => (object)Ssao.scale, 0)
					},
					type = typeof(float)
				};
				this.ssaoRadiusBar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Ssao>(this.addresses.r_ssao, (Structures.Ssao Ssao) => (object)Ssao.radius, 0)
					},
					type = typeof(float)
				};
				this.ssaoBiasBar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Ssao>(this.addresses.r_ssao, (Structures.Ssao Ssao) => (object)Ssao.bias, 0)
					},
					type = typeof(float)
				};
				this.ssaoIntensityBar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.BO2.GetStructMemberAddress<Structures.Ssao>(this.addresses.r_ssao, (Structures.Ssao Ssao) => (object)Ssao.intensity, 0)
					},
					type = typeof(float)
				};
				this.DOFFarBlurSider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_farBlur
					},
					type = typeof(float)
				};
				this.DOFFarStartSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_farStart
					},
					type = typeof(float)
				};
				this.DOFFarEndSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_farEnd
					},
					type = typeof(float)
				};
				this.DOFNearBlurSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_nearBlur
					},
					type = typeof(float)
				};
				this.DOFNearStartSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_nearStart
					},
					type = typeof(float)
				};
				this.DOFNearEndSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_nearEnd
					},
					type = typeof(float)
				};
				this.DOFViewmodelStartSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_viewModelStart
					},
					type = typeof(float)
				};
				this.DOFViewmodelEndSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_viewModelEnd
					},
					type = typeof(float)
				};
				this.DOFBiasSlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dof_bias
					},
					type = typeof(float)
				};
				this.DOFQualitySlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_dofHDR
					},
					type = typeof(int)
				};
				this.skyBrightnessBar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_sky_intensity_factor0
					},
					type = typeof(float)
				};
				this.skyTempBar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_skyColorTemp
					},
					type = typeof(float)
				};
				this.SunQualitySlider.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.sm_sunQuality
					},
					type = typeof(int)
				};
				this.playersRbar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_heroLightScaleR
					},
					type = typeof(float)
				};
				this.playersGbar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_heroLightScaleG
					},
					type = typeof(float)
				};
				this.playersBbar.DataContext = new Address
				{
					address = new IntPtr[]
					{
						this.addresses.r_heroLightScaleB
					},
					type = typeof(float)
				};
			}
			catch
			{
			}
		}

		// Token: 0x060000CC RID: 204
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x060000CD RID: 205
		[DllImport("user32.dll")]
		private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x060000CE RID: 206 RVA: 0x00033184 File Offset: 0x00031384
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			IntPtr handle = new WindowInteropHelper(this).Handle;
			MainWindow.SetWindowLong(handle, -16, MainWindow.GetWindowLong(handle, -16) & -524289);
			this.writeMemory = true;
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
			IntPtr handle2 = windowInteropHelper.Handle;
			HwndSource hwndSource = HwndSource.FromHwnd(windowInteropHelper.Handle);
			if (hwndSource != null)
			{
				hwndSource.AddHook(new HwndSourceHook(this.HwndMessageHook));
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000331EC File Offset: 0x000313EC
		private void TemporaryButtonTextReplace(System.Windows.Controls.Button control, string newText, string oldText, int time)
		{
			control.Dispatcher.Invoke(delegate()
			{
				control.Content = newText;
			});
			Thread.Sleep(time);
			control.Dispatcher.Invoke(delegate()
			{
				control.Content = oldText;
			});
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00033254 File Offset: 0x00031454
		private void AddUidRecursive(Grid control)
		{
			foreach (object obj in control.Children)
			{
				if (obj.GetType() == typeof(Grid))
				{
					if ((obj as Grid).Uid != null && (obj as Grid).Uid.Length > 1)
					{
						this.controls.Add((obj as Grid).Uid, obj);
					}
					this.AddUidRecursive((Grid)obj);
				}
				else
				{
					if (obj.GetType() == typeof(System.Windows.Controls.TabControl))
					{
						this.gen.GetUID();
						System.Windows.Controls.TabControl tabControl = (System.Windows.Controls.TabControl)obj;
						if (tabControl.Uid != null && tabControl.Uid.Length > 1)
						{
							this.controls.Add(tabControl.Uid, obj);
						}
						using (IEnumerator enumerator2 = ((IEnumerable)tabControl.Items).GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								object obj2 = enumerator2.Current;
								this.controls.Add((obj2 as TabItem).Uid, obj2);
								this.AddUidRecursive((Grid)((TabItem)obj2).Content);
							}
							continue;
						}
					}
					if (obj.GetType() == typeof(System.Windows.Controls.ListBox))
					{
						using (IEnumerator enumerator2 = ((IEnumerable)((System.Windows.Controls.ListBox)obj).Items).GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								object obj3 = enumerator2.Current;
								if (obj3.GetType() == typeof(Grid))
								{
									this.AddUidRecursive((Grid)obj3);
								}
							}
							continue;
						}
					}
					if (obj.GetType() == typeof(Slider) && ((Slider)obj).DataContext != null && ((Slider)obj).DataContext.GetType() == typeof(CustomSliderAddress))
					{
						HashAlgorithm hashAlgorithm = MD5.Create();
						CustomSliderAddress customSliderAddress = ((Slider)obj).DataContext as CustomSliderAddress;
						string s = customSliderAddress.friendlyName + "-" + customSliderAddress.name + customSliderAddress.type.ToString();
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = hashAlgorithm.ComputeHash(bytes);
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 0; i < array.Length; i++)
						{
							stringBuilder.Append(array[i].ToString("X2"));
						}
						string text = stringBuilder.ToString();
						(obj as Slider).Uid = text;
						this.controls.Add(text, obj);
					}
					else
					{
						try
						{
							if ((obj as System.Windows.Controls.Control).Uid != null && (obj as System.Windows.Controls.Control).Uid.Length > 1)
							{
								this.controls.Add((obj as System.Windows.Controls.Control).Uid, obj);
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000335D4 File Offset: 0x000317D4
		private void AddContextMenus()
		{
			foreach (object obj in this.controls.Values)
			{
				System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();
				System.Windows.Controls.MenuItem menuItem = new System.Windows.Controls.MenuItem
				{
					Header = "Create Keybind"
				};
				menuItem.Click += this.AddKeybindContextMenu_Click;
				contextMenu.Items.Add(menuItem);
				if (obj.GetType() == typeof(System.Windows.Controls.Button))
				{
					(obj as System.Windows.Controls.Button).ContextMenu = contextMenu;
				}
				else if (obj.GetType() == typeof(Slider))
				{
					(obj as Slider).ContextMenu = contextMenu;
				}
				else if (obj.GetType() == typeof(System.Windows.Controls.CheckBox))
				{
					(obj as System.Windows.Controls.CheckBox).ContextMenu = contextMenu;
				}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000336D0 File Offset: 0x000318D0
		private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			((System.Windows.Controls.TextBox)sender).SelectAll();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000336E0 File Offset: 0x000318E0
		private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
		{
			int caretIndex = ((System.Windows.Controls.TextBox)sender).CaretIndex;
			if (e.Key == Key.OemComma || e.Key == Key.OemPeriod)
			{
				try
				{
					if (((System.Windows.Controls.TextBox)sender).Text[caretIndex] == '.' || ((System.Windows.Controls.TextBox)sender).Text[caretIndex] == ',')
					{
						System.Windows.Controls.TextBox textBox = (System.Windows.Controls.TextBox)sender;
						int caretIndex2 = textBox.CaretIndex;
						textBox.CaretIndex = caretIndex2 + 1;
						e.Handled = true;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00033770 File Offset: 0x00031970
		private void Send(string cfg)
		{
			MatchCollection matchCollection = new Regex("(z_fog)\\w+(\\s\\d*\\.?\\d*){1,3}", RegexOptions.IgnoreCase | RegexOptions.Singleline).Matches(cfg);
			if (matchCollection.Count > 0)
			{
				Structures.Fog fog = this.BO2.ReadStruct<Structures.Fog>(this.addresses.Fog);
				foreach (object obj in matchCollection)
				{
					Match match = (Match)obj;
					try
					{
						string[] array = match.Value.Replace(Environment.NewLine, "").ToLower().Split(new char[]
						{
							' '
						});
						string text = array[0];
						if (text != null)
						{
							uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
							if (num <= 2051480301U)
							{
								if (num <= 712787315U)
								{
									if (num != 470765523U)
									{
										if (num != 620367602U)
										{
											if (num == 712787315U)
											{
												if (text == "z_fogfadeheight")
												{
													fog.fadeHeight = float.Parse(array[1]);
												}
											}
										}
										else if (text == "z_fogstartdist")
										{
											fog.startDist = float.Parse(array[1]);
										}
									}
									else if (text == "z_fogsunyaw")
									{
										fog.sunHazeYawAngle = float.Parse(array[1]);
									}
								}
								else if (num != 1374917208U)
								{
									if (num != 1972289925U)
									{
										if (num == 2051480301U)
										{
											if (text == "z_fogsunopacity")
											{
												fog.sunHazeOpacity = float.Parse(array[1]);
											}
										}
									}
									else if (text == "z_fogstartheight")
									{
										fog.startHeight = float.Parse(array[1]);
									}
								}
								else if (text == "z_fogsuninner")
								{
									fog.hazeInnerRadius = float.Parse(array[1]);
								}
							}
							else if (num <= 2908295979U)
							{
								if (num != 2269133767U)
								{
									if (num != 2558979663U)
									{
										if (num == 2908295979U)
										{
											if (text == "z_fogsunouter")
											{
												fog.hazeOuterRadius = float.Parse(array[1]);
											}
										}
									}
									else if (text == "z_fogsuncolor")
									{
										fog.sunHazeColor.r = float.Parse(array[1]) * 255f;
										fog.sunHazeColor.g = float.Parse(array[2]) * 255f;
										fog.sunHazeColor.b = float.Parse(array[3]) * 255f;
									}
								}
								else if (text == "z_fogopacity")
								{
									fog.fogOpacity = float.Parse(array[1]);
								}
							}
							else if (num != 3985199230U)
							{
								if (num != 4202495681U)
								{
									if (num == 4227549096U)
									{
										if (text == "z_fogfadedist")
										{
											fog.fadeDist = float.Parse(array[1]);
										}
									}
								}
								else if (text == "z_fogcolor")
								{
									fog.fogColor.r = float.Parse(array[1]) * 255f;
									fog.fogColor.g = float.Parse(array[2]) * 255f;
									fog.fogColor.b = float.Parse(array[3]) * 255f;
								}
							}
							else if (text == "z_fogsunpitch")
							{
								fog.sunHazePitchAngle = float.Parse(array[1]);
							}
						}
					}
					catch
					{
					}
				}
				this.BO2.WriteStruct(this.addresses.Fog, fog);
			}
			this.console.Send(cfg);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00033BCC File Offset: 0x00031DCC
		private void SendSingle_Click(object sender, RoutedEventArgs e)
		{
			this.BO2.WriteByteArray(this.addresses.disableDvarLimits, new byte[]
			{
				176,
				1,
				144,
				144,
				144
			}, true);
			this.Send(this.SingleCommandTextbox.Text);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00033C07 File Offset: 0x00031E07
		private void SendCFG_Click(object sender, RoutedEventArgs e)
		{
			this.BO2.WriteByteArray(this.addresses.disableDvarLimits, new byte[]
			{
				176,
				1,
				144,
				144,
				144
			}, true);
			this.Send(this.CFGText.Text);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00033C42 File Offset: 0x00031E42
		private void SingleCommandTextbox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				this.SendSingle_Click(null, null);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00033C58 File Offset: 0x00031E58
		private void LoadCFG_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
			openFileDialog.Filter = "BO2 Config(*.cfg)|*.cfg|All files(*.*)|*.*";
			bool? flag = openFileDialog.ShowDialog();
			bool flag2 = true;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				this.CFGText.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00033CAC File Offset: 0x00031EAC
		private void SaveCFG_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
			saveFileDialog.Filter = "BO2 Config(*.cfg)|*.cfg|All files(*.*)|*.*";
			saveFileDialog.RestoreDirectory = true;
			Microsoft.Win32.FileDialog fileDialog = saveFileDialog;
			DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
			fileDialog.InitialDirectory = ((parent != null) ? parent.ToString() : null) + "\\CFGs";
			bool? flag = saveFileDialog.ShowDialog();
			bool flag2 = true;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				File.WriteAllText(saveFileDialog.FileName, this.CFGText.Text);
				this.SaveCFG.Content = "Saved " + Path.GetFileName(saveFileDialog.FileName) + "!";
				Task.Run(delegate()
				{
					Thread.Sleep(5000);
					this.SaveCFG.Dispatcher.Invoke(delegate()
					{
						this.SaveCFG.Content = "Save CFG";
					});
				});
			}
			saveFileDialog.RestoreDirectory = true;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00033D70 File Offset: 0x00031F70
		private void TScaleBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			string text = "";
			int num = 0;
			char[] array = new char[]
			{
				'0',
				'1',
				'2',
				'3',
				'4',
				'5',
				'6',
				'7',
				'8',
				'9',
				',',
				'.'
			};
			foreach (char c in this.tScaleBox.Text)
			{
				if (Array.IndexOf<char>(array, c) != -1)
				{
					if (c == array[10] || c == array[11])
					{
						num++;
					}
					if (num < 2)
					{
						text += c.ToString();
					}
				}
			}
			this.tScaleBox.Text = text;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00033E00 File Offset: 0x00032000
		private void SendTScale_Click(object sender, RoutedEventArgs e)
		{
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			if (this.BO2.pHandle != IntPtr.Zero)
			{
				try
				{
					this.BO2.WriteFloat(this.addresses.timescale, float.Parse(this.tScaleBox.Text));
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00033E74 File Offset: 0x00032074
		private void MemorySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (this.writeMemory && this.initialised)
			{
				try
				{
					Slider slider = (Slider)sender;
					Address address = (Address)slider.DataContext;
					TypeCode typeCode = Type.GetTypeCode(address.type);
					if (typeCode != TypeCode.Int32)
					{
						if (typeCode != TypeCode.Single)
						{
							if (typeCode == TypeCode.Double)
							{
								for (int i = 0; i < address.address.Length; i++)
								{
									this.BO2.WriteDouble(address.address[i], slider.Value);
								}
							}
						}
						else
						{
							for (int j = 0; j < address.address.Length; j++)
							{
								this.BO2.WriteFloat(address.address[j], (float)slider.Value);
							}
						}
					}
					else
					{
						for (int k = 0; k < address.address.Length; k++)
						{
							this.BO2.WriteInt(address.address[k], (int)Math.Round(slider.Value));
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000302B2 File Offset: 0x0002E4B2
		private void MemoryDial_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00033F78 File Offset: 0x00032178
		private void FogColorWheel_ColorUpdated(object sender, EventArgs e)
		{
			if (this.writeMemory && this.initialised)
			{
				ColorWheelControl colorWheelControl = (ColorWheelControl)sender;
				DoubleColor doubleColor = colorWheelControl.Palette.Colors[0].DoubleColor;
				Structures.flColor flColor = new Structures.flColor
				{
					r = (float)doubleColor.R,
					g = (float)doubleColor.G,
					b = (float)doubleColor.B
				};
				if (this.BO2.pHandle != IntPtr.Zero)
				{
					this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fogColor, flColor);
				}
				bool? isChecked = this.SyncFogColorsToggle.IsChecked;
				bool flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					DoubleColor doubleColor2 = colorWheelControl.Palette.Colors[0].DoubleColor;
					this.FogHazeColorWheel.Palette.Colors[0].DoubleColor = doubleColor2;
					this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.sunHazeColor, flColor);
				}
				isChecked = this.SyncSunFogToSunColor.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					DoubleColor doubleColor3 = this.FogHazeColorWheel.Palette.Colors[0].DoubleColor;
					flColor = new Structures.flColor
					{
						r = (float)doubleColor3.R,
						g = (float)doubleColor3.G,
						b = (float)doubleColor3.B
					};
					this.SunColorWheel.Palette.Colors[0].DoubleColor = doubleColor3;
					this.BO2.WriteStructMember<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.colour, flColor);
				}
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00034224 File Offset: 0x00032424
		private void Brightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			try
			{
				this.FogColorWheel.Palette.Colors[0].Brightness255 = (byte)this.BrightnessSlider.Value;
				this.FogColorWheel_ColorUpdated(this.FogColorWheel, null);
			}
			catch
			{
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0003427C File Offset: 0x0003247C
		private void HazeBrightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			try
			{
				this.FogHazeColorWheel.Palette.Colors[0].Brightness255 = (byte)this.HazeBrightnessSlider.Value;
				this.FogHazeColorUpdated(this.FogHazeColorWheel, null);
			}
			catch
			{
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000342D4 File Offset: 0x000324D4
		private void FogHazeColorUpdated(object sender, EventArgs e)
		{
			if (this.writeMemory && this.initialised)
			{
				DoubleColor doubleColor = ((ColorWheelControl)sender).Palette.Colors[0].DoubleColor;
				Structures.flColor flColor = new Structures.flColor
				{
					r = (float)doubleColor.R,
					g = (float)doubleColor.G,
					b = (float)doubleColor.B
				};
				bool? isChecked = this.SyncSunFogToSunColor.IsChecked;
				bool flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					DoubleColor doubleColor2 = this.FogHazeColorWheel.Palette.Colors[0].DoubleColor;
					this.SunColorWheel.Palette.Colors[0].DoubleColor = doubleColor2;
					this.BO2.WriteStructMember<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.colour, flColor);
				}
				if (this.BO2.pHandle != IntPtr.Zero)
				{
					this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.sunHazeColor, flColor);
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00034488 File Offset: 0x00032688
		private void SunBrightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			try
			{
				this.SunColorWheel.Palette.Colors[0].Brightness255 = (byte)this.SunBrightnessSlider.Value;
				this.SunColorWheel_ColorUpdated(this.SunColorWheel, null);
			}
			catch
			{
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000344E0 File Offset: 0x000326E0
		private void SunColorWheel_ColorUpdated(object sender, EventArgs e)
		{
			if (this.writeMemory && this.initialised)
			{
				DoubleColor doubleColor = ((ColorWheelControl)sender).Palette.Colors[0].DoubleColor;
				Structures.flColor flColor = new Structures.flColor
				{
					r = (float)doubleColor.R,
					g = (float)doubleColor.G,
					b = (float)doubleColor.B
				};
				if (this.BO2.pHandle != IntPtr.Zero)
				{
					this.BO2.WriteStructMember<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.colour, flColor);
				}
				bool? isChecked = this.SyncSunFogToSunColor.IsChecked;
				bool flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					byte brightness = this.FogHazeColorWheel.Palette.Colors[0].Brightness255;
					this.FogHazeColorWheel.Palette.Colors[0] = this.SunColorWheel.Palette.Colors[0];
					this.FogHazeColorWheel.Palette.Colors[0].Brightness255 = brightness;
					this.FogHazeColorUpdated(this.FogHazeColorWheel, e);
					isChecked = this.SyncFogColorsToggle.IsChecked;
					flag = true;
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						brightness = this.FogColorWheel.Palette.Colors[0].Brightness255;
						this.FogColorWheel.Palette.Colors[0] = this.SunColorWheel.Palette.Colors[0];
						this.FogColorWheel.Palette.Colors[0].Brightness255 = brightness;
						this.FogColorWheel_ColorUpdated(this.FogColorWheel, e);
					}
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000346FF File Offset: 0x000328FF
		private float DegreeToRadian(float angle)
		{
			return 3.1415927f * angle / 180f;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00034710 File Offset: 0x00032910
		private Structures.Vector3 AnglesToSunPosition(Structures.Vector3 Rotation)
		{
			float num = 0f;
			float num2 = 1f;
			return new Structures.Vector3
			{
				X = (float)((double)num + (double)num2 * Math.Cos((double)this.DegreeToRadian(Rotation.Y)) * Math.Cos((double)this.DegreeToRadian(Rotation.X))),
				Y = (float)((double)num + (double)num2 * Math.Sin((double)this.DegreeToRadian(Rotation.Y)) * Math.Cos((double)this.DegreeToRadian(Rotation.Z))),
				Z = -(float)((double)num + (double)num2 * Math.Sin((double)this.DegreeToRadian(Rotation.X)))
			};
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000347BC File Offset: 0x000329BC
		private void SunAngle_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				Structures.Vector3 vector = this.AnglesToSunPosition(new Structures.Vector3
				{
					X = (float)this.SunPitchDial.Value,
					Y = (float)this.SunYawDial.Value,
					Z = 0f
				});
				this.writeMemory = false;
				this.SunXSlider.Value = (double)vector.X;
				this.SunYSlider.Value = (double)vector.Y;
				this.SunZSlider.Value = (double)vector.Z;
				this.writeMemory = true;
				if (this.BO2.pHandle != IntPtr.Zero && this.updateSun)
				{
					this.BO2.WriteStruct(this.BO2.GetStructMemberAddress<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.X, 0), vector);
					this.BO2.WriteStruct(this.addresses.r_lightTweakSunDirection_readOnly, new Structures.Vector3
					{
						X = (float)this.SunYawDial.Value,
						Y = (float)this.SunPitchDial.Value,
						Z = 0f
					});
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00034958 File Offset: 0x00032B58
		private void SkyTransitionToggle_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.skyTransitionToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteFloat(this.addresses.r_skyTransition, 1f);
				return;
			}
			this.BO2.WriteFloat(this.addresses.r_skyTransition, 0f);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000349C0 File Offset: 0x00032BC0
		private void RemoveSunFlareToggle_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.removeSunFlareToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.flareDisableEffects, 1);
				this.BO2.WriteByte(this.addresses.r_superFlareDraw, 0);
				return;
			}
			this.BO2.WriteByte(this.addresses.flareDisableEffects, 0);
			this.BO2.WriteByte(this.addresses.r_superFlareDraw, 1);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00034A4C File Offset: 0x00032C4C
		private void DOFEnable_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.DOFEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.r_dof_tweak, 1);
				this.BO2.WriteByte(this.addresses.r_dof_enable, 1);
				return;
			}
			this.BO2.WriteByte(this.addresses.r_dof_tweak, 0);
			this.BO2.WriteByte(this.addresses.r_dof_enable, 0);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00034AD8 File Offset: 0x00032CD8
		private void PatchSSAODistance()
		{
			byte[] array = new byte[]
			{
				243,
				15,
				16,
				5,
				0,
				0,
				0,
				0
			};
			if (this.SSAODistanceAllocatedMemory == IntPtr.Zero)
			{
				this.SSAODistanceAllocatedMemory = this.BO2.AllocateMemory(4U);
				this.BO2.WriteFloat(this.SSAODistanceAllocatedMemory, 4f);
			}
			Buffer.BlockCopy(BitConverter.GetBytes((int)this.SSAODistanceAllocatedMemory), 0, array, 4, 4);
			this.BO2.WriteByteArray(this.addresses.ssaoDistancePatch, array);
			this.ssaoDistanceSlider.DataContext = new Address
			{
				address = new IntPtr[]
				{
					this.SSAODistanceAllocatedMemory
				},
				type = typeof(float)
			};
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00034B98 File Offset: 0x00032D98
		private void SsaoToggle_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.ssaoToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteInt(this.addresses.r_ssao, 1);
				this.PatchSSAODistance();
				return;
			}
			this.BO2.WriteInt(this.addresses.r_ssao, 0);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00034BFC File Offset: 0x00032DFC
		private void gsEnable_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.gsEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.EnableGreenscreen();
				this.removeGun.IsChecked = new bool?(false);
				return;
			}
			this.DisableGreenscreen();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00034C4C File Offset: 0x00032E4C
		private void EnableGreenscreen()
		{
			this.BO2.WriteInt(this.addresses.r_modellimit, 0);
			this.BO2.WriteByte(this.addresses.r_skipPvs, 1);
			this.BO2.WriteByteArray(this.addresses.r_clearColor, this.GreenScreenColor);
			this.BO2.WriteByteArray(this.addresses.r_clearColor2, this.GreenScreenColor);
			this.BO2.WriteByte(this.addresses.r_bloomTweaks, 1);
			this.BO2.WriteFloat(this.addresses.r_znear, 10000f);
			this.BO2.WriteFloat(this.addresses.r_zfar, 1E-06f);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00034D0C File Offset: 0x00032F0C
		private void DisableGreenscreen()
		{
			this.BO2.WriteInt(this.addresses.r_modellimit, 1024);
			this.BO2.WriteByte(this.addresses.r_skipPvs, 0);
			bool? isChecked = this.gpEnable.IsChecked;
			bool flag = false;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.r_bloomTweaks, 0);
			}
			this.BO2.WriteFloat(this.addresses.r_znear, 4f);
			this.BO2.WriteFloat(this.addresses.r_zfar, 0f);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00034DBC File Offset: 0x00032FBC
		private void gsColor_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.gsR.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				byte[] array = new byte[4];
				array[0] = byte.MaxValue;
				this.GreenScreenColor = array;
			}
			else
			{
				isChecked = this.gsG.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					byte[] array2 = new byte[4];
					array2[1] = byte.MaxValue;
					this.GreenScreenColor = array2;
				}
				else
				{
					isChecked = this.gsB.IsChecked;
					flag = true;
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						byte[] array3 = new byte[4];
						array3[2] = byte.MaxValue;
						this.GreenScreenColor = array3;
					}
					else
					{
						isChecked = this.gsP.IsChecked;
						flag = true;
						if (isChecked.GetValueOrDefault() == flag & isChecked != null)
						{
							byte[] array4 = new byte[4];
							array4[0] = byte.MaxValue;
							array4[2] = byte.MaxValue;
							this.GreenScreenColor = array4;
						}
					}
				}
			}
			isChecked = this.gsEnable.IsChecked;
			flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByteArray(this.addresses.r_clearColor, this.GreenScreenColor);
				this.BO2.WriteByteArray(this.addresses.r_clearColor2, this.GreenScreenColor);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00034F0C File Offset: 0x0003310C
		private void createPlayerMaterialPatch()
		{
			this.playerMaterialPatch = this.BO2.AllocateMemory(1024U);
			int num = (int)IntPtr.Add(this.addresses.PlayersMaterialPatchJump, 7);
			int num2 = (int)IntPtr.Add(this.playerMaterialPatch, 512);
			byte[] bytes = new AssemblyCompiler(0, this.playerMaterialPatch).Compile(new object[]
			{
				Opcodes.push(Registers.ebx),
				Opcodes.mov(Registers.ebx, 4),
				Opcodes.imul(Registers.eax, Registers.ebx),
				Opcodes.add(Registers.eax, this.addresses.MaterialsCollection.ToInt32()),
				Opcodes.mov(Registers.eax, ~Registers.eax),
				Opcodes.push(Registers.eax),
				Opcodes.add(Registers.eax, 92),
				Opcodes.mov(Registers.eax, ~Registers.eax),
				Opcodes.cmp(Registers.eax, 24840700),
				Opcodes.je("patch"),
				Opcodes.cmp(Registers.eax, 24866844),
				Opcodes.je("patch"),
				Opcodes.pop(Registers.eax),
				Opcodes.jmp("return"),
				"patch:",
				Opcodes.pop(Registers.eax),
				Opcodes.mov(Registers.eax, num2),
				Opcodes.mov(Registers.eax, ~Registers.eax),
				Opcodes.cmp(Registers.eax, 0),
				Opcodes.jne("return"),
				Opcodes.mov(Registers.ebx, this.addresses.clientObjMap.ToInt32()),
				Opcodes.xor(Registers.eax, Registers.eax),
				Opcodes.mov(Registers.ax, ~Registers.ebx),
				Opcodes.mov(Registers.bx, 124),
				Opcodes.imul(Registers.ax, Registers.bx),
				Opcodes.mov(Registers.ebx, this.addresses.objBuf.ToInt32()),
				Opcodes.add(Registers.ebx, Registers.eax),
				Opcodes.add(Registers.ebx, 120),
				Opcodes.mov(Registers.ebx, ~Registers.ebx),
				Opcodes.mov(Registers.ebx, ~Registers.ebx),
				Opcodes.add(Registers.ebx, 36),
				Opcodes.mov(Registers.ebx, ~Registers.ebx),
				Opcodes.mov(Registers.ebx, ~Registers.ebx + 4),
				Opcodes.mov(Registers.eax, Registers.ebx),
				Opcodes.mov(Registers.ebx, num2),
				Opcodes.mov(~Registers.ebx, Registers.eax),
				"return:",
				Opcodes.pop(Registers.ebx),
				Opcodes.jmp(num)
			});
			this.BO2.WriteByteArray(this.playerMaterialPatch, bytes);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00035254 File Offset: 0x00033454
		private void applyPlayerMaterialPatch()
		{
			try
			{
				this.heroWeaponLighting = this.addresses.dvarFinder.returnedDvars["r_heroWeaponLighting"].address - 24;
			}
			catch
			{
			}
			if (this.heroWeaponLighting == IntPtr.Zero)
			{
				try
				{
					this.heroWeaponLighting = this.addresses.dvarFinder.FindSingleDvar("r_heroWeaponLighting");
				}
				catch
				{
				}
			}
			if (this.heroWeaponLighting != IntPtr.Zero)
			{
				this.BO2.WriteBoolean(IntPtr.Add(this.heroWeaponLighting, 24), true);
				return;
			}
			if (this.playerMaterialPatch == IntPtr.Zero)
			{
				this.createPlayerMaterialPatch();
			}
			byte[] bytes = new AssemblyCompiler(0, this.addresses.PlayersMaterialPatchJump).Compile(new object[]
			{
				Opcodes.jmp(this.playerMaterialPatch.ToInt32()),
				Opcodes.nop(),
				Opcodes.nop()
			});
			this.BO2.WriteByteArray(this.addresses.PlayersMaterialPatchJump, bytes);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0003537C File Offset: 0x0003357C
		private void disablePlayerMaterialPatch()
		{
			this.heroWeaponLighting = IntPtr.Zero;
			try
			{
				this.heroWeaponLighting = this.addresses.dvarFinder.returnedDvars["r_heroWeaponLighting"].address - 24;
			}
			catch
			{
			}
			if (this.heroWeaponLighting == IntPtr.Zero)
			{
				try
				{
					this.heroWeaponLighting = this.addresses.dvarFinder.FindSingleDvar("r_heroWeaponLighting");
				}
				catch
				{
				}
			}
			if (this.heroWeaponLighting != IntPtr.Zero)
			{
				this.BO2.WriteBoolean(IntPtr.Add(this.heroWeaponLighting, 24), false);
				return;
			}
			byte[] array = new byte[]
			{
				139,
				4,
				133
			};
			array = this.BO2.CombineBytes(new byte[][]
			{
				array,
				BitConverter.GetBytes((int)this.addresses.MaterialsCollection)
			});
			this.BO2.WriteByteArray(this.addresses.MaterialsPatch, array, true);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00035498 File Offset: 0x00033698
		private void gpEnable_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.gpEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				isChecked = this.IncludeWeaponsInPlayerPass.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					this.applyPlayerMaterialPatch();
				}
				this.ssaoWasOn = Convert.ToBoolean(this.ssaoToggle.IsChecked);
				this.greenPlayersGrid.IsEnabled = true;
				this.BO2.WriteStruct(this.addresses.r_heroLightScaleR, new Structures.Vector3
				{
					X = (float)this.playersRbar.Value,
					Y = (float)this.playersGbar.Value,
					Z = (float)this.playersBbar.Value
				});
				this.BO2.WriteByte(this.addresses.r_bloomTweaks, 1);
				this.ssaoToggle.IsChecked = new bool?(false);
				this.BO2.WriteInt(this.addresses.r_ssao, 0);
				return;
			}
			this.disablePlayerMaterialPatch();
			this.greenPlayersGrid.IsEnabled = false;
			this.BO2.WriteStruct(this.addresses.r_heroLightScaleR, new Structures.Vector3
			{
				X = 1f,
				Y = 1f,
				Z = 1f
			});
			isChecked = this.gsEnable.IsChecked;
			flag = false;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.r_bloomTweaks, Convert.ToBoolean(this.bloomTweaksToggle.IsChecked) ? 1 : 0);
			}
			this.ssaoToggle.IsChecked = new bool?(this.ssaoWasOn);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00035688 File Offset: 0x00033888
		private void PlayersAlphaCheckbox_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.PlayersAlphaCheckbox.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				isChecked = this.IncludeWeaponsInPlayerPass.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					this.applyPlayerMaterialPatch();
				}
				this.gpEnable.IsEnabled = false;
				this.greenPlayersGrid.IsEnabled = false;
				this.BO2.WriteInt(this.addresses.r_exposureTweak, 1);
				this.BO2.WriteInt(this.addresses.r_bloomTweaks, 1);
				this.BO2.WriteFloat(this.addresses.r_exposureValue, 30f);
				this.BO2.WriteStruct(this.addresses.r_heroLightScaleR, new Structures.Vector3
				{
					X = 1E+13f,
					Y = 1E+13f,
					Z = 1E+13f
				});
				return;
			}
			this.disablePlayerMaterialPatch();
			this.gpEnable.IsEnabled = true;
			UIElement uielement = this.greenPlayersGrid;
			isChecked = this.gpEnable.IsChecked;
			flag = true;
			uielement.IsEnabled = (isChecked.GetValueOrDefault() == flag & isChecked != null);
			this.BO2.WriteInt(this.addresses.r_exposureTweak, 0);
			isChecked = this.gpEnable.IsChecked;
			flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteStruct(this.addresses.r_heroLightScaleR, new Structures.Vector3
				{
					X = (float)this.playersRbar.Value,
					Y = (float)this.playersGbar.Value,
					Z = (float)this.playersBbar.Value
				});
				return;
			}
			this.BO2.WriteStruct(this.addresses.r_heroLightScaleR, new Structures.Vector3
			{
				X = 1f,
				Y = 1f,
				Z = 1f
			});
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000358A8 File Offset: 0x00033AA8
		private void toggleDpthByDof()
		{
			bool? isChecked = this.depthEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.EnableDepthDof();
				return;
			}
			this.DisableDepthDof();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000358E4 File Offset: 0x00033AE4
		private void EnableDepthDof()
		{
			this.BO2.WriteByte(this.addresses.r_dof_enable, 1);
			this.BO2.WriteByte(this.addresses.r_dof_tweak, 1);
			this.BO2.WriteFloat(this.addresses.r_dof_farStart, -100f);
			this.BO2.WriteFloat(this.addresses.r_dof_farEnd, (float)this.DepthDistanceSlider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_nearStart, 1f);
			this.BO2.WriteFloat(this.addresses.r_dof_nearEnd, 1f);
			this.BO2.WriteFloat(this.addresses.r_dof_farBlur, 1f);
			this.BO2.WriteFloat(this.addresses.r_dof_nearBlur, 1f);
			this.BO2.WriteFloat(this.addresses.r_dof_viewModelStart, 0f);
			this.BO2.WriteFloat(this.addresses.r_dof_viewModelEnd, 0f);
			this.BO2.WriteFloat(this.addresses.r_dof_bias, 0f);
			this.BO2.WriteInt(this.addresses.r_dofHDR, 0);
			this.BO2.WriteByte(this.addresses.r_exposureTweak, 1);
			this.BO2.WriteFloat(this.addresses.r_exposureValue, -16f);
			this.BO2.WriteByte(this.addresses.cg_useColorControl, 1);
			this.BO2.WriteFloat(this.addresses.cg_colorSaturation, 0f);
			this.BO2.WriteInt(this.addresses.r_modellimit, 1024);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00035AB0 File Offset: 0x00033CB0
		private void DisableDepthDof()
		{
			bool? isChecked = this.DOFEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.r_dof_tweak, 1);
				this.BO2.WriteByte(this.addresses.r_dof_enable, 1);
			}
			else
			{
				this.BO2.WriteByte(this.addresses.r_dof_tweak, 0);
				this.BO2.WriteByte(this.addresses.r_dof_enable, 0);
			}
			this.BO2.WriteFloat(this.addresses.r_dof_farStart, (float)this.DOFFarStartSlider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_farEnd, (float)this.DOFFarEndSlider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_nearStart, (float)this.DOFNearStartSlider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_nearEnd, (float)this.DOFNearEndSlider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_farBlur, (float)this.DOFFarBlurSider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_nearBlur, (float)this.DOFNearBlurSlider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_viewModelStart, (float)this.DOFViewmodelStartSlider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_viewModelEnd, (float)this.DOFViewmodelEndSlider.Value);
			this.BO2.WriteFloat(this.addresses.r_dof_bias, (float)this.DOFBiasSlider.Value);
			this.BO2.WriteInt(this.addresses.r_dofHDR, (int)this.DOFQualitySlider.Value);
			this.BO2.WriteByte(this.addresses.r_exposureTweak, 0);
			this.BO2.WriteByte(this.addresses.cg_useColorControl, 0);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00035CC0 File Offset: 0x00033EC0
		private void toggleDepthByFog()
		{
			bool? isChecked = this.depthEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.EnableDepthFog();
				return;
			}
			this.DisableDepthFog();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00035CFC File Offset: 0x00033EFC
		public void EnableDepthFog()
		{
			this.BO2.WriteByte(this.addresses.r_dof_tweak, 0);
			this.BO2.WriteByte(this.addresses.r_dof_enable, 0);
			this.BO2.WriteByte(this.addresses.r_exposureTweak, 1);
			this.BO2.WriteFloat(this.addresses.r_exposureValue, 16f);
			this.BO2.WriteFloat(this.addresses.r_sky_intensity_factor0, 0f);
			this.BO2.WriteByteArray(this.addresses.r_clearColor, new byte[]
			{
				1,
				1,
				1,
				0
			});
			this.BO2.WriteByteArray(this.addresses.r_clearColor2, new byte[]
			{
				1,
				1,
				1,
				0
			});
			this.BO2.WriteByte(this.addresses.r_bloomTweaks, 1);
			this.BO2.WriteInt(this.addresses.r_modellimit, 1024);
			this.BO2.WriteByte(this.addresses.cg_useColorControl, 1);
			this.BO2.WriteFloat(this.addresses.cg_colorSaturation, 0f);
			Structures.flColor flColor = new Structures.flColor
			{
				r = 1000f,
				g = 1000f,
				b = 1000f
			};
			this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.startDist, 0f);
			this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fadeDist, (float)this.DepthDistanceSlider.Value);
			this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fadeHeight, 20000f);
			this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fogColor, flColor);
			this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fogOpacity, 100f);
			this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.sunHazeColor, flColor);
			this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.sunHazeOpacity, 100f);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00036118 File Offset: 0x00034318
		public void DisableDepthFog()
		{
			bool? isChecked = this.DOFEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.r_dof_tweak, 1);
				this.BO2.WriteByte(this.addresses.r_dof_enable, 1);
			}
			else
			{
				this.BO2.WriteByte(this.addresses.r_dof_tweak, 0);
				this.BO2.WriteByte(this.addresses.r_dof_enable, 0);
			}
			this.BO2.WriteByte(this.addresses.r_exposureTweak, 0);
			this.BO2.WriteFloat(this.addresses.r_exposureValue, 12.5f);
			this.BO2.WriteFloat(this.addresses.r_sky_intensity_factor0, 1f);
			this.BO2.WriteByteArray(this.addresses.r_clearColor, new byte[]
			{
				1,
				1,
				1,
				0
			});
			this.BO2.WriteByteArray(this.addresses.r_clearColor2, new byte[]
			{
				1,
				1,
				1,
				0
			});
			this.BO2.WriteByte(this.addresses.r_bloomTweaks, Convert.ToBoolean(this.bloomTweaksToggle.IsChecked) ? 1 : 0);
			this.BO2.WriteInt(this.addresses.r_modellimit, 1024);
			this.BO2.WriteByte(this.addresses.cg_useColorControl, 0);
			this.BO2.WriteFloat(this.addresses.cg_colorSaturation, 1f);
			Structures.flColor flColor = default(Structures.flColor);
			flColor.r = 5f;
			flColor.g = 5f;
			flColor.b = 5f;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000362EC File Offset: 0x000344EC
		private void depthEnable_Checked(object sender, RoutedEventArgs e)
		{
			this.gsEnable.IsEnabled = !Convert.ToBoolean(this.depthEnable.IsChecked);
			this.gpEnable.IsEnabled = !Convert.ToBoolean(this.depthEnable.IsChecked);
			bool? isChecked = this.depthEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				isChecked = this.removeGun.IsChecked;
				flag = true;
				this.removeGunWasEnabled = (isChecked.GetValueOrDefault() == flag & isChecked != null);
				isChecked = this.removeSunFlareToggle.IsChecked;
				flag = true;
				this.removeFlareWasEnabled = (isChecked.GetValueOrDefault() == flag & isChecked != null);
				this.removeSunFlareToggle.IsChecked = new bool?(false);
				this.removeGun.IsChecked = new bool?(true);
				this.gsEnable.IsChecked = new bool?(false);
				isChecked = this.depthByBuffer.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					this.EnableDepthDof();
					return;
				}
				this.preDepthfog = this.BO2.ReadStruct<Structures.Fog>(this.addresses.Fog);
				this.EnableDepthFog();
				return;
			}
			else
			{
				this.removeSunFlareToggle.IsChecked = new bool?(this.removeFlareWasEnabled);
				this.removeGun.IsChecked = new bool?(this.removeGunWasEnabled);
				isChecked = this.depthByBuffer.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					this.DisableDepthDof();
					return;
				}
				this.DisableDepthFog();
				this.BO2.WriteStruct(this.addresses.Fog, this.preDepthfog);
				return;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000364B4 File Offset: 0x000346B4
		private void DepthByBuffer_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.depthEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				isChecked = this.depthByBuffer.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					this.DisableDepthFog();
					try
					{
						this.BO2.WriteStruct(this.addresses.Fog, this.preDepthfog);
					}
					catch
					{
					}
					this.EnableDepthDof();
					return;
				}
				this.DisableDepthDof();
				this.EnableDepthFog();
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00036554 File Offset: 0x00034754
		private void depthColorWheel_ColorUpdated(object sender, EventArgs e)
		{
			if (this.writeMemory && this.initialised)
			{
				DoubleColor doubleColor = ((ColorWheelControl)sender).Palette.Colors[0].DoubleColor;
				Structures.flColor flColor = new Structures.flColor
				{
					r = (float)doubleColor.R / 255f,
					g = (float)doubleColor.G / 255f,
					b = (float)doubleColor.B / 255f
				};
				if (this.BO2.pHandle != IntPtr.Zero)
				{
					this.BO2.WriteFloat(this.addresses.cg_colorScaleR, flColor.r);
					this.BO2.WriteFloat(this.addresses.cg_colorScaleG, flColor.g);
					this.BO2.WriteFloat(this.addresses.cg_colorScaleB, flColor.b);
				}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00036648 File Offset: 0x00034848
		private void depthBrightnessBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			try
			{
				this.depthColorWheel.Palette.Colors[0].Brightness255 = (byte)this.depthBrightnessBar.Value;
				this.depthColorWheel_ColorUpdated(this.depthColorWheel, null);
			}
			catch
			{
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000366A0 File Offset: 0x000348A0
		private void tBarrierRemove_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.tBarrierRemove.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.disableTheatreBarrier, 0);
				return;
			}
			this.BO2.WriteByte(this.addresses.disableTheatreBarrier, 1);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00036700 File Offset: 0x00034900
		private void greenSkyToggle_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.greenSkyToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.RemoveSkybox();
				AiryzMemory bo = this.BO2;
				IntPtr r_clearColor = this.addresses.r_clearColor;
				byte[] array = new byte[4];
				array[1] = byte.MaxValue;
				bo.WriteByteArray(r_clearColor, array);
				AiryzMemory bo2 = this.BO2;
				IntPtr r_clearColor2 = this.addresses.r_clearColor2;
				byte[] array2 = new byte[4];
				array2[1] = byte.MaxValue;
				bo2.WriteByteArray(r_clearColor2, array2);
				this.BO2.WriteByte(this.addresses.r_bloomTweaks, 1);
				return;
			}
			this.RestoreSkybox();
			this.BO2.WriteByteArray(this.addresses.r_clearColor, new byte[4]);
			this.BO2.WriteByteArray(this.addresses.r_clearColor2, new byte[4]);
			this.BO2.WriteByte(this.addresses.r_bloomTweaks, 0);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000367EC File Offset: 0x000349EC
		private void bloomTweaksToggle_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.bloomTweaksToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.r_bloomTweaks, 1);
				return;
			}
			this.BO2.WriteByte(this.addresses.r_bloomTweaks, 0);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0003684C File Offset: 0x00034A4C
		private void removePlayers_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.removePlayers.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteInt(this.addresses.r_dobjLimit, 0);
				return;
			}
			this.BO2.WriteInt(this.addresses.r_dobjLimit, 1024);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000368B0 File Offset: 0x00034AB0
		private void removeGun_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.removeGun.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteByte(this.addresses.cg_drawGun, 0);
				return;
			}
			this.BO2.WriteByte(this.addresses.cg_drawGun, 1);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00036910 File Offset: 0x00034B10
		private void removeSkull_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.removeSkull.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.unNop = this.BO2.ReadByteArray(this.addresses.disableSkullProtection, 7);
				this.BO2.NOP(this.addresses.disableSkullProtection, 7);
				this.oldSkullValue = this.BO2.ReadByte(this.addresses.disableSkull);
				this.BO2.WriteByte(this.addresses.disableSkull, 0);
				return;
			}
			this.BO2.WriteByteArray(this.addresses.disableSkullProtection, this.unNop);
			this.BO2.WriteByte(this.addresses.disableSkull, this.oldSkullValue);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000369E0 File Offset: 0x00034BE0
		private void DepthDistanceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			bool? isChecked = this.depthEnable.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				isChecked = this.depthByBuffer.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					this.BO2.WriteFloat(this.addresses.r_dof_farEnd, (float)this.DepthDistanceSlider.Value);
					return;
				}
				this.BO2.WriteStructMember<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.fadeDist, (float)this.DepthDistanceSlider.Value);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00036AC4 File Offset: 0x00034CC4
		private System.Drawing.Color colorTemperatureToRGB(double kelvin)
		{
			double num = kelvin / 100.0;
			double x;
			double num2;
			double num3;
			if (num <= 66.0)
			{
				x = 255.0;
				num2 = num;
				num2 = 99.4708025861 * Math.Log(num2) - 161.1195681661;
				if (num <= 19.0)
				{
					num3 = 0.0;
				}
				else
				{
					num3 = num - 10.0;
					num3 = 138.5177312231 * Math.Log(num3) - 305.0447927307;
				}
			}
			else
			{
				x = num - 60.0;
				x = 329.698727446 * Math.Pow(x, -0.1332047592);
				num2 = num - 60.0;
				num2 = 288.1221695283 * Math.Pow(num2, -0.0755148492);
				num3 = 255.0;
			}
			return System.Drawing.Color.FromArgb((int)this.clamp(x, 0.0, 255.0), (int)this.clamp(num2, 0.0, 255.0), (int)this.clamp(num3, 0.0, 255.0));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00036BFA File Offset: 0x00034DFA
		private double clamp(double x, double min, double max)
		{
			if (x < min)
			{
				return min;
			}
			if (x > max)
			{
				return max;
			}
			return x;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00036C0C File Offset: 0x00034E0C
		private void skyTempBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			try
			{
				this.BO2.WriteFloat(this.addresses.r_skyColorTemp, (float)this.skyTempBar.Value);
				bool? isChecked = this.SyncSkyTemp.IsChecked;
				bool flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					System.Drawing.Color color = this.colorTemperatureToRGB(this.skyTempBar.Value + 1000.0);
					this.SunColorWheel.Palette.Colors[0].R = (double)((float)color.R * ((float)this.SunColorWheel.Palette.Colors[0].Brightness255 / 255f));
					this.SunColorWheel.Palette.Colors[0].G = (double)((float)color.G * ((float)this.SunColorWheel.Palette.Colors[0].Brightness255 / 255f));
					this.SunColorWheel.Palette.Colors[0].B = (double)((float)color.B * ((float)this.SunColorWheel.Palette.Colors[0].Brightness255 / 255f));
					this.SunColorWheel.Palette.Colors[0].Brightness255 = (byte)Math.Round(this.skyBrightnessBar.Value * 8.0);
					this.SunColorWheel_ColorUpdated(this.SunColorWheel, null);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00036DB8 File Offset: 0x00034FB8
		private void skyBrightnessBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			try
			{
				this.BO2.WriteFloat(this.addresses.r_sky_intensity_factor0, (float)this.skyBrightnessBar.Value);
				bool? isChecked = this.SyncSkyTemp.IsChecked;
				bool flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					System.Drawing.Color color = this.colorTemperatureToRGB(this.skyTempBar.Value + 1000.0);
					this.SunColorWheel.Palette.Colors[0].R = (double)((float)color.R * ((float)this.SunColorWheel.Palette.Colors[0].Brightness255 / 255f));
					this.SunColorWheel.Palette.Colors[0].G = (double)((float)color.G * ((float)this.SunColorWheel.Palette.Colors[0].Brightness255 / 255f));
					this.SunColorWheel.Palette.Colors[0].B = (double)((float)color.B * ((float)this.SunColorWheel.Palette.Colors[0].Brightness255 / 255f));
					this.SunColorWheel.Palette.Colors[0].Brightness255 = (byte)Math.Round(this.skyBrightnessBar.Value * 8.0);
					this.SunBrightnessSlider.Value = (double)this.SunColorWheel.Palette.Colors[0].Brightness255;
					this.SunColorWheel_ColorUpdated(this.SunColorWheel, null);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00036F88 File Offset: 0x00035188
		private void CheckLogin()
		{
			try
			{
				this.cache = Cache.LoadCacheFromFile();
				try
				{
					base.Resources["DefaultColor"] = this.cache.color;
					this.ThemeHexCode.Text = ColorTranslator.ToHtml(System.Drawing.Color.FromArgb((int)this.cache.color.Color.R, (int)this.cache.color.Color.G, (int)this.cache.color.Color.B));
				}
				catch
				{
				}
				try
				{
					base.Resources["DefaultBackground"] = this.cache.backgroundColor;
					base.Resources["DefaultBackground"] = this.cache.backgroundColor;
					base.Resources["DefaultBackgroundOpaque"] = this.cache.backgroundColor;
					this.SettingsPanel.Background = this.cache.backgroundColor;
					this.MainGrid.Background = this.cache.backgroundColor;
					this.ThemeHexCode_Background.Text = ColorTranslator.ToHtml(System.Drawing.Color.FromArgb((int)this.cache.backgroundColor.Color.R, (int)this.cache.backgroundColor.Color.G, (int)this.cache.backgroundColor.Color.B));
				}
				catch
				{
				}
				try
				{
					base.Resources["DefaultFontWeight"] = this.cache.fontWeight;
					this.FontWeightSelector.Text = this.cache.fontWeight.ToString();
				}
				catch
				{
				}
				try
				{
					if (this.cache.windowScale >= 1f)
					{
						this.WindowScale = this.cache.windowScale;
						this.ApplicationScaleTransform.ScaleX = (double)this.WindowScale;
						this.ApplicationScaleTransform.ScaleY = (double)this.WindowScale;
						this.WindowScaleSelector.Text = this.cache.windowScale.ToString();
						this.resizeWindow(this.MainTabs);
					}
				}
				catch
				{
				}
				try
				{
					this.CFGText.FontSize = this.cache.fontSize;
					this.FontSizeSelector.Text = this.cache.fontSize.ToString();
				}
				catch
				{
				}
				try
				{
					if (this.cache.streamable_username_encrypted != null && this.cache.streamable_username_encrypted.Length > 0)
					{
						this.StreamableIntegrationButton.Content = "Disconnect Streamable";
					}
				}
				catch
				{
				}
				try
				{
					string text;
					if (this.cache.autocompleteLimit == -1)
					{
						text = "All";
					}
					else
					{
						text = this.cache.autocompleteLimit.ToString();
					}
					this.AutofillLimitSelector.Text = text;
				}
				catch
				{
				}
				try
				{
					this.LoginPanel.Visibility = Visibility.Hidden;
					foreach (object obj in ((IEnumerable)this.MainTabs.Items))
					{
						(obj as TabItem).IsEnabled = true;
					}
				}
				catch
				{
				}
				try
				{
					this.LoadCFGButton.IsEnabled = true;
					this.SaveCFGButton.IsEnabled = true;
					this.isLoggedIn = true;
				}
				catch
				{
				}
				try
				{
					this.SingleCommandTextbox.FilterMode = this.cache.filter;
					this.AutofillModeSelector.Text = this.cache.filter.ToString();
				}
				catch
				{
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00037440 File Offset: 0x00035640
		public bool LoginCallback(int current, int max)
		{
			this.LoginProgress.Dispatcher.Invoke(delegate()
			{
				this.LoginProgress.Value = (double)current;
				this.LoginProgress.Maximum = (double)max;
			});
			return true;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00037488 File Offset: 0x00035688
		private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			string submittedID = this.LoginTextbox.Text;
			this.LoginButton.Content = "Logging In...";
			this.LoginButton.IsEnabled = false;
			Action <>9__1;
			Task.Run(delegate()
			{
				LoginResult result = Login.Verify(submittedID, new Func<int, int, bool>(this.LoginCallback));
				if (result.Success)
				{
					Dispatcher dispatcher = this.LoginPanel.Dispatcher;
					Action callback;
					if ((callback = <>9__1) == null)
					{
						callback = (<>9__1 = delegate()
						{
							string name = "";
							if (this.LoginTextbox.Text.Contains("_"))
							{
								name = this.LoginTextbox.Text.Split(new char[]
								{
									'_'
								})[0];
							}
							else
							{
								name = this.LoginTextbox.Text;
							}
							this.LoginPanel.Visibility = Visibility.Hidden;
							foreach (object obj in ((IEnumerable)this.MainTabs.Items))
							{
								(obj as TabItem).IsEnabled = true;
							}
							this.LoadCFGButton.IsEnabled = true;
							this.SaveCFGButton.IsEnabled = true;
							this.cache.ID = GetID.LastID();
							this.cache.Name = name;
							this.Init();
							this.cache.Save();
						});
					}
					dispatcher.Invoke(callback);
					return;
				}
				this.LoginButton.Dispatcher.Invoke(delegate()
				{
					this.LoginButton.IsEnabled = true;
					this.LoginButton.Content = "Login Failed: " + result.Reason;
				});
			});
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000374E0 File Offset: 0x000356E0
		private void NameTextbox_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.NameTextbox.Text.Length == 0)
			{
				this.IDTextBox.Text = "";
			}
			if (!this.NameTextbox.Text.Contains('_'))
			{
				this.IDTextBox.Text = this.NameTextbox.Text + "_" + this.UUID;
				return;
			}
			this.IDTextBox.Text = "Name cannot include: '_'";
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0003755A File Offset: 0x0003575A
		private void GetIDButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			this.GetIDGrid.Visibility = Visibility.Visible;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00037568 File Offset: 0x00035768
		private void SaveCache()
		{
			this.cache.fontWeight = (FontWeight)base.Resources["DefaultFontWeight"];
			this.cache.color = (SolidColorBrush)base.Resources["DefaultColor"];
			this.cache.windowScale = this.WindowScale;
			this.cache.fontSize = this.CFGText.FontSize;
			this.cache.Save();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000375E8 File Offset: 0x000357E8
		private void ReloadPointers_Click(object sender, RoutedEventArgs e)
		{
			this.ReloadPointers.Content = "Reloading...";
			bool? isChecked = this.PersistOnReload.IsChecked;
			bool flag = true;
			this.persist_settings = (isChecked.GetValueOrDefault() == flag & isChecked != null);
			this.RefreshGame();
			Task.Run(delegate()
			{
				Thread.Sleep(500);
				this.ReloadPointers.Dispatcher.Invoke(delegate()
				{
					this.ReloadPointers.Content = "Done!";
				});
				Thread.Sleep(5000);
				this.ReloadPointers.Dispatcher.Invoke(delegate()
				{
					this.ReloadPointers.Content = "RELOAD";
				});
			});
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00037644 File Offset: 0x00035844
		private void RestoreAll_Click(object sender, RoutedEventArgs e)
		{
			this.gsEnable.IsChecked = new bool?(false);
			this.depthEnable.IsChecked = new bool?(false);
			this.removeGun.IsChecked = new bool?(false);
			this.NormalPassDefaultRadioButton.IsChecked = new bool?(true);
			this.removeGun.IsChecked = new bool?(false);
			this.removePlayers.IsChecked = new bool?(false);
			this.greenSkyToggle.IsChecked = new bool?(false);
			this.WireframeToggle.IsChecked = new bool?(false);
			this.removeSkull.IsChecked = new bool?(false);
			this.bloomTweaksToggle.IsChecked = new bool?(false);
			this.tBarrierRemove.IsChecked = new bool?(false);
			this.ParticlesToggle.IsChecked = new bool?(false);
			this.PlayersAlphaCheckbox.IsChecked = new bool?(false);
			this.gpEnable.IsChecked = new bool?(false);
			this.console.Send(BuiltInCFGs.Default);
			this.DepthDistanceSlider.Value = 2000.0;
			this.ssaoToggle.IsChecked = new bool?(false);
			this.MaterialsPatchSelector.SelectedIndex = 0;
			this.ResetFog();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00037786 File Offset: 0x00035986
		private void SettingsButton_Click(object sender, RoutedEventArgs e)
		{
			base.SizeToContent = SizeToContent.WidthAndHeight;
			this.SettingsPanel.Visibility = Visibility.Visible;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0003779B File Offset: 0x0003599B
		private void BackButton_Click(object sender, RoutedEventArgs e)
		{
			this.SettingsPanel.Visibility = Visibility.Hidden;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000377AC File Offset: 0x000359AC
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			SolidColorBrush solidColorBrush = (SolidColorBrush)((System.Windows.Controls.Button)sender).Background;
			string text = ColorTranslator.ToHtml(System.Drawing.Color.FromArgb((int)solidColorBrush.Color.R, (int)solidColorBrush.Color.G, (int)solidColorBrush.Color.B));
			this.ThemeHexCode.Text = text;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0003780C File Offset: 0x00035A0C
		private void ThemeHexCode_TextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				if (this.ThemeHexCode.Text.Length == 7 && this.ThemeHexCode.Text[0] == '#')
				{
					System.Drawing.Color color = ColorTranslator.FromHtml(this.ThemeHexCode.Text);
					SolidColorBrush solidColorBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
					base.Resources["DefaultColor"] = solidColorBrush;
					this.cache.color = solidColorBrush;
					this.SaveCache();
				}
				else if (this.ThemeHexCode.Text[0] != '#')
				{
					this.ThemeHexCode.Text = "#" + this.ThemeHexCode.Text;
					if (this.ThemeHexCode.CaretIndex == 0)
					{
						this.ThemeHexCode.CaretIndex += 2;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00037908 File Offset: 0x00035B08
		private void BackgroundHexCode_TextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				if (this.ThemeHexCode_Background.Text.Length == 7 && this.ThemeHexCode_Background.Text[0] == '#')
				{
					System.Drawing.Color color = ColorTranslator.FromHtml(this.ThemeHexCode_Background.Text);
					SolidColorBrush solidColorBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
					this.cache.backgroundColor = solidColorBrush;
					base.Resources["DefaultBackground"] = solidColorBrush;
					base.Resources["DefaultBackgroundOpaque"] = solidColorBrush;
					this.SettingsPanel.Background = solidColorBrush;
					this.MainGrid.Background = solidColorBrush;
					this.cache.Save();
				}
				else if (this.ThemeHexCode_Background.Text[0] != '#')
				{
					this.ThemeHexCode_Background.Text = "#" + this.ThemeHexCode_Background.Text;
					if (this.ThemeHexCode_Background.CaretIndex == 0)
					{
						this.ThemeHexCode_Background.CaretIndex += 2;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00037A44 File Offset: 0x00035C44
		private void ThemeSelector_Checked(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.DarkThemeToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.cache.darkTheme = true;
				this.cache.backgroundColor = new SolidColorBrush(System.Windows.Media.Color.FromArgb(byte.MaxValue, 20, 20, 20));
			}
			else
			{
				this.cache.darkTheme = false;
				this.cache.backgroundColor = new SolidColorBrush(System.Windows.Media.Color.FromArgb(byte.MaxValue, 245, 245, 245));
			}
			string text = ColorTranslator.ToHtml(System.Drawing.Color.FromArgb((int)this.cache.backgroundColor.Color.R, (int)this.cache.backgroundColor.Color.G, (int)this.cache.backgroundColor.Color.B));
			this.ThemeHexCode_Background.Text = text;
			this.SaveCache();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00037B3B File Offset: 0x00035D3B
		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			base.Resources["DefaultFontWeight"] = ((ListBoxItem)this.FontWeightSelector.SelectedItem).FontWeight;
			this.SaveCache();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000302B2 File Offset: 0x0002E4B2
		private void BO2_Console_V4_SizeChanged(object sender, SizeChangedEventArgs e)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00037B70 File Offset: 0x00035D70
		private void resizeWindow(object sender)
		{
			this.ProgramaticallyChangedSize = true;
			try
			{
				if (((System.Windows.Controls.TabControl)sender).SelectedIndex > 0)
				{
					if (this.StoredSizes.ContainsKey(((System.Windows.Controls.TabControl)sender).SelectedIndex))
					{
						base.SizeToContent = SizeToContent.Manual;
						double[] array = this.StoredSizes[((System.Windows.Controls.TabControl)sender).SelectedIndex];
						base.Width = array[0];
						base.Height = array[1];
					}
					else
					{
						base.SizeToContent = SizeToContent.WidthAndHeight;
					}
				}
				else
				{
					base.Width = ((Grid)((TabItem)((System.Windows.Controls.TabControl)sender).SelectedItem).Content).MinWidth + (double)(50f * this.WindowScale);
					base.Height = (((Grid)((TabItem)((System.Windows.Controls.TabControl)sender).SelectedItem).Content).MinHeight + 80.0) * (double)this.WindowScale;
				}
				base.MinWidth = (((Grid)((TabItem)((System.Windows.Controls.TabControl)sender).SelectedItem).Content).MinWidth + 50.0) * (double)this.WindowScale;
				base.MinHeight = (((Grid)((TabItem)((System.Windows.Controls.TabControl)sender).SelectedItem).Content).MinHeight + 80.0) * (double)this.WindowScale;
			}
			catch
			{
			}
			base.MaxHeight = (double)(1000f * this.WindowScale);
			this.ProgramaticallyChangedSize = false;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00037CF8 File Offset: 0x00035EF8
		private void MainTabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			try
			{
				Task.Run(delegate()
				{
					this.ReadAndApplyGameSettings();
					try
					{
						Structures.Settings settings = this.GenerateSettings();
						DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
						DirectoryInfo directoryInfo = new DirectoryInfo(((parent != null) ? parent.ToString() : null) + "\\Autosaves");
						if (!directoryInfo.Exists)
						{
							directoryInfo.Create();
						}
						File.WriteAllText(directoryInfo.FullName + "\\Autosave_" + this.currentSessionName + ".bo2", JsonConvert.SerializeObject(settings, 1));
					}
					catch
					{
					}
				});
			}
			catch
			{
			}
			if (e.Source is System.Windows.Controls.TabControl)
			{
				this.resizeWindow(sender);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00037D40 File Offset: 0x00035F40
		private void CFGExpander_Expanded(object sender, RoutedEventArgs e)
		{
			DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
			DirectoryInfo directoryInfo = new DirectoryInfo(((parent != null) ? parent.ToString() : null) + "\\CFGs");
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			this.CFGList.ItemsSource = directoryInfo.GetFiles("*.cfg");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00037D9C File Offset: 0x00035F9C
		private void CFGList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (e.OriginalSource.GetType() == typeof(TextBlock))
			{
				this.CFGText.Text = File.ReadAllText(((FileInfo)this.CFGList.SelectedItem).FullName);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00037DEC File Offset: 0x00035FEC
		private void FontSizeSelector_Changed(object sender, SelectionChangedEventArgs e)
		{
			this.CFGText.FontSize = ((ListBoxItem)this.FontSizeSelector.SelectedItem).FontSize;
			this.cache.fontSize = this.CFGText.FontSize;
			this.cache.Save();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00037E3C File Offset: 0x0003603C
		private void WindowScaleSelector_Changed(object sender, SelectionChangedEventArgs e)
		{
			this.WindowScale = float.Parse(((ListBoxItem)this.WindowScaleSelector.SelectedItem).Content.ToString());
			this.ApplicationScaleTransform.ScaleX = (double)this.WindowScale;
			this.ApplicationScaleTransform.ScaleY = (double)this.WindowScale;
			this.resizeWindow(null);
			this.cache.windowScale = this.WindowScale;
			this.cache.Save();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00037EB8 File Offset: 0x000360B8
		private void FogToControls(Structures.Fog fog)
		{
			this.FogBaseDistanceSlider.Value = (double)fog.startDist;
			this.FogFadeSlider.Value = (double)fog.fadeDist;
			this.FogHeightStartSlider.Value = (double)fog.startHeight;
			this.FogHeightFadeSlider.Value = (double)fog.fadeHeight;
			if ((double)fog.fogOpacity < this.FogBrightnessSlider.Maximum)
			{
				this.FogBrightnessSlider.Value = (double)fog.fogOpacity;
			}
			this.SunHazeAngleSlider.Value = (double)fog.sunHazeYawAngle;
			this.SunHazePitchSlider.Value = (double)fog.sunHazePitchAngle;
			this.SunHazeStartRadiusSlider.Value = (double)fog.hazeInnerRadius;
			this.SunHazeEndRadiusSlider.Value = (double)fog.hazeOuterRadius;
			this.SunHazeBrightnessSlider.Value = (double)fog.sunHazeOpacity;
			this.FogColorWheel.Palette.Colors[0].R = (double)fog.fogColor.r;
			this.FogColorWheel.Palette.Colors[0].G = (double)fog.fogColor.g;
			this.FogColorWheel.Palette.Colors[0].B = (double)fog.fogColor.b;
			this.FogHazeColorWheel.Palette.Colors[0].R = (double)fog.sunHazeColor.r;
			this.FogHazeColorWheel.Palette.Colors[0].G = (double)fog.sunHazeColor.g;
			this.FogHazeColorWheel.Palette.Colors[0].B = (double)fog.sunHazeColor.b;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00038078 File Offset: 0x00036278
		private void SSAOToControls(Structures.Ssao ssao)
		{
			this.ssaoToggle.IsChecked = new bool?(ssao.ssao == 1);
			this.ssaoBiasBar.Value = (double)ssao.bias;
			this.ssaoIntensityBar.Value = (double)ssao.intensity;
			this.ssaoRadiusBar.Value = (double)ssao.radius;
			this.ssaoScaleBar.Value = (double)ssao.scale;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000380E8 File Offset: 0x000362E8
		private void SaveFogPresetButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo("Fog Presets");
				if (!directoryInfo.Exists)
				{
					directoryInfo.Create();
				}
				Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
				saveFileDialog.RestoreDirectory = true;
				Microsoft.Win32.FileDialog fileDialog = saveFileDialog;
				DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
				fileDialog.InitialDirectory = ((parent != null) ? parent.ToString() : null) + "\\Fog Presets";
				saveFileDialog.Filter = "Fog Preset(*.zfog)|*.zfog|All files(*.*)|*.*";
				bool? flag = saveFileDialog.ShowDialog();
				bool flag2 = true;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					string contents = JsonConvert.SerializeObject(this.BO2.ReadStruct<Structures.Fog>(this.addresses.Fog), 1);
					File.WriteAllText(saveFileDialog.FileName, contents);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000381B4 File Offset: 0x000363B4
		private void LoadFogPresetFromFile(string dir)
		{
			Structures.Fog fog = JsonConvert.DeserializeObject<Structures.Fog>(File.ReadAllText(dir));
			this.writeMemory = false;
			this.FogToControls(fog);
			this.writeMemory = true;
			this.BO2.WriteStruct(this.addresses.Fog, fog);
			bool? isChecked = this.SyncSunFogToSunColor.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteStructMember<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.colour, fog.sunHazeColor);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00038284 File Offset: 0x00036484
		private void LoadFogPreset_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
				DirectoryInfo directoryInfo = new DirectoryInfo(((parent != null) ? parent.ToString() : null) + "\\Fog Presets");
				if (!directoryInfo.Exists)
				{
					directoryInfo.Create();
				}
				Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
				openFileDialog.RestoreDirectory = true;
				Microsoft.Win32.FileDialog fileDialog = openFileDialog;
				DirectoryInfo parent2 = Directory.GetParent(Assembly.GetEntryAssembly().Location);
				fileDialog.InitialDirectory = ((parent2 != null) ? parent2.ToString() : null) + "\\Fog Presets";
				openFileDialog.Filter = "Fog Preset(*.zfog)|*.zfog|All files(*.*)|*.*";
				bool? flag = openFileDialog.ShowDialog();
				bool flag2 = true;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					this.LoadFogPresetFromFile(openFileDialog.FileName);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0003834C File Offset: 0x0003654C
		private void LoadFogPresetDropdown_MouseUp(object sender, MouseButtonEventArgs e)
		{
			DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
			DirectoryInfo directoryInfo = new DirectoryInfo(((parent != null) ? parent.ToString() : null) + "\\Fog Presets");
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.zfog"))
			{
			}
			this.LoadFogPresetDropdown.ItemsSource = directoryInfo.GetFiles("*.zfog");
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000383C8 File Offset: 0x000365C8
		private void LoadFogPresetDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			try
			{
				if (this.LoadFogPresetDropdown.SelectedIndex >= 0)
				{
					this.LoadFogPresetFromFile(((FileInfo)this.LoadFogPresetDropdown.SelectedItem).FullName);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00038414 File Offset: 0x00036614
		private void RandomFogButton_Click(object sender, RoutedEventArgs e)
		{
			Random random = new Random(DateTime.Now.Millisecond);
			Structures.Fog fog = default(Structures.Fog);
			fog.startDist = (float)random.Next((int)Math.Round(this.FogBaseDistanceSlider.Minimum), 2500);
			fog.fadeDist = (float)random.Next((int)fog.startDist, (int)Math.Round(this.FogFadeSlider.Maximum));
			fog.startHeight = (float)random.Next((int)Math.Round(this.FogHeightStartSlider.Minimum), (int)Math.Round(this.FogHeightStartSlider.Maximum));
			fog.fadeHeight = (float)random.Next((int)Math.Round((double)fog.startHeight), (int)Math.Round(this.FogHeightFadeSlider.Maximum));
			fog.fogOpacity = (float)random.Next(0, 100) / 100f;
			fog.sunHazeYawAngle = (float)random.Next((int)Math.Round(this.SunHazeAngleSlider.Min), (int)Math.Round(this.SunHazeAngleSlider.Max));
			fog.sunHazePitchAngle = (float)random.Next((int)Math.Round(this.SunHazePitchSlider.Min), (int)Math.Round(this.SunHazePitchSlider.Max));
			fog.hazeInnerRadius = (float)random.Next((int)Math.Round(this.SunHazeStartRadiusSlider.Minimum), (int)Math.Round(this.SunHazeStartRadiusSlider.Maximum));
			fog.hazeOuterRadius = (float)random.Next((int)Math.Round((double)fog.hazeInnerRadius), (int)Math.Round(this.SunHazeEndRadiusSlider.Maximum));
			fog.sunHazeOpacity = (float)random.Next(0, 100) / 100f;
			fog.fogColor.r = (float)random.Next(0, 1000) / 10f;
			fog.fogColor.g = (float)random.Next(0, 1000) / 10f;
			fog.fogColor.b = (float)random.Next(0, 1000) / 10f;
			bool? isChecked = this.SyncFogColorsToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				fog.sunHazeColor = fog.fogColor;
			}
			else
			{
				fog.sunHazeColor.r = (float)random.Next(0, 1000) / 10f;
				fog.sunHazeColor.g = (float)random.Next(0, 1000) / 10f;
				fog.sunHazeColor.b = (float)random.Next(0, 1000) / 10f;
			}
			this.writeMemory = false;
			this.FogToControls(fog);
			this.BO2.WriteStruct(this.addresses.Fog, fog);
			isChecked = this.SyncSunFogToSunColor.IsChecked;
			flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				DoubleColor doubleColor = this.FogHazeColorWheel.Palette.Colors[0].DoubleColor;
				this.SunColorWheel.Palette.Colors[0].DoubleColor = doubleColor;
				this.BO2.WriteStructMember<Structures.Sun>(this.addresses.Sun, (Structures.Sun sun) => (object)sun.colour, fog.sunHazeColor);
			}
			this.writeMemory = true;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000387B4 File Offset: 0x000369B4
		private void SendToCFGBox_Click(object sender, RoutedEventArgs e)
		{
			if (this.CFGText.Text.Length == 0)
			{
				System.Windows.Controls.TextBox cfgtext = this.CFGText;
				cfgtext.Text += this.SingleCommandTextbox.Text;
				return;
			}
			if (this.CFGText.Text[this.CFGText.Text.Length - 1] == '\n')
			{
				System.Windows.Controls.TextBox cfgtext2 = this.CFGText;
				cfgtext2.Text += this.SingleCommandTextbox.Text;
				return;
			}
			System.Windows.Controls.TextBox cfgtext3 = this.CFGText;
			cfgtext3.Text = cfgtext3.Text + Environment.NewLine + this.SingleCommandTextbox.Text;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00038864 File Offset: 0x00036A64
		private string FogToCFG(Structures.Fog currFog)
		{
			return string.Concat(new string[]
			{
				"//FOG\nz_fogStartDist ",
				currFog.startDist.ToString(),
				Environment.NewLine,
				"z_fogFadeDist ",
				currFog.fadeDist.ToString(),
				Environment.NewLine,
				"z_fogStartHeight ",
				currFog.startHeight.ToString(),
				Environment.NewLine,
				"z_fogFadeHeight ",
				currFog.fadeHeight.ToString(),
				Environment.NewLine,
				"z_fogOpacity ",
				currFog.fogOpacity.ToString(),
				Environment.NewLine,
				"z_fogSunPitch ",
				currFog.sunHazePitchAngle.ToString(),
				Environment.NewLine,
				"z_fogSunYaw ",
				currFog.sunHazeYawAngle.ToString(),
				Environment.NewLine,
				"z_fogSunInner ",
				currFog.hazeInnerRadius.ToString(),
				Environment.NewLine,
				"z_fogSunOuter ",
				currFog.hazeOuterRadius.ToString(),
				Environment.NewLine,
				"z_fogColor ",
				Math.Round((double)(currFog.fogColor.r / 255f), 4).ToString(),
				" ",
				Math.Round((double)(currFog.fogColor.g / 255f), 4).ToString(),
				" ",
				Math.Round((double)(currFog.fogColor.b / 255f), 4).ToString(),
				Environment.NewLine,
				"z_fogSunOpacity ",
				currFog.sunHazeOpacity.ToString(),
				Environment.NewLine,
				"z_fogSunColor ",
				Math.Round((double)(currFog.sunHazeColor.r / 255f), 4).ToString(),
				" ",
				Math.Round((double)(currFog.sunHazeColor.g / 255f), 4).ToString(),
				" ",
				Math.Round((double)(currFog.sunHazeColor.b / 255f), 4).ToString()
			});
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00038AE0 File Offset: 0x00036CE0
		private string GenerateFogCfg()
		{
			Structures.Fog currFog = this.BO2.ReadStruct<Structures.Fog>(this.addresses.Fog);
			return this.FogToCFG(currFog);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00038B0C File Offset: 0x00036D0C
		private void AddFogToCFG_Click(object sender, RoutedEventArgs e)
		{
			Structures.Fog currFog = this.BO2.ReadStruct<Structures.Fog>(this.addresses.Fog);
			string text = this.FogToCFG(currFog);
			if (this.CFGText.Text.Length == 0)
			{
				System.Windows.Controls.TextBox cfgtext = this.CFGText;
				cfgtext.Text += text;
				return;
			}
			if (this.CFGText.Text[this.CFGText.Text.Length - 1] == '\n')
			{
				System.Windows.Controls.TextBox cfgtext2 = this.CFGText;
				cfgtext2.Text += text;
				return;
			}
			System.Windows.Controls.TextBox cfgtext3 = this.CFGText;
			cfgtext3.Text = cfgtext3.Text + Environment.NewLine + text;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00038BBC File Offset: 0x00036DBC
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ", length)
			select s[MainWindow.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00038BF8 File Offset: 0x00036DF8
		private void CustomMemorySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (this.writeMemory && this.initialised)
			{
				try
				{
					Slider slider = (Slider)sender;
					CustomSliderAddress customSliderAddress = (CustomSliderAddress)slider.DataContext;
					switch (customSliderAddress.type)
					{
					case dvarType_t.FLOAT:
						this.BO2.WriteFloat(this.addresses.dvarFinder.returnedDvars[customSliderAddress.name].address, (float)slider.Value);
						break;
					case dvarType_t.FLOAT_3:
					case dvarType_t.FLOAT_4:
					{
						IntPtr address = IntPtr.Add(this.addresses.dvarFinder.returnedDvars[customSliderAddress.name].address, customSliderAddress.offset);
						this.BO2.WriteFloat(address, (float)slider.Value);
						break;
					}
					case dvarType_t.INT:
						this.BO2.WriteInt(this.addresses.dvarFinder.returnedDvars[customSliderAddress.name].address, (int)Math.Round(slider.Value));
						break;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00038D18 File Offset: 0x00036F18
		private void CreateSlider(CustomSliderAddress address)
		{
			string name = MainWindow.RandomString(10);
			Grid grid = new Grid
			{
				Height = 32.0,
				HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
				Margin = new Thickness(0.0, 0.0, 30.0, 0.0)
			};
			System.Windows.Controls.Label label = new System.Windows.Controls.Label
			{
				Height = 32.0,
				Content = address.friendlyName,
				FontSize = 16.0,
				Margin = new Thickness(5.0, 8.0, 0.0, 0.0),
				VerticalAlignment = VerticalAlignment.Center
			};
			float num = (float)new FormattedText(address.friendlyName, CultureInfo.CurrentCulture, System.Windows.FlowDirection.LeftToRight, new Typeface(label.FontFamily, label.FontStyle, this.cache.fontWeight, label.FontStretch), label.FontSize, System.Windows.Media.Brushes.Black, new NumberSubstitution(), TextFormattingMode.Display).Width + 20f;
			float num2 = num + 100f;
			Slider slider = new Slider
			{
				HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
				Margin = new Thickness((double)num2, 3.0, 0.0, 0.0),
				Name = name,
				DataContext = address
			};
			slider.UpdateLayout();
			switch (address.type)
			{
			case dvarType_t.FLOAT:
			case dvarType_t.FLOAT_3:
			case dvarType_t.FLOAT_4:
			{
				float num3 = address.fMin;
				float num4 = address.fMax;
				slider.Minimum = (double)num3;
				slider.Maximum = (double)num4;
				slider.Value = (double)address.fDefaultValue;
				break;
			}
			case dvarType_t.INT:
			{
				int intMin = address.intMin;
				int intMax = address.intMax;
				slider.Minimum = (double)intMin;
				slider.Maximum = (double)intMax;
				slider.Value = (double)address.intdefaultValue;
				break;
			}
			}
			slider.ValueChanged += this.CustomMemorySlider_ValueChanged;
			slider.IsSnapToTickEnabled = (address.type == dvarType_t.INT || address.type == dvarType_t.INT64);
			System.Windows.Controls.TextBox textBox = new System.Windows.Controls.TextBox
			{
				HorizontalAlignment = System.Windows.HorizontalAlignment.Left,
				Height = 24.0,
				Margin = new Thickness((double)num, 3.0, 0.0, 0.0),
				TextWrapping = TextWrapping.Wrap,
				VerticalAlignment = VerticalAlignment.Center,
				Width = 90.0,
				FontSize = 16.0,
				BorderBrush = null,
				TextAlignment = TextAlignment.Right
			};
			System.Windows.Data.Binding binding = new System.Windows.Data.Binding();
			binding.Source = slider;
			binding.Path = new PropertyPath("Value", new object[]
			{
				slider.Value
			});
			binding.Mode = BindingMode.TwoWay;
			binding.StringFormat = "{0:N2}";
			binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
			textBox.SetBinding(System.Windows.Controls.TextBox.TextProperty, binding);
			textBox.MouseDoubleClick += this.TextBox_MouseDoubleClick;
			textBox.KeyDown += this.TextBox_KeyUp;
			grid.Children.Add(slider);
			grid.Children.Add(textBox);
			grid.Children.Add(label);
			this.CustomSliderListBox.Items.Add(grid);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00039088 File Offset: 0x00037288
		private void CreateCustomSliderButton_Click(object sender, RoutedEventArgs e)
		{
			this.InactiveOverlay.Visibility = Visibility.Visible;
			CustomSliderDialog customSliderDialog = new CustomSliderDialog(this.BO2, this.addresses);
			customSliderDialog.Resources["DefaultBackground"] = base.Resources["DefaultBackground"];
			customSliderDialog.Resources["DefaultBackgroundOpaque"] = base.Resources["DefaultBackgroundOpaque"];
			customSliderDialog.Resources["DefaultColor"] = base.Resources["DefaultColor"];
			customSliderDialog.ApplicationScaleTransform.ScaleX = (double)this.WindowScale;
			customSliderDialog.ApplicationScaleTransform.ScaleY = (double)this.WindowScale;
			customSliderDialog.Width *= (double)this.WindowScale;
			customSliderDialog.Height *= (double)this.WindowScale;
			bool? flag = customSliderDialog.ShowDialog();
			bool flag2 = true;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				CustomSliderAddress customSliderAddress = new CustomSliderAddress
				{
					type = customSliderDialog.dvarType,
					name = customSliderDialog.dvarName,
					friendlyName = customSliderDialog.dvarFriendlyName,
					offset = 0
				};
				switch (customSliderAddress.type)
				{
				case dvarType_t.FLOAT:
				case dvarType_t.FLOAT_3:
				case dvarType_t.FLOAT_4:
					customSliderAddress.fMin = (float)customSliderDialog.dvarMin;
					customSliderAddress.fMax = (float)customSliderDialog.dvarMax;
					customSliderAddress.fDefaultValue = (float)customSliderDialog.dvarCurrent;
					break;
				case dvarType_t.INT:
					customSliderAddress.intMax = (int)customSliderDialog.dvarMax;
					customSliderAddress.intMin = (int)customSliderDialog.dvarMin;
					customSliderAddress.intdefaultValue = (int)customSliderDialog.dvarCurrent;
					break;
				}
				DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
				DirectoryInfo directoryInfo = new DirectoryInfo(((parent != null) ? parent.ToString() : null) + "\\Sliders");
				if (!directoryInfo.Exists)
				{
					directoryInfo.Create();
				}
				File.WriteAllText("Sliders\\" + customSliderDialog.dvarName + ".json", JsonConvert.SerializeObject(customSliderAddress, 1));
				if (!this.addresses.dvarFinder.dvars.Contains(customSliderDialog.dvarName))
				{
					this.addresses.dvarFinder.dvars.Add(customSliderDialog.dvarName);
					this.addresses.dvarFinder.returnedDvars.Add(customSliderDialog.dvarName, new dvar.DvarResult
					{
						address = customSliderDialog.dvarAddress,
						type = customSliderAddress.type,
						name = customSliderDialog.dvarName
					});
				}
				if (customSliderAddress.type == dvarType_t.FLOAT_3 || customSliderAddress.type == dvarType_t.FLOAT_4)
				{
					CustomSliderAddress customSliderAddress2 = JsonConvert.DeserializeObject<CustomSliderAddress>(JsonConvert.SerializeObject(customSliderAddress));
					customSliderAddress2.offset = 4;
					CustomSliderAddress customSliderAddress3 = JsonConvert.DeserializeObject<CustomSliderAddress>(JsonConvert.SerializeObject(customSliderAddress));
					customSliderAddress3.offset = 8;
					CustomSliderAddress customSliderAddress4 = customSliderAddress;
					customSliderAddress4.friendlyName += " - X";
					CustomSliderAddress customSliderAddress5 = customSliderAddress2;
					customSliderAddress5.friendlyName += " - Y";
					CustomSliderAddress customSliderAddress6 = customSliderAddress3;
					customSliderAddress6.friendlyName += " - Z";
					this.CreateSlider(customSliderAddress);
					this.CreateSlider(customSliderAddress2);
					this.CreateSlider(customSliderAddress3);
					if (customSliderAddress.type == dvarType_t.FLOAT_4)
					{
						CustomSliderAddress customSliderAddress7 = JsonConvert.DeserializeObject<CustomSliderAddress>(JsonConvert.SerializeObject(customSliderAddress));
						customSliderAddress7.offset = 12;
						CustomSliderAddress customSliderAddress8 = customSliderAddress7;
						customSliderAddress8.friendlyName += " - W";
						this.CreateSlider(customSliderAddress7);
					}
				}
				else
				{
					this.CreateSlider(customSliderAddress);
				}
			}
			this.InactiveOverlay.Visibility = Visibility.Hidden;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00039410 File Offset: 0x00037610
		private void SingleCommandTextbox_Populating(object sender, PopulatingEventArgs e)
		{
			MainWindow.PopulateInfo populateInfo = new MainWindow.PopulateInfo
			{
				AutoCompleteBox = (sender as AutoCompleteBox),
				SearchText = (sender as AutoCompleteBox).SearchText
			};
			e.Cancel = true;
			TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
			Task.Factory.StartNew<MainWindow.PopulateInfo>(() => this.Populate(populateInfo)).ContinueWith(delegate(Task<MainWindow.PopulateInfo> task)
			{
				this.OnPopulateComplete(task.Result);
			}, scheduler);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00039488 File Offset: 0x00037688
		private void AnimationSearch_Populating(object sender, PopulatingEventArgs e)
		{
			MainWindow.PopulateInfoAnimations populateInfo = new MainWindow.PopulateInfoAnimations
			{
				AutoCompleteBox = (sender as AutoCompleteBox),
				SearchText = (sender as AutoCompleteBox).SearchText
			};
			e.Cancel = true;
			TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
			Task.Factory.StartNew<MainWindow.PopulateInfoAnimations>(() => this.PopulateAnimations(populateInfo)).ContinueWith(delegate(Task<MainWindow.PopulateInfoAnimations> task)
			{
				this.OnPopulateCompleteAnim(task.Result);
			}, scheduler);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00039500 File Offset: 0x00037700
		private MainWindow.PopulateInfoAnimations PopulateAnimations(MainWindow.PopulateInfoAnimations populateInfo)
		{
			populateInfo.Results = (from candidate in Animations.AllAnimations
			where candidate.Contains(populateInfo.SearchText.ToLower())
			select candidate).ToList<string>();
			return populateInfo;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00039548 File Offset: 0x00037748
		private MainWindow.PopulateInfo Populate(MainWindow.PopulateInfo populateInfo)
		{
			if (this.cache.filter == null)
			{
				populateInfo.Results = new List<DvarEntry>();
				return populateInfo;
			}
			if (this.cache.autocompleteLimit == -1)
			{
				populateInfo.Results = (from candidate in DvarsWithDesc.DvarsWithDescriptions
				where candidate.Name.ToLower().Contains(populateInfo.SearchText.ToLower())
				select candidate).ToList<DvarEntry>();
			}
			else
			{
				populateInfo.Results = (from candidate in DvarsWithDesc.DvarsWithDescriptions
				where candidate.Name.ToLower().Contains(populateInfo.SearchText.ToLower())
				select candidate).Take(this.cache.autocompleteLimit).ToList<DvarEntry>();
			}
			return populateInfo;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000395F8 File Offset: 0x000377F8
		private void OnPopulateComplete(MainWindow.PopulateInfo populateInfo)
		{
			if (populateInfo.SearchText == populateInfo.AutoCompleteBox.SearchText)
			{
				populateInfo.AutoCompleteBox.ItemsSource = populateInfo.Results;
				populateInfo.AutoCompleteBox.PopulateComplete();
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0003962E File Offset: 0x0003782E
		private void OnPopulateCompleteAnim(MainWindow.PopulateInfoAnimations populateInfo)
		{
			if (populateInfo.SearchText == populateInfo.AutoCompleteBox.SearchText)
			{
				populateInfo.AutoCompleteBox.ItemsSource = populateInfo.Results;
				populateInfo.AutoCompleteBox.PopulateComplete();
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00039664 File Offset: 0x00037864
		private void AutofillModeChanged(object sender, SelectionChangedEventArgs e)
		{
			this.SingleCommandTextbox.FilterMode = (AutoCompleteFilterMode)Enum.Parse(typeof(AutoCompleteFilterMode), (string)((ComboBoxItem)this.AutofillModeSelector.SelectedItem).Content);
			this.cache.filter = this.SingleCommandTextbox.FilterMode;
			this.cache.Save();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000396CC File Offset: 0x000378CC
		private void AutofillLimit_Change(object sender, SelectionChangedEventArgs e)
		{
			try
			{
				string text = (string)((ListBoxItem)this.AutofillLimitSelector.SelectedItem).Content;
				if (text == "All")
				{
					this.cache.autocompleteLimit = -1;
				}
				else
				{
					this.cache.autocompleteLimit = int.Parse(text);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00039738 File Offset: 0x00037938
		private void ReadAndApplyGameSettings()
		{
			try
			{
				if (Process.GetProcessById(this.BO2.process.Id) != null)
				{
					Structures.Fog CurrentFog = this.BO2.ReadStruct<Structures.Fog>(this.addresses.Fog);
					Structures.Vector3 sunReadOnly = this.BO2.ReadStruct<Structures.Vector3>(this.addresses.r_lightTweakSunDirection_readOnly);
					Structures.Sun sunActual = this.BO2.ReadStruct<Structures.Sun>(this.addresses.Sun);
					float skyTemp = this.BO2.ReadFloat(this.addresses.r_skyColorTemp);
					float skyBrightnesss = this.BO2.ReadFloat(this.addresses.r_sky_intensity_factor0);
					float skyRotation = this.BO2.ReadFloat(this.addresses.r_skyrotation);
					Structures.Ssao ssao = this.BO2.ReadStruct<Structures.Ssao>(this.addresses.r_ssao);
					int dofEnabled = (int)this.BO2.ReadByte(this.addresses.r_dof_enable);
					int dofTweak = (int)this.BO2.ReadByte(this.addresses.r_dof_tweak);
					float dofFarBlur = this.BO2.ReadFloat(this.addresses.r_dof_farBlur);
					float dofFarStart = this.BO2.ReadFloat(this.addresses.r_dof_farStart);
					float dofFarEnd = this.BO2.ReadFloat(this.addresses.r_dof_farEnd);
					float dofNearBlur = this.BO2.ReadFloat(this.addresses.r_dof_nearBlur);
					float dofNearStart = this.BO2.ReadFloat(this.addresses.r_dof_nearStart);
					float dofNearEnd = this.BO2.ReadFloat(this.addresses.r_dof_nearEnd);
					float dofViewStart = this.BO2.ReadFloat(this.addresses.r_dof_viewModelStart);
					float dofViewEnd = this.BO2.ReadFloat(this.addresses.r_dof_viewModelEnd);
					float dofBias = this.BO2.ReadFloat(this.addresses.r_dof_bias);
					int dofQuality = this.BO2.ReadInt(this.addresses.r_dofHDR);
					int sunQuality = this.BO2.ReadInt(this.addresses.sm_sunQuality);
					this.writeMemory = false;
					this.MainTabs.Dispatcher.Invoke(delegate()
					{
						try
						{
							bool? isChecked = this.depthEnable.IsChecked;
							bool flag = true;
							if (isChecked.GetValueOrDefault() == flag & isChecked != null)
							{
								isChecked = this.depthByFog.IsChecked;
								flag = true;
								if (isChecked.GetValueOrDefault() == flag & isChecked != null)
								{
									goto IL_5F;
								}
							}
							this.FogToControls(CurrentFog);
							IL_5F:
							this.SSAOToControls(ssao);
							this.skyBrightnessBar.Value = (double)skyBrightnesss;
							this.skyTempBar.Value = (double)skyTemp;
							this.SunXSlider.Value = (double)sunActual.X;
							this.SunYSlider.Value = (double)sunActual.Y;
							this.SunZSlider.Value = (double)sunActual.Z;
							this.SkyRotation_Dial.Value = (double)skyRotation;
							this.SunColorWheel.Palette.Colors[0] = new PaletteColor
							{
								R = (double)sunActual.colour.r,
								G = (double)sunActual.colour.g,
								B = (double)sunActual.colour.b
							};
							this.SunQualitySlider.Value = (double)sunQuality;
							this.updateSun = false;
							this.SunYawDial.Value = (double)sunReadOnly.X;
							this.SunPitchDial.Value = (double)sunReadOnly.Y;
							this.updateSun = true;
							this.writeMemory = false;
							isChecked = this.depthEnable.IsChecked;
							flag = true;
							if (isChecked.GetValueOrDefault() == flag & isChecked != null)
							{
								isChecked = this.depthByBuffer.IsChecked;
								flag = true;
								if (isChecked.GetValueOrDefault() == flag & isChecked != null)
								{
									goto IL_35B;
								}
							}
							this.DOFFarBlurSider.Value = (double)dofFarBlur;
							this.DOFFarEndSlider.Value = (double)dofFarEnd;
							this.DOFFarStartSlider.Value = (double)dofFarStart;
							this.DOFNearBlurSlider.Value = (double)dofNearBlur;
							this.DOFNearEndSlider.Value = (double)dofNearEnd;
							this.DOFNearStartSlider.Value = (double)dofNearStart;
							this.DOFViewmodelEndSlider.Value = (double)dofViewEnd;
							this.DOFViewmodelStartSlider.Value = (double)dofViewStart;
							this.DOFBiasSlider.Value = (double)dofBias;
							this.DOFQualitySlider.Value = (double)dofQuality;
							Console.WriteLine(dofEnabled.ToString() + "/" + dofTweak.ToString());
							this.DOFEnable.IsChecked = new bool?(dofTweak == 1);
							IL_35B:;
						}
						catch
						{
						}
					});
				}
				this.writeMemory = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000399E8 File Offset: 0x00037BE8
		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			this.demoPreviewerWebView.Close();
			this.SaveCache();
			Environment.Exit(0);
		}

		// Token: 0x0600013A RID: 314
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600013B RID: 315 RVA: 0x00039A01 File Offset: 0x00037C01
		private void MinimiseButton_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.SendMessage(new WindowInteropHelper(this).Handle, 274U, (IntPtr)61472, IntPtr.Zero);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00039A28 File Offset: 0x00037C28
		private void NormalPassToggle_Changed(object sender, RoutedEventArgs e)
		{
			this.shader = (Enums.debugShader)int.Parse((string)((System.Windows.Controls.RadioButton)sender).DataContext);
			this.BO2.WriteInt(this.addresses.r_debugShader, (int)this.shader);
			this.BO2.GetStructMemberAddress<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.baseTechType, 0);
			if (this.shader == Enums.debugShader.None)
			{
				this.BO2.WriteStructMember<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.baseTechType, 772);
				this.bloomTweaksToggle.IsChecked = new bool?(this.oldBloomTweaks);
				return;
			}
			this.BO2.WriteStructMember<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.baseTechType, 8738);
			bool? isChecked = this.bloomTweaksToggle.IsChecked;
			bool flag = true;
			this.oldBloomTweaks = (isChecked.GetValueOrDefault() == flag & isChecked != null);
			this.bloomTweaksToggle.IsChecked = new bool?(true);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00039BE4 File Offset: 0x00037DE4
		private void ParticlesToggle_CheckedChanged(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.ParticlesToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.BO2.WriteStructMember<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.emisssiveTechType, 1);
				return;
			}
			if (this.shader == Enums.debugShader.None)
			{
				this.BO2.WriteStructMember<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.emisssiveTechType, 3);
				return;
			}
			this.BO2.WriteStructMember<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.emisssiveTechType, 34);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00039D3C File Offset: 0x00037F3C
		private void WireframeToggle_CheckedChanged(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.WireframeToggle.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				byte b = 32;
				isChecked = this.ParticlesToggle.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					b = 1;
				}
				IntPtr structMemberAddress = this.BO2.GetStructMemberAddress<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.baseTechType, 0);
				this.BO2.WriteByteArray(structMemberAddress, new byte[]
				{
					32,
					b
				});
				return;
			}
			if (this.shader == Enums.debugShader.None)
			{
				byte b2 = 3;
				isChecked = this.ParticlesToggle.IsChecked;
				flag = true;
				if (isChecked.GetValueOrDefault() == flag & isChecked != null)
				{
					b2 = 1;
				}
				IntPtr structMemberAddress2 = this.BO2.GetStructMemberAddress<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.baseTechType, 0);
				this.BO2.WriteByteArray(structMemberAddress2, new byte[]
				{
					4,
					b2
				});
				return;
			}
			this.BO2.WriteStructMember<Structures.GfxDrawMethod>(this.addresses.gfxDrawMethod, (Structures.GfxDrawMethod method) => (object)method.baseTechType, 8738);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00039F24 File Offset: 0x00038124
		private void CallFunctionTest_Click(object sender, RoutedEventArgs e)
		{
			WeaponChanger.addresses = this.addresses;
			WeaponChanger.BO2 = this.BO2;
			WeaponChanger.EnableLoop();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00039F44 File Offset: 0x00038144
		private void RemoveSkybox()
		{
			int num = this.BO2.ReadInt(this.addresses.SkyboxModel);
			if (num != 0)
			{
				this.model = num;
			}
			this.BO2.WriteInt(this.addresses.SkyboxModel, 0);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00039F89 File Offset: 0x00038189
		private void RestoreSkybox()
		{
			if (this.model != 0)
			{
				this.BO2.WriteInt(this.addresses.SkyboxModel, this.model);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000302B2 File Offset: 0x0002E4B2
		private void NormalMaterialPatch_CheckedChanged(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00039FB0 File Offset: 0x000381B0
		private void MaterialsPatchSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.MaterialsPatchSelector.SelectedIndex > 0)
			{
				int num = this.BO2.CallFunction86(this.addresses.DB_FindXAssetHeader, new object[]
				{
					6,
					"mc/lambert1",
					true,
					-1
				});
				if (num != 0)
				{
					byte[] array = new byte[]
					{
						184
					};
					array = this.BO2.CombineBytes(new byte[][]
					{
						array,
						BitConverter.GetBytes(num),
						new byte[]
						{
							144,
							144
						}
					});
					this.BO2.WriteByteArray(this.addresses.MaterialsPatch, array, true);
					if (this.MaterialsPatchSelector.SelectedIndex == 2)
					{
						array = new byte[]
						{
							185
						};
						array = this.BO2.CombineBytes(new byte[][]
						{
							array,
							BitConverter.GetBytes(num),
							new byte[]
							{
								144,
								144
							}
						});
						this.BO2.WriteByteArray(this.addresses.MaterialsPatchStatic, array, true);
						return;
					}
					array = new byte[]
					{
						139,
						12,
						141
					};
					array = this.BO2.CombineBytes(new byte[][]
					{
						array,
						BitConverter.GetBytes((int)this.addresses.MaterialsCollection)
					});
					this.BO2.WriteByteArray(this.addresses.MaterialsPatchStatic, array, true);
					return;
				}
			}
			else
			{
				byte[] array2 = new byte[]
				{
					139,
					4,
					133
				};
				array2 = this.BO2.CombineBytes(new byte[][]
				{
					array2,
					BitConverter.GetBytes((int)this.addresses.MaterialsCollection)
				});
				this.BO2.WriteByteArray(this.addresses.MaterialsPatch, array2, true);
				array2 = new byte[]
				{
					139,
					12,
					141
				};
				array2 = this.BO2.CombineBytes(new byte[][]
				{
					array2,
					BitConverter.GetBytes((int)this.addresses.MaterialsCollection)
				});
				this.BO2.WriteByteArray(this.addresses.MaterialsPatchStatic, array2, true);
				this.RestoreSkybox();
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0003A1F0 File Offset: 0x000383F0
		private void IncludeWeaponsInPlayerPass_CheckedChanged(object sender, RoutedEventArgs e)
		{
			bool? isChecked = this.IncludeWeaponsInPlayerPass.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				isChecked = this.PlayersAlphaCheckbox.IsChecked;
				flag = true;
				if (!(isChecked.GetValueOrDefault() == flag & isChecked != null))
				{
					isChecked = this.gpEnable.IsChecked;
					flag = true;
					if (!(isChecked.GetValueOrDefault() == flag & isChecked != null))
					{
						return;
					}
				}
				this.applyPlayerMaterialPatch();
				return;
			}
			this.disablePlayerMaterialPatch();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0003A270 File Offset: 0x00038470
		private void SunHazeAngleSlider_ValueChanged(object sender, EventArgs e)
		{
			if (this.writeMemory && this.initialised)
			{
				try
				{
					this.BO2.WriteFloat(this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.sunHazeYawAngle, 0), (float)this.SunHazeAngleSlider.Value);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0003A314 File Offset: 0x00038514
		private void SunHazePitchSlider_ValueChanged(object sender, EventArgs e)
		{
			if (this.writeMemory && this.initialised)
			{
				try
				{
					this.BO2.WriteFloat(this.BO2.GetStructMemberAddress<Structures.Fog>(this.addresses.Fog, (Structures.Fog fog) => (object)fog.sunHazePitchAngle, 0), (float)this.SunHazePitchSlider.Value);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0003A3B8 File Offset: 0x000385B8
		private void AnimSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string[] array = new string[6];
			array[0] = Directory.GetCurrentDirectory();
			array[1] = "\\Anims\\";
			int num = 2;
			object selectedItem = this.AnimCategorySelector.SelectedItem;
			array[num] = ((selectedItem != null) ? selectedItem.ToString() : null);
			array[3] = "\\";
			array[4] = (string)this.AnimSelector.SelectedItem;
			array[5] = ".gif";
			string text = string.Concat(array);
			bool? isChecked = this.TargetAnimationRadio.IsChecked;
			bool flag = true;
			if (isChecked.GetValueOrDefault() == flag & isChecked != null)
			{
				this.Anim1Textbox.Text = (string)this.AnimSelector.SelectedItem;
			}
			else
			{
				this.Anim2Textbox.Text = (string)this.AnimSelector.SelectedItem;
			}
			if (File.Exists(text))
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.UriSource = new Uri(text);
				bitmapImage.EndInit();
				ImageBehavior.SetAnimatedSource(this.AnimViewer, bitmapImage);
				return;
			}
			this.AnimViewer.Source = null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0003A4B8 File Offset: 0x000386B8
		private void SwapAnimationButton_Click(object sender, RoutedEventArgs e)
		{
			AnimationChanger.addresses = this.addresses;
			AnimationChanger.memory = this.BO2;
			AnimationChanger.AnimationChangeResult result = AnimationChanger.ReplaceAnim(this.Anim1Textbox.Text, this.Anim2Textbox.Text);
			Task.Run(delegate()
			{
				string newText = "";
				switch (result)
				{
				case AnimationChanger.AnimationChangeResult.Good:
					newText = "Done!";
					break;
				case AnimationChanger.AnimationChangeResult.Anim1Bad:
					newText = "Error: Could not find Target Animation";
					break;
				case AnimationChanger.AnimationChangeResult.Anim2Bad:
					newText = "Error: Could not find Source Animation";
					break;
				case AnimationChanger.AnimationChangeResult.BothBad:
					newText = "Error: Both animations could not be found";
					break;
				case AnimationChanger.AnimationChangeResult.incompatible:
					newText = "Error: Animations are not compatible";
					break;
				}
				this.TemporaryButtonTextReplace(this.SwapAnimationButton, newText, "Replace Animation", 5000);
			});
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0003A519 File Offset: 0x00038719
		private void RestoreAllAnimations_Click(object sender, RoutedEventArgs e)
		{
			Task.Run(delegate()
			{
				AnimationChanger.RestoreAll();
				this.TemporaryButtonTextReplace(this.RestoreAllAnimations, "Done!", "Restore All Animations", 5000);
			});
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0003A52D File Offset: 0x0003872D
		private void WeaponClassSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.WeaponSelector.SelectedIndex = -1;
			this.WeaponSelector.ItemsSource = WeaponIDs.Weapons[(string)this.WeaponClassSelector.SelectedItem].Keys;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0003A568 File Offset: 0x00038768
		private void WeaponSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.WeaponSelector.SelectedIndex != -1)
			{
				WeaponChanger.SetWeapon(WeaponIDs.Weapons[(string)this.WeaponClassSelector.SelectedItem][(string)this.WeaponSelector.SelectedItem]);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0003A5B7 File Offset: 0x000387B7
		private void CamoSelector_Click(object sender, RoutedEventArgs e)
		{
			WeaponChanger.SetCamo((int)((byte)((sender as System.Windows.Controls.Button).DataContext as camo).ID));
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0003A5D4 File Offset: 0x000387D4
		private void ClearWeaponsButton_Click(object sender, RoutedEventArgs e)
		{
			WeaponChanger.ClearSelection();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0003A5DB File Offset: 0x000387DB
		private void WeaponChangerToggle_Click(object sender, RoutedEventArgs e)
		{
			if (WeaponChanger.loopRunning)
			{
				WeaponChanger.DisableLoop();
				this.WeaponChangerToggle.Content = "Enable Weapon Changer";
				return;
			}
			WeaponChanger.EnableLoop();
			this.WeaponChangerToggle.Content = "Disable Weapon Changer";
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0003A610 File Offset: 0x00038810
		private void DemoMapSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.DemoMapSelector.SelectedIndex >= 0)
			{
				this.DemoSelector.ItemsSource = Demos.DemosSortedByMap[this.DemoMapSelector.Items[this.DemoMapSelector.SelectedIndex].ToString()];
				return;
			}
			this.DemoSelector.ItemsSource = null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0003A670 File Offset: 0x00038870
		private void DemoSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.DemoSelector.SelectedIndex >= 0)
			{
				string path = Demos.DemoNameFileMap[this.DemoSelector.SelectedItem.ToString()] + ".tags";
				if (File.Exists(path))
				{
					byte[] filedata = File.ReadAllBytes(path);
					if (DemoMetaDataUtil.FileHasMetaData(filedata))
					{
						Dictionary<string, string> dictionary = DemoMetaDataUtil.ReadDemoMetaData(filedata);
						string text = null;
						if (dictionary.TryGetValue("description", out text))
						{
							this.DemoDescriptionTextbox.Text = text;
						}
						else
						{
							this.DemoDescriptionTextbox.Text = "";
						}
						string a;
						if (!dictionary.TryGetValue("has_embed", out a) || !(a == "1"))
						{
							return;
						}
						try
						{
							string text2 = dictionary["embed_host"];
							if (text2 != null)
							{
								if (!(text2 == "yt"))
								{
									if (text2 == "streamable")
									{
										SolidColorBrush col = (SolidColorBrush)base.Resources["DefaultBackground"];
										this.demoPreviewerWebView.NavigateToString(EmbedURLBuilder.Streamable(dictionary["video_id"], col, (int)this.demoPreviewerWebView.Width, (int)this.demoPreviewerWebView.Height, true, false));
									}
								}
								else
								{
									string s = "0";
									string s2 = "0";
									dictionary.TryGetValue("start_time", out s);
									dictionary.TryGetValue("end_time", out s2);
									this.demoPreviewerWebView.Navigate(EmbedURLBuilder.Youtube(dictionary["video_id"], true, int.Parse(s), int.Parse(s2), false));
								}
							}
							return;
						}
						catch
						{
							return;
						}
					}
					SolidColorBrush solidColorBrush = (SolidColorBrush)base.Resources["DefaultBackground"];
					this.demoPreviewerWebView.NavigateToString("<body bgcolor=\"#" + solidColorBrush.ToString().Substring(3) + "\">");
				}
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0003A858 File Offset: 0x00038A58
		private void RenameDirectory(DirectoryInfo di, string name)
		{
			if (di == null)
			{
				throw new ArgumentNullException("di", "Directory info to rename cannot be null");
			}
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("New name cannot be null or blank", "name");
			}
			di.MoveTo(Path.Combine(di.Parent.FullName, name));
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0003A8A8 File Offset: 0x00038AA8
		private void EditDemoMetadataButton_Click(object sender, RoutedEventArgs e)
		{
			if (this.DemoSelector.SelectedIndex >= 0)
			{
				string text = Demos.DemoNameFileMap[(string)this.DemoSelector.SelectedItem];
				string name = new DirectoryInfo(Path.GetDirectoryName(text)).Name;
				this.InactiveOverlay.Visibility = Visibility.Visible;
				Dictionary<string, string> currentMetadata = DemoMetaDataUtil.ReadDemoMetaData(text + ".tags");
				DemoMetadataEditor demoMetadataEditor = new DemoMetadataEditor(text, currentMetadata, this.addresses, this.BO2, this.console, this.cache.GetStreamableLogin());
				demoMetadataEditor.Resources["DefaultBackground"] = base.Resources["DefaultBackground"];
				demoMetadataEditor.Resources["DefaultBackgroundOpaque"] = base.Resources["DefaultBackgroundOpaque"];
				demoMetadataEditor.Resources["DefaultColor"] = base.Resources["DefaultColor"];
				demoMetadataEditor.ApplicationScaleTransform.ScaleX = (double)this.WindowScale;
				demoMetadataEditor.ApplicationScaleTransform.ScaleY = (double)this.WindowScale;
				demoMetadataEditor.Width *= (double)this.WindowScale;
				demoMetadataEditor.Height *= (double)this.WindowScale;
				bool? flag = demoMetadataEditor.ShowDialog();
				bool flag2 = true;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					Dictionary<string, string> metadata = demoMetadataEditor.metadata;
					DemoMetaDataUtil.ApplyMetadataToDemoFile(text + ".tags", metadata);
					if (name != demoMetadataEditor.demo_title)
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(text));
						this.RenameDirectory(directoryInfo, demoMetadataEditor.demo_title);
						int selectedIndex = this.DemoSelector.SelectedIndex;
						Demos.DemosSortedByMap[this.DemoMapSelector.SelectedItem.ToString()][selectedIndex] = demoMetadataEditor.demo_title;
						Demos.DemoNameFileMap.Add(demoMetadataEditor.demo_title, directoryInfo.FullName + Path.GetFileName(text));
					}
					this.DemoSelector_SelectionChanged(this.DemoSelector, null);
					this.InactiveOverlay.Visibility = Visibility.Hidden;
				}
				else
				{
					this.InactiveOverlay.Visibility = Visibility.Hidden;
				}
				this.InactiveOverlay.Dispatcher.Invoke(delegate()
				{
					this.InactiveOverlay.Visibility = Visibility.Hidden;
				});
			}
			this.InactiveOverlay.Dispatcher.Invoke(delegate()
			{
				this.InactiveOverlay.Visibility = Visibility.Hidden;
			});
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0003AAFC File Offset: 0x00038CFC
		private void FastForwardToTick(int tick, int player_index, System.Windows.Controls.Button caller)
		{
			this.console.Send("timescale 8; demo_pause 0");
			this.cancelFastForard = false;
			Action <>9__2;
			Task.Run(delegate()
			{
				int currentTick = 0;
				while (currentTick < tick - 1000 && !this.cancelFastForard)
				{
					if (player_index >= 0)
					{
						this.BO2.WriteInt(this.addresses.selectedPlayerIndex, player_index);
					}
					currentTick = this.BO2.ReadInt(this.addresses.Tick);
					this.DemoSkipProgressBar.Dispatcher.Invoke(delegate()
					{
						this.DemoSkipProgressBar.Value = (double)currentTick;
						if (currentTick == 0)
						{
							caller.Content = "Loading...";
							return;
						}
						caller.Content = "Skipping to Tick: " + tick.ToString();
					});
					Thread.Sleep(1);
				}
				this.console.Send("demo_pause 1; timescale 1;");
				Dispatcher dispatcher = this.DemoSkipProgressBar.Dispatcher;
				Action callback;
				if ((callback = <>9__2) == null)
				{
					callback = (<>9__2 = delegate()
					{
						this.DemoSkipProgressBar.Visibility = Visibility.Hidden;
					});
				}
				dispatcher.Invoke(callback);
				this.TemporaryButtonTextReplace(caller, "Done!", "Load Selected Demo", 5000);
			});
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0003AB54 File Offset: 0x00038D54
		private void LoadDemo(string filename)
		{
			byte[] array = File.ReadAllBytes(filename);
			byte[] bytes = File.ReadAllBytes(filename + ".thumbnail");
			byte[] bytes2 = File.ReadAllBytes(filename + ".summary");
			string text = new FileInfo(filename).Name;
			string[] array2 = text.Split(new char[]
			{
				'_'
			});
			text = array2[1] + "_" + array2[2];
			if (text == "mp_nuketown")
			{
				text += "_2020";
			}
			this.console.Send("ui_mapname " + text);
			Structures.DemoInfo demoInfo = default(Structures.DemoInfo);
			demoInfo.DemoDataPtr = (int)this.BO2.AllocateMemory((uint)array.Length);
			demoInfo.DemoSize = array.Length;
			this.BO2.WriteByteArray((IntPtr)demoInfo.DemoDataPtr, array);
			this.BO2.WriteByteArray(this.addresses.DemoSummaryAddress, bytes2);
			this.BO2.WriteByteArray(this.addresses.DemoThumbnailAddress, bytes);
			this.BO2.WriteByteArray(this.addresses.DemoThumbnailAddress2, bytes);
			this.BO2.WriteStruct(this.addresses.DemoAddress1, demoInfo);
			this.BO2.WriteStruct(this.addresses.DemoAddress2, demoInfo);
			this.BO2.WriteByteArray(this.addresses.DemoLoadPatch, new byte[]
			{
				235
			});
			this.console.Send("demo_play demo");
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0003ACE4 File Offset: 0x00038EE4
		private void SmartLoadDemo(string demo_file, System.Windows.Controls.Button caller)
		{
			this.LoadDemo(demo_file);
			if (File.Exists(demo_file + ".tags"))
			{
				Dictionary<string, string> dictionary = DemoMetaDataUtil.ReadDemoMetaData(demo_file + ".tags");
				if (dictionary.ContainsKey("start_tick"))
				{
					string text;
					dictionary.TryGetValue("player_index", out text);
					if (text == null)
					{
						text = "-1";
					}
					int num = int.Parse(dictionary["start_tick"]);
					this.DemoSkipProgressBar.Visibility = Visibility.Visible;
					this.DemoSkipProgressBar.Minimum = 0.0;
					this.DemoSkipProgressBar.Maximum = (double)(num - 1000);
					this.FastForwardToTick(num, int.Parse(text), caller);
					return;
				}
			}
			Task.Run(delegate()
			{
				this.TemporaryButtonTextReplace(caller, "Done!", "Load Selected Demo", 5000);
			});
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0003ADC0 File Offset: 0x00038FC0
		private void LoadSelectedDemoButton_Click(object sender, RoutedEventArgs e)
		{
			if (this.DemoSelector.SelectedIndex >= 0)
			{
				string demo_file = Demos.DemoNameFileMap[(string)this.DemoSelector.SelectedItem];
				this.SmartLoadDemo(demo_file, this.LoadSelectedDemoButton);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0003AE03 File Offset: 0x00039003
		private void EndDemoPlayback_Click(object sender, RoutedEventArgs e)
		{
			this.cancelFastForard = true;
			this.console.Send("xpartystopdemo");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000302B2 File Offset: 0x0002E4B2
		private void RecordDemoPreview_Click(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000302B2 File Offset: 0x0002E4B2
		private void StopRecordPreview_Click(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000317A6 File Offset: 0x0002F9A6
		public bool callbackTest(string input)
		{
			return true;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0003AE1C File Offset: 0x0003901C
		private void OpenInBrowser(object sender, RoutedEventArgs e)
		{
			if (this.DemoSelector.SelectedIndex >= 0)
			{
				Dictionary<string, string> dictionary = DemoMetaDataUtil.ReadDemoMetaData(Demos.DemoNameFileMap[(string)this.DemoSelector.SelectedItem] + ".tags");
				string text;
				if (dictionary.TryGetValue("embed_host", out text) && text != null)
				{
					if (text == "yt")
					{
						Process.Start("https://www.youtube.com/watch?v=" + dictionary["video_id"]);
						return;
					}
					if (!(text == "streamable"))
					{
						return;
					}
					Process.Start("https://www.streamable.com/" + dictionary["video_id"]);
				}
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0003AEC8 File Offset: 0x000390C8
		private void RefreshDemosList_Click(object sender, RoutedEventArgs e)
		{
			if (this.cache.demos_folder.Length > 0)
			{
				Demos.LoadDemos(this.cache.demos_folder, this.DemoSelector.Dispatcher);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0003AEF8 File Offset: 0x000390F8
		[STAThread]
		private void SelectDemoFolderButton_Click(object sender, RoutedEventArgs e)
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
			commonOpenFileDialog.IsFolderPicker = true;
			if (this.cache.demos_folder.Length > 0)
			{
				commonOpenFileDialog.InitialDirectory = this.cache.demos_folder;
			}
			if (commonOpenFileDialog.ShowDialog() == 1)
			{
				try
				{
					if (commonOpenFileDialog.FileName != null)
					{
						this.cache.demos_folder = commonOpenFileDialog.FileName;
						Demos.LoadDemos(this.cache.demos_folder, this.DemoMapSelector.Dispatcher);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0003AF88 File Offset: 0x00039188
		private void StreamableIntegrationButton_Click(object sender, RoutedEventArgs e)
		{
			if (this.cache.streamable_username_encrypted == null || this.cache.streamable_username_encrypted.Length == 0)
			{
				StreamableLoginDialog streamableLoginDialog = new StreamableLoginDialog();
				this.InactiveOverlay.Visibility = Visibility.Visible;
				streamableLoginDialog.Resources["DefaultBackground"] = base.Resources["DefaultBackground"];
				streamableLoginDialog.Resources["DefaultBackgroundOpaque"] = base.Resources["DefaultBackgroundOpaque"];
				streamableLoginDialog.Resources["DefaultColor"] = base.Resources["DefaultColor"];
				streamableLoginDialog.ApplicationScaleTransform.ScaleX = (double)this.WindowScale;
				streamableLoginDialog.ApplicationScaleTransform.ScaleY = (double)this.WindowScale;
				streamableLoginDialog.Width *= (double)this.WindowScale;
				streamableLoginDialog.Height *= (double)this.WindowScale;
				bool? flag = streamableLoginDialog.ShowDialog();
				bool flag2 = true;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					this.cache.SetStreamableLogin(streamableLoginDialog.username, streamableLoginDialog.password);
					Task.Run(delegate()
					{
						this.TemporaryButtonTextReplace(this.StreamableIntegrationButton, "Done!", "Disconnect Streamable", 5000);
					});
				}
				this.InactiveOverlay.Visibility = Visibility.Hidden;
			}
			else
			{
				this.cache.streamable_password_encrypted = "";
				this.cache.streamable_username_encrypted = "";
				Task.Run(delegate()
				{
					this.TemporaryButtonTextReplace(this.StreamableIntegrationButton, "Done!", "Configure Streamable", 5000);
				});
			}
			this.cache.Save();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0003B108 File Offset: 0x00039308
		public static List<int> SearchBytePattern(byte[] pattern, byte[] bytes)
		{
			List<int> list = new List<int>();
			int num = pattern.Length;
			int num2 = bytes.Length;
			byte b = pattern[0];
			for (int i = 0; i < num2; i++)
			{
				if (b == bytes[i] && num2 - i >= num)
				{
					byte[] array = new byte[num];
					Array.Copy(bytes, i, array, 0, num);
					if (array.SequenceEqual(pattern))
					{
						list.Add(i);
						i += num - 1;
					}
				}
			}
			return list;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0003B174 File Offset: 0x00039374
		public static byte[] CreateSpecialByteArray(int length)
		{
			byte[] array = new byte[length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 0;
			}
			return array;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0003B19C File Offset: 0x0003939C
		private void SaveCurrentDemo()
		{
			byte[] pattern = MainWindow.CreateSpecialByteArray(this.maxError);
			this.BO2.DefaultStringLength = 50;
			if (this.addresses.DemoSummaryAddress != IntPtr.Zero)
			{
				Structures.DemoInfo demoInfo = this.BO2.ReadStruct<Structures.DemoInfo>(this.addresses.DemoAddress1);
				byte[] bytes = this.BO2.ReadByteArray((IntPtr)demoInfo.DemoDataPtr, demoInfo.DemoSize);
				byte[] bytes2 = this.BO2.ReadByteArray(this.addresses.DemoThumbnailAddress, 255);
				int length = this.BO2.ReadInt(this.addresses.DemoSummaryLengthAddress);
				byte[] bytes3 = this.BO2.ReadByteArray(this.addresses.DemoSummaryAddress, length);
				string text = this.BO2.ReadStringASCII(this.addresses.DemoNameAddress);
				string gamemode = text.Split(new char[]
				{
					'_'
				})[0];
				string map = text.Split(new char[]
				{
					'_'
				})[1] + "_" + text.Split(new char[]
				{
					'_'
				})[2];
				if (MainWindow.SearchBytePattern(pattern, bytes).Count > 0)
				{
					DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(string.Format("This demo file has over {0} empty bytes in a row, which is an indication of error. This most likely means the demo hasn't finished loading yet, I recommend you wait 5 - 10 seconds and try again. Would you like to save this file anyway?", this.maxError), "Confirmation", MessageBoxButtons.YesNo);
					if (dialogResult != System.Windows.Forms.DialogResult.Yes && dialogResult == System.Windows.Forms.DialogResult.No)
					{
						return;
					}
				}
				DemoFileBuilder demoFileBuilder = new DemoFileBuilder(gamemode, map);
				Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
				saveFileDialog.FileName = text;
				saveFileDialog.Filter = "Demo (*.demo)|*.demo";
				saveFileDialog.ShowDialog();
				if (saveFileDialog.FileName.Contains('\\'))
				{
					if (!saveFileDialog.FileName.Contains(".demo"))
					{
						Microsoft.Win32.SaveFileDialog saveFileDialog2 = saveFileDialog;
						saveFileDialog2.FileName += ".demo";
					}
					File.WriteAllBytes(saveFileDialog.FileName, bytes);
					File.WriteAllBytes(saveFileDialog.FileName + ".summary", bytes3);
					File.WriteAllBytes(saveFileDialog.FileName + ".tags", demoFileBuilder.GetTags());
					File.WriteAllBytes(saveFileDialog.FileName + ".thumbnail", bytes2);
					System.Windows.MessageBox.Show("Ripped Demo");
				}
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000302B2 File Offset: 0x0002E4B2
		private void SaveCurentDemoButton_Click(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0003B3CC File Offset: 0x000395CC
		private void openDemoInBrowserButton_Click(object sender, RoutedEventArgs e)
		{
			if (this.DemoSelector.SelectedIndex >= 0)
			{
				Process.Start(Path.GetDirectoryName(Demos.DemoNameFileMap[(string)this.DemoSelector.SelectedItem]));
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0003B404 File Offset: 0x00039604
		private void LoadDemoFromFile_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
			openFileDialog.Filter = "BO2 Demo Files (*.demo)|*.demo|All files(*.*)|*.*";
			bool? flag = openFileDialog.ShowDialog();
			bool flag2 = true;
			if ((flag.GetValueOrDefault() == flag2 & flag != null) && openFileDialog.FileName.Length > 0 && File.Exists(openFileDialog.FileName))
			{
				this.SmartLoadDemo(openFileDialog.FileName, this.LoadDemoFromFileButton);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0003B46C File Offset: 0x0003966C
		private void ExecuteKeybind(Keybind keybind)
		{
			switch (keybind.keybindType)
			{
			case KeybindType.Click:
				(new ButtonAutomationPeer(this.controls[keybind.ControlUUID] as System.Windows.Controls.Button).GetPattern(PatternInterface.Invoke) as IInvokeProvider).Invoke();
				return;
			case KeybindType.IncreaseBy:
				if (this.controls[keybind.ControlUUID].GetType() == typeof(Slider))
				{
					(this.controls[keybind.ControlUUID] as Slider).Value += (double)keybind.Value;
					return;
				}
				break;
			case KeybindType.DecreaseBy:
				if (this.controls[keybind.ControlUUID].GetType() == typeof(Slider))
				{
					(this.controls[keybind.ControlUUID] as Slider).Value -= (double)keybind.Value;
					return;
				}
				break;
			case KeybindType.SetValue:
				if (this.controls[keybind.ControlUUID].GetType() == typeof(Slider))
				{
					(this.controls[keybind.ControlUUID] as Slider).Value = (double)keybind.Value;
					return;
				}
				break;
			case KeybindType.Toggle:
				if (this.controls[keybind.ControlUUID].GetType() == typeof(System.Windows.Controls.CheckBox))
				{
					System.Windows.Controls.CheckBox checkBox = this.controls[keybind.ControlUUID] as System.Windows.Controls.CheckBox;
					checkBox.IsChecked = !checkBox.IsChecked;
					return;
				}
				break;
			case KeybindType.SendCommand:
				this.console.Send(keybind.command);
				return;
			case KeybindType.BringToFront:
				if (!base.IsActive)
				{
					base.WindowState = WindowState.Minimized;
					base.Show();
					base.WindowState = WindowState.Normal;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0003B660 File Offset: 0x00039860
		private void AddKeybindContextMenu_Click(object sender, RoutedEventArgs e)
		{
			UIElement placementTarget = (((sender as System.Windows.Controls.MenuItem).Parent as System.Windows.Controls.ContextMenu).Parent as Popup).PlacementTarget;
			KeybindHost host;
			if (placementTarget.GetType() == typeof(System.Windows.Controls.Button))
			{
				host = KeybindHost.Button;
			}
			else if (placementTarget.GetType() == typeof(Slider))
			{
				host = KeybindHost.Slider;
			}
			else
			{
				if (!(placementTarget.GetType() == typeof(System.Windows.Controls.CheckBox)))
				{
					return;
				}
				host = KeybindHost.Checkbox;
			}
			KeybindDialog keybindDialog = new KeybindDialog(host);
			keybindDialog.Resources["DefaultBackground"] = base.Resources["DefaultBackground"];
			keybindDialog.Resources["DefaultBackgroundOpaque"] = base.Resources["DefaultBackgroundOpaque"];
			keybindDialog.Resources["DefaultColor"] = base.Resources["DefaultColor"];
			keybindDialog.ApplicationScaleTransform.ScaleX = (double)this.WindowScale;
			keybindDialog.ApplicationScaleTransform.ScaleY = (double)this.WindowScale;
			keybindDialog.Width *= (double)this.WindowScale;
			keybindDialog.Height *= (double)this.WindowScale;
			this.InactiveOverlay.Visibility = Visibility.Visible;
			bool? flag = keybindDialog.ShowDialog();
			bool flag2 = true;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				Keybind keybind = new Keybind
				{
					keybindType = keybindDialog.Type,
					ControlUUID = placementTarget.Uid,
					FriendlyName = keybindDialog.BindName
				};
				KeybindType keybindType = keybind.keybindType;
				if (keybindType - KeybindType.IncreaseBy > 2)
				{
					if (keybindType == KeybindType.SendCommand)
					{
						keybind.command = keybindDialog.Value;
					}
				}
				else
				{
					float value = float.Parse(keybindDialog.Value);
					keybind.Value = value;
				}
				if (!this.cache.Keybinds.ContainsKey(keybindDialog.Key))
				{
					this.cache.Keybinds.Add(keybindDialog.Key, keybind);
					this.KeybindsList.Items.Refresh();
					this.cache.Save();
				}
				else
				{
					System.Windows.MessageBox.Show("Error: Could not create keybind. A command is already bound to this key");
				}
			}
			this.InactiveOverlay.Visibility = Visibility.Hidden;
		}

		// Token: 0x06000167 RID: 359
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000168 RID: 360 RVA: 0x0003B88C File Offset: 0x00039A8C
		private void GlobalKeyboardHook_KeyboardPressed(object sender, GlobalKeyboardHookEventArgs e)
		{
			if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown && MainWindow.GetForegroundWindow() == this.BO2.winHandle && this.cache.Keybinds.ContainsKey(e.KeyboardData.Key))
			{
				this.ExecuteKeybind(this.cache.Keybinds[e.KeyboardData.Key]);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0003B901 File Offset: 0x00039B01
		private void SettingsTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.KeybindsList.ItemsSource = this.cache.Keybinds;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0003B91C File Offset: 0x00039B1C
		private void CustomKeybindButton_Click(object sender, RoutedEventArgs e)
		{
			KeybindDialog keybindDialog = new KeybindDialog(KeybindHost.Custom);
			keybindDialog.Resources["DefaultBackground"] = base.Resources["DefaultBackground"];
			keybindDialog.Resources["DefaultBackgroundOpaque"] = base.Resources["DefaultBackgroundOpaque"];
			keybindDialog.Resources["DefaultColor"] = base.Resources["DefaultColor"];
			keybindDialog.ApplicationScaleTransform.ScaleX = (double)this.WindowScale;
			keybindDialog.ApplicationScaleTransform.ScaleY = (double)this.WindowScale;
			keybindDialog.Width *= (double)this.WindowScale;
			keybindDialog.Height *= (double)this.WindowScale;
			this.InactiveOverlay.Visibility = Visibility.Visible;
			bool? flag = keybindDialog.ShowDialog();
			bool flag2 = true;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				Keybind keybind = new Keybind
				{
					keybindType = keybindDialog.Type,
					FriendlyName = keybindDialog.BindName
				};
				KeybindType keybindType = keybind.keybindType;
				if (keybindType - KeybindType.IncreaseBy > 2)
				{
					if (keybindType == KeybindType.SendCommand)
					{
						keybind.command = keybindDialog.Value;
					}
				}
				else
				{
					float value = float.Parse(keybindDialog.Value);
					keybind.Value = value;
				}
				this.cache.Keybinds.Add(keybindDialog.Key, keybind);
				this.KeybindsList.Items.Refresh();
				this.cache.Save();
			}
			this.InactiveOverlay.Visibility = Visibility.Hidden;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0003BAA0 File Offset: 0x00039CA0
		private void DeleteKeybindButton_Click(object sender, RoutedEventArgs e)
		{
			if (this.KeybindsList.SelectedIndex >= 0)
			{
				Keys key = ((KeyValuePair<Keys, Keybind>)this.KeybindsList.SelectedItem).Key;
				this.cache.Keybinds.Remove(key);
				this.KeybindsList.Items.Refresh();
				this.cache.Save();
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0003BB01 File Offset: 0x00039D01
		private float rnd(double value)
		{
			return (float)Math.Round(value, 2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0003BB0C File Offset: 0x00039D0C
		private string GenerateSSAOCfg()
		{
			string[] array = new string[6];
			array[0] = "//SSAO\nr_ssao ";
			int num = 1;
			bool? isChecked = this.ssaoToggle.IsChecked;
			bool flag = true;
			array[num] = ((isChecked.GetValueOrDefault() == flag & isChecked != null) ? "1\n" : "0\n");
			array[2] = string.Format("r_ssaoScale {0}\n", this.rnd(this.ssaoScaleBar.Value));
			array[3] = string.Format("r_ssaoRadius {0}\n", this.rnd(this.ssaoRadiusBar.Value));
			array[4] = string.Format("r_ssaoBias {0}\n", this.rnd(this.ssaoBiasBar.Value));
			array[5] = string.Format("r_ssaoIntensity {0}\n", this.rnd(this.ssaoIntensityBar.Value));
			return string.Concat(array);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0003BBE9 File Offset: 0x00039DE9
		private void SendSSAOtoCFGButton_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Controls.TextBox cfgtext = this.CFGText;
			cfgtext.Text = cfgtext.Text + Environment.NewLine + this.GenerateSSAOCfg();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0003BC0C File Offset: 0x00039E0C
		private string GenerateDofCFG()
		{
			string[] array = new string[14];
			array[0] = "//DOF\nr_dof_enable ";
			int num = 1;
			bool? isChecked = this.DOFEnable.IsChecked;
			bool flag = true;
			array[num] = ((isChecked.GetValueOrDefault() == flag & isChecked != null) ? "1\n" : "0\n");
			array[2] = "r_dof_tweak ";
			int num2 = 3;
			isChecked = this.DOFEnable.IsChecked;
			flag = true;
			array[num2] = ((isChecked.GetValueOrDefault() == flag & isChecked != null) ? "1\n" : "0\n");
			array[4] = string.Format("r_dof_nearBlur {0}\n", this.rnd(this.DOFNearBlurSlider.Value));
			array[5] = string.Format("r_dof_farBlur {0}\n", this.rnd(this.DOFFarBlurSider.Value));
			array[6] = string.Format("r_dof_viewModelStart {0}\n", this.rnd(this.DOFViewmodelStartSlider.Value));
			array[7] = string.Format("r_dof_viewModelEnd {0}\n", this.rnd(this.DOFViewmodelEndSlider.Value));
			array[8] = string.Format("r_dof_nearStart {0}\n", this.rnd(this.DOFNearStartSlider.Value));
			array[9] = string.Format("r_dof_nearEnd {0}\n", this.rnd(this.DOFNearEndSlider.Value));
			array[10] = string.Format("r_dof_farStart {0}\n", this.rnd(this.DOFFarStartSlider.Value));
			array[11] = string.Format("r_dof_farEnd {0}\n", this.rnd(this.DOFFarEndSlider.Value));
			array[12] = string.Format("r_dof_bias {0}\n", this.rnd(this.DOFBiasSlider.Value));
			array[13] = string.Format("r_dofHDR {0}\n", this.DOFQualitySlider.Value);
			return string.Concat(array);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0003BDF4 File Offset: 0x00039FF4
		private void SendDOFtoCFGButton_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Controls.TextBox cfgtext = this.CFGText;
			cfgtext.Text = cfgtext.Text + Environment.NewLine + this.GenerateDofCFG();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0003BE18 File Offset: 0x0003A018
		private string GenerateSunCFG()
		{
			DoubleColor doubleColor = this.SunColorWheel.Palette.Colors[0].DoubleColor;
			string[] array = new string[12];
			array[0] = "//SUN + SKY\n";
			array[1] = string.Format("r_lightTweakSunLight {0}\n", this.rnd(this.SunBrightnessSlider.Value));
			array[2] = string.Format("r_lightTweakSunColor {0} {1} {2}\n", this.rnd(doubleColor.R / this.SunBrightnessSlider.Value), this.rnd(doubleColor.G / this.SunBrightnessSlider.Value), this.rnd(doubleColor.B / this.SunBrightnessSlider.Value));
			array[3] = string.Format("r_skyColorTemp {0}\n", this.rnd(this.skyTempBar.Value));
			array[4] = string.Format("r_sky_intensity_factor0 {0}\n", this.rnd(this.skyBrightnessBar.Value));
			array[5] = "flareDisableEffects ";
			int num = 6;
			bool? isChecked = this.removeSunFlareToggle.IsChecked;
			bool flag = true;
			array[num] = ((isChecked.GetValueOrDefault() == flag & isChecked != null) ? "1" : "0");
			array[7] = "\nr_superFlareDraw ";
			int num2 = 8;
			isChecked = this.removeSunFlareToggle.IsChecked;
			flag = false;
			array[num2] = ((isChecked.GetValueOrDefault() == flag & isChecked != null) ? "1" : "0");
			array[9] = "\nr_skyTransition ";
			int num3 = 10;
			isChecked = this.skyTransitionToggle.IsChecked;
			flag = true;
			array[num3] = ((isChecked.GetValueOrDefault() == flag & isChecked != null) ? "1" : "0");
			array[11] = "\n";
			return string.Concat(array);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0003BFDB File Offset: 0x0003A1DB
		private void SendSunToCFGButton_Click(object sender, RoutedEventArgs e)
		{
			DoubleColor doubleColor = this.SunColorWheel.Palette.Colors[0].DoubleColor;
			System.Windows.Controls.TextBox cfgtext = this.CFGText;
			cfgtext.Text = cfgtext.Text + Environment.NewLine + this.GenerateSunCFG();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0003C01C File Offset: 0x0003A21C
		private string GenerateCFG()
		{
			this.ReadAndApplyGameSettings();
			return "//Automatically Generated Config File Based On Previous Settings" + Environment.NewLine + "//CFG Box Text:" + Environment.NewLine + this.CFGText.Text + Environment.NewLine + "//End of CFG Box Text" + Environment.NewLine + "Auto Generated Settings:" + this.GenerateFogCfg() + Environment.NewLine + this.GenerateSSAOCfg() + Environment.NewLine + this.GenerateDofCFG() + Environment.NewLine + this.GenerateSunCFG();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0003C0CC File Offset: 0x0003A2CC
		private Structures.Settings GenerateSettings()
		{
			Structures.Settings settings = new Structures.Settings();
			this.CFGText.Dispatcher.Invoke(delegate()
			{
				try
				{
					settings = new Structures.Settings
					{
						cfg = this.CFGText.Text,
						single = this.SingleCommandTextbox.Text,
						fog = this.GenerateFogCfg(),
						ssao = this.GenerateSSAOCfg(),
						dof = this.GenerateDofCFG(),
						sun = this.GenerateSunCFG()
					};
				}
				catch
				{
				}
			});
			return settings;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0003C114 File Offset: 0x0003A314
		private void SaveCFGButton_Click(object sender, RoutedEventArgs e)
		{
			Structures.Settings settings = this.GenerateSettings();
			Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
			saveFileDialog.Filter = "BO2 File(*.bo2)|*.bo2|All files(*.*)|*.*";
			saveFileDialog.RestoreDirectory = true;
			Microsoft.Win32.FileDialog fileDialog = saveFileDialog;
			DirectoryInfo parent = Directory.GetParent(Assembly.GetEntryAssembly().Location);
			fileDialog.InitialDirectory = ((parent != null) ? parent.ToString() : null) + "\\CFGs";
			bool? flag = saveFileDialog.ShowDialog();
			bool flag2 = true;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				string contents = JsonConvert.SerializeObject(settings, 1);
				File.WriteAllText(saveFileDialog.FileName, contents);
				Task.Run(delegate()
				{
					this.TemporaryButtonTextReplace(this.SaveCFGButton, "SAVED!", "SAVE ALL", 5000);
				});
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0003C1B0 File Offset: 0x0003A3B0
		private void LoadCFGButton_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
			openFileDialog.Filter = "BO2 File(*.bo2)|*.bo2|All files(*.*)|*.*";
			bool? flag = openFileDialog.ShowDialog();
			bool flag2 = true;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				try
				{
					Structures.Settings settings = JsonConvert.DeserializeObject<Structures.Settings>(File.ReadAllText(openFileDialog.FileName));
					this.CFGText.Text = settings.cfg;
					this.SingleCommandTextbox.Text = settings.single;
					string cfg = string.Concat(new string[]
					{
						settings.fog,
						"\n",
						settings.ssao,
						"\n",
						settings.dof,
						"\n",
						settings.sun
					});
					this.Send(cfg);
				}
				catch
				{
					System.Windows.MessageBox.Show("This BO2 File was created with an older version of the tool, and cannot currently be loaded using this version.\r\n\r\n");
				}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0003C294 File Offset: 0x0003A494
		private void SkyRotation_Dial_ValueChanged(object sender, EventArgs e)
		{
			if (this.isLoggedIn && this.writeMemory)
			{
				this.BO2.WriteFloat(this.addresses.r_skyrotation, (float)this.SkyRotation_Dial.Value);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0003C2C8 File Offset: 0x0003A4C8
		private void ResetFog()
		{
			if (DefaultFogs.Defaults.ContainsKey(this.GetMapName()))
			{
				Structures.Fog fog = DefaultFogs.Defaults[this.GetMapName()];
				this.FogToControls(fog);
				this.BO2.WriteStruct(this.addresses.Fog, fog);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0003C31C File Offset: 0x0003A51C
		private void ResetFogToDefault_Click(object sender, RoutedEventArgs e)
		{
			if (DefaultFogs.Defaults.ContainsKey(this.GetMapName()))
			{
				this.ResetFog();
				Task.Run(delegate()
				{
					this.TemporaryButtonTextReplace(this.ResetFogToDefault, "Reset!", "Reset To Default", 5000);
				});
				return;
			}
			this.BO2.ReadStruct<Structures.Fog>(this.addresses.Fog);
			Task.Run(delegate()
			{
				this.TemporaryButtonTextReplace(this.ResetFogToDefault, "Error Resetting Fog", "Reset To Default", 5000);
			});
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0003C37D File Offset: 0x0003A57D
		private void SaveTickButton_Click(object sender, RoutedEventArgs e)
		{
			this.SavedTick = this.BO2.ReadInt(this.addresses.Tick);
			this.GoToTickButton.Content = "Skip To " + this.FormatTick(this.SavedTick);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0003C3BC File Offset: 0x0003A5BC
		private void GoToTickButton_Click(object sender, RoutedEventArgs e)
		{
			Task.Run(delegate()
			{
				if (this.SavedTick > 100)
				{
					while (this.BO2.ReadInt(this.addresses.Tick) > this.SavedTick)
					{
						this.console.Send("demo_back;");
						Thread.Sleep(50);
					}
					this.console.Send("demo_pause 0;timescale 10;");
					while (this.BO2.ReadInt(this.addresses.Tick) < this.SavedTick - 1000)
					{
						Thread.Sleep(50);
					}
					this.console.Send("demo_pause 1; timescale 1");
				}
			});
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0003C3D0 File Offset: 0x0003A5D0
		private void AnimCategorySelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string str = this.AnimCategorySelector.SelectedItem.ToString();
			string path = "Anims\\" + str;
			List<string> list = new List<string>();
			foreach (string path2 in Directory.GetFiles(path))
			{
				list.Add(Path.GetFileNameWithoutExtension(path2));
			}
			this.AnimSelector.ItemsSource = list;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0003C434 File Offset: 0x0003A634
		private IntPtr HwndMessageHook(IntPtr wnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
		{
			if (msg == 562)
			{
				this.StoredSizes[this.MainTabs.SelectedIndex] = new double[]
				{
					base.Width,
					base.Height
				};
				handled = true;
			}
			return IntPtr.Zero;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0003C480 File Offset: 0x0003A680
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/BO2 Console V4;component/xaml/mainwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0003C4B0 File Offset: 0x0003A6B0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0003C4BC File Offset: 0x0003A6BC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.BO2_Console_V4 = (MainWindow)target;
				this.BO2_Console_V4.Loaded += this.Window_Loaded;
				this.BO2_Console_V4.SizeChanged += this.BO2_Console_V4_SizeChanged;
				this.BO2_Console_V4.Closing += this.BO2_Console_V4_Closing;
				return;
			case 2:
				this.MainGrid = (Grid)target;
				return;
			case 3:
				this.CloseButton = (System.Windows.Controls.Button)target;
				this.CloseButton.Click += this.CloseButton_Click;
				return;
			case 4:
				this.MinimiseButton = (System.Windows.Controls.Button)target;
				this.MinimiseButton.Click += this.MinimiseButton_Click;
				return;
			case 5:
				this.InactiveOverlay = (Grid)target;
				return;
			case 6:
				this.TabGrid = (Grid)target;
				return;
			case 7:
				this.ApplicationScaleTransform = (ScaleTransform)target;
				return;
			case 8:
				this.MainTabs = (System.Windows.Controls.TabControl)target;
				this.MainTabs.SelectionChanged += this.MainTabs_SelectionChanged;
				return;
			case 9:
				this.MainMenuGrid = (Grid)target;
				return;
			case 10:
				this.CurrentVersionLabel = (System.Windows.Controls.Label)target;
				return;
			case 11:
				this.RestoreAll = (System.Windows.Controls.Button)target;
				this.RestoreAll.Click += this.RestoreAll_Click;
				return;
			case 12:
				this.ReloadPointers = (System.Windows.Controls.Button)target;
				this.ReloadPointers.Click += this.ReloadPointers_Click;
				return;
			case 13:
				this.SettingsButton = (System.Windows.Controls.Button)target;
				this.SettingsButton.Click += this.SettingsButton_Click;
				return;
			case 14:
				this.LoadCFGButton = (System.Windows.Controls.Button)target;
				this.LoadCFGButton.Click += this.LoadCFGButton_Click;
				return;
			case 15:
				this.SaveCFGButton = (System.Windows.Controls.Button)target;
				this.SaveCFGButton.Click += this.SaveCFGButton_Click;
				return;
			case 16:
				this.waifu = (System.Windows.Controls.Image)target;
				return;
			case 17:
				this.waifu2 = (System.Windows.Controls.Image)target;
				return;
			case 18:
				this.SettingsPanel = (Grid)target;
				return;
			case 19:
				this.BackButton = (System.Windows.Controls.Button)target;
				this.BackButton.Click += this.BackButton_Click;
				return;
			case 20:
				this.SettingsTabControl = (System.Windows.Controls.TabControl)target;
				this.SettingsTabControl.SelectionChanged += this.SettingsTabControl_SelectionChanged;
				return;
			case 21:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 22:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 23:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 24:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 25:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 26:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 27:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 28:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 29:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 30:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 31:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 32:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 33:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 34:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 35:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 36:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 37:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 38:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 39:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 40:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 41:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 42:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 43:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 44:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 45:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 46:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 47:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 48:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 49:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 50:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 51:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 52:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 53:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 54:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 55:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 56:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 57:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 58:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 59:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 60:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 61:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 62:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 63:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 64:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 65:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 66:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 67:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 68:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 69:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 70:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 71:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 72:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 73:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 74:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 75:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 76:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 77:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 78:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 79:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 80:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 81:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 82:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 83:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 84:
				((System.Windows.Controls.Button)target).Click += this.Button_Click;
				return;
			case 85:
				this.FontWeightSelector = (System.Windows.Controls.ComboBox)target;
				this.FontWeightSelector.SelectionChanged += this.ComboBox_SelectionChanged;
				return;
			case 86:
				this.DarkThemeToggle = (System.Windows.Controls.RadioButton)target;
				this.DarkThemeToggle.Unchecked += this.ThemeSelector_Checked;
				this.DarkThemeToggle.Click += this.ThemeSelector_Checked;
				return;
			case 87:
				this.LightThemeToggle = (System.Windows.Controls.RadioButton)target;
				this.LightThemeToggle.Unchecked += this.ThemeSelector_Checked;
				this.LightThemeToggle.Click += this.ThemeSelector_Checked;
				return;
			case 88:
				this.FontSizeSelector = (System.Windows.Controls.ComboBox)target;
				this.FontSizeSelector.SelectionChanged += this.FontSizeSelector_Changed;
				return;
			case 89:
				this.WindowScaleSelector = (System.Windows.Controls.ComboBox)target;
				this.WindowScaleSelector.SelectionChanged += this.WindowScaleSelector_Changed;
				return;
			case 90:
				this.AutofillModeSelector = (System.Windows.Controls.ComboBox)target;
				this.AutofillModeSelector.SelectionChanged += this.AutofillModeChanged;
				return;
			case 91:
				this.AutofillLimitSelector = (System.Windows.Controls.ComboBox)target;
				this.AutofillLimitSelector.SelectionChanged += this.AutofillModeChanged;
				return;
			case 92:
				this.ThemeHexCode = (System.Windows.Controls.TextBox)target;
				this.ThemeHexCode.TextChanged += this.ThemeHexCode_TextChanged;
				return;
			case 93:
				this.ThemeHexCode_Background = (System.Windows.Controls.TextBox)target;
				this.ThemeHexCode_Background.TextChanged += this.BackgroundHexCode_TextChanged;
				return;
			case 94:
				this.StreamableIntegrationButton = (System.Windows.Controls.Button)target;
				this.StreamableIntegrationButton.Click += this.StreamableIntegrationButton_Click;
				return;
			case 95:
				this.PersistOnReload = (System.Windows.Controls.CheckBox)target;
				return;
			case 96:
				this.KeybindsList = (System.Windows.Controls.ListView)target;
				return;
			case 97:
				this.CustomKeybindButton = (System.Windows.Controls.Button)target;
				this.CustomKeybindButton.Click += this.CustomKeybindButton_Click;
				return;
			case 98:
				this.DeleteKeybindButton = (System.Windows.Controls.Button)target;
				this.DeleteKeybindButton.Click += this.DeleteKeybindButton_Click;
				return;
			case 99:
				this.PluginListBox = (System.Windows.Controls.ListBox)target;
				this.PluginListBox.SelectionChanged += this.PluginListBox_SelectionChanged;
				return;
			case 100:
				this.PluginNameBox = (System.Windows.Controls.TextBox)target;
				return;
			case 101:
				this.PluginAuthorBox = (System.Windows.Controls.TextBox)target;
				return;
			case 102:
				this.PluginDescBox = (System.Windows.Controls.TextBox)target;
				return;
			case 103:
				this.PluginEnabledBox = (System.Windows.Controls.CheckBox)target;
				this.PluginEnabledBox.Checked += this.PluginEnabledBox_Checked;
				this.PluginEnabledBox.Unchecked += this.PluginEnabledBox_Checked;
				return;
			case 104:
				this.VerifiedPluginLabel = (System.Windows.Controls.Label)target;
				return;
			case 105:
				this.PluginHash = (System.Windows.Controls.TextBox)target;
				return;
			case 106:
				this.LoginPanel = (Grid)target;
				return;
			case 107:
				this.LoginTextbox = (System.Windows.Controls.TextBox)target;
				return;
			case 108:
				this.GetIDButton = (System.Windows.Controls.Label)target;
				this.GetIDButton.MouseLeftButtonUp += this.GetIDButton_MouseLeftButtonUp;
				return;
			case 109:
				this.LoginButton = (System.Windows.Controls.Button)target;
				this.LoginButton.Click += this.LoginButton_Click;
				return;
			case 110:
				this.LoginProgress = (System.Windows.Controls.ProgressBar)target;
				return;
			case 111:
				this.GetIDGrid = (Grid)target;
				return;
			case 112:
				this.NameTextbox = (System.Windows.Controls.TextBox)target;
				this.NameTextbox.TextChanged += this.NameTextbox_TextChanged;
				return;
			case 113:
				this.IDTextBox = (System.Windows.Controls.TextBox)target;
				return;
			case 114:
				this.SendSingle = (System.Windows.Controls.Button)target;
				this.SendSingle.Click += this.SendSingle_Click;
				return;
			case 115:
				this.tScaleBox = (System.Windows.Controls.TextBox)target;
				this.tScaleBox.TextChanged += this.TScaleBox_TextChanged;
				return;
			case 116:
				this.sendTScale = (System.Windows.Controls.Button)target;
				this.sendTScale.Click += this.SendTScale_Click;
				return;
			case 117:
				this.CFGText = (System.Windows.Controls.TextBox)target;
				return;
			case 118:
				this.LoadCFG = (System.Windows.Controls.Button)target;
				this.LoadCFG.Click += this.LoadCFG_Click;
				return;
			case 119:
				this.SendCFG = (System.Windows.Controls.Button)target;
				this.SendCFG.Click += this.SendCFG_Click;
				return;
			case 120:
				this.SaveCFG = (System.Windows.Controls.Button)target;
				this.SaveCFG.Click += this.SaveCFG_Click;
				return;
			case 121:
				this.SingleCommandTextbox = (AutoCompleteBox)target;
				this.SingleCommandTextbox.KeyUp += this.SingleCommandTextbox_KeyUp;
				this.SingleCommandTextbox.Populating += new PopulatingEventHandler(this.SingleCommandTextbox_Populating);
				return;
			case 122:
				this.CFGExpander = (Expander)target;
				this.CFGExpander.Expanded += this.CFGExpander_Expanded;
				return;
			case 123:
				this.CFGList = (System.Windows.Controls.ListBox)target;
				this.CFGList.MouseDoubleClick += this.CFGList_MouseDoubleClick;
				return;
			case 124:
				this.AddToCFGButton = (System.Windows.Controls.Button)target;
				this.AddToCFGButton.Click += this.SendToCFGBox_Click;
				return;
			case 125:
				this.FogBaseDistanceSlider = (Slider)target;
				this.FogBaseDistanceSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 126:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 127:
				this.FogFadeSlider = (Slider)target;
				this.FogFadeSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 128:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 129:
				this.FogHeightFadeSlider = (Slider)target;
				this.FogHeightFadeSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 130:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 131:
				this.SunHazeStartRadiusSlider = (Slider)target;
				this.SunHazeStartRadiusSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 132:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 133:
				this.SunHazeEndRadiusSlider = (Slider)target;
				this.SunHazeEndRadiusSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 134:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 135:
				this.FogBrightnessSlider = (Slider)target;
				this.FogBrightnessSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 136:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 137:
				this.SunHazeBrightnessSlider = (Slider)target;
				this.SunHazeBrightnessSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 138:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 139:
				this.FogColorWheel = (ColorWheelControl)target;
				this.FogColorWheel.ColorsUpdated += this.FogColorWheel_ColorUpdated;
				return;
			case 140:
				this.FogHazeColorWheel = (ColorWheelControl)target;
				this.FogHazeColorWheel.ColorsUpdated += this.FogHazeColorUpdated;
				return;
			case 141:
				this.BrightnessSlider = (Slider)target;
				this.BrightnessSlider.ValueChanged += this.Brightness_ValueChanged;
				return;
			case 142:
				this.HazeBrightnessSlider = (Slider)target;
				this.HazeBrightnessSlider.ValueChanged += this.HazeBrightness_ValueChanged;
				return;
			case 143:
				this.FogHeightStartSlider = (Slider)target;
				this.FogHeightStartSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 144:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 145:
				this.LoadFogPresetDropdown = (System.Windows.Controls.ComboBox)target;
				this.LoadFogPresetDropdown.SelectionChanged += this.LoadFogPresetDropdown_SelectionChanged;
				this.LoadFogPresetDropdown.PreviewMouseLeftButtonDown += this.LoadFogPresetDropdown_MouseUp;
				return;
			case 146:
				this.SaveFogPresetButton = (System.Windows.Controls.Button)target;
				this.SaveFogPresetButton.Click += this.SaveFogPresetButton_Click;
				return;
			case 147:
				this.LoadFogPreset = (System.Windows.Controls.Button)target;
				this.LoadFogPreset.Click += this.LoadFogPreset_Click;
				return;
			case 148:
				this.AddFogToCFG = (System.Windows.Controls.Button)target;
				this.AddFogToCFG.Click += this.AddFogToCFG_Click;
				return;
			case 149:
				this.ResetFogToDefault = (System.Windows.Controls.Button)target;
				this.ResetFogToDefault.Click += this.ResetFogToDefault_Click;
				return;
			case 150:
				this.RandomFogButton = (System.Windows.Controls.Button)target;
				this.RandomFogButton.Click += this.RandomFogButton_Click;
				return;
			case 151:
				this.SyncFogColorsToggle = (System.Windows.Controls.CheckBox)target;
				return;
			case 152:
				this.SyncSunFogToSunColor = (System.Windows.Controls.CheckBox)target;
				return;
			case 153:
				this.SunHazeAngleSlider = (Dial)target;
				return;
			case 154:
				this.SunHazePitchSlider = (Dial)target;
				return;
			case 155:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 156:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 157:
				this.gsEnable = (System.Windows.Controls.CheckBox)target;
				this.gsEnable.Checked += this.gsEnable_Checked;
				this.gsEnable.Unchecked += this.gsEnable_Checked;
				return;
			case 158:
				this.gpEnable = (System.Windows.Controls.CheckBox)target;
				this.gpEnable.Checked += this.gpEnable_Checked;
				this.gpEnable.Unchecked += this.gpEnable_Checked;
				return;
			case 159:
				this.depthEnable = (System.Windows.Controls.CheckBox)target;
				this.depthEnable.Checked += this.depthEnable_Checked;
				this.depthEnable.Unchecked += this.depthEnable_Checked;
				return;
			case 160:
				this.depthByFog = (System.Windows.Controls.RadioButton)target;
				return;
			case 161:
				this.depthByBuffer = (System.Windows.Controls.RadioButton)target;
				this.depthByBuffer.Checked += this.DepthByBuffer_Checked;
				this.depthByBuffer.Unchecked += this.DepthByBuffer_Checked;
				return;
			case 162:
				this.greenPlayersGrid = (Grid)target;
				return;
			case 163:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 164:
				this.playersRbar = (Slider)target;
				this.playersRbar.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 165:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 166:
				this.playersGbar = (Slider)target;
				this.playersGbar.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 167:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 168:
				this.playersBbar = (Slider)target;
				this.playersBbar.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 169:
				this.depthColorWheel = (ColorWheelControl)target;
				this.depthColorWheel.ColorsUpdated += this.depthColorWheel_ColorUpdated;
				return;
			case 170:
				this.depthBrightnessBar = (Slider)target;
				this.depthBrightnessBar.ValueChanged += this.depthBrightnessBar_ValueChanged;
				return;
			case 171:
				this.removeGun = (System.Windows.Controls.CheckBox)target;
				this.removeGun.Checked += this.removeGun_Checked;
				this.removeGun.Unchecked += this.removeGun_Checked;
				return;
			case 172:
				this.removeSkull = (System.Windows.Controls.CheckBox)target;
				this.removeSkull.Checked += this.removeSkull_Checked;
				this.removeSkull.Unchecked += this.removeSkull_Checked;
				return;
			case 173:
				this.removePlayers = (System.Windows.Controls.CheckBox)target;
				this.removePlayers.Checked += this.removePlayers_Checked;
				this.removePlayers.Unchecked += this.removePlayers_Checked;
				return;
			case 174:
				this.bloomTweaksToggle = (System.Windows.Controls.CheckBox)target;
				this.bloomTweaksToggle.Checked += this.bloomTweaksToggle_Checked;
				this.bloomTweaksToggle.Unchecked += this.bloomTweaksToggle_Checked;
				return;
			case 175:
				this.greenSkyToggle = (System.Windows.Controls.CheckBox)target;
				this.greenSkyToggle.Checked += this.greenSkyToggle_Checked;
				this.greenSkyToggle.Unchecked += this.greenSkyToggle_Checked;
				return;
			case 176:
				this.tBarrierRemove = (System.Windows.Controls.CheckBox)target;
				this.tBarrierRemove.Checked += this.tBarrierRemove_Checked;
				this.tBarrierRemove.Unchecked += this.tBarrierRemove_Checked;
				return;
			case 177:
				this.WireframeToggle = (System.Windows.Controls.CheckBox)target;
				this.WireframeToggle.Checked += this.WireframeToggle_CheckedChanged;
				this.WireframeToggle.Unchecked += this.WireframeToggle_CheckedChanged;
				return;
			case 178:
				this.ParticlesToggle = (System.Windows.Controls.CheckBox)target;
				this.ParticlesToggle.Unchecked += this.ParticlesToggle_CheckedChanged;
				this.ParticlesToggle.Checked += this.ParticlesToggle_CheckedChanged;
				return;
			case 179:
				this.gsR = (System.Windows.Controls.RadioButton)target;
				this.gsR.Checked += this.gsColor_Checked;
				return;
			case 180:
				this.gsG = (System.Windows.Controls.RadioButton)target;
				this.gsG.Checked += this.gsColor_Checked;
				return;
			case 181:
				this.gsB = (System.Windows.Controls.RadioButton)target;
				this.gsB.Checked += this.gsColor_Checked;
				return;
			case 182:
				this.gsP = (System.Windows.Controls.RadioButton)target;
				this.gsP.Checked += this.gsColor_Checked;
				return;
			case 183:
				this.DepthDistanceSlider = (Slider)target;
				this.DepthDistanceSlider.ValueChanged += this.DepthDistanceSlider_ValueChanged;
				return;
			case 184:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 185:
				this.PlayersAlphaCheckbox = (System.Windows.Controls.CheckBox)target;
				this.PlayersAlphaCheckbox.Unchecked += this.PlayersAlphaCheckbox_Checked;
				this.PlayersAlphaCheckbox.Checked += this.PlayersAlphaCheckbox_Checked;
				return;
			case 186:
				this.NormalMapGrid = (Grid)target;
				return;
			case 187:
				this.NormalPassDefaultRadioButton = (System.Windows.Controls.RadioButton)target;
				this.NormalPassDefaultRadioButton.Checked += this.NormalPassToggle_Changed;
				return;
			case 188:
				((System.Windows.Controls.RadioButton)target).Checked += this.NormalPassToggle_Changed;
				return;
			case 189:
				((System.Windows.Controls.RadioButton)target).Checked += this.NormalPassToggle_Changed;
				return;
			case 190:
				((System.Windows.Controls.RadioButton)target).Checked += this.NormalPassToggle_Changed;
				return;
			case 191:
				((System.Windows.Controls.RadioButton)target).Checked += this.NormalPassToggle_Changed;
				return;
			case 192:
				((System.Windows.Controls.RadioButton)target).Checked += this.NormalPassToggle_Changed;
				return;
			case 193:
				this.___No_Name_ = (System.Windows.Controls.Label)target;
				return;
			case 194:
				this.MaterialsPatchSelector = (System.Windows.Controls.ComboBox)target;
				this.MaterialsPatchSelector.SelectionChanged += this.MaterialsPatchSelector_SelectionChanged;
				return;
			case 195:
				this.IncludeWeaponsInPlayerPass = (System.Windows.Controls.CheckBox)target;
				this.IncludeWeaponsInPlayerPass.Checked += this.IncludeWeaponsInPlayerPass_CheckedChanged;
				this.IncludeWeaponsInPlayerPass.Unchecked += this.IncludeWeaponsInPlayerPass_CheckedChanged;
				return;
			case 196:
				this.TickLabel = (System.Windows.Controls.Label)target;
				return;
			case 197:
				this.SaveTickButton = (System.Windows.Controls.Button)target;
				this.SaveTickButton.Click += this.SaveTickButton_Click;
				return;
			case 198:
				this.GoToTickButton = (System.Windows.Controls.Button)target;
				this.GoToTickButton.Click += this.GoToTickButton_Click;
				return;
			case 199:
				this.TheaterProgressBar = (System.Windows.Controls.ProgressBar)target;
				return;
			case 200:
				this.ssaoToggle = (System.Windows.Controls.CheckBox)target;
				this.ssaoToggle.Checked += this.SsaoToggle_Checked;
				this.ssaoToggle.Unchecked += this.SsaoToggle_Checked;
				return;
			case 201:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 202:
				this.ssaoScaleBar = (Slider)target;
				this.ssaoScaleBar.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 203:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 204:
				this.ssaoRadiusBar = (Slider)target;
				this.ssaoRadiusBar.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 205:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 206:
				this.ssaoBiasBar = (Slider)target;
				this.ssaoBiasBar.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 207:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 208:
				this.ssaoIntensityBar = (Slider)target;
				this.ssaoIntensityBar.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 209:
				this.SendSSAOtoCFGButton = (System.Windows.Controls.Button)target;
				this.SendSSAOtoCFGButton.Click += this.SendSSAOtoCFGButton_Click;
				return;
			case 210:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 211:
				this.ssaoDistanceSlider = (Slider)target;
				this.ssaoDistanceSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 212:
				this.DOFEnable = (System.Windows.Controls.CheckBox)target;
				this.DOFEnable.Checked += this.DOFEnable_Checked;
				this.DOFEnable.Unchecked += this.DOFEnable_Checked;
				return;
			case 213:
				this.DOFFarBlurSider = (Slider)target;
				this.DOFFarBlurSider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 214:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 215:
				this.DOFFarStartSlider = (Slider)target;
				this.DOFFarStartSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 216:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 217:
				this.DOFFarEndSlider = (Slider)target;
				this.DOFFarEndSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 218:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 219:
				this.DOFNearBlurSlider = (Slider)target;
				this.DOFNearBlurSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 220:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 221:
				this.DOFNearStartSlider = (Slider)target;
				this.DOFNearStartSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 222:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 223:
				this.DOFNearEndSlider = (Slider)target;
				this.DOFNearEndSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 224:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 225:
				this.DOFViewmodelStartSlider = (Slider)target;
				this.DOFViewmodelStartSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 226:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 227:
				this.DOFViewmodelEndSlider = (Slider)target;
				this.DOFViewmodelEndSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 228:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 229:
				this.DOFBiasSlider = (Slider)target;
				this.DOFBiasSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 230:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 231:
				this.DOFQualitySlider = (Slider)target;
				this.DOFQualitySlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 232:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 233:
				this.SendDOFtoCFGButton = (System.Windows.Controls.Button)target;
				this.SendDOFtoCFGButton.Click += this.SendDOFtoCFGButton_Click;
				return;
			case 234:
				this.SunXSlider = (Slider)target;
				this.SunXSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 235:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 236:
				this.SunYSlider = (Slider)target;
				this.SunYSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 237:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 238:
				this.SunZSlider = (Slider)target;
				this.SunZSlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 239:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 240:
				this.SunColorWheel = (ColorWheelControl)target;
				this.SunColorWheel.ColorsUpdated += this.SunColorWheel_ColorUpdated;
				return;
			case 241:
				this.SunBrightnessSlider = (Slider)target;
				this.SunBrightnessSlider.ValueChanged += this.SunBrightness_ValueChanged;
				return;
			case 242:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 243:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 244:
				this.SendSunToCFGButton = (System.Windows.Controls.Button)target;
				this.SendSunToCFGButton.Click += this.SendSunToCFGButton_Click;
				return;
			case 245:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 246:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				return;
			case 247:
				this.skyTempBar = (Slider)target;
				this.skyTempBar.ValueChanged += this.skyTempBar_ValueChanged;
				return;
			case 248:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				return;
			case 249:
				this.skyBrightnessBar = (Slider)target;
				this.skyBrightnessBar.ValueChanged += this.skyBrightnessBar_ValueChanged;
				return;
			case 250:
				this.skyTransitionToggle = (System.Windows.Controls.CheckBox)target;
				this.skyTransitionToggle.Checked += this.SkyTransitionToggle_Checked;
				this.skyTransitionToggle.Unchecked += this.SkyTransitionToggle_Checked;
				return;
			case 251:
				this.removeSunFlareToggle = (System.Windows.Controls.CheckBox)target;
				this.removeSunFlareToggle.Checked += this.RemoveSunFlareToggle_Checked;
				this.removeSunFlareToggle.Unchecked += this.RemoveSunFlareToggle_Checked;
				return;
			case 252:
				this.SyncSkyTemp = (System.Windows.Controls.CheckBox)target;
				this.SyncSkyTemp.Checked += this.RemoveSunFlareToggle_Checked;
				return;
			case 253:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				return;
			case 254:
				this.SunQualitySlider = (Slider)target;
				this.SunQualitySlider.ValueChanged += this.MemorySlider_ValueChanged;
				return;
			case 255:
				this.SunPitchDial = (Dial)target;
				return;
			case 256:
				this.SunYawDial = (Dial)target;
				return;
			case 257:
				((System.Windows.Controls.TextBox)target).MouseDoubleClick += this.TextBox_MouseDoubleClick;
				((System.Windows.Controls.TextBox)target).KeyDown += this.TextBox_KeyUp;
				return;
			case 258:
				this.SkyRotation_Dial = (Dial)target;
				return;
			case 259:
				this.WeaponClassSelector = (System.Windows.Controls.ListBox)target;
				this.WeaponClassSelector.SelectionChanged += this.WeaponClassSelector_SelectionChanged;
				return;
			case 260:
				this.WeaponSelector = (System.Windows.Controls.ListBox)target;
				this.WeaponSelector.SelectionChanged += this.WeaponSelector_SelectionChanged;
				return;
			case 261:
				this.grdChampions = (Grid)target;
				return;
			case 262:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 263:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 264:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 265:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 266:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 267:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 268:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 269:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 270:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 271:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 272:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 273:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 274:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 275:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 276:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 277:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 278:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 279:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 280:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 281:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 282:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 283:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 284:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 285:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 286:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 287:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 288:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 289:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 290:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 291:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 292:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 293:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 294:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 295:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 296:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 297:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 298:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 299:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 300:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 301:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 302:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 303:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 304:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 305:
				((System.Windows.Controls.Button)target).Click += this.CamoSelector_Click;
				return;
			case 306:
				this.ClearWeaponsButton = (System.Windows.Controls.Button)target;
				this.ClearWeaponsButton.Click += this.ClearWeaponsButton_Click;
				return;
			case 307:
				this.WeaponChangerToggle = (System.Windows.Controls.Button)target;
				this.WeaponChangerToggle.Click += this.WeaponChangerToggle_Click;
				return;
			case 308:
				this.AnimViewer = (System.Windows.Controls.Image)target;
				return;
			case 309:
				this.AnimCategorySelector = (System.Windows.Controls.ListBox)target;
				this.AnimCategorySelector.SelectionChanged += this.AnimCategorySelector_SelectionChanged;
				return;
			case 310:
				this.AnimSelector = (System.Windows.Controls.ListBox)target;
				this.AnimSelector.SelectionChanged += this.AnimSelector_SelectionChanged;
				return;
			case 311:
				this.AnimSearcher = (AutoCompleteBox)target;
				return;
			case 312:
				this.appbar_arrow_left = (Canvas)target;
				return;
			case 313:
				this.Anim1Textbox = (AutoCompleteBox)target;
				this.Anim1Textbox.Populating += new PopulatingEventHandler(this.AnimationSearch_Populating);
				return;
			case 314:
				this.Anim2Textbox = (AutoCompleteBox)target;
				this.Anim2Textbox.Populating += new PopulatingEventHandler(this.AnimationSearch_Populating);
				return;
			case 315:
				this.TargetAnimationRadio = (System.Windows.Controls.RadioButton)target;
				return;
			case 316:
				this.SourceAnimationRadio = (System.Windows.Controls.RadioButton)target;
				return;
			case 317:
				this.SwapAnimationButton = (System.Windows.Controls.Button)target;
				this.SwapAnimationButton.Click += this.SwapAnimationButton_Click;
				return;
			case 318:
				this.RestoreTargetAnimation = (System.Windows.Controls.Button)target;
				return;
			case 319:
				this.RestoreAllAnimations = (System.Windows.Controls.Button)target;
				this.RestoreAllAnimations.Click += this.RestoreAllAnimations_Click;
				return;
			case 320:
				this.demoPreviewerWebView = (WebView)target;
				return;
			case 321:
				this.DemoMapSelector = (System.Windows.Controls.ListBox)target;
				this.DemoMapSelector.SelectionChanged += this.DemoMapSelector_SelectionChanged;
				return;
			case 322:
				this.DemoSelector = (System.Windows.Controls.ListBox)target;
				this.DemoSelector.SelectionChanged += this.DemoSelector_SelectionChanged;
				return;
			case 323:
				this.EditDemoMetadataButton = (System.Windows.Controls.Button)target;
				this.EditDemoMetadataButton.Click += this.EditDemoMetadataButton_Click;
				return;
			case 324:
				this.DemoSkipProgressBar = (System.Windows.Controls.ProgressBar)target;
				return;
			case 325:
				this.DemoDescriptionTextbox = (System.Windows.Controls.TextBox)target;
				return;
			case 326:
				this.EndDemoPlaybackButton = (System.Windows.Controls.Button)target;
				this.EndDemoPlaybackButton.Click += this.EndDemoPlayback_Click;
				return;
			case 327:
				this.OpenInBrowserButton = (System.Windows.Controls.Button)target;
				this.OpenInBrowserButton.Click += this.OpenInBrowser;
				return;
			case 328:
				this.RefreshDemosList = (System.Windows.Controls.Button)target;
				this.RefreshDemosList.Click += this.RefreshDemosList_Click;
				return;
			case 329:
				this.SelectDemoFolderButton = (System.Windows.Controls.Button)target;
				this.SelectDemoFolderButton.Click += this.SelectDemoFolderButton_Click;
				return;
			case 330:
				this.SaveCurrentDemoButton = (System.Windows.Controls.Button)target;
				this.SaveCurrentDemoButton.Click += this.SaveCurentDemoButton_Click;
				return;
			case 331:
				this.openDemoInBrowserButton = (System.Windows.Controls.Button)target;
				this.openDemoInBrowserButton.Click += this.openDemoInBrowserButton_Click;
				return;
			case 332:
				this.LoadSelectedDemoButton = (System.Windows.Controls.Button)target;
				this.LoadSelectedDemoButton.Click += this.LoadSelectedDemoButton_Click;
				return;
			case 333:
				this.LoadDemoFromFileButton = (System.Windows.Controls.Button)target;
				this.LoadDemoFromFileButton.Click += this.LoadDemoFromFile_Click;
				return;
			case 334:
				this.CreateCustomSliderButton = (System.Windows.Controls.Button)target;
				this.CreateCustomSliderButton.Click += this.CreateCustomSliderButton_Click;
				return;
			case 335:
				this.CustomSliderListBox = (System.Windows.Controls.ListBox)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000194 RID: 404
		private float WindowScale = 1f;

		// Token: 0x04000195 RID: 405
		private ExternalConsole console = new ExternalConsole();

		// Token: 0x04000196 RID: 406
		private Addresses addresses = new Addresses();

		// Token: 0x04000197 RID: 407
		private AiryzMemory BO2;

		// Token: 0x04000198 RID: 408
		private Cache cache = new Cache();

		// Token: 0x04000199 RID: 409
		private bool writeMemory;

		// Token: 0x0400019A RID: 410
		private bool initialised;

		// Token: 0x0400019B RID: 411
		private bool isLoggedIn;

		// Token: 0x0400019C RID: 412
		private string UUID = GetID.LastID();

		// Token: 0x0400019D RID: 413
		private Thread checkGameThread;

		// Token: 0x0400019E RID: 414
		private ICollection<PluginLoader.Plugin> plugins;

		// Token: 0x0400019F RID: 415
		private ICollection<IBO2Plugin> LoadedPlugins = new List<IBO2Plugin>();

		// Token: 0x040001A0 RID: 416
		private Dictionary<string, object> controls = new Dictionary<string, object>();

		// Token: 0x040001A1 RID: 417
		private UIDGenerator gen;

		// Token: 0x040001A2 RID: 418
		private GlobalKeyboardHook globalKeyboardHook = new GlobalKeyboardHook(null);

		// Token: 0x040001A3 RID: 419
		private VersionInfo versionInfo = new VersionInfo();

		// Token: 0x040001A4 RID: 420
		private string currentSessionName;

		// Token: 0x040001A5 RID: 421
		private const int WmExitSizeMove = 562;

		// Token: 0x040001A6 RID: 422
		private bool sentViaCode;

		// Token: 0x040001A7 RID: 423
		private const int GWL_STYLE = -16;

		// Token: 0x040001A8 RID: 424
		private const int WS_SYSMENU = 524288;

		// Token: 0x040001A9 RID: 425
		private bool updateSun = true;

		// Token: 0x040001AA RID: 426
		private IntPtr SSAODistanceAllocatedMemory = IntPtr.Zero;

		// Token: 0x040001AB RID: 427
		private byte[] GreenScreenColor;

		// Token: 0x040001AC RID: 428
		private IntPtr playerMaterialPatch = IntPtr.Zero;

		// Token: 0x040001AD RID: 429
		private IntPtr heroWeaponLighting = IntPtr.Zero;

		// Token: 0x040001AE RID: 430
		private bool ssaoWasOn;

		// Token: 0x040001AF RID: 431
		private bool removeGunWasEnabled;

		// Token: 0x040001B0 RID: 432
		private bool removeFlareWasEnabled;

		// Token: 0x040001B1 RID: 433
		private Structures.Fog preDepthfog;

		// Token: 0x040001B2 RID: 434
		private byte oldSkullValue;

		// Token: 0x040001B3 RID: 435
		private byte[] unNop;

		// Token: 0x040001B4 RID: 436
		private bool persist_settings;

		// Token: 0x040001B5 RID: 437
		private bool ProgramaticallyChangedSize = true;

		// Token: 0x040001B6 RID: 438
		private Dictionary<int, double[]> StoredSizes = new Dictionary<int, double[]>();

		// Token: 0x040001B7 RID: 439
		private float originalExposure;

		// Token: 0x040001B8 RID: 440
		private static Random random = new Random();

		// Token: 0x040001B9 RID: 441
		private Enums.debugShader shader;

		// Token: 0x040001BA RID: 442
		private bool oldBloomTweaks;

		// Token: 0x040001BB RID: 443
		private int model;

		// Token: 0x040001BC RID: 444
		private bool cancelFastForard;

		// Token: 0x040001BD RID: 445
		private int maxError = 50;

		// Token: 0x040001BE RID: 446
		private int SavedTick;

		// Token: 0x040001BF RID: 447
		internal MainWindow BO2_Console_V4;

		// Token: 0x040001C0 RID: 448
		internal Grid MainGrid;

		// Token: 0x040001C1 RID: 449
		internal System.Windows.Controls.Button CloseButton;

		// Token: 0x040001C2 RID: 450
		internal System.Windows.Controls.Button MinimiseButton;

		// Token: 0x040001C3 RID: 451
		internal Grid InactiveOverlay;

		// Token: 0x040001C4 RID: 452
		internal Grid TabGrid;

		// Token: 0x040001C5 RID: 453
		internal ScaleTransform ApplicationScaleTransform;

		// Token: 0x040001C6 RID: 454
		internal System.Windows.Controls.TabControl MainTabs;

		// Token: 0x040001C7 RID: 455
		internal Grid MainMenuGrid;

		// Token: 0x040001C8 RID: 456
		internal System.Windows.Controls.Label CurrentVersionLabel;

		// Token: 0x040001C9 RID: 457
		internal System.Windows.Controls.Button RestoreAll;

		// Token: 0x040001CA RID: 458
		internal System.Windows.Controls.Button ReloadPointers;

		// Token: 0x040001CB RID: 459
		internal System.Windows.Controls.Button SettingsButton;

		// Token: 0x040001CC RID: 460
		internal System.Windows.Controls.Button LoadCFGButton;

		// Token: 0x040001CD RID: 461
		internal System.Windows.Controls.Button SaveCFGButton;

		// Token: 0x040001CE RID: 462
		internal System.Windows.Controls.Image waifu;

		// Token: 0x040001CF RID: 463
		internal System.Windows.Controls.Image waifu2;

		// Token: 0x040001D0 RID: 464
		internal Grid SettingsPanel;

		// Token: 0x040001D1 RID: 465
		internal System.Windows.Controls.Button BackButton;

		// Token: 0x040001D2 RID: 466
		internal System.Windows.Controls.TabControl SettingsTabControl;

		// Token: 0x040001D3 RID: 467
		internal System.Windows.Controls.ComboBox FontWeightSelector;

		// Token: 0x040001D4 RID: 468
		internal System.Windows.Controls.RadioButton DarkThemeToggle;

		// Token: 0x040001D5 RID: 469
		internal System.Windows.Controls.RadioButton LightThemeToggle;

		// Token: 0x040001D6 RID: 470
		internal System.Windows.Controls.ComboBox FontSizeSelector;

		// Token: 0x040001D7 RID: 471
		internal System.Windows.Controls.ComboBox WindowScaleSelector;

		// Token: 0x040001D8 RID: 472
		internal System.Windows.Controls.ComboBox AutofillModeSelector;

		// Token: 0x040001D9 RID: 473
		internal System.Windows.Controls.ComboBox AutofillLimitSelector;

		// Token: 0x040001DA RID: 474
		internal System.Windows.Controls.TextBox ThemeHexCode;

		// Token: 0x040001DB RID: 475
		internal System.Windows.Controls.TextBox ThemeHexCode_Background;

		// Token: 0x040001DC RID: 476
		internal System.Windows.Controls.Button StreamableIntegrationButton;

		// Token: 0x040001DD RID: 477
		internal System.Windows.Controls.CheckBox PersistOnReload;

		// Token: 0x040001DE RID: 478
		internal System.Windows.Controls.ListView KeybindsList;

		// Token: 0x040001DF RID: 479
		internal System.Windows.Controls.Button CustomKeybindButton;

		// Token: 0x040001E0 RID: 480
		internal System.Windows.Controls.Button DeleteKeybindButton;

		// Token: 0x040001E1 RID: 481
		internal System.Windows.Controls.ListBox PluginListBox;

		// Token: 0x040001E2 RID: 482
		internal System.Windows.Controls.TextBox PluginNameBox;

		// Token: 0x040001E3 RID: 483
		internal System.Windows.Controls.TextBox PluginAuthorBox;

		// Token: 0x040001E4 RID: 484
		internal System.Windows.Controls.TextBox PluginDescBox;

		// Token: 0x040001E5 RID: 485
		internal System.Windows.Controls.CheckBox PluginEnabledBox;

		// Token: 0x040001E6 RID: 486
		internal System.Windows.Controls.Label VerifiedPluginLabel;

		// Token: 0x040001E7 RID: 487
		internal System.Windows.Controls.TextBox PluginHash;

		// Token: 0x040001E8 RID: 488
		internal Grid LoginPanel;

		// Token: 0x040001E9 RID: 489
		internal System.Windows.Controls.TextBox LoginTextbox;

		// Token: 0x040001EA RID: 490
		internal System.Windows.Controls.Label GetIDButton;

		// Token: 0x040001EB RID: 491
		internal System.Windows.Controls.Button LoginButton;

		// Token: 0x040001EC RID: 492
		internal System.Windows.Controls.ProgressBar LoginProgress;

		// Token: 0x040001ED RID: 493
		internal Grid GetIDGrid;

		// Token: 0x040001EE RID: 494
		internal System.Windows.Controls.TextBox NameTextbox;

		// Token: 0x040001EF RID: 495
		internal System.Windows.Controls.TextBox IDTextBox;

		// Token: 0x040001F0 RID: 496
		internal System.Windows.Controls.Button SendSingle;

		// Token: 0x040001F1 RID: 497
		internal System.Windows.Controls.TextBox tScaleBox;

		// Token: 0x040001F2 RID: 498
		internal System.Windows.Controls.Button sendTScale;

		// Token: 0x040001F3 RID: 499
		internal System.Windows.Controls.TextBox CFGText;

		// Token: 0x040001F4 RID: 500
		internal System.Windows.Controls.Button LoadCFG;

		// Token: 0x040001F5 RID: 501
		internal System.Windows.Controls.Button SendCFG;

		// Token: 0x040001F6 RID: 502
		internal System.Windows.Controls.Button SaveCFG;

		// Token: 0x040001F7 RID: 503
		internal AutoCompleteBox SingleCommandTextbox;

		// Token: 0x040001F8 RID: 504
		internal Expander CFGExpander;

		// Token: 0x040001F9 RID: 505
		internal System.Windows.Controls.ListBox CFGList;

		// Token: 0x040001FA RID: 506
		internal System.Windows.Controls.Button AddToCFGButton;

		// Token: 0x040001FB RID: 507
		internal Slider FogBaseDistanceSlider;

		// Token: 0x040001FC RID: 508
		internal Slider FogFadeSlider;

		// Token: 0x040001FD RID: 509
		internal Slider FogHeightFadeSlider;

		// Token: 0x040001FE RID: 510
		internal Slider SunHazeStartRadiusSlider;

		// Token: 0x040001FF RID: 511
		internal Slider SunHazeEndRadiusSlider;

		// Token: 0x04000200 RID: 512
		internal Slider FogBrightnessSlider;

		// Token: 0x04000201 RID: 513
		internal Slider SunHazeBrightnessSlider;

		// Token: 0x04000202 RID: 514
		internal ColorWheelControl FogColorWheel;

		// Token: 0x04000203 RID: 515
		internal ColorWheelControl FogHazeColorWheel;

		// Token: 0x04000204 RID: 516
		internal Slider BrightnessSlider;

		// Token: 0x04000205 RID: 517
		internal Slider HazeBrightnessSlider;

		// Token: 0x04000206 RID: 518
		internal Slider FogHeightStartSlider;

		// Token: 0x04000207 RID: 519
		internal System.Windows.Controls.ComboBox LoadFogPresetDropdown;

		// Token: 0x04000208 RID: 520
		internal System.Windows.Controls.Button SaveFogPresetButton;

		// Token: 0x04000209 RID: 521
		internal System.Windows.Controls.Button LoadFogPreset;

		// Token: 0x0400020A RID: 522
		internal System.Windows.Controls.Button AddFogToCFG;

		// Token: 0x0400020B RID: 523
		internal System.Windows.Controls.Button ResetFogToDefault;

		// Token: 0x0400020C RID: 524
		internal System.Windows.Controls.Button RandomFogButton;

		// Token: 0x0400020D RID: 525
		internal System.Windows.Controls.CheckBox SyncFogColorsToggle;

		// Token: 0x0400020E RID: 526
		internal System.Windows.Controls.CheckBox SyncSunFogToSunColor;

		// Token: 0x0400020F RID: 527
		internal Dial SunHazeAngleSlider;

		// Token: 0x04000210 RID: 528
		internal Dial SunHazePitchSlider;

		// Token: 0x04000211 RID: 529
		internal System.Windows.Controls.CheckBox gsEnable;

		// Token: 0x04000212 RID: 530
		internal System.Windows.Controls.CheckBox gpEnable;

		// Token: 0x04000213 RID: 531
		internal System.Windows.Controls.CheckBox depthEnable;

		// Token: 0x04000214 RID: 532
		internal System.Windows.Controls.RadioButton depthByFog;

		// Token: 0x04000215 RID: 533
		internal System.Windows.Controls.RadioButton depthByBuffer;

		// Token: 0x04000216 RID: 534
		internal Grid greenPlayersGrid;

		// Token: 0x04000217 RID: 535
		internal Slider playersRbar;

		// Token: 0x04000218 RID: 536
		internal Slider playersGbar;

		// Token: 0x04000219 RID: 537
		internal Slider playersBbar;

		// Token: 0x0400021A RID: 538
		internal ColorWheelControl depthColorWheel;

		// Token: 0x0400021B RID: 539
		internal Slider depthBrightnessBar;

		// Token: 0x0400021C RID: 540
		internal System.Windows.Controls.CheckBox removeGun;

		// Token: 0x0400021D RID: 541
		internal System.Windows.Controls.CheckBox removeSkull;

		// Token: 0x0400021E RID: 542
		internal System.Windows.Controls.CheckBox removePlayers;

		// Token: 0x0400021F RID: 543
		internal System.Windows.Controls.CheckBox bloomTweaksToggle;

		// Token: 0x04000220 RID: 544
		internal System.Windows.Controls.CheckBox greenSkyToggle;

		// Token: 0x04000221 RID: 545
		internal System.Windows.Controls.CheckBox tBarrierRemove;

		// Token: 0x04000222 RID: 546
		internal System.Windows.Controls.CheckBox WireframeToggle;

		// Token: 0x04000223 RID: 547
		internal System.Windows.Controls.CheckBox ParticlesToggle;

		// Token: 0x04000224 RID: 548
		internal System.Windows.Controls.RadioButton gsR;

		// Token: 0x04000225 RID: 549
		internal System.Windows.Controls.RadioButton gsG;

		// Token: 0x04000226 RID: 550
		internal System.Windows.Controls.RadioButton gsB;

		// Token: 0x04000227 RID: 551
		internal System.Windows.Controls.RadioButton gsP;

		// Token: 0x04000228 RID: 552
		internal Slider DepthDistanceSlider;

		// Token: 0x04000229 RID: 553
		internal System.Windows.Controls.CheckBox PlayersAlphaCheckbox;

		// Token: 0x0400022A RID: 554
		internal Grid NormalMapGrid;

		// Token: 0x0400022B RID: 555
		internal System.Windows.Controls.RadioButton NormalPassDefaultRadioButton;

		// Token: 0x0400022C RID: 556
		internal System.Windows.Controls.Label ___No_Name_;

		// Token: 0x0400022D RID: 557
		internal System.Windows.Controls.ComboBox MaterialsPatchSelector;

		// Token: 0x0400022E RID: 558
		internal System.Windows.Controls.CheckBox IncludeWeaponsInPlayerPass;

		// Token: 0x0400022F RID: 559
		internal System.Windows.Controls.Label TickLabel;

		// Token: 0x04000230 RID: 560
		internal System.Windows.Controls.Button SaveTickButton;

		// Token: 0x04000231 RID: 561
		internal System.Windows.Controls.Button GoToTickButton;

		// Token: 0x04000232 RID: 562
		internal System.Windows.Controls.ProgressBar TheaterProgressBar;

		// Token: 0x04000233 RID: 563
		internal System.Windows.Controls.CheckBox ssaoToggle;

		// Token: 0x04000234 RID: 564
		internal Slider ssaoScaleBar;

		// Token: 0x04000235 RID: 565
		internal Slider ssaoRadiusBar;

		// Token: 0x04000236 RID: 566
		internal Slider ssaoBiasBar;

		// Token: 0x04000237 RID: 567
		internal Slider ssaoIntensityBar;

		// Token: 0x04000238 RID: 568
		internal System.Windows.Controls.Button SendSSAOtoCFGButton;

		// Token: 0x04000239 RID: 569
		internal Slider ssaoDistanceSlider;

		// Token: 0x0400023A RID: 570
		internal System.Windows.Controls.CheckBox DOFEnable;

		// Token: 0x0400023B RID: 571
		internal Slider DOFFarBlurSider;

		// Token: 0x0400023C RID: 572
		internal Slider DOFFarStartSlider;

		// Token: 0x0400023D RID: 573
		internal Slider DOFFarEndSlider;

		// Token: 0x0400023E RID: 574
		internal Slider DOFNearBlurSlider;

		// Token: 0x0400023F RID: 575
		internal Slider DOFNearStartSlider;

		// Token: 0x04000240 RID: 576
		internal Slider DOFNearEndSlider;

		// Token: 0x04000241 RID: 577
		internal Slider DOFViewmodelStartSlider;

		// Token: 0x04000242 RID: 578
		internal Slider DOFViewmodelEndSlider;

		// Token: 0x04000243 RID: 579
		internal Slider DOFBiasSlider;

		// Token: 0x04000244 RID: 580
		internal Slider DOFQualitySlider;

		// Token: 0x04000245 RID: 581
		internal System.Windows.Controls.Button SendDOFtoCFGButton;

		// Token: 0x04000246 RID: 582
		internal Slider SunXSlider;

		// Token: 0x04000247 RID: 583
		internal Slider SunYSlider;

		// Token: 0x04000248 RID: 584
		internal Slider SunZSlider;

		// Token: 0x04000249 RID: 585
		internal ColorWheelControl SunColorWheel;

		// Token: 0x0400024A RID: 586
		internal Slider SunBrightnessSlider;

		// Token: 0x0400024B RID: 587
		internal System.Windows.Controls.Button SendSunToCFGButton;

		// Token: 0x0400024C RID: 588
		internal Slider skyTempBar;

		// Token: 0x0400024D RID: 589
		internal Slider skyBrightnessBar;

		// Token: 0x0400024E RID: 590
		internal System.Windows.Controls.CheckBox skyTransitionToggle;

		// Token: 0x0400024F RID: 591
		internal System.Windows.Controls.CheckBox removeSunFlareToggle;

		// Token: 0x04000250 RID: 592
		internal System.Windows.Controls.CheckBox SyncSkyTemp;

		// Token: 0x04000251 RID: 593
		internal Slider SunQualitySlider;

		// Token: 0x04000252 RID: 594
		internal Dial SunPitchDial;

		// Token: 0x04000253 RID: 595
		internal Dial SunYawDial;

		// Token: 0x04000254 RID: 596
		internal Dial SkyRotation_Dial;

		// Token: 0x04000255 RID: 597
		internal System.Windows.Controls.ListBox WeaponClassSelector;

		// Token: 0x04000256 RID: 598
		internal System.Windows.Controls.ListBox WeaponSelector;

		// Token: 0x04000257 RID: 599
		internal Grid grdChampions;

		// Token: 0x04000258 RID: 600
		internal System.Windows.Controls.Button ClearWeaponsButton;

		// Token: 0x04000259 RID: 601
		internal System.Windows.Controls.Button WeaponChangerToggle;

		// Token: 0x0400025A RID: 602
		internal System.Windows.Controls.Image AnimViewer;

		// Token: 0x0400025B RID: 603
		internal System.Windows.Controls.ListBox AnimCategorySelector;

		// Token: 0x0400025C RID: 604
		internal System.Windows.Controls.ListBox AnimSelector;

		// Token: 0x0400025D RID: 605
		internal AutoCompleteBox AnimSearcher;

		// Token: 0x0400025E RID: 606
		internal Canvas appbar_arrow_left;

		// Token: 0x0400025F RID: 607
		internal AutoCompleteBox Anim1Textbox;

		// Token: 0x04000260 RID: 608
		internal AutoCompleteBox Anim2Textbox;

		// Token: 0x04000261 RID: 609
		internal System.Windows.Controls.RadioButton TargetAnimationRadio;

		// Token: 0x04000262 RID: 610
		internal System.Windows.Controls.RadioButton SourceAnimationRadio;

		// Token: 0x04000263 RID: 611
		internal System.Windows.Controls.Button SwapAnimationButton;

		// Token: 0x04000264 RID: 612
		internal System.Windows.Controls.Button RestoreTargetAnimation;

		// Token: 0x04000265 RID: 613
		internal System.Windows.Controls.Button RestoreAllAnimations;

		// Token: 0x04000266 RID: 614
		internal WebView demoPreviewerWebView;

		// Token: 0x04000267 RID: 615
		internal System.Windows.Controls.ListBox DemoMapSelector;

		// Token: 0x04000268 RID: 616
		internal System.Windows.Controls.ListBox DemoSelector;

		// Token: 0x04000269 RID: 617
		internal System.Windows.Controls.Button EditDemoMetadataButton;

		// Token: 0x0400026A RID: 618
		internal System.Windows.Controls.ProgressBar DemoSkipProgressBar;

		// Token: 0x0400026B RID: 619
		internal System.Windows.Controls.TextBox DemoDescriptionTextbox;

		// Token: 0x0400026C RID: 620
		internal System.Windows.Controls.Button EndDemoPlaybackButton;

		// Token: 0x0400026D RID: 621
		internal System.Windows.Controls.Button OpenInBrowserButton;

		// Token: 0x0400026E RID: 622
		internal System.Windows.Controls.Button RefreshDemosList;

		// Token: 0x0400026F RID: 623
		internal System.Windows.Controls.Button SelectDemoFolderButton;

		// Token: 0x04000270 RID: 624
		internal System.Windows.Controls.Button SaveCurrentDemoButton;

		// Token: 0x04000271 RID: 625
		internal System.Windows.Controls.Button openDemoInBrowserButton;

		// Token: 0x04000272 RID: 626
		internal System.Windows.Controls.Button LoadSelectedDemoButton;

		// Token: 0x04000273 RID: 627
		internal System.Windows.Controls.Button LoadDemoFromFileButton;

		// Token: 0x04000274 RID: 628
		internal System.Windows.Controls.Button CreateCustomSliderButton;

		// Token: 0x04000275 RID: 629
		internal System.Windows.Controls.ListBox CustomSliderListBox;

		// Token: 0x04000276 RID: 630
		private bool _contentLoaded;

		// Token: 0x0200003D RID: 61
		private class PopulateInfo
		{
			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600019A RID: 410 RVA: 0x0003F65A File Offset: 0x0003D85A
			// (set) Token: 0x0600019B RID: 411 RVA: 0x0003F662 File Offset: 0x0003D862
			public AutoCompleteBox AutoCompleteBox { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600019C RID: 412 RVA: 0x0003F66B File Offset: 0x0003D86B
			// (set) Token: 0x0600019D RID: 413 RVA: 0x0003F673 File Offset: 0x0003D873
			public string SearchText { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600019E RID: 414 RVA: 0x0003F67C File Offset: 0x0003D87C
			// (set) Token: 0x0600019F RID: 415 RVA: 0x0003F684 File Offset: 0x0003D884
			public IEnumerable<DvarEntry> Results { get; set; }
		}

		// Token: 0x0200003E RID: 62
		private class PopulateInfoAnimations
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060001A1 RID: 417 RVA: 0x0003F68D File Offset: 0x0003D88D
			// (set) Token: 0x060001A2 RID: 418 RVA: 0x0003F695 File Offset: 0x0003D895
			public AutoCompleteBox AutoCompleteBox { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060001A3 RID: 419 RVA: 0x0003F69E File Offset: 0x0003D89E
			// (set) Token: 0x060001A4 RID: 420 RVA: 0x0003F6A6 File Offset: 0x0003D8A6
			public string SearchText { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060001A5 RID: 421 RVA: 0x0003F6AF File Offset: 0x0003D8AF
			// (set) Token: 0x060001A6 RID: 422 RVA: 0x0003F6B7 File Offset: 0x0003D8B7
			public IEnumerable<string> Results { get; set; }
		}
	}
}
