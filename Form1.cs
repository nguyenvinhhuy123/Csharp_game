namespace c_game;

public partial class Form1 : Form
{   
    bool go_Left, go_Right, jumping, on_PLatform = true;
    int jump_force = 8;
    public Form1()
    {
        InitializeComponent();
    }
    private void main_Game_Timer_Event(object sender, EventArgs e)
    {
        main_Character.character_Movement(go_Left,go_Right,ref jumping,ref jump_force, ref on_PLatform);
        foreach (Control ctrl in this.Controls)
        {
            if (ctrl is PictureBox)
            {
                if ((string)ctrl.Tag == "platform")
                {
                    //Interact with platform
                    if (main_Character.character_Box.Bounds.IntersectsWith(ctrl.Bounds))
                    {
                        main_Character.character_Box.Top = ctrl.Top - main_Character.character_Box.Height;
                        jump_force = -1;
                        on_PLatform = true;
                    }
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
        if (e.KeyCode == Keys.Space && !jumping && on_PLatform)
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
        if (e.KeyCode == Keys.Space)
        {
            jumping = false;
        }
    }
    
}
