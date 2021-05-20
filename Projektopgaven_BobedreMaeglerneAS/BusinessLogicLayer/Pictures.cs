using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class Pictures
    {
        private int index = 0; //it is incremented when a picture from list is shown
        private PictureBox output; //general PictureBox
        private List<Image> images; //indeholder alle billeder som skal vises
        
        //every time a pictures instance is created, picture will be shown in 
        public Pictures(PictureBox picture)
        {
            output = picture;
        }

        //delegate to show pictures
        private delegate void DisplayDelegate(Image image);

        //when this method is called, the image taken as argument is shown in the picturebox
        private void DisplayImage(Image image)
        {
            output.Image = image;
        }

        public void GeneratePictures()
        {
            while (true)
            {
                //thread is sleeping for one minute
                Thread.Sleep(6000);

                //create a list of images from directory Resources
                images = new List<Image>();
                DirectoryInfo di = new DirectoryInfo(@"Resources/");
                FileInfo[] fileinfos = di.GetFiles("*.jpg", SearchOption.AllDirectories);
                foreach (FileInfo fi in fileinfos)
                    images.Add(Image.FromFile(fi.FullName)); //add images in list

                Image image = images[index];

                try
                {
                    //picturebox invokes a delegate (has image as argument)
                    //delegate invokes a method (has image as argument)
                    //new object[] { image } == argument of both delegate and method
                    //displayimage method puts a new image in the picturebox called output
                    output.Invoke(new DisplayDelegate(DisplayImage), new object[] { image });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                index++; //gå til næste bilede

                if (index == images.Count)
                    index = 0;
            }
        }
    }
}
