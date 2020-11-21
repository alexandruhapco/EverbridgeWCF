using EverbridgeClientSide.DoorServiceNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverbridgeClientSide {
    class Program {
        static void Main(string[] args) {
            using (var client = new DoorServiceClient()) {
                client.getAllDoors().ToList().ForEach(x => Console.WriteLine(x.ToString()));

                while(true) {

                }
           
            }
        }
    }
}
