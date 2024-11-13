//using system;
//using system.collections;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace arrayexamples
//{

//    public class employee
//    {
//        public int id { get; set; }
//        public string name { get; set; }
//        public string location { get; set; }

//        public employee(int id, string name, string location)
//        {
//            this.id = id;
//            this.name = name;
//            this.location = location;
//        }
//    }
//    public class arraylistrealtimeexample
//    {
//        public static void main(string[] args)
//        {
//            employee e1 = new employee(201, "sigma", "singapore");

//            arraylist emp1 = new arraylist();
//            emp1.add(new employee(101, "raju", "hyd"));
//            emp1.add(new employee(102, "harsha", "hyd"));
//            emp1.add(e1);

//            console.writeline("employee details");
//            console.writeline("----------------------------------------------");
//            foreach (employee e in emp1)
//            {
//                console.writeline(e.id);
//                console.writeline(e.name);
//                console.writeline(e.location);
//            }
//            console.readline();
//        }
//    }
//}
