using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

namespace B168_Series_Mod
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        static string currentDir = Environment.CurrentDirectory;
        static string com1 = "HUAWEI Mobile Connect - 3G PC UI Interface"; //HUAWEI Mobile Connect - 3G PC UI Interface
        static string com2 = "Application Interface"; //HUAWEI Mobile Connect - 3G Application Interface
        public static string Rating; 
        static string com1Connect = "";
        static string com2Connect = "";
        static string tempPath = Path.GetTempPath() + @"HUAWEI_AIO\";

        static string ip_address;

       
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            textboxIMEI.MaxLength = 15;
        }

       

        public void cekCOM1()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => ports.FirstOrDefault(s => s.Contains(n))).ToList();

                foreach (string s in portList)
                {
                    string text = "> " + s + "\n";
                    //MessageBox.Show(s);
                    if (string.IsNullOrEmpty(s))
                    {

                    }
                    else if(s.Contains(com1))
                    {
                        com1Connect = "1";
                        break;
                    }
                    else
                    {
                        com1Connect = "0";
                    }
                }
            }
        }

        public void cekCOM2()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => ports.FirstOrDefault(s => s.Contains(n))).ToList();

                foreach (string s in portList)
                {
                    string text = "> " + s + "\n";
                    if (string.IsNullOrEmpty(s))
                    {

                    }
                    else if (s.Contains(com2))
                    {
                        com2Connect = "1";
                        break;
                    }
                    else
                    {
                        com2Connect = "0";
                    }
                }
            }
        }

        void SortOutputHandler(object sender, DataReceivedEventArgs e)
        {
            Trace.WriteLine(e.Data);
            this.BeginInvoke(new MethodInvoker(() =>
            {
                richTextBox1.AppendText(e.Data ?? string.Empty);
            }));
        }

        private void backgroundWorkerUSBLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            button4.Enabled = false;
            
            richTextBox1.Text = "[*] Starting USB Loader.." + Environment.NewLine + Environment.NewLine;

            //File.WriteAllBytes("balong_usbdload.exe", Properties.Resources.balong_usbdload);



            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = tempPath,
                    FileName = tempPath + @"balong_usbdload.exe",
                    Arguments = " -c " + "\"" + textBox3.Text + "\"",
            UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                
                richTextBox1.Text = line;
                /*if (line.Contains("20%"))
                {
                    progressBar1.Increment(20);
                }

                if (line.Contains("40%"))
                {
                    progressBar1.Increment(20);
                }
                */
                if(line.Contains("[*] Download complete"))
                {
                    richTextBox1.Text = "[*] Done." + Environment.NewLine;

                }
            }



            if (checkBox1.Checked)
            {
                System.IO.File.AppendAllText(currentDir + "\\log.txt", richTextBox1.Text);
            }

            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            groupBox5.Enabled = true;
            button4.Enabled = true;
        }

        private void backgroundWorkerUnlock_DoWork(object sender, DoWorkEventArgs e)
        {
            if (radioButton2.Checked)
            {
                ip_address = textBox1.Text;
            }
            else if (radioButton1.Checked)
            {
                ip_address = "192.168.8.1";
            }

            if (string.IsNullOrEmpty(ip_address))
            {
                richTextBox1.Text = "Please set IP address";
            }
            else
            {
                Match match = Regex.Match(ip_address, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
                if (match.Success)
                {
                    richTextBox1.Text += "[*] Unlocking device.." + Environment.NewLine;

                    try
                    {
                        //File.WriteAllBytes("adb.exe", Properties.Resources.adb);
                        //File.WriteAllBytes("AdbWinApi.dll", Properties.Resources.AdbWinApi);
                        //File.WriteAllBytes("AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);

                        Process p = new Process();

                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardInput = true;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.RedirectStandardError = true;
                        p.StartInfo.FileName = tempPath + "adb.exe";
                        p.StartInfo.Arguments = " connect " + ip_address + ":5555";
                        p.Start();
                        p.WaitForExit();

                        string text = p.StandardOutput.ReadToEnd();
                        richTextBox1.Text += text.Replace(":5555:5555", ":5555").Replace("unable", "[*] Unable");

                        if (!richTextBox1.Text.Contains("Unable to connect"))
                        {
                            Process process = new Process();

                            process.StartInfo.CreateNoWindow = true;
                            process.StartInfo.UseShellExecute = false;
                            process.StartInfo.RedirectStandardInput = true;
                            process.StartInfo.RedirectStandardOutput = true;
                            process.StartInfo.RedirectStandardError = true;
                            process.StartInfo.FileName = tempPath + "adb.exe";
                            process.StartInfo.Arguments = " shell \"atc AT^ NVWREX = 8268,0,12,1,0,0,0,2,0,0,0,A,0,0,0\"";
                            process.Start();
                            process.WaitForExit();

                            text = process.StandardOutput.ReadToEnd();
                            richTextBox1.Text += text;

                            rebootRouter();

                            //File.Delete("adb.exe");
                            //File.Delete("AdbWinApi.dll");
                            //File.Delete("AdbWinUsbApi.dll");

                        }
                        else
                        {
                            richTextBox1.Text += "[*] Device not found.";
                            button1.Enabled = false;
                            button3.Enabled = false;
                            label8.ForeColor = Color.Red;
                            label8.Text = "Not connected";
                        }
                    }
                    catch
                    {

                    }
                }
                else
                {
                    richTextBox1.Text += "Please enter a valid IP address" + Environment.NewLine;
                }



            }

            if (checkBox1.Checked)
            {
                System.IO.File.AppendAllText(currentDir + "\\log.txt", richTextBox1.Text);
            }
        }


        private void backgroundWorkerFlash_DoWork(object sender, DoWorkEventArgs e)
        {
            groupBox5.Enabled = false;
            groupBox3.Enabled = false;
            groupBox1.Enabled = false;
            button4.Enabled = false;

            richTextBox1.Text = "[*] Starting Flash Tool.." + Environment.NewLine + Environment.NewLine;

            //File.WriteAllBytes("balong_flash.exe", Properties.Resources.balong_flash);

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = tempPath + @"balong_flash.exe",
                    Arguments = "\"" + textBox4.Text + "\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();

                richTextBox1.Text = "[*] " + line;
                /*if (line.Contains("20%"))
                {
                    progressBar1.Increment(20);
                }

                if (line.Contains("40%"))
                {
                    progressBar1.Increment(20);
                }
                */
                if ( line.Contains("[*] Rebooting.."))
                {
                    richTextBox1.Text = "[*] Done." + Environment.NewLine;

                }
            }

            groupBox5.Enabled = true;
            groupBox3.Enabled = true;
            groupBox1.Enabled = true;
            button4.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        public void Logger(String lines)
        {

            // Write the string to a file.append mode is enabled so that the log
            // lines get appended to  test.txt than wiping content and writing the log

            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt", true);
            file.WriteLine(lines);

            file.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Disclaimer : I am not responsible for any harm or damage to your device. Please make sure you know what you are doing. Thank you", "Huawei B618 AIO Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //checkDevice();
            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);

            }

            File.WriteAllBytes(tempPath + @"adb.exe", Properties.Resources.adb);
            File.WriteAllBytes(tempPath + @"AdbWinApi.dll", Properties.Resources.AdbWinApi);
            File.WriteAllBytes(tempPath + @"AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);
            File.WriteAllBytes(tempPath + @"balong_flash.exe", Properties.Resources.balong_flash);
            File.WriteAllBytes(tempPath + @"balong_usbdload.exe", Properties.Resources.balong_usbdload);


        }

        private void Unlock()
        {
            if (radioButton2.Checked)
            {
                ip_address = textBox1.Text;
            }
            else if (radioButton1.Checked)
            {
                ip_address = "192.168.8.1";
            }

            Match match = Regex.Match(ip_address, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            if (match.Success)
            {
                string output;
                richTextBox1.Text = "[*] Starting server.." + Environment.NewLine;

                Process start = new Process();
                start.StartInfo.CreateNoWindow = true;
                start.StartInfo.UseShellExecute = false;
                start.StartInfo.RedirectStandardInput = true;
                start.StartInfo.RedirectStandardOutput = true;
                start.StartInfo.RedirectStandardError = true;
                start.StartInfo.FileName = tempPath + "adb.exe";
                start.StartInfo.Arguments = " start-server";
                start.Start();
                start.WaitForExit();


                output = "";
                Process connect = new Process();
                richTextBox1.Text += "[*] Connecting to server.." + Environment.NewLine;

                connect.StartInfo.CreateNoWindow = true;
                connect.StartInfo.UseShellExecute = false;
                connect.StartInfo.RedirectStandardInput = true;
                connect.StartInfo.RedirectStandardOutput = true;
                connect.StartInfo.RedirectStandardError = true;
                connect.StartInfo.FileName = tempPath + "adb.exe";
                connect.StartInfo.Arguments = " connect " + ip_address + ":5555";
                connect.Start();
                output += connect.StandardOutput.ReadToEnd();
                //richTextBox1.Text = output;
                connect.WaitForExit();



                if (output.Contains("unable"))
                {
                    richTextBox1.Text += "[*] " + output.Replace(":5555:5555", ":5555").Replace("unable", "Unable").Replace(":5555", "");

                }
                else
                {
                    richTextBox1.Text += "[*] " + output.Replace(":5555:5555", ":5555").Replace("connected", "Connected").Replace(":5555", "");

                    output = "";
                    richTextBox1.Text += "[*] Unlocking.." + Environment.NewLine;

                    Process step_2 = new Process();

                    step_2.StartInfo.CreateNoWindow = true;
                    step_2.StartInfo.UseShellExecute = false;
                    step_2.StartInfo.RedirectStandardInput = true;
                    step_2.StartInfo.RedirectStandardOutput = true;
                    step_2.StartInfo.RedirectStandardError = true;
                    step_2.StartInfo.FileName = tempPath + "adb.exe";
                    step_2.StartInfo.Arguments = " shell \"atc AT^NVWREX = 8268,0,12,1,0,0,0,2,0,0,0,A,0,0,0\"";
                    step_2.Start();
                    step_2.WaitForExit();

                    output += step_2.StandardOutput.ReadToEnd();
                    richTextBox1.Text += output;



                    output = "";

                    rebootRouter();

                    richTextBox1.Text += "[*] Killing server.." + Environment.NewLine;

                    Process kill = new Process();
                    kill.StartInfo.CreateNoWindow = true;
                    kill.StartInfo.UseShellExecute = false;
                    kill.StartInfo.RedirectStandardInput = true;
                    kill.StartInfo.RedirectStandardOutput = true;
                    kill.StartInfo.RedirectStandardError = true;
                    kill.StartInfo.FileName = tempPath + "adb.exe";
                    kill.StartInfo.Arguments = " kill-server";
                    kill.Start();
                    kill.WaitForExit();

                    richTextBox1.Text += "[*] Done.";

                    
                }
            }
            else
            {
                richTextBox1.Text += "[*] Please enter a valid IP address" + Environment.NewLine;

            }

            metroTabControl1.Enabled = true;
            button4.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (checkBox1.Checked)
            {
                System.IO.File.AppendAllText(currentDir + "\\log.txt", richTextBox1.Text);
            }

            
        }

        private void Bypass()
        {
            if (radioButton2.Checked)
            {
                ip_address = textBox1.Text;
            }
            else if (radioButton1.Checked)
            {
                ip_address = "192.168.8.1";
            }

            Match match = Regex.Match(ip_address, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            if (match.Success)
            {

                string output;
                richTextBox1.Text = "[*] Starting server.." + Environment.NewLine;

                Process start = new Process();
                start.StartInfo.CreateNoWindow = true;
                start.StartInfo.UseShellExecute = false;
                start.StartInfo.RedirectStandardInput = true;
                start.StartInfo.RedirectStandardOutput = true;
                start.StartInfo.RedirectStandardError = true;
                start.StartInfo.FileName = tempPath + "adb.exe";
                start.StartInfo.Arguments = " start-server";
                start.Start();
                start.WaitForExit();


                output = "";
                Process connect = new Process();
                richTextBox1.Text += "[*] Connecting to server.." + Environment.NewLine;

                connect.StartInfo.CreateNoWindow = true;
                connect.StartInfo.UseShellExecute = false;
                connect.StartInfo.RedirectStandardInput = true;
                connect.StartInfo.RedirectStandardOutput = true;
                connect.StartInfo.RedirectStandardError = true;
                connect.StartInfo.FileName = tempPath + "adb.exe";
                connect.StartInfo.Arguments = " connect " + ip_address + ":5555";
                connect.Start();
                output += connect.StandardOutput.ReadToEnd();
                //richTextBox1.Text = output;
                connect.WaitForExit();



                if (output.Contains("unable"))
                {
                    richTextBox1.Text += "[*] " + output.Replace(":5555:5555", ":5555").Replace("unable", "Unable").Replace(":5555", "");

                }
                else
                {
                    richTextBox1.Text += "[*] " + output.Replace(":5555:5555", ":5555").Replace("connected", "Connected").Replace(":5555", "");

                    richTextBox1.Text += "[*] Mounting '/system' as rewritable.." + Environment.NewLine;


                    output = "";

                    Process step_4 = new Process();

                    step_4.StartInfo.CreateNoWindow = true;
                    step_4.StartInfo.UseShellExecute = false;
                    step_4.StartInfo.RedirectStandardInput = true;
                    step_4.StartInfo.RedirectStandardOutput = true;
                    step_4.StartInfo.RedirectStandardError = true;
                    step_4.StartInfo.FileName = tempPath + "adb.exe";
                    step_4.StartInfo.Arguments = " shell mount -o remount,rw /system";
                    step_4.Start();
                    step_4.WaitForExit();

                    output += step_4.StandardOutput.ReadToEnd();
                    richTextBox1.Text += output;


                    richTextBox1.Text += "[*] Writing 'echo 64' to '/system/etc/fix_ttl'.." + Environment.NewLine;

                    output = "";

                    Process step_5 = new Process();

                    step_5.StartInfo.CreateNoWindow = true;
                    step_5.StartInfo.UseShellExecute = false;
                    step_5.StartInfo.RedirectStandardInput = true;
                    step_5.StartInfo.RedirectStandardOutput = true;
                    step_5.StartInfo.RedirectStandardError = true;
                    step_5.StartInfo.FileName = tempPath + "adb.exe";
                    step_5.StartInfo.Arguments = " shell \"echo 64 > /system/etc/fix_ttl\"";
                    step_5.Start();
                    step_5.WaitForExit();

                    output += step_5.StandardOutput.ReadToEnd();
                    richTextBox1.Text += output;

                    output = "";

                    richTextBox1.Text += "[*] Writing 'echo 1' to '/system/etc/disable_spe'.." + Environment.NewLine;


                    Process echo_1 = new Process();

                    echo_1.StartInfo.CreateNoWindow = true;
                    echo_1.StartInfo.UseShellExecute = false;
                    echo_1.StartInfo.RedirectStandardInput = true;
                    echo_1.StartInfo.RedirectStandardOutput = true;
                    echo_1.StartInfo.RedirectStandardError = true;
                    echo_1.StartInfo.FileName = tempPath + "adb.exe";
                    echo_1.StartInfo.Arguments = " shell \"echo 1 > /system/etc/disable_spe\"";
                    echo_1.Start();
                    echo_1.WaitForExit();

                    output += echo_1.StandardOutput.ReadToEnd();
                    richTextBox1.Text += output;

                    output = "";

                    richTextBox1.Text += "[*] Mounting '/system' as read-only.." + Environment.NewLine;



                    Process remount = new Process();

                    remount.StartInfo.CreateNoWindow = true;
                    remount.StartInfo.UseShellExecute = false;
                    remount.StartInfo.RedirectStandardInput = true;
                    remount.StartInfo.RedirectStandardOutput = true;
                    remount.StartInfo.RedirectStandardError = true;
                    remount.StartInfo.FileName = tempPath + "adb.exe";
                    remount.StartInfo.Arguments = " shell mount -o remount,ro /system";
                    remount.Start();
                    remount.WaitForExit();

                    output += remount.StandardOutput.ReadToEnd();
                    richTextBox1.Text += output;

                    output = "";

                    rebootRouter();

                    richTextBox1.Text += "[*] Killing server.." + Environment.NewLine;

                    Process kill = new Process();
                    kill.StartInfo.CreateNoWindow = true;
                    kill.StartInfo.UseShellExecute = false;
                    kill.StartInfo.RedirectStandardInput = true;
                    kill.StartInfo.RedirectStandardOutput = true;
                    kill.StartInfo.RedirectStandardError = true;
                    kill.StartInfo.FileName = tempPath + "adb.exe";
                    kill.StartInfo.Arguments = " kill-server";
                    kill.Start();
                    kill.WaitForExit();

                    richTextBox1.Text += "[*] Done.";
                   
                }

            }
            else
            {
                richTextBox1.Text += "[*] Please enter a valid IP address" + Environment.NewLine;

            }





            if (checkBox1.Checked)
            {
                System.IO.File.AppendAllText(currentDir + "\\log.txt", richTextBox1.Text);
            }
            metroTabControl1.Enabled = true;
            button4.Enabled = true;

        }
        private void backgroundWorkerBypass_DoWork(object sender, DoWorkEventArgs e)
        {
            richTextBox1.Clear();
            
            Bypass();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            backgroundWorkerUSBLoader.RunWorkerAsync();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            backgroundWorkerFlash.RunWorkerAsync();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFileDialog1.FileName;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerUSBLoader.IsBusy)
                backgroundWorkerUSBLoader.CancelAsync();
            backgroundWorkerUSBLoader.RunWorkerAsync(richTextBox1.Text);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog2.FileName;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerFlash.IsBusy)
                backgroundWorkerFlash.CancelAsync();
            backgroundWorkerFlash.RunWorkerAsync();
        }

       


        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
            textBox1.Text = "";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "Enter IP Address";
                textBox1.Enabled = false;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void checkDevice()
        {
            com1Connect = "";
            com2Connect = "";
            richTextBox1.Clear();
            label8.Text = "";
            richTextBox1.Text = "[*] Checking if device is connected via serial port.." + Environment.NewLine;

            cekCOM1();
            cekCOM2();
            if (com1Connect == "1" && com2Connect == "0")
            {
                label8.ForeColor = Color.Green;
                label8.Text = "Connected (PC UI Interface)";

                richTextBox1.Text += "[*] Device is connected." + Environment.NewLine;
                button1.Enabled = true;
                button3.Enabled = true;

            }
            else if (com1Connect == "0" && com2Connect == "1")
            {
                label8.ForeColor = Color.Green;
                label8.Text = "Connected (Application Interface)";

                richTextBox1.Text += "[*] Device is connected." + Environment.NewLine;
                button1.Enabled = true;
                button3.Enabled = true;

            }
            else if (com1Connect == "1" && com2Connect == "1")
            {
                label8.ForeColor = Color.Green;
                label8.Text = "Connected (Application Interface)";

                richTextBox1.Text += "[*] Device is connected." + Environment.NewLine;
                button1.Enabled = true;
                button3.Enabled = true;

            }
            else
            {
                label8.ForeColor = Color.Red;
                label8.Text = "Not connected";

                richTextBox1.Text += "[*] Device not found." + Environment.NewLine;

            }

            if (checkBox1.Checked)
            {
                System.IO.File.AppendAllText(currentDir + "\\log.txt", richTextBox1.Text);
            }

            //MessageBox.Show(com1Connect + "] - [" + com2Connect);


            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            checkDevice();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Enabled = true;
                ip_address = textBox1.Text;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

      

        private void BackgroundUnlock_DoWork(object sender, DoWorkEventArgs e)
        {
            Unlock();
        }

       
       

        private void BackgroundIMEI_DoWork(object sender, DoWorkEventArgs e)
        {
            
            Imei();

        }
        private void Imei()
        {
            if (radioButton2.Checked)
            {
                ip_address = textBox1.Text;
            }
            else if (radioButton1.Checked)
            {
                ip_address = "192.168.8.1";
            }

            Match match = Regex.Match(ip_address, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            if (match.Success)
            {
                string output;
                richTextBox1.Text = "[*] Starting server.." + Environment.NewLine;

                Process start = new Process();
                start.StartInfo.CreateNoWindow = true;
                start.StartInfo.UseShellExecute = false;
                start.StartInfo.RedirectStandardInput = true;
                start.StartInfo.RedirectStandardOutput = true;
                start.StartInfo.RedirectStandardError = true;
                start.StartInfo.FileName = tempPath + "adb.exe";
                start.StartInfo.Arguments = " start-server";
                start.Start();
                start.WaitForExit();


                output = "";
                Process connect = new Process();
                richTextBox1.Text += "[*] Connecting to server.." + Environment.NewLine;

                connect.StartInfo.CreateNoWindow = true;
                connect.StartInfo.UseShellExecute = false;
                connect.StartInfo.RedirectStandardInput = true;
                connect.StartInfo.RedirectStandardOutput = true;
                connect.StartInfo.RedirectStandardError = true;
                connect.StartInfo.FileName = tempPath + "adb.exe";
                connect.StartInfo.Arguments = " connect " + ip_address + ":5555";
                connect.Start();
                output += connect.StandardOutput.ReadToEnd();
                //richTextBox1.Text = output;
                connect.WaitForExit();



                if (output.Contains("unable"))
                {
                    richTextBox1.Text += "[*] " + output.Replace(":5555:5555", ":5555").Replace("unable", "Unable").Replace(":5555", "");

                }
                else
                {
                    richTextBox1.Text += "[*] " + output.Replace(":5555:5555", ":5555").Replace("connected", "Connected").Replace(":5555", "");

                    output = "";
                    richTextBox1.Text += "[*] Changing IMEI.. ";

                    Process step_2 = new Process();

                    step_2.StartInfo.CreateNoWindow = true;
                    step_2.StartInfo.UseShellExecute = false;
                    step_2.StartInfo.RedirectStandardInput = true;
                    step_2.StartInfo.RedirectStandardOutput = true;
                    step_2.StartInfo.RedirectStandardError = true;
                    step_2.StartInfo.FileName = tempPath + "adb.exe";
                    step_2.StartInfo.Arguments = " shell \"atc AT^PHYNUM=IMEI," + textboxIMEI.Text + "\""; ;
                    step_2.Start();
                    output += step_2.StandardOutput.ReadToEnd();
                    step_2.WaitForExit();
                    //richTextBox1.Text += output.Replace("Waiting for response...","");
                    //

                    if (output.Contains("OK"))
                    {
                        richTextBox1.Text += "OK" + Environment.NewLine;

                        

                        output = "";

                        rebootRouter();

                        richTextBox1.Text += "[*] Killing server.." + Environment.NewLine;

                        Process kill = new Process();
                        kill.StartInfo.CreateNoWindow = true;
                        kill.StartInfo.UseShellExecute = false;
                        kill.StartInfo.RedirectStandardInput = true;
                        kill.StartInfo.RedirectStandardOutput = true;
                        kill.StartInfo.RedirectStandardError = true;
                        kill.StartInfo.FileName = tempPath + "adb.exe";
                        kill.StartInfo.Arguments = " kill-server";
                        kill.Start();
                        kill.WaitForExit();

                        richTextBox1.Text += "[*] Done.";

                      
                    }
                    else
                    {
                        richTextBox1.Text += "Fail";

                    }



                }
            }
            else
            {
                richTextBox1.Text += "[*] Please enter a valid IP address" + Environment.NewLine;

            }

            metroTabControl1.Enabled = true;
            button4.Enabled = true;
        }

       

        


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorkerKillADB.RunWorkerAsync();
        }

        private void BackgroundWorkerKillADB_DoWork(object sender, DoWorkEventArgs e)
        {
            Process kill = new Process();
            kill.StartInfo.CreateNoWindow = true;
            kill.StartInfo.UseShellExecute = false;
            kill.StartInfo.RedirectStandardInput = true;
            kill.StartInfo.RedirectStandardOutput = true;
            kill.StartInfo.RedirectStandardError = true;
            kill.StartInfo.FileName = tempPath + "adb.exe";
            kill.StartInfo.Arguments = " kill-server";
            kill.Start();
            kill.WaitForExit();
        }

       



      

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/paypalme2/pearlxcore?locale.x=en_US");

        }

        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pearlxcore");

        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            

            richTextBox1.Clear();
            if (textboxIMEI.Text.Length == 15)
            {
                metroTabControl1.Enabled = false;
                button4.Enabled = false;

                if (backgroundIMEI.IsBusy)
                    backgroundIMEI.CancelAsync();
                backgroundIMEI.RunWorkerAsync();
            }
            else
            {
                richTextBox1.Text += "[*] IMEI not valid." + Environment.NewLine;
                metroTabControl1.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            metroTabControl1.Enabled = false;
            button4.Enabled = false;

            if (backgroundUnlock.IsBusy)
                backgroundUnlock.CancelAsync();
            backgroundUnlock.RunWorkerAsync();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            metroTabControl1.Enabled = false;
            button4.Enabled = false;

            if (backgroundWorkerBypass.IsBusy)
                backgroundWorkerBypass.CancelAsync();
            backgroundWorkerBypass.RunWorkerAsync();
        }

        private void BackgroundWorkerReadStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            if (radioButton2.Checked)
            {
                ip_address = textBox1.Text;
            }
            else if (radioButton1.Checked)
            {
                ip_address = "192.168.8.1";
            }

            string output;
            richTextBox1.Text = "[*] Starting server.." + Environment.NewLine;

            Process start = new Process();
            start.StartInfo.CreateNoWindow = true;
            start.StartInfo.UseShellExecute = false;
            start.StartInfo.RedirectStandardInput = true;
            start.StartInfo.RedirectStandardOutput = true;
            start.StartInfo.RedirectStandardError = true;
            start.StartInfo.FileName = tempPath + "adb.exe";
            start.StartInfo.Arguments = " start-server";
            start.Start();
            start.WaitForExit();


            output = "";
            Process connect = new Process();
            richTextBox1.Text += "[*] Connecting to server.." + Environment.NewLine;

            connect.StartInfo.CreateNoWindow = true;
            connect.StartInfo.UseShellExecute = false;
            connect.StartInfo.RedirectStandardInput = true;
            connect.StartInfo.RedirectStandardOutput = true;
            connect.StartInfo.RedirectStandardError = true;
            connect.StartInfo.FileName = tempPath + "adb.exe";
            connect.StartInfo.Arguments = " connect " + ip_address + ":5555";
            connect.Start();
            output += connect.StandardOutput.ReadToEnd();
            //richTextBox1.Text = output;
            connect.WaitForExit();



            if (output.Contains("unable"))
            {
                richTextBox1.Text += "[*] " + output.Replace(":5555:5555", ":5555").Replace("unable", "Unable").Replace(":5555", "");

            }
            else
            {
                richTextBox1.Text += "[*] " + output.Replace(":5555:5555", ":5555").Replace("connected", "Connected").Replace(":5555", "");

                output = "";

                richTextBox1.Text += "[*] Checking value for '/system/etc/fix_ttl' : ";

                Process step_2 = new Process();

                step_2.StartInfo.CreateNoWindow = true;
                step_2.StartInfo.UseShellExecute = false;
                step_2.StartInfo.RedirectStandardInput = true;
                step_2.StartInfo.RedirectStandardOutput = true;
                step_2.StartInfo.RedirectStandardError = true;
                step_2.StartInfo.FileName = tempPath + "adb.exe";
                step_2.StartInfo.Arguments = " shell cat /system/etc/fix_ttl";
                step_2.Start();
                step_2.WaitForExit();

                output += step_2.StandardOutput.ReadToEnd();
                richTextBox1.Text += output;

                output = "";

                richTextBox1.Text += Environment.NewLine + "[*] Checking value for '/system/etc/disable_spe' : ";

                Process step_3 = new Process();

                step_3.StartInfo.CreateNoWindow = true;
                step_3.StartInfo.UseShellExecute = false;
                step_3.StartInfo.RedirectStandardInput = true;
                step_3.StartInfo.RedirectStandardOutput = true;
                step_3.StartInfo.RedirectStandardError = true;
                step_3.StartInfo.FileName = tempPath + "adb.exe";
                step_3.StartInfo.Arguments = " shell cat /system/etc/disable_spe";
                step_3.Start();
                step_3.WaitForExit();

                output += step_3.StandardOutput.ReadToEnd();
                richTextBox1.Text += output;

                richTextBox1.Text += Environment.NewLine + "[*] Killing server.." + Environment.NewLine;

                Process kill = new Process();
                kill.StartInfo.CreateNoWindow = true;
                kill.StartInfo.UseShellExecute = false;
                kill.StartInfo.RedirectStandardInput = true;
                kill.StartInfo.RedirectStandardOutput = true;
                kill.StartInfo.RedirectStandardError = true;
                kill.StartInfo.FileName = tempPath + "adb.exe";
                kill.StartInfo.Arguments = " kill-server";
                kill.Start();
                kill.WaitForExit();

                richTextBox1.Text += "[*] Done." + Environment.NewLine;
            }


            metroTabControl1.Enabled = true;
            button4.Enabled = true;
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            metroTabControl1.Enabled = false;
            button4.Enabled = false;

            if (backgroundWorkerReadStatus.IsBusy)
                backgroundWorkerReadStatus.CancelAsync();
            backgroundWorkerReadStatus.RunWorkerAsync();
        }

        private void TextboxIMEI_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TextboxIMEI_Click(object sender, EventArgs e)
        {
            textboxIMEI.ForeColor = Color.White;
            textboxIMEI.Text = "";
        }

        private void TextboxIMEI_Leave(object sender, EventArgs e)
        {
            if (textboxIMEI.Text.Length == 15)
            {

            }
            else if(textboxIMEI.Text.Length == 0)
            {
                textboxIMEI.ForeColor = Color.DarkGray;
                textboxIMEI.Text = "Enter IMEI";
            }
            else
            {
                textboxIMEI.ForeColor = Color.DarkGray;
                textboxIMEI.Text = "Enter IMEI";
            }
        }

        private void TextboxIMEI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void rebootRouter()
        {
            DialogResult dialogResult = MessageBox.Show("Reboot the router?", "Huawei B618 AIO Mod Tool", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                richTextBox1.Text += "[*] Rebooting device.." + Environment.NewLine;

                 string output = "";

                Process reboot = new Process();

                reboot.StartInfo.CreateNoWindow = true;
                reboot.StartInfo.UseShellExecute = false;
                reboot.StartInfo.RedirectStandardInput = true;
                reboot.StartInfo.RedirectStandardOutput = true;
                reboot.StartInfo.RedirectStandardError = true;
                reboot.StartInfo.FileName = tempPath + "adb.exe";
                reboot.StartInfo.Arguments = " shell \"echo -en 'AT^RESET\r' > /dev/appvcom1\"";
                reboot.Start();
                reboot.WaitForExit();

                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        

       
       

        private void RichTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}
