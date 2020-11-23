using EverbridgeClientSide.DoorServiceNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EverbridgeClientSide {
    class CallbackHandler : IDoorServiceCallback {
        public void notifyUserOnChange(string message) {
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(message);
            
        }
    }

}
