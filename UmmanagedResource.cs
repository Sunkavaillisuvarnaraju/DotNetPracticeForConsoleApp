using System;
using System.Threading;
namespace DestructorDemo
{
    public class UmmanagedResource : IDisposable
    {
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
       public  int count = 0;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //Write Code Here to Destroy the Managed Resources
                    Console.WriteLine("Managed Resources Destroyed by Dispose Method");
                }
                //Write Code Here to Destroy the Umanaged Resources
                Console.WriteLine("Unmanaged Resources Destroyed by Dispose Method");
                disposedValue = true;
            }
            else
            {
                Console.WriteLine("Resources are Already Destroyed by Dispose Method");
            }
        }
        ~UmmanagedResource()
        {
            count++;
            //Write Code here to Destroy the Object
            Console.WriteLine("Request Comes to Destructor to Destroy the Resources");
            Dispose(false);
        }
        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            //Write Code here to Destroy the Object
            Console.WriteLine("Request Comes to Dispose Method to Destroy the Resources");
            Dispose(true);
            //GC.SuppressFinalize(this);
        }
        #endregion
    }
    class Program
    {
        static void Main()
        {
            UmmanagedResource resource = null;
            try
            {
                resource = new UmmanagedResource();
                Console.WriteLine("Using Resources");
            }
            finally
            {
                if (resource != null)
                {
                    Console.WriteLine("Calling Dispose Method to Destroy Resources");
                    resource.Dispose();
                }
            }
            //Trying to Call the Dispose Method again
            Console.WriteLine();
            Console.WriteLine("Trying to Call the Dispose Method Again To Destroy Resources");
            resource.Dispose();
            Console.WriteLine($"End of the Main Method {resource.count}");
            Console.ReadKey();
        }
    }
}
