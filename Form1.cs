namespace c_game;


public partial class Form1 : Form
{   
    bool go_Left, go_Right, jumping, on_PLatform = true;
    int jump_force = 10;
    int score_Txt = 0;
    public Form1()
    {
        InitializeComponent();
    }
    private void main_Game_Timer_Event(object sender, EventArgs e)
    {
        score.Text = "Score: " + score_Txt;
        main_Character.character_Movement(go_Left,go_Right,ref jumping,ref jump_force, ref on_PLatform);
        if (bullet_1.Bullet_Visibility() == false) bullet_1.Random_Spawn_Handler();
        bullet_1.bullet_Movement_Handler(ref score_Txt);
        if (bullet_2.Bullet_Visibility() == false && bullet_1.bullet_Box.Left <= 805 && bullet_1.bullet_Box.Left >= 790) bullet_2.Random_Spawn_Handler();
        bullet_2.bullet_Movement_Handler(ref score_Txt);
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
                if ((string)ctrl.Tag == "bullet")
                {
                    if (main_Character.character_Box.Bounds.IntersectsWith(ctrl.Bounds))
                    {
                        game_Timer.Stop();
                        game_Over();
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
    private void game_Over()
    {
        var try_Again = MessageBox.Show("Try again??","SKILLISSUES?????? GG EZ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        if (try_Again == DialogResult.Yes)
        {
            //Restart game block
            game_Start();
        }
        else this.Close();
    }
    private void game_Start()
    {
        //reset character position and state
        go_Left = false;
        go_Right = false;
        jumping = false;
        on_PLatform = true;
        score_Txt = 0;
        main_Character.character_Box.Left = 800;
        main_Character.character_Box.Top = 600;

        //reset bullet position
        bullet_1.bullet_Box.Left = 0;
        bullet_1.bullet_Box.Top = 650;
        bullet_1.bullet_Box.Visible = false;

        bullet_2.bullet_Box.Left = 0;
        bullet_2.bullet_Box.Top = 650;
        bullet_2.bullet_Box.Visible = false;

        game_Timer.Start();
    }
}
