using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNguyen.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                Dispose();
            }

            isDisposed = true;
        }

        //Override this to dispose custom object (Ghi đè lên điều này để loại bỏ đối tượng tùy chỉnh)
        protected virtual void DisposeCore()
        { 
        }
    }
}
