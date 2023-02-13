using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace c_game;

public partial class Form1 : Form
{   
    bool go_Left, go_Right, jumping;
    int jump_force = 8;
    public Form1()
    {
        InitializeComponent();
    }
    private void main_Game_Timer_Event(object sender, EventArgs e)
    {
        main_Character.character_Movement(go_Left,go_Right,jumping,ref jump_force);
        foreach (Control ctrl in this.Controls)
        {
            if (ctrl is PictureBox)
            {
                if ((string)ctrl.Tag == "platform")
                {

                }
            }
        }
    }
    private void KeyIsDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
        {
            go_Left = true;
        }   
        if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
        {
            go_Right = true;
        }
        if (e.KeyCode == Keys.Space )
        {
            jumping = true;
        }

    }
    private void KeyIsUp(object sender,KeyEventArgs e)
    {   
        if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
        {
            go_Left = false;
        }   
        if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
        {
            go_Right = false;
        }
        if (e.KeyCode == Keys.Space )
        {
            jumping = false;
        }
    }
    
}
