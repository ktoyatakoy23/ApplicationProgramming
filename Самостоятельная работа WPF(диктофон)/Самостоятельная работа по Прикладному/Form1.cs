using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Самостоятельная_работа_по_Прикладному
{
    // Разработайте приложение для записи и воспроизведения 
    //аудиофайлов с использованием микрофона и динамика компьютера.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WaveInEvent record;
        private WaveFileWriter write;
        
        private WaveOut play;
        private AudioFileReader read;
        private void record_button_Click(object sender, EventArgs e)
        {
            record = new WaveInEvent();
            record.DataAvailable += WaveIn_DataAvailable;

            write = new WaveFileWriter("output.wav", record.WaveFormat);

            record.StartRecording();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            play = new WaveOut();
            read = new AudioFileReader("output.wav");
            play.Init(read);
            play.Play();
        }
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            write.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void stop_record_button_Click(object sender, EventArgs e)
        {
            record?.StopRecording();
            write?.Close();
        }

        private void stop_play_button_Click(object sender, EventArgs e)
        {
            play?.Stop();
            read?.Dispose();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Wave File (*.wav)|*.wav";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy("output.wav", saveFileDialog.FileName, true);
                MessageBox.Show("Файл сохранен");
            }
        }
    }
}
