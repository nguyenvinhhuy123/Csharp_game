﻿namespace c_game;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Timer game_Timer;
    private character_Class main_Character;
    private PlatForm main_Platform;
    private bullet bullet_1, bullet_2, bullet_3;
    private System.Windows.Forms.Label score;

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
        //Form components
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.LightBlue;
        this.components = new System.ComponentModel.Container(); 
        this.ClientSize = new System.Drawing.Size(1600, 900);
        this.Text = "Cgame";
        this.SuspendLayout();
        //score
        this.score = new System.Windows.Forms.Label();
        this.score.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.score.Location = new System.Drawing.Point(0,50);
        this.score.Name = "score";
        this.score.Size = new System.Drawing.Size(180, 85);
        this.score.TabIndex = 0;
        this.score.Text = "Score: 0";
        this.score.TextAlign = System.Drawing.ContentAlignment.TopRight;
        this.Controls.Add(this.score);
        //game timer
        this.game_Timer = new System.Windows.Forms.Timer(this.components);
        this.game_Timer.Enabled = true;
        this.game_Timer.Interval = 30;
        this.game_Timer.Tick += new System.EventHandler(this.main_Game_Timer_Event);
        //character
        this.main_Character = new character_Class();
        this.Controls.Add(main_Character.character_Box);
        //PlatForm
        this.main_Platform = new PlatForm();
        this.Controls.Add(main_Platform.get_Platform_Box());
        //Bullet
        this.bullet_1 = new bullet();
        this.Controls.Add(bullet_1.get_Bullet_Box());

        this.bullet_2 = new bullet();
        this.Controls.Add(bullet_2.get_Bullet_Box());
        this.bullet_2.bullet_Box.BackColor = System.Drawing.Color.Green;

        
        //key_event_Handler_initialize
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
        this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);


        this.ResumeLayout(false);
    }
    #endregion
}
