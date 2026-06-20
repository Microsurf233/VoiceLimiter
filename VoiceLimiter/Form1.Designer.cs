namespace VoiceLimiter;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        notifyIcon1 = new NotifyIcon(components);
        textBox1 = new TextBox();
        label1 = new Label();
        textBox2 = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // notifyIcon1
        // 
        notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
        notifyIcon1.Text = "notifyIcon1";
        notifyIcon1.Visible = true;
        notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 60);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(707, 30);
        textBox1.TabIndex = 0;
        textBox1.Text = "吾实有所需，现欲解限。解限之利弊吾确已明辨。";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft YaHei UI", 15F);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(707, 39);
        label1.TabIndex = 1;
        label1.Text = "欲退此程序，须复下文于空处，见心诚，此阵自解。";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(12, 96);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(707, 30);
        textBox2.TabIndex = 2;
        // 
        // button1
        // 
        button1.Location = new Point(12, 132);
        button1.Name = "button1";
        button1.Size = new Size(707, 34);
        button1.TabIndex = 3;
        button1.Text = "解";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(11F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(738, 205);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        ShowInTaskbar = false;
        Text = "Volume Limiter";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private NotifyIcon notifyIcon1;
    private TextBox textBox1;
    private Label label1;
    private TextBox textBox2;
    private Button button1;
}
