using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myScrenCapture
{
    class mySoundPlayer
    {
        /// <summary>
        /// Simple Sound Player
        /// </summary>
        SoundPlayer mySOUNDPLAYER;

        private string mySound;

        public mySoundPlayer(string myPathToSoundFile) 
        {
            if (myPathToSoundFile != "")
            {
                mySound = myPathToSoundFile;
            }
        }

        public void PlayOnce()
        {
            if (mySOUNDPLAYER == null)
            {
                mySOUNDPLAYER = new SoundPlayer(mySound);
            }
            try
            {
                mySOUNDPLAYER.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                
            }
        }

    }
}
