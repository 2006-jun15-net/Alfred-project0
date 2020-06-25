using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryApp
{
    /// <summary>
    /// This interface has an abstract method display that prints out the contents of the specified object
    /// </summary>
    interface IDisplay
    {
        /// <summary>
        /// An abstract mehtod that diplays the conetnts of the specified object
        /// </summary>
        public abstract void display();
    }
}
