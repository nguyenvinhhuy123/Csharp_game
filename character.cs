using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace c_game;

public class character_Class
{
    public System.Windows.Forms.PictureBox character_Box;
    private int init_Health = 100;
    private int init_Atk = 20;
    private int init_Move_speed = 20;
    private int init_Jump_Speed = 30;
    private bool air_Borne = false; 
    public character_Class()
    {
        //Init Character
        this.character_Box = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.character_Box)).BeginInit();
        //this.character_Box.ImageLocation = "asset/playerGrey_up1.png";
        this.character_Box.BackColor = System.Drawing.Color.DarkBlue;
        this.character_Box.Location = new System.Drawing.Point(800,600);
        this.character_Box.ClientSize = new Size(100,100);
        this.character_Box.TabStop = false;
        this.character_Box.SizeMode = PictureBoxSizeMode.StretchImage;
        this.character_Box.BorderStyle = BorderStyle.None;
        this.character_Box.Tag = "character";
        ((System.ComponentModel.ISupportInitialize)(this.character_Box)).EndInit();
    }
    public System.Windows.Forms.PictureBox get_character_Box()
    {
        return this.character_Box;
    }
    public int get_Health()
    {
        return init_Health;
    }
    public int get_Atk()
    {
        return init_Atk;
    }
    public void set_Health(int updated_Health)
    {
        this.init_Health = updated_Health;
    }
    public void set_Atk(int updated_Atk)
    {
        this.init_Atk = updated_Atk;
    }
    public void character_Movement(bool dir_Left, bool dir_Right, bool jumping,ref int jump_force)
    {

        if (dir_Left)
        {
            character_Box.Left -= init_Move_speed;
        }
        if (dir_Right)
        {
            character_Box.Left += init_Move_speed;
        }
        if (jumping && !air_Borne && jump_force >= 0)
        {
            air_Borne = true;
            character_Box.Top -= init_Jump_Speed;
            jump_force -= 1;
        }
        if (air_Borne && jump_force >= 0)
        {
            character_Box.Top -= init_Jump_Speed;
            jump_force -= 1;
        }
        if (air_Borne && jump_force < 0)
        {
            character_Box.Top += init_Jump_Speed;
            if (character_Box.Top == 700 - character_Box.Height)
            { 
                air_Borne = false;
                jump_force = 8;
            }

        }
    }
};