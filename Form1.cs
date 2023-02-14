namespace c_game;

public partial class Form1 : Form
{   
    bool go_Left, go_Right, jumping, on_PLatform = true;
    int jump_force = 10;
    public Form1()
    {
        InitializeComponent();
    }
    private void main_Game_Timer_Event(object sender, EventArgs e)
    {
        main_Character.character_Movement(go_Left,go_Right,ref jumping,ref jump_force, ref on_PLatform);
        if (bullet_1.Bullet_Visibility() == false) bullet_1_Random_Spawn_Handler();
        bullet_1.bullet_Movement_Handler();
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
    private void bullet_1_Random_Spawn_Handler()
    {
        var random_Generator =new Random();
        int[] width_Random = {-50,1950};
        int[] bullet_Speed_Random = {15,-15};
        int width_Index = random_Generator.Next(width_Random.Length);
        bullet_1.bullet_Box.Left = width_Random[width_Index];
        bullet_1.set_Bullet_Speed(bullet_Speed_Random[width_Index]);
    }
    private void game_Over()
    {
        var try_Again = MessageBox.Show("Try again??","BALLS",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        if (try_Again == DialogResult.Yes)
        {
            //Restart game block
        }
        else this.Close();
    }
}
