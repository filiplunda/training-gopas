using static Training._05._01_UsingDelegates.UsingDelegates;

namespace Training._05._02_DelegateCallBack
{
    class DelegateHelper
    {
        //public static WorkCompletedCallBack CallBack;

        public static event WorkCompletedCallBack CallBack;

        public static DownloadCompletedCallBack DowloadCompletedCallBack;

        public static void DoWork()
        {
            Console.WriteLine("Doing my work");
            Thread.Sleep(100);

            if(CallBack != null)
            {
                CallBack(string.Format("{0} [{1}]", "Hello world", DateTime.Now.ToLongTimeString()));
            }
        }

        public static void DownloadFile(string fileUrl)
        {
            Console.WriteLine($"Starting download from {fileUrl} ...");

            int fileSize = new Random().Next(100, 200);
            Thread.Sleep(fileSize);

            if(DowloadCompletedCallBack != null)
            {
                DowloadCompletedCallBack(string.Format("{0} [{1}]", $"Download {fileUrl} finalized", DateTime.Now.ToLongTimeString()));
            }
        }
    }
}
