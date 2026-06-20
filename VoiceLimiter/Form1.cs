using NAudio.CoreAudioApi;
using System.Diagnostics;

namespace VoiceLimiter;

public partial class Form1 : Form
{
    private System.Timers.Timer _timer;
    public Form1()
    {
        _timer = new(1000.0);
        _timer.Elapsed += (_, _) => AdjustVolume();
        _timer.Start();
        this.FormClosing += (_, e) =>
        {
            Hide();
            e.Cancel = true;
        };
        this.Shown += Form1_Shown;
        ;
        ShowInTaskbar = false;
        InitializeComponent();
    }
    private void AdjustVolume()
    {
        var maxVolume = 0.3f;
        try
        {
            var file = File.ReadAllText(Environment.CurrentDirectory + "\\MaxVolume.txt");
            var volume = float.Parse(file) / 100f;
            maxVolume = volume;
        }
        catch (Exception)
        {
            // Ignored. use default value 0.3.
        }

        using var enumerator = new MMDeviceEnumerator();
        using var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
        var audioEndpointVolume = device.AudioEndpointVolume;
        // 获取当前主音量级别（范围0.0到1.0）
        float currentVolume = audioEndpointVolume.MasterVolumeLevelScalar;
        if (currentVolume >= maxVolume)
        {
            audioEndpointVolume.MasterVolumeLevelScalar = currentVolume - 0.02f;
            Debug.WriteLine($"Volume reduced to {audioEndpointVolume.MasterVolumeLevel * 100}%.");
            return;
        }
        Debug.WriteLine($"Do nothing, as system is muted, or current volume is safe.");
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        this.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox2.Text == "吾实有所需，现欲解限。解限之利弊吾确已明辨。")
        {
            Environment.Exit(0);
        }
        else
        {
            this.textBox2.Text = string.Empty;
            Hide();
        }
    }

    private void Form1_Shown(object? sender, EventArgs e)
    {
        Hide();
        this.Shown -= Form1_Shown;
    }
}
