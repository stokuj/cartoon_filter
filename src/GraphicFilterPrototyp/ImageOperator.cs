using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;

namespace GraphicFilter
{
    internal class ImageOperator
    {
        private const string CppDllName = "CppCode.dll";
        [DllImport(CppDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cppApplyFilter(IntPtr arr, IntPtr remainder);
        [DllImport(CppDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte cppCalcuateRemainder(byte pixelVal, byte divider);

        private const string AsmDllName = "ASMCode.dll";
        [DllImport(AsmDllName)]
        private static extern void asmApplyFilter(IntPtr arr, IntPtr remainder);
        [DllImport(AsmDllName)]
        private static extern byte asmCalcuateRemainder(byte pixelVal, byte divider);

        static ImageOperator()
        {
            // Ustawienie ścieżki wyszukiwania DLL na katalog aplikacji
            string dllDirectory = AppDomain.CurrentDomain.BaseDirectory;
            SetDllDirectory(dllDirectory);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetDllDirectory(string lpPathName);

        const int size = 16;
        private BitmapData bmpData;

        public Image image { get; set; }

        public Bitmap bitmap { get; set; }

        public Image afterImage { get; set; }

        public byte[] red { get; set; }

        public byte[] green { get; set; }

        public byte[] blue { get; set; }

        public byte[] redV { get; set; }

        public byte[] greenV { get; set; }

        public byte[] blueV { get; set; }

        public double time { get; set; }

        public void bitmapFromImage()
        {
            bitmap = (Bitmap)image;
        }

        public void createRGB(int value, bool isAsm)
        {

            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            IntPtr ptr = bmpData.Scan0;
            int bytes = bmpData.Stride * bitmap.Height;

            byte[] rgbValues = new byte[bytes];
            red = new byte[bytes / 3];
            green = new byte[bytes / 3];
            blue = new byte[bytes / 3];

            redV = new byte[bytes / 3];
            greenV = new byte[bytes / 3];
            blueV = new byte[bytes / 3];

            Marshal.Copy(ptr, rgbValues, 0, bytes);
            int count = 0;
            int stride = bmpData.Stride;

            // Pomiar czasu całej operacji, nie pojedynczych pikseli
            Stopwatch stopwatch = Stopwatch.StartNew();
            // loop creating arrays r g b from bitmaps
            for (int column = 0; column < bmpData.Height; column++)
            {
                for (int row = 0; row < bmpData.Width; row++)
                {
                    blue[count] = (rgbValues[(column * stride) + (row * 3)]);
                    green[count] = (rgbValues[(column * stride) + (row * 3) + 1]);
                    red[count] = (rgbValues[(column * stride) + (row * 3) + 2]);

                    if (isAsm)
                    {
                        redV[count] = asmCalcuateRemainder(red[count], (byte)value);
                        greenV[count] = asmCalcuateRemainder(green[count], (byte)value);
                        blueV[count] = asmCalcuateRemainder(blue[count], (byte)value);
                    }
                    else
                    {
                        redV[count] = cppCalcuateRemainder(red[count], (byte)value);
                        greenV[count] = cppCalcuateRemainder(green[count], (byte)value);
                        blueV[count] = cppCalcuateRemainder(blue[count], (byte)value);
                    }
                    count++;
                }
            }
            stopwatch.Stop();
            time += stopwatch.Elapsed.TotalMilliseconds;
            bitmap.UnlockBits(bmpData);
        }

        public void ApplyEffect(int value, bool isAsm, int cores)
        {
            int arraySize = red.Length / size;
            IntPtr[] redArray = new IntPtr[arraySize];
            IntPtr[] greenArray = new IntPtr[arraySize];
            IntPtr[] blueArray = new IntPtr[arraySize];

            IntPtr[] redValue = new IntPtr[arraySize];
            IntPtr[] greenValue = new IntPtr[arraySize];
            IntPtr[] blueValue = new IntPtr[arraySize];

            AllocateArrays(redArray, greenArray, blueArray, redValue, greenValue, blueValue, arraySize);

            Stopwatch stopwatch = Stopwatch.StartNew();
            if (isAsm)
            {
                Parallel.For(0, arraySize, new ParallelOptions { MaxDegreeOfParallelism = cores }, i =>
                {
                    asmApplyFilter(redArray[i], redValue[i]);
                    asmApplyFilter(greenArray[i], greenValue[i]);
                    asmApplyFilter(blueArray[i], blueValue[i]);
                });

            }
            else
            {
                for (int i = 0; i < arraySize; i++)
                {
                    cppApplyFilter(redArray[i], redValue[i]);
                    cppApplyFilter(greenArray[i], greenValue[i]);
                    cppApplyFilter(blueArray[i], blueValue[i]);
                }
            }
            stopwatch.Stop();
            time += stopwatch.Elapsed.TotalMilliseconds;

            AssignNewValues(redArray, greenArray, blueArray, arraySize);

            for (int i = 0; i < arraySize; i++)
            {
                Marshal.FreeHGlobal(redArray[i]);
                Marshal.FreeHGlobal(greenArray[i]);
                Marshal.FreeHGlobal(blueArray[i]);

                Marshal.FreeHGlobal(redValue[i]);
                Marshal.FreeHGlobal(greenValue[i]);
                Marshal.FreeHGlobal(blueValue[i]);
            }

        }
        private void AllocateArrays(IntPtr[] redArray, IntPtr[] greenArray, IntPtr[] blueArray,
                                    IntPtr[] redValue, IntPtr[] greenValue, IntPtr[] blueValue,
                                    int arraySize)
        {
            int begin = 0;

            for (int i = 0; i < arraySize; i++)
            {
                redArray[i] = Marshal.AllocHGlobal(sizeof(byte) * size);
                greenArray[i] = Marshal.AllocHGlobal(sizeof(byte) * size);
                blueArray[i] = Marshal.AllocHGlobal(sizeof(byte) * size);

                Marshal.Copy(red, begin, redArray[i], size);
                Marshal.Copy(green, begin, greenArray[i], size);
                Marshal.Copy(blue, begin, blueArray[i], size);

                redValue[i] = Marshal.AllocHGlobal(sizeof(byte) * size);
                greenValue[i] = Marshal.AllocHGlobal(sizeof(byte) * size);
                blueValue[i] = Marshal.AllocHGlobal(sizeof(byte) * size);

                Marshal.Copy(redV, begin, redValue[i], size);
                Marshal.Copy(greenV, begin, greenValue[i], size);
                Marshal.Copy(blueV, begin, blueValue[i], size);

                begin += size;
            }
        }

        private void AssignNewValues(IntPtr[] redArray, IntPtr[] greenArray, IntPtr[] blueArray, int arraySize)
        {
            byte[] r = new byte[arraySize * size];
            byte[] g = new byte[arraySize * size];
            byte[] b = new byte[arraySize * size];
            int counter = 0;
            byte rb;
            byte gb;
            byte bb;
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //reading new r g b pixel values
                    rb = Marshal.ReadByte(redArray[i] + j);
                    gb = Marshal.ReadByte(greenArray[i] + j);
                    bb = Marshal.ReadByte(blueArray[i] + j);
                    // assignment to r g b
                    r[counter] = rb;
                    g[counter] = gb;
                    b[counter] = bb;
                    counter++;
                }
            }
            // assigning new values
            red = r;
            green = g;
            blue = b;
        }

        public void AfterImageFromRGB()
        {

            Bitmap pic = new Bitmap(bmpData.Width, bmpData.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Color c;
            int arrayIndex;
            int width = bmpData.Width;
            int height = bmpData.Height;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    arrayIndex = y * bmpData.Width + x; // calculating index
                    c = Color.FromArgb(red[arrayIndex], green[arrayIndex], blue[arrayIndex]); // finding color based on rgb value
                    pic.SetPixel(x, y, c); // pixel alignment
                }
            }
            afterImage = (Image)pic;
        }
    }
}