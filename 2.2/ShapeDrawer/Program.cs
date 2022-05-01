using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{ 
    public class Program
    {
        
        public static void Main()
        {
        
        Shape myShape = new Shape();


        new Window("Shape Drawer", 800, 600); //open window
            do
            {
                SplashKit.ProcessEvents();// fetch next UI interaction
                SplashKit.ClearScreen(Color.Beige); //clear screen and draw framrate
                

                if (SplashKit.MouseClicked(MouseButton.LeftButton) == true)
                {

                    myShape.X = (SplashKit.MouseX()) -50;
                    myShape.Y = (SplashKit.MouseY()) -50;
                    myShape.color = SplashKit.ColorGreen();                   
                }
                if(myShape.IsAt(SplashKit.MousePosition()))
                {
                    if (SplashKit.KeyTyped(KeyCode.SpaceKey) == true)
                    {
                        myShape.color = SplashKit.RandomRGBColor(255);
                    }
                }
                myShape.Draw();
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer")); //keep window open
        }
    }
}
