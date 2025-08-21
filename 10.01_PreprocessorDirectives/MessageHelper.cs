//#define TRIAL

namespace Training._10._01_PreprocessorDirectives
{
    internal static class MessageHelper
    {
        public static void WriteMessage()
        {
#if TRIAL
            Console.WriteLine("Only in TRIAL from MessageHelper");
#endif
            Console.WriteLine("Every time from MessageHelper");
        }
    }
}
