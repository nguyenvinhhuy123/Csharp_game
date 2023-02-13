using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_game
{
    public class PlatForm
    {
        private System.Windows.Forms.PictureBox platForm_Box;
        public PlatForm()
        {
            this.platForm_Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.platForm_Box)).BeginInit();
            this.platForm_Box.Location = new System.Drawing.Point(0,700);
            this.platForm_Box.BackColor = System.Drawing.Color.Brown;
            this.platForm_Box.Size = new Size(1900,200);
            this.platForm_Box.TabStop = false;
            this.platForm_Box.BorderStyle = BorderStyle.FixedSingle;
            this.platForm_Box.Tag = "platform";
            ((System.ComponentModel.ISupportInitialize)(this.platForm_Box)).EndInit();
        }
        public System.Windows.Forms.PictureBox get_Platform_Box()
        {
            return this.platForm_Box;
        }
    }
}