#define cppFunctions _declspec(dllexport)

extern "C" {  
    cppFunctions unsigned char cppCalcuateRemainder(unsigned char pixel, unsigned char divider)
    {
        if ((pixel % divider) > (divider / 2))
        {
            if ((unsigned char)(pixel + divider - (pixel % divider)) < pixel)
            {
                return (255 - pixel);
            }
            else
            {
                return (divider - (pixel % divider));
            }
        }
        else
        {
            return (0 - (pixel % divider));
        }
    }

	cppFunctions void cppApplyFilter(unsigned char *arr, unsigned char *val)
	{
        unsigned char xmm1; 
        unsigned char xmm2; 
       for (int i = 0; i < 16; i++)
       {
           xmm1 = *(arr + i);
           xmm2 = *(val + i);
           xmm1 += xmm2;
           *(arr + i) = xmm1;
        }     
	}
}