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
            MessageBox.Show(message);
        }
    }

}
