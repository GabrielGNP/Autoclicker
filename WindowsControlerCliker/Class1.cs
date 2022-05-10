using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsControlerCliker
{
    class Class1
    {

        //============ Estructura de entrada de teclado
        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardInput
        {
            public ushort wVk; //Codigo de llave virtual  ||| VK_XBUTTON1 = 0x05 | VK_XBUTTON2 = 0x06
            // llaves vistuales https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes

            public ushort wScan; // Codigo de escaneo de la tecla que queremos presionar.

            public uint dwFlags; // banderas sobre la entrada KeyUp, ExtendKey, Unicode, ScanCode 
            // https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput#remarks

            public uint time; // es una marca de tiempo de la entrada, si se establece en 0, el sistema proporciona su propia marca de tiempo
            
            public IntPtr dwExtraInfo; // proporciona información adicional sobre la pulsación de tecla, se obtiene mediante la función GetMessageExtraInfo .
        }


        //============== Estructura de entrada de ratón
        [StructLayout(LayoutKind.Sequential)]
        public struct MouseInput
        {
            public int dx; //dx es la posición absoluta del mouse, o la cantidad de movimiento desde que se generó el último evento del mouse, según el valor del dwFlags

            public int dy; // dy es lo mismo que dx pero para el eje y

            // Los datos absolutos se especifican como la coordenada x del mouse; los datos relativos se especifican como el número de píxeles movidos.
            
            public uint mouseData;

            public uint dwFlags; //son un conjunto de indicadores de bits que especifican varios aspectos de los movimientos del mouse y los clics de los botones
            //Si dwFlags contiene MOUSEEVENTF_WHEEL o MOUSEEVENTF_HWHEEL, mouseDataespecifica la cantidad de movimiento de la rueda.
            //Un valor positivo indica que la rueda se giró hacia adelante, lejos del usuario;
            //un valor negativo indica que la rueda se giró hacia atrás, hacia el usuario. 
            // Un clic de la rueda se define como WHEEL_DELTA =120

            public uint time; //es una marca de tiempo de la entrada, si se establece en 0, entonces el sistema proporciona su propia timestamp

            public IntPtr dwExtraInfo; //es un valor adicional asociado con el evento del mouse. Se obtiene mediante la GetMessageExtraInfofunción.
        }

        /*Banderas
         * Un tipo de enumeración (o tipo de enumeración ) es un tipo de valor definido por un conjunto de constantes con nombre del tipo numérico integral subyacente ( int, uint, byte, etc.). De forma predeterminada, los valores constantes asociados de los enummiembros son de tipo int; comienzan con cero y aumentan en uno siguiendo el orden del texto de definición.

Si desea que un tipo de enumeración represente una combinación de opciones, defina enummiembros para esas opciones de modo que una opción individual sea un campo de bits. Es decir, los valores asociados de esos enummiembros deben ser las potencias de dos. Luego, puede usar los operadores lógicos bit a bit |o &para combinar opciones o intersectar combinaciones de opciones, respectivamente.

El [Flags]atributo indica que una enumeración se puede tratar como un campo de bits; es decir, un conjunto de banderas.
         
         */

        //================== Estructura de entrada de hardware
        [StructLayout(LayoutKind.Sequential)]
        public struct HardwareInput
        {
            public uint uMsg; //es el mensaje generado por el hardware de entrada
            public ushort wParamL; //es la palabra de orden inferior del lParam parámetro para uMsg.
            public ushort wParamH; //es la palabra de orden superior del lParam parámetro para uMsg.
        }


        //============ Unión de entrada
        //InputUniones el parámetro de unión en el INPUT struct.
        //Contiene los datos de entrada para el mouse, el teclado o el hardware.
        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)] public MouseInput mi;
            [FieldOffset(0)] public KeyboardInput ki;
            [FieldOffset(0)] public HardwareInput hi;
        }

        //=============== La estructura de entrada
        public struct Input
        {
            public int type; //es el tipo del evento de entrada. Especifica qué entrada structse utilizará desde la unión
            // 1 = MOUSEINPUT
            // 2 = KEYBDINPUT
            // 3 = HARDWAREINPUT

            public InputUnion u;
        }


        //============== Tipo de entrada
        // es un simple enumpara los diferentes tipos de entrada utilizados en el INPUT struct.
        [Flags]
        public enum InputType
        {
            Mouse = 0,
            Keyboard = 1,
            Hardware = 2
        }

        //=============== Indicadores de eventos Keys
        //tiene las banderas utilizadas por KEYBDINPUT struct.
        [Flags]
        public enum KeyEventF
        {
            KeyDown = 0x0000,
            ExtendedKey = 0x0001,
            KeyUp = 0x0002,
            Unicode = 0x0004,
            Scancode = 0x0008
        }

        //================ Indicadores de eventos de ratón
        //tiene las banderas utilizadas por MOUSEINPUT struct.
        [Flags]
        public enum MouseEventF
        {
            Absolute = 0x8000,
            HWheel = 0x01000,
            Move = 0x0001,
            MoveNoCoalesce = 0x2000,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            VirtualDesk = 0x4000,
            Wheel = 0x0800,
            XDown = 0x0080,
            XUp = 0x0100
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        private static extern IntPtr GetMessageExtraInfo();

        [DllImport("user32.dll", CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        protected static extern int SetWindowsHookEx(
            int idHook,
            HookProc lpfn,
            IntPtr hMod,
            int dwThreadId);

        protected delegate int HookProc(int nCode, int wParam, IntPtr lParam);

        protected const int WH_MOUSE_LL = 14;
        protected const int WH_KEYBOARD_LL = 13;

    }
}
