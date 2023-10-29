using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[DllImport("user32.dll")]
static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo);

[DllImport("user32.dll")]
static extern short GetAsyncKeyState(int vKey);


const uint LEFTDOWN = 0x02;
const uint LEFTUP = 0x04;
const int HOTKEY = 0x26; 

bool enableClicker = false;
int clickInterval = 5;
Console.WriteLine("Coded by Pimsickgirl");

while (true)
{
    if (GetAsyncKeyState(HOTKEY)<0) 
    {
        enableClicker = !enableClicker;
        Console.WriteLine("Up arrow key");
        Thread.Sleep(300);
    }
    
    if (enableClicker)
    {
        MouseClick();
    }
    Thread.Sleep(clickInterval);
}

void MouseClick()
{
    mouse_event(LEFTDOWN,0,0,0,IntPtr.Zero);

    mouse_event(LEFTUP, 0, 0, 0, IntPtr.Zero);
}