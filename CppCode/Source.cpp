#define cppFunctions _declspec(dllexport)
#include <emmintrin.h> // SSE2

extern "C" {  
    // Funkcja obliczająca zmodyfikowaną wartość piksela
    // Zabezpieczenie przed dzieleniem przez zero
    cppFunctions unsigned char cppCalcuateRemainder(unsigned char pixel, unsigned char divider)
    {
        if (divider == 0) return 0; // zabezpieczenie
        unsigned char rem = pixel % divider;
        if (rem > (divider / 2))
        {
            if ((unsigned char)(pixel + divider - rem) < pixel)
            {
                // Zwracamy 255 - pixel, rzutowanie by uniknąć problemów z unsigned
                return static_cast<unsigned char>(255 - pixel);
            }
            else
            {
                return static_cast<unsigned char>(divider - rem);
            }
        }
        else
        {
            // Zamiast 0 - rem (może dać wynik ujemny), używamy 256 - rem
            return static_cast<unsigned char>(256 - rem);
        }
    }

    // SIMD: Przetwarzanie 16 bajtów naraz (SSE2)
    cppFunctions void cppApplyFilter(unsigned char *arr, unsigned char *val)
    {
        // Zakładamy, że arr i val są wyrównane do 16 bajtów i mają co najmniej 16 bajtów
        __m128i* pArr = (__m128i*)arr;
        __m128i* pVal = (__m128i*)val;
        __m128i v1 = _mm_loadu_si128(pArr);
        __m128i v2 = _mm_loadu_si128(pVal);
        v1 = _mm_add_epi8(v1, v2);
        _mm_storeu_si128(pArr, v1);
    }
}