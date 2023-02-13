using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_game;
public class bullet
{
    public System.Windows.Forms.PictureBox bullet_Box;
    private int bullet_Speed;
    public bullet()
    {
        this.bullet_Box = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.bullet_Box)).BeginInit();
        this.bullet_Box.Visible = false;
        this.bullet_Box.BackColor = System.Drawing.Color.Red;
        this.bullet_Box.Location = new System.Drawing.Point(0,600);
        this.bullet_Box.ClientSize = new Size(50,25);
        this.bullet_Box.TabStop = false;
        this.bullet_Box.SizeMode = PictureBoxSizeMode.StretchImage;
        this.bullet_Box.BorderStyle = BorderStyle.FixedSingle;
        this.bullet_Box.Tag = "bullet";
        ((System.ComponentModel.ISupportInitialize)(this.bullet_Box)).EndInit();
        
    }

    public System.Windows.Forms.PictureBox get_Bullet_Box()
    {
        return this.bullet_Box;
    }
    public void set_Bullet_Speed(int init_Speed)
    {
        this.bullet_Box.Visible = true;
        this.bullet_Speed = init_Speed;
    }
    public void bullet_Movement_Handler()
    {
        if (bullet_Box.Left <= -101 || bullet_Box.Left > 2001)
        {
            this.bullet_Box.Visible = false;
        }
        else this.bullet_Box.Left += bullet_Speed;
    }
    public bool Bullet_Visibility()
    {
        return bullet_Box.Visible;
    }

}