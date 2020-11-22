using EverbridgeClientSide.DoorServiceNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EverbridgeClientSide {
    class Program {

        private static void printInstruction() {
            Console.WriteLine("Press Number to choose the action:");
            Console.WriteLine("1 - Get all");
            Console.WriteLine("2 - Open");
            Console.WriteLine("3 - Close");
            Console.WriteLine("4 - Lock");
            Console.WriteLine("5 - Unlock");
            Console.WriteLine("6 - Get status");
            Console.WriteLine("7 - Add new");
            Console.WriteLine("8 - Change label");
            Console.WriteLine("9 - Remove");
            Console.WriteLine("0 - Print Instruction");
        }

        static void Main(string[] args) {
            // Construct InstanceContext to handle messages on callback interface
            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            var client = new DoorServiceClient(instanceContext);
            client.clientRegistration();
            printInstruction();
            printAllDoors(client);

            while (true) {
                Console.Write("Input: ");
                var input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (input) {
                    case '1': printAllDoors(client); break;
                    case '2': executeSingleObjectAction((x) => client.openDoor(x), "Door is opened"); break;
                    case '3': executeSingleObjectAction((x) => client.closeDoor(x), "Door is closed"); break;
                    case '4': executeSingleObjectAction((x) => client.lockDoor(x), "Door is locked"); break;
                    case '5': executeSingleObjectAction((x) => client.lockDoor(x), "Door is unlocked"); break;
                    case '6': printDoor(client); break;
                    case '7': addNewDoor(client); break;
                    case '8': changeLable(client); break;
                    case '9': executeSingleObjectAction((x) => client.removeDoor(x), "Door is removed"); break;
                    case '0': printInstruction(); break;
                    default:
                        break;
                }
            }
        }

        private static void changeLable(DoorServiceClient client) {
            Console.Write("Enter door id: ");
            if (long.TryParse(Console.ReadLine(), out long id)) {
                Console.Write("Enter new label: ");
                var label = Console.ReadLine();
                if (client.updateDoorLabel(id, label)) {
                    Console.WriteLine("Label was updated");
                    return;
                }
            }
            Console.WriteLine("Nope");
        }

        private static void addNewDoor(DoorServiceClient client) {
            Console.Write("Enter new door label: ");
            var label = Console.ReadLine();
            if (client.addNewDoor(label)) {
                Console.WriteLine("Door was added");
                return;
            }
            Console.WriteLine("Nope");
        }

        private static void printAllDoors(DoorServiceClient client) {
            Console.WriteLine(new String('-', 60));
            client.getAllDoors().ToList().ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine(new String('-', 60));
        }

        private static void printDoor(DoorServiceClient client) {
            Console.Write("Enter door id: ");
            if (long.TryParse(Console.ReadLine(), out long id)) {
                var door = client.getDoor(id);
                if (door != null) {
                    Console.WriteLine(door.ToString());
                    return;
                }
            }
            Console.WriteLine("Nope");
        }

        private static void executeSingleObjectAction(Func<long, bool> action, string consoleSuccessOutput) {
            Console.Write("Enter door id: ");
            if (long.TryParse(Console.ReadLine(), out long id)) {
                if (action.Invoke(id)) {
                    Console.WriteLine(consoleSuccessOutput);
                    return;
                }
            }
            Console.WriteLine("Nope");
        }


    }
}
